using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Project/GeometryObjectData", 
    fileName = "GeometryObjectData")]
public class GeometryObjectData : ScriptableObject
{
    [SerializeField] List<ClickColorData> clicksData = null;

    private string pathToFileJsonName = "Assets/Resources/NamePref.json";

    public Color GetColorForQuntityClick(int quntityClicks)
    {
        foreach(ClickColorData c in clicksData)
        {
            if(c.minClicksCount <= quntityClicks &&
                c.maxClicksCount >= quntityClicks)
            {
                return c.color;
            }
        }

        return Color.white;
    }

    public Color GetRandomColor()
    {
        int idClickData = Random.Range(0, clicksData.Count - 1);
        Color color = clicksData[idClickData].color;
        return color;

    }

    //Return name of prefab from json file
    // specified in variable pathToFileJsonName
    public JsonNameGeometryObject GetNameGeometryObject()
    {
        string textFile = File.ReadAllText(pathToFileJsonName);
        JsonNameGeometryObject jsonName =
            JsonUtility.FromJson<JsonNameGeometryObject>(textFile);

        return jsonName;
    }
}
