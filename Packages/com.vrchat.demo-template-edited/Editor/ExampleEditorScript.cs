using UnityEditor;

public class ExampleEditorScript
{
    [MenuItem("Example Editor Script/Test")]
    static void Test()
    {
        EditorUtility.DisplayDialog("Example Script", "Opened This Dialog +7", "OK");
    }
}
