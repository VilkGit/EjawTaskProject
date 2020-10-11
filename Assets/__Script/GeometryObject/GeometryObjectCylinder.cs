using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryObjectCylinder : GeometryObjectModel
{
    protected override void Start()
    {
        dataObject = Resources.Load<GeometryObjectData>(
            "GeometrySettings/Cylinder");
        gameObject.name = dataObject.GetNameGeometryObject().cylinder;

        base.Start();
    }


}
