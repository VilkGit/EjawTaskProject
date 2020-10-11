using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Struct for json data, where saved prefab name 
[System.Serializable]
public struct JsonNameGeometryObject
{
    public string cube;
    public string sphere;
    public string cylinder;

    public JsonNameGeometryObject(string cube,
        string sphere,
        string cylinder)
    {
        this.cube = cube;
        this.sphere = sphere;
        this.cylinder = cylinder;
    }
}
