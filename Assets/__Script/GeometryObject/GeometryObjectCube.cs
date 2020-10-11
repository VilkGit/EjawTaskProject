using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryObjectCube : GeometryObjectModel
{
    protected override void Start()
    {
        dataObject = Resources.Load<GeometryObjectData>(
            "GeometrySettings/Cube");
        gameObject.name = dataObject.GetNameGeometryObject().cube;
        base.Start();
    }


}
