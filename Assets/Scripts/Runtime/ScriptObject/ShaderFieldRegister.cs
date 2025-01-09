using JEngine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;

namespace YKGame.Runtime
{
    /// <summary>
    /// 用defaultFields中统一的名称去关联不同Shader中的同类不同名字段
    /// </summary>
    public class ShaderFieldRegister : ScriptableObject
    {
        [Serializable]
        private class ShaderField
        {
            public Shader shader;
            public Field[] fields;

            public void AddField(string commonName)
            {
                if(fields == null)
                {
                    fields = new Field[1] { new Field() { commonName = commonName } };
                    return;
                }
                Field field = fields.FirstOrDefault(o => o.commonName == commonName);
                if(field == null)
                {
                    field = fields.FirstOrDefault(o => string.IsNullOrEmpty(o.commonName));
                    if (field == null)
                    {
                        Array.Resize(ref fields, fields.Length + 1);
                        field = new Field() { commonName = commonName };
                        fields[fields.Length - 1] = field;
                    }
                    else
                        field.commonName = commonName;
                }
            }
        }
        [Serializable]
        private class Field
        {
            public string commonName;
            public string realName;
        }

        [SerializeField]
        private string[] defaultFields;

        [SerializeField]
        private ShaderField[] list;

        public bool TryGetFieldName(Shader shader,string common_name,out string real_name)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if(list[i].shader == shader)
                {
                    for (int j = 0; j < list[i].fields.Length; j++)
                    {
                        if (list[i].fields[j].commonName == common_name)
                        {
                            real_name = list[i].fields[j].realName;
                            return true;
                        }
                    }
                    break;
                }
            }
            real_name = "";
            return false;
        }

        [ContextMenu("将defaultFields添加到列表")]
        private void AddFieldToList()
        {
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < defaultFields.Length; j++)
                {
                    list[i].AddField(defaultFields[j]);
                }
            }
        }
    }
}