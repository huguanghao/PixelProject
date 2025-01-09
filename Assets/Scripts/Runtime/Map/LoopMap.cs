using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YKGame.Runtime
{
    public enum LoopType
    {
        /// <summary>
        /// x轴循环
        /// </summary>
        ONLY_X,
        /// <summary>
        /// y轴循环
        /// </summary>
        ONLY_Y,
        /// <summary>
        /// 双轴循环
        /// </summary>
        ALL,
        /// <summary>
        /// 不循环
        /// </summary>
        NONE,
    }
    public class LoopMap : MonoBehaviour
    {
        public static Transform player;
        public static LoopType loopType;
        public static Vector3 mapNum;
        public static Vector2 mapTotalSize;
        public Vector3 targetPos;
        // Start is called before the first frame update
        void Awake()
        {

        }

        // Update is called once per frame
        void Update()
        {
            targetPos = transform.position;
            if (loopType == LoopType.ONLY_X || loopType == LoopType.ALL)
            {
                if (player.position.x > transform.position.x + mapTotalSize.x / 2)
                {
                    targetPos.x += mapTotalSize.x;
                    transform.position = targetPos;
                }
                else if (player.position.x < transform.position.x - mapTotalSize.x / 2)
                {
                    targetPos.x -= mapTotalSize.x;
                    transform.position = targetPos;
                }
            }
            if (loopType == LoopType.ONLY_Y || loopType == LoopType.ALL)
            {
                if (player.position.y > transform.position.y + mapTotalSize.y / 2)
                {
                    targetPos.y += mapTotalSize.y;
                    transform.position = targetPos;
                }
                else if (player.position.y < transform.position.y - mapTotalSize.y / 2)
                {
                    targetPos.y -= mapTotalSize.y;
                    transform.position = targetPos;
                }
            }
        }
    }
}
