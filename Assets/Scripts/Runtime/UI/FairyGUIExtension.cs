using UnityEngine;
using FairyGUI;
using System;
using System.IO;

namespace YKGame.Runtime
{
    public static class FairyGUIExtension
    {
        public static GObject FindChild(this GComponent gComponent, string childName)
        {
            string[] childNames = childName.Split('.');

            GObject child = gComponent;
            for (int i = 0; i < childNames.Length; ++i)
            {
                if (child.asCom != null)
                {
                    child = child.asCom.GetChild(childNames[i]);
                }
                else
                    child = null;

                if (child == null)
                    break;
            }

            return child;
        }

        /// <summary>
        /// 直接加载本地图片
        /// </summary>
        /// <param name="img"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static void SetImageUrl(this GLoader image, string name, int width, int height)
        {
            var path = Application.streamingAssetsPath;
            using (FileStream fileStream = new FileStream(Path.Combine(path, name), FileMode.Open, FileAccess.Read))
            {
                fileStream.Seek(0, SeekOrigin.Begin);
                byte[] bytes = new byte[fileStream.Length];
                fileStream.Read(bytes, 0, (int)fileStream.Length);
                fileStream.Close();
                fileStream.Dispose();
                Texture2D texture = new Texture2D(width, height, TextureFormat.RGBA32, false);
                texture.LoadImage(bytes);
                image.texture = new NTexture(texture);
            }
        }
    }
}
