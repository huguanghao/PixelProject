using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LanguageType {
    Chinese,
    ChineseTraditional,
    English,
    Japan,
    Korean,
}

public class ZiMuLanguageType : MonoBehaviour
{
    public LanguageType LanguageType;

    public static ZiMuLanguageType Instance;

    void Awake() {
        Instance = this;
    }
}
