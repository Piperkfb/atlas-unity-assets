using System.Collections;
using System.Collections.Generic;

using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEditor.PackageManager;

public class WeaponCreation : BaseItemCreation<Weapon>
{
    private WeaponType weaponType;
    private EquipSlot equipSlot;
    private float attackPower;
    private float attackSpeed;
    private float durability;
    private float range;
    private float criticalHitChance;
    

    [MenuItem("Window/Item Manager/Weapon Creation")]
    public static void ShowWindow()
    {
        GetWindow<WeaponCreation>("Weapon Creation");
    }
    private void OnGUI()
    {
        DrawCommonFields();
        GUILayout.Label("Properties Section:", EditorStyles.boldLabel);
        weaponType = (WeaponType)EditorGUILayout.EnumPopup("Weapon Type:", weaponType);
        equipSlot = (EquipSlot)EditorGUILayout.EnumPopup("Equip Slot:", equipSlot);
        attackPower = EditorGUILayout.FloatField("Attack Power:", attackPower);
        attackSpeed = EditorGUILayout.FloatField("Attack Speed:", attackSpeed);
        durability = EditorGUILayout.FloatField("Durability:", durability);
        range = EditorGUILayout.FloatField("Range:", range);
        criticalHitChance = EditorGUILayout.FloatField("Critical Hit Chance:", criticalHitChance);
        
        if (GUILayout.Button("Create Weapon")) CreateWeapons();
    }
    private void CreateWeapons()
    {
        Weapon NewWeapon = CreateInstance<Weapon>();
        NewWeapon.itemName = itemName;
        NewWeapon.icon = icon;
        NewWeapon.description = description;
        NewWeapon.baseValue = baseValue;
        NewWeapon.rarity = rarity;
        NewWeapon.requiredLevel = requiredLevel;
        NewWeapon.weaponType = weaponType;
        NewWeapon.attackPower = attackPower;
        NewWeapon.attackSpeed = attackSpeed;
        NewWeapon.durability = durability;
        NewWeapon.range = range;
        NewWeapon.criticalHitChance = criticalHitChance;
        NewWeapon.equipSlot = equipSlot;

        string SavePath = "Assets/Items/Weapons/";

        //make a folder if it doesn't exist
        if (!AssetDatabase.IsValidFolder(SavePath))
            {
                System.IO.Directory.CreateDirectory(Application.dataPath + SavePath.Substring("Assets".Length));
                AssetDatabase.Refresh();
            }
        if (!File.Exists(itemName))
        {
            string SaveFile = SavePath + itemName + ".asset";
            AssetDatabase.CreateAsset(NewWeapon, SaveFile);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }  
        else
        {
            Debug.Log("It exists already");       
        }
    }
}
