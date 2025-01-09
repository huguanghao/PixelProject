using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnCursorEnterAnimation : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    [SerializeField]
    public List<SkeletonAnimation> spines;

    private void Awake()
    {
        OnPointerExit(null);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        for (int i = 0; i < spines.Count; i++)
        {
            spines[i].AnimationState.SetAnimation(0, "click", true);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        for (int i = 0; i < spines.Count; i++)
        {
            spines[i].AnimationState.SetAnimation(0, "idle", true);
        }
    }
}
