using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace YKGame.Runtime
{
    public static class Direction
    {
        private static Vector3 rightDir = new Vector3(0, 0, 0);
        private static Vector3 leftDir = new Vector3(0, 180, 0);
        public static Vector3 RightDir
        {
            get => rightDir;
        }
        public static Vector3 LeftDir
        {
            get => leftDir;
        }
    }
}
