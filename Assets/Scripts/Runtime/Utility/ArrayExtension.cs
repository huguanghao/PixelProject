using JEngine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YKGame.Runtime
{
    public static class ArrayExtension
    {
        /// <summary>
        /// 二维数组,根据每行第一个值查找
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arrayTwo"></param>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public static bool FindLineByFirstValue<T>(this T[][] arrayTwo, T firstValue, out T[] ret)
        {
            ret = null;
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                if (arrayTwo[i] != null && arrayTwo[i].Length > 0 && arrayTwo[i][0].Equals(firstValue))
                {
                    ret = arrayTwo[i];
                    return true;
                }
            }
            return false;
        }
    }
}
