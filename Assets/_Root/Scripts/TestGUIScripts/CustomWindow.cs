using UnityEditor;



public class CustomWindow : EditorWindow
{
    private string _myString = "Hallo PPL";
    private bool _gruopEnabled;
    private bool _myBool = true;
    private float _myFloat = 1.23f;

    [MenuItem("Window/Custom Window")]

    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(CustomWindow));
    }

    private void OnGUI()
    {
        EditorGUILayout.LabelField("Base Settings", EditorStyles.boldLabel);
        _myString = EditorGUILayout.TextField("Text Field", _myString);

        _gruopEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", _gruopEnabled);
        _myBool = EditorGUILayout.Toggle("Toggle", _myBool);
        _myFloat = EditorGUILayout.Slider("Slider", _myFloat, -3, 3);
        EditorGUILayout.EndToggleGroup();
    }
}
