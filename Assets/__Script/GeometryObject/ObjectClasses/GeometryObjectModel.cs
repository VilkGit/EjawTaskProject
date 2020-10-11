using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UniRx;

public class GeometryObjectModel : MonoBehaviour
{
    [SerializeField] int clickOnModel = 0;
    [SerializeField] Color modelColor = new Color();
    
    private GameData admin = null;
    
    protected GeometryObjectData dataObject = null;


    private void Awake()
    {
        admin = Resources.Load<GameData>("Admin");
        
    }

    protected virtual void Start()
    {
        //If in successor class does not set path to dataObject
        //  will call exception
        if (dataObject == null)
        {
            throw new System.NullReferenceException(
                "dataObject not be null." +
                " Have to set path dataObject in Start()");
        }
        ChengeColorByTime();
    }

    // After the time specified in Admin change color object on random
    private void ChengeColorByTime()
    {
        ChengeColor(dataObject.GetRandomColor());
        Observable.TimerFrame(admin.observableTime * 100).Subscribe(
            _ => ChengeColorByTime());
    }

    protected void ChengeColor(Color newColor)
    {
        GetComponent<Renderer>().material.color = newColor;
        modelColor = newColor;
    }

    // Calld when mouse cliced on this object
    public void ClickOnModel()
    {
        clickOnModel++;
        ChengeColor(dataObject.GetColorForQuntityClick(clickOnModel));
    }
}
