using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GeometryObjectSphere : GeometryObjectModel
{
    protected override void Start()
    {
        dataObject = Resources.Load<GeometryObjectData>(
            "GeometrySettings/Sphere");
        gameObject.name = dataObject.GetNameGeometryObject().sphere;

        base.Start();
    }


}
