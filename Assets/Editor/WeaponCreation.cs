using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class WeaponCreation : BaseItemCreation<Weapon>
{
    private float AttackPower;
    private float AttackSpeed;
    private float Durability;
    private float AttackRange;
    private float CritChance;

    [MenuItem("Window/Item Manager/Weapon Creation")]
    public static void ShowWindow()
    {
        GetWindow<WeaponCreation>("Weapon Creation");
    }
    private void OnGUI()
    {
        Weapon NewWeapon
    }
    private void CreateWeapons()
    {
        string SavePath = "Assets/Items/Weapons/";
        if (!AssetDatabase.IsValidFolder(SavePath))
            {
                System.IO.Directory.CreateDirectory(Application.dataPath + SavePath.Substring("Assets".Length));
                AssetDatabase.Refresh();
            }
        string SaveFile = SavePath + itemName + ".asset";
        AssetDatabase.CreateAsset(newItem, SaveFile);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}
