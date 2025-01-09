using Spine.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;

namespace YKGame.Runtime
{
    public static class TransformTool
    {
        public static Vector3 modelDirectionLeft;
        public static Vector3 modelDirectionRight;
        public static void SetLookAtLeftOrRight(this Transform model,Vector3 moveDir)
        {
            float x = model.InverseTransformVector(moveDir).x;
            if(x < -0.001f)
                model.localEulerAngles = model.localEulerAngles == modelDirectionLeft ? modelDirectionRight : modelDirectionLeft;
        }
        //通过旋转Y轴使right看向方向
        public static void SetRightLookAt(this Transform transform, Vector3 direction)
        {
            if (transform.lossyScale.x >= 0)
                transform.right = Vector3.ProjectOnPlane(direction, Vector3.up);
            else
                transform.right = -Vector3.ProjectOnPlane(direction, Vector3.up);
        }
        public static void SetLookAtLeftOrRight(this SkeletonAnimation model,Vector3 moveDir)
        {
            if (model.initialFlipX)
                moveDir.x = -moveDir.x;
            //float x = model.transform.InverseTransformVector(moveDir).x;
            if (moveDir.x != 0)
                model.Skeleton.ScaleX = moveDir.x < 0 ? -1 : 1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="z"></param>
        public static void Rotate(this Transform transform,Vector3 center,float radius, float angle)
        {
            transform.Rotate(Vector3.up, angle);
            transform.position = center + transform.forward * radius;
        }
        /// <summary>
        /// 震动
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="radius"></param>
        public static void Shock(this Transform transform, Vector3 center, float radius)
        {
            transform.position = center + radius * Random.insideUnitSphere;
        }

        public static void MoveTowards(this Transform transform, Vector3 toPos, float maxDistanceDelta)
        {
            toPos.y = transform.position.y;
            transform.position = Vector3.MoveTowards(transform.position, toPos, maxDistanceDelta);
        }

        public static void AddPosition(this Transform transform, Vector3 movement)
        {
            transform.position += movement;
        }

        public static void SetPosition(this Transform transform, Vector3 position)
        {
            transform.position = position;
        }
    }
}
