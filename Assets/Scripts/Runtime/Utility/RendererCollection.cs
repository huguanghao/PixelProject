using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YKGame.Runtime
{
    public class RendererCollection : MonoBehaviour
    {
        public Renderer[] renderers;

        public void CollectMaterials()
        {
            renderers = gameObject.GetComponentsInChildren<Renderer>();
        }
    }
}
