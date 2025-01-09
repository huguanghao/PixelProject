using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

public class MergeSequenceFrameImage : EditorWindow
{
    enum EmImgFormat
    {
        PNG = 0,
        JPG = 1,
        TGA = 2
    }
    static string filePath = "";
    static string outPath = "";

    static int impWidth;
    static int impHeight;

    static int outSizeIndex = 0;
    static int outWidth = 4096;
    static int outHeight = 4096;
    public static readonly string[] enumNames = Enum.GetNames(typeof(EmImgFormat));
    public static readonly string[] enumSizes = new string[] {
        "32","64","128","256","512","1024","2048","4096","8192"
    };
    static List<Task> task = new List<Task>();
    static TaskFactory taskfactory = new TaskFactory();

    [MenuItem("Tools/�Զ��幤��/����֡ͼƬ�ϲ�")]
    public static void ShowExample()
    {
        MergeSequenceFrameImage wnd = GetWindow<MergeSequenceFrameImage>();
        wnd.titleContent = new GUIContent("MergeSequenceFrameImage");
        wnd.minSize = new Vector2(500, 540);
        Init();
    }

    public static void Init()
    {
        isMerge = false;
        outSizeIndex = enumSizes.Length - 1;
        outWidth = outHeight = int.Parse(enumSizes[outSizeIndex]);
    }
    static EmImgFormat emImgFormat = EmImgFormat.JPG;
    static EmImgFormat emOutFormat = EmImgFormat.PNG;
    static string[] strImgFormat = new string[]
    {
        "*.png",
        "*.jpg",
        "*.tga"
    };
    static string importImgFormat = "*.jpg";
    GUIStyle filePathStyle;
    static int curProgress = 0;
    static int maxProgress = 1;

    static float progress = 0f;
    static string proDesc = "";
    static bool isMerge = false;
    private void OnGUI()
    {
        GUILayout.BeginVertical();
        GUILayout.Space(10.0f);
        GUILayout.Label("����֡ͼƬ����", new GUILayoutOption[] { GUILayout.Width(100) });
        GUILayout.Space(10.0f);
        GUILayout.BeginHorizontal();
        GUILayout.Label("����֡ͼƬ·����", new GUILayoutOption[] { GUILayout.Width(100) });
        filePathStyle = new GUIStyle(GUI.skin.GetStyle("TextField"));
        filePathStyle.alignment = TextAnchor.LowerLeft;
        GUILayout.TextField(filePath, filePathStyle, new GUILayoutOption[] { GUILayout.Width(330) });
        GUILayout.Space(10.0f);
        if (GUILayout.Button("���", new GUILayoutOption[] { GUILayout.Width(40.0f) }))
        {
            filePath = EditorUtility.OpenFolderPanel("ѡ������֡ͼƬĿ¼", Application.dataPath, "");
        }
        GUILayout.EndHorizontal();
        //�쳣��ʾ
        if (string.IsNullOrEmpty(filePath))
        {
            ShowRedTipsLab("��ѡ������֡ͼƬĿ¼·��");
        }
        //ͼƬ��ʽ
        GUILayout.Space(10.0f);
        GUILayout.BeginHorizontal();
        GUILayout.Label("����֡ͼƬ��ʽ:", new GUILayoutOption[] { GUILayout.Width(100) });
        EditorGUI.BeginChangeCheck();
        emImgFormat = (EmImgFormat)EditorGUILayout.Popup("", (int)emImgFormat, enumNames, new GUILayoutOption[] { GUILayout.Width(330) });
        if (EditorGUI.EndChangeCheck())
        {
            importImgFormat = strImgFormat[(int)emImgFormat];
        }
        GUILayout.EndHorizontal();
        //����֡�ߴ�����
        GUILayout.Space(10.0f);
        GUILayout.BeginHorizontal();
        GUILayout.Label("����֡ͼƬ�ߴ磺", new GUILayoutOption[] { GUILayout.Width(100) });
        GUILayout.Label("Width", new GUILayoutOption[] { GUILayout.Width(40) });
        impWidth = EditorGUILayout.IntField(impWidth, new GUILayoutOption[] { GUILayout.Width(80) });
        GUILayout.Label("Height", new GUILayoutOption[] { GUILayout.Width(40) });
        impHeight = EditorGUILayout.IntField(impHeight, new GUILayoutOption[] { GUILayout.Width(80) });
        GUILayout.EndHorizontal();
        if (impHeight <= 0 || impWidth <= 0)
        {
            ShowRedTipsLab("����������֡ͼƬ�ߴ�");
        }
        else if ((impHeight & (impHeight - 1)) != 0 || (impWidth & (impWidth - 1)) != 0)
        {
            ShowRedTipsLab("����ĳߴ粻��2�Ĵ���");
        }
        GUILayout.Space(10.0f);
        GUILayout.Label("ע�⣺��ȷ�����Ϊ2�Ĵ���", new GUILayoutOption[] { GUILayout.Width(500) });
        //��������
        GUILayout.Space(30.0f);
        GUILayout.Label("����ͼƬ����", new GUILayoutOption[] { GUILayout.Width(100) });
        GUILayout.Space(10.0f);
        GUILayout.BeginHorizontal();

        GUILayout.Label("����ͼƬ·����", new GUILayoutOption[] { GUILayout.Width(100) });
        GUIStyle tryStyle = new GUIStyle(GUI.skin.GetStyle("TextField"));
        tryStyle.alignment = TextAnchor.LowerLeft;
        GUILayout.TextField(outPath, tryStyle, new GUILayoutOption[] { GUILayout.Width(330) });
        GUILayout.Space(10.0f);
        if (GUILayout.Button("���", new GUILayoutOption[] { GUILayout.Width(40.0f) }))
        {
            outPath = EditorUtility.OpenFolderPanel("ѡ��Ҫ������Ŀ¼", Application.dataPath, "");
        }

        GUILayout.EndHorizontal();
        if (string.IsNullOrEmpty(outPath))
        {
            ShowRedTipsLab("��ѡ��Ҫ������Ŀ¼·��");
        }
        //�����ߴ�����
        GUILayout.Space(10.0f);
        GUILayout.BeginHorizontal();
        GUILayout.Label("����ͼƬ��С:", new GUILayoutOption[] { GUILayout.Width(100) });
        EditorGUI.BeginChangeCheck();
        outSizeIndex = EditorGUILayout.Popup("", outSizeIndex, enumSizes, new GUILayoutOption[] { GUILayout.Width(330) });
        if (EditorGUI.EndChangeCheck())
        {
            outWidth = int.Parse(enumSizes[outSizeIndex]);
            outHeight = outWidth;
        }
        GUILayout.EndHorizontal();
        //����ͼƬ��ʽ
        GUILayout.Space(10.0f);
        GUILayout.BeginHorizontal();
        GUILayout.Label("����ͼƬ��ʽ:", new GUILayoutOption[] { GUILayout.Width(100) });
        emOutFormat = (EmImgFormat)EditorGUILayout.Popup("", (int)emOutFormat, enumNames, new GUILayoutOption[] { GUILayout.Width(330) });
        GUILayout.EndHorizontal();
        GUILayout.Space(10.0f);
        //ִ��
        if (GUILayout.Button("ִ�кϲ�", new GUILayoutOption[] { GUILayout.Width(120.0f) }) && !isMerge)
        {
            //����һϵ�м��
            if (!CheckIsValid())
            {
                Debug.LogError("�������δͨ����");
                return;
            }
            isMerge = true;
            StartMerge();
        }


        //GUILayout.Space(10.0f);
        //if (GUILayout.Button("����", new GUILayoutOption[] { GUILayout.Width(120.0f) }) && !isMerge)
        //{
        //    filePath = "C:/Users/Administrator/Desktop/sucai";
        //    outPath = Application.dataPath;
        //    impWidth = 1024;impHeight = 512;
        //    outWidth = outHeight = 512;
        //}
        //GUILayout.Space(10.0f);
        //GUILayout.BeginHorizontal();
        //GUILayout.Label("count", new GUILayoutOption[] { GUILayout.Width(40) });
        //cnt = EditorGUILayout.IntField(cnt, new GUILayoutOption[] { GUILayout.Width(80) });
        //GUILayout.EndHorizontal();

        GUILayout.EndVertical();
    }
    static void ShowRedTipsLab(string tips)
    {
        GUI.color = Color.red;
        GUILayout.Label(tips, new GUILayoutOption[] { GUILayout.Width(500) });
        GUI.color = Color.white;
    }
    static int cnt = 0;
    public static void StartMerge()
    {
        proDesc = "��ʼ��ȡ����֡ͼƬ";
        EditorUtility.DisplayProgressBar(proDesc, "", progress);
        Debug.Log(filePath);
        DirectoryInfo folder = new DirectoryInfo(filePath);
        var files = folder.GetFiles(importImgFormat);
        maxProgress = files.Length;
        //maxProgress = cnt;//test
        Texture2D[] texture2Ds = new Texture2D[maxProgress];
        for (int i = 0; i < maxProgress; i++)
        {
            FileInfo file = files[i];
            FileStream fs = new FileStream(filePath + "/" + file.Name, FileMode.Open, FileAccess.Read);
            int byteLength = (int)fs.Length;
            byte[] imgBytes = new byte[byteLength];
            fs.Read(imgBytes, 0, byteLength);
            fs.Close();
            fs.Dispose();
            Texture2D t2d = new Texture2D(impWidth, impHeight);
            t2d.LoadImage(imgBytes);
            t2d.Apply();
            texture2Ds[i] = t2d;
            progress = (float)(i + 1) / maxProgress;
            EditorUtility.DisplayProgressBar(proDesc, file.Name, progress);
        }
        proDesc = "׼��д����ͼ";
        progress = 0f;
        EditorUtility.DisplayProgressBar(proDesc, "", progress);
        Texture2D tex = GetOutTex(texture2Ds);
        byte[] bytes = new byte[] { };
        string suffix = "";
        if (emOutFormat == EmImgFormat.PNG)
        {
            bytes = tex.EncodeToPNG();
            suffix = ".png";
        }
        else if (emOutFormat == EmImgFormat.JPG)
        {
            bytes = tex.EncodeToJPG();
            suffix = ".jpg";
        }
        else if (emOutFormat == EmImgFormat.TGA)
        {
            bytes = tex.EncodeToTGA();
            suffix = ".tga";
        }
        File.WriteAllBytes(outPath + "/output" + suffix, bytes);
        EditorUtility.ClearProgressBar();
        EditorApplication.ExecuteMenuItem("Assets/Refresh");
        isMerge = false;
    }
    public static Texture2D GetOutTex(Texture2D[] texs)
    {
        int len = texs.Length;
        if (len < 1) return null;
        Texture2D nTex = new Texture2D(outWidth, outHeight, TextureFormat.ARGB32, true);
        Color[] colors = new Color[outWidth * outHeight];
        int offsetW, offsetH;
        offsetW = 0;//����д��ƫ��
        offsetH = 0;//����д��ƫ��
        //�Ƿ��ǿ�ͼ
        bool isHor = impWidth > impHeight;
        float ratio = isHor ? (float)impWidth / impHeight : (float)impHeight / impWidth;
        //�����������㵥�����
        float oriCnt = Mathf.Sqrt(len / ratio);

        int littleCnt = Mathf.CeilToInt(oriCnt);
        int moreCnt = Mathf.CeilToInt(oriCnt * ratio);


        int wCnt = isHor ? littleCnt : moreCnt;
        //�������
        int hCnt = isHor ? moreCnt : littleCnt;
        //���Ÿ߶�
        int singleH = Mathf.FloorToInt(outHeight / hCnt);
        int singleW = Mathf.FloorToInt(outWidth / wCnt);
        //���ſ��
        Debug.Log(string.Format("����õ�����ͼ��width=={0}==height=={1}", singleW, singleH));
        Debug.Log(string.Format("����õ�����ͼ��wCnt=={0}==hCnt=={1}", wCnt, hCnt));
        int texIndex = 0;
        GetTextureCol(texs, ref colors, texIndex, singleW, singleH, offsetW, offsetH);
        proDesc = "ͼƬ�ϲ���ɣ���ʼд���ͼ";
        EditorUtility.DisplayProgressBar(proDesc, "", progress);
        nTex.SetPixels(colors);
        nTex.Apply();
        return nTex;
    }
    static void GetTextureCol(Texture2D[] texs, ref Color[] colors, int texIndex, int singleW, int singleH, int offsetW, int offsetH)
    {
        proDesc = string.Format("д���{0}��ͼƬ", texIndex + 1);
        Texture2D tex = texs[texIndex];
        EditorUtility.DisplayProgressBar(proDesc, tex.name, progress);
        for (int h = 0; h < singleH; h++)
        {
            for (int w = 0; w < singleW; w++)
            {
                Color color = tex.GetPixelBilinear((float)w / singleW, (float)h / singleH);
                int index = h * outWidth + w + offsetW + (offsetH * outHeight);
                try
                {
                    if (colors[index] == null)
                    {
                        colors[index] = color;
                        continue;
                    }
                    colors[index] = color;

                }
                catch (Exception e)
                {
                    Debug.LogError(e.ToString());
                }
            }

        }
        offsetW += singleW;
        if (offsetW + singleW > outWidth)
        {
            offsetH += singleH;
            offsetW = 0;
        }
        texIndex = texIndex + 1;
        progress = (float)texIndex / maxProgress;
        if (texIndex < texs.Length)
        {
            GetTextureCol(texs, ref colors, texIndex, singleW, singleH, offsetW, offsetH);
        }
    }

    static bool CheckIsValid()
    {
        bool ret = true;
        //·�����
        if (string.IsNullOrEmpty(filePath))
        {
            return false;
        }
        if (string.IsNullOrEmpty(outPath))
        {
            return false;
        }
        //�ߴ���
        if (impHeight <= 0 || impWidth <= 0)
        {
            return false;
        }
        if (outWidth <= 0 || outHeight <= 0)
        {
            return false;
        }
        return ret;
    }
}