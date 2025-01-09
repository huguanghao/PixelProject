using UnityEngine.AI;
using UnityEngine;
using YKGameFramework;
using UnityEngine.EventSystems;

namespace YKGame.Runtime
{
    /// <summary>
    /// 速度模式
    /// </summary>
    public enum ForceMode
    {
        /// <summary>
        /// 只受自身导航速度影响（刚体速度限制在zero~导航当前速度之间）
        /// </summary>
        OnlySelf,
        /// <summary>
        /// 与外力叠加（导航速度+其他速度）
        /// </summary>
        Addition,
        /// <summary>
        /// 只受外力影响（每帧设置刚体速度为otherVelocity）
        /// </summary>
        OnlyOther,
        None,
    }

    [RequireComponent(typeof(NavMeshAgent))]
    [RequireComponent(typeof(Rigidbody))]
    public class MoveAgent : MonoBehaviour
    {
        public bool anyHit;
        public int hitCount;
        [SerializeField]
        private int layer;
        public int Layer
        {
            get => layer;
            set
            {
                layer = value;
            }
        }
        public Rigidbody rigid;
        public NavMeshAgent agent;
        public Vector3 moveDirection;
        public Vector3 customAgentVelocity;

        public bool useAcce = false;
        public Vector3 agentVelocity
        {
            get
            {
                if (customAgentVelocity != Vector3.zero)
                    return customAgentVelocity;
                else if (!useAcce)
                    agent.velocity = agent.desiredVelocity;
                return agent.velocity;
            }
        }

        /// <summary>
        /// 检查前方有无其他同Layer物体
        /// </summary>
        public float checkDistance = 1f;
        [SerializeField]
        private ForceMode forceMode = ForceMode.OnlySelf;
        public ForceMode Mode => forceMode;

        /// <summary>
        /// 自定义外力合速度
        /// </summary>
        [SerializeField]
        private Vector3 otherVelocity;
        [SerializeField]
        private Vector3 lockOtherVelocity;
        /// <summary>
        /// 自定义外力合速度
        /// </summary>
        public Vector3 OtherVelocity => otherVelocity;
        /// <summary>
        /// 当前锁定的外力合速度大小
        /// </summary>
        public Vector3 LockOtherVelocity => lockOtherVelocity;
        /// <summary>
        /// 外力速度
        /// </summary>
        private Vector3 CurrentOtherVelocity => lockOtherVelocity == Vector3.zero ? otherVelocity : lockOtherVelocity;

        private Transform followTarget;
        private Rigidbody followTargetRigidbody;
        private float setDelay;
        private float nextTime;
        private bool setOnArrived;

        private Vector3 GetTargetDestination()
        {
            if (followTarget == null)
                return agent.destination;
            if(setDelay > 0)
            {
                if(nextTime >= Time.fixedTime)
                    nextTime += setDelay;
                else
                    return agent.destination;
            }
            else if (setOnArrived && agent.isOnNavMesh && agent.hasPath && agent.remainingDistance > agent.stoppingDistance)
            {
                return agent.destination;
            }
            return followTargetRigidbody == null ? followTarget.position : (followTargetRigidbody.position + followTargetRigidbody.velocity * Time.fixedDeltaTime);
        }

        // Start is called before the first frame update
        void Awake()
        {
            if (!TryGetComponent(out rigid))
                rigid = gameObject.AddComponent<Rigidbody>();
            if (!TryGetComponent(out agent))
                agent = gameObject.AddComponent<NavMeshAgent>();
            rigid.useGravity = false;
            rigid.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;

            agent.updatePosition = false;
            agent.updateRotation = false;
            agent.obstacleAvoidanceType = ObstacleAvoidanceType.NoObstacleAvoidance;
        }

        public void SetLockVelocity(Vector3 velocity, bool setLock = false)
        {
            if (setLock)
            {
                lockOtherVelocity = velocity;
            }
            else if(velocity == lockOtherVelocity)
            {
                lockOtherVelocity = Vector3.zero;
            }
            ChangeMode();
        }

        private void ChangeMode()
        {
            if (lockOtherVelocity != Vector3.zero)
                forceMode = ForceMode.OnlyOther;
            else if(otherVelocity != Vector3.zero)
                forceMode = ForceMode.Addition;
            else
                forceMode = ForceMode.OnlySelf;
        }

        public void AddVelocity(Vector3 velocity)
        {
            otherVelocity += velocity;
            ChangeMode();
        }

        public void RemoveVelocity(Vector3 velocity)
        {
            otherVelocity -= velocity;
            ChangeMode();
        }

        public void SetFollowTarget(Transform target)
        {
            followTarget = target;
            if (followTarget == null)
                followTargetRigidbody = null;
            else
            {
                followTargetRigidbody = followTarget.GetComponentInParent<Rigidbody>();
            }
            setOnArrived = false;
            setDelay = 0;
        }

        public void SetFollowTarget(Transform target, float delay)
        {
            SetFollowTarget(target);
            setDelay = delay;
            nextTime = Time.fixedTime;
        }

        public void SetFollowTargetOnArrived(Transform target)
        {
            SetFollowTarget(target);
            setOnArrived = true;
            if (agent.isActiveAndEnabled && agent.isOnNavMesh)
                agent.SetDestination(target.position);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (agent.isActiveAndEnabled)
            {
                agent.nextPosition = rigid.position;
                //刚体限制在导航网格内
                rigid.position = agent.nextPosition;
            }
            if(rigid.drag > 0)
            {
                rigid.drag = 0;
                Vector3 targetNextPosition = GetTargetDestination();
                targetNextPosition.y = rigid.position.y;
                if (agent.isActiveAndEnabled && agent.isOnNavMesh && (agent.destination.x != targetNextPosition.x || agent.destination.z != targetNextPosition.z))
                    agent.SetDestination(targetNextPosition);
                moveDirection = agent.desiredVelocity.normalized;
                return;
            }
            switch (forceMode)
            {
                case ForceMode.OnlySelf:
                    SetVelocityOnlySelf();
                    break;
                case ForceMode.Addition:
                    SetVelocityAddition();
                    break;
                case ForceMode.OnlyOther:
                    rigid.velocity = CurrentOtherVelocity;
                    break;
            }
        }

        private void OnCollisionStay(Collision collision)
        {
            if (hitCount > 1)
                return;
            if (layer > 0 && collision.collider.gameObject.layer == layer)
            {
                anyHit = true;
                if (collision.rigidbody != null && collision.rigidbody.TryGetComponent(out MoveAgent other) && other.agent.destination != agent.destination)
                {
                    hitCount++;
                }
            }
        }

        void SetVelocityOnlySelf()
        {
            if (customAgentVelocity != Vector3.zero)
            {
                rigid.velocity = agent.velocity = customAgentVelocity;
                return;
            }

            bool flag = layer == 0 || hitCount > 1 || !anyHit;
            hitCount = 0;
            anyHit = false;
            Vector3 targetNextPosition = GetTargetDestination();
            targetNextPosition.y = rigid.position.y;
            if (agent.isActiveAndEnabled && agent.isOnNavMesh && (agent.destination.x != targetNextPosition.x || agent.destination.z != targetNextPosition.z))
                agent.SetDestination(targetNextPosition);
            if (flag)
            {
                //没有障碍直接移动
                if (!agent.Raycast(targetNextPosition,out _))
                {
                    moveDirection = (targetNextPosition - rigid.position).normalized;
                    rigid.velocity = Vector3.zero;
                    if(moveDirection == Vector3.zero)
                        agent.velocity = Vector3.zero;
                    else
                    {
                        agent.velocity = agent.speed * moveDirection;
                        rigid.MovePosition(Vector3.MoveTowards(rigid.position, targetNextPosition, agent.speed * Time.fixedDeltaTime));
                    }
                }
                else
                {
                    rigid.velocity = agentVelocity;
                    moveDirection = agent.velocity.normalized;
                }
            }
            else
            {
                rigid.velocity = Vector3.Lerp(rigid.velocity, agentVelocity, Time.fixedDeltaTime);
                moveDirection = agent.velocity.normalized;
            }
        }

        void SetVelocityAddition()
        {
            //rigid.velocity = Vector3.MoveTowards(rigid.velocity, agent.velocity, agent.acceleration * Time.fixedDeltaTime);
            rigid.velocity = agentVelocity + CurrentOtherVelocity;
        }
    }
}
