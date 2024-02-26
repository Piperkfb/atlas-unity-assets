using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class WeaponDatabase : ItemDatabase<Weapon>
{
    [MenuItem("Window/Item Manager/Weapon Database")]

//    public override static void OnGUI((Rect position, SerializedProperty property, GUIContent label))
 //   {

 //   }
    public static void ShowWindow()
    {
        GetWindow<WeaponDatabase>("Weapon Database");
    }
    protected override void DrawItemList()
    {
        throw new System.NotImplementedException();
    }

    protected override void DrawPropertiesSection()
    {
        EditorGUI.BeginChangeCheck();

        GUILayout.Label("Properties Section:", EditorStyles.boldLabel);

    }

    protected override void ExportItemsToCSV()
    {
        throw new System.NotImplementedException();
    }

    protected override void ImportItemsFromCSV()
    {
        throw new System.NotImplementedException();
    }
    private void DeleteSelectedWeapon()
    {
        if (selectedItem != null)
        {
            AssetDatabase.DeleteAsset(AssetDatabase.GetAssetPath(selectedItem));
            selectedItem = null;
            AssetDatabase.Refresh();
        }
    }
}
