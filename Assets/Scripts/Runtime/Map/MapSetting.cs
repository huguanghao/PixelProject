using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSetting : MonoBehaviour
{
    public Vector3 StartWorldPosition;
    public bool ignoreUp = true;
    public float Edge_Dis_Up;
    public float Edge_Dis_Down;
    public float Edge_Dis_Left;
    public float Edge_Dis_Right;
    private Vector2Int size;
    public Vector2Int Size { get => size; set { size = value; OnValidate(); } }
    private Vector2 sizeWithEdge;
    public Vector2 SizeWithEdge => sizeWithEdge;

#if UNITY_EDITOR
    public Action onValidated;

    private void OnDestroy()
    {
        onValidated = null;
    }
#endif
    private void OnValidate()
    {
        sizeWithEdge.x = size.x + Edge_Dis_Left + Edge_Dis_Right;
        sizeWithEdge.y = size.y + Edge_Dis_Up + Edge_Dis_Down;
#if UNITY_EDITOR
        onValidated?.Invoke();
#endif
    }

    private void Reset()
    {
        AutoSetStartPos();
    }

    public void AutoSetStartPos()
    {
        //SpriteRenderer renderer = GetComponentInChildren<SpriteRenderer>();
        //if (renderer != null)
        //{
        //    StartWorldPosition = renderer.bounds.center - renderer.bounds.extents;
        //    StartWorldPosition.y = 0;
        //}
    }
}
