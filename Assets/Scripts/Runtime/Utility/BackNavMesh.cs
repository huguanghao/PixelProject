using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BackNavMesh : MonoBehaviour
{
    public NavMeshSurface surface;

    public bool back;

    private void OnValidate()
    {
        if (back)
        {
            back = false;
            if(surface.navMeshData == null)
                surface.navMeshData = new NavMeshData();
            surface.UpdateNavMesh(surface.navMeshData);
        }
    }

    // Start is called before the first frame update
    void Awake()
    {
        gameObject.TryGetComponent(out surface);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
