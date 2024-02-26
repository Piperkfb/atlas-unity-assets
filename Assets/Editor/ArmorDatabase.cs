using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ArmorDatabase : ItemDatabase<Armor>
{

    [MenuItem("Window/Item Manager/Armor Database")]
    public static void ShowWindow()
    {
        GetWindow<ArmorDatabase>("Armor Database");
    }
    protected override void DrawItemList()
    {
        throw new System.NotImplementedException();
    }

    protected override void DrawPropertiesSection()
    {
        throw new System.NotImplementedException();
    }

    protected override void ExportItemsToCSV()
    {
        throw new System.NotImplementedException();
    }

    protected override void ImportItemsFromCSV()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
