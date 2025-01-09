using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ZiMuTextLang : MonoBehaviour
{
    public string Chinese;
    public string ChineseTraditional;
    public string English;
    public string Japan;
    public string Korean;

    // Start is called before the first frame update
    void Start()
    {
        Text textCom = GetComponent<Text>();

        if (ZiMuLanguageType.Instance.LanguageType == LanguageType.Chinese) {
            textCom.text = Chinese;
        } else if (ZiMuLanguageType.Instance.LanguageType == LanguageType.ChineseTraditional) {
            textCom.text = ChineseTraditional;
        } else if (ZiMuLanguageType.Instance.LanguageType == LanguageType.English) {
            textCom.text = English;
        } else if (ZiMuLanguageType.Instance.LanguageType == LanguageType.Japan) {
            textCom.text = Japan;
        } else if (ZiMuLanguageType.Instance.LanguageType == LanguageType.Korean) {
            textCom.text = Korean;
        }
    }
}
