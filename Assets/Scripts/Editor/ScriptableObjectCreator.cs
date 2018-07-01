using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

public class ScriptableObjectCreator
{

    private const string _resourcesPath = "Assets/Resources";

    [MenuItem("ScriptableObjects/Create items data")]
    public static void CreateItemsData()
    {
        ItemsData asset = ScriptableObject.CreateInstance<ItemsData>();

        if (!Directory.Exists(_resourcesPath))
            Directory.CreateDirectory(_resourcesPath);

        AssetDatabase.CreateAsset(asset, "Assets/Resources/ItemsData.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }
}
