using UnityEditor;
using UnityEngine;

public class DarthMaul: EditorWindow
{
    [MenuItem("Qychui/2.DarthMaul")]
    public static void ShowWindows()
    {

        DarthMaul.CreateInstance<DarthMaul>().ShowUtility();

    }

    public string mTag;
    public int mLayer;
    public Object mObject;

    public void OnGUI()
    {
        this.mObject = EditorGUILayout.ObjectField("对象选择器", this.mObject, typeof(GameObject), true);

        if (GUILayout.Button("Close"))
        {
            this.Close();
        }
    }
}
