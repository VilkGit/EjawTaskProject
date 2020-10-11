using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnModel : MonoBehaviour
{
    [SerializeField] GameObject[] models = new GameObject[1];
    
    private bool firstClick = false;


    void Update()
    {
        FirstClick();
        Click();   
    }

    void FirstClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!firstClick)
            {
                firstClick = true;
                Instantiate(models[Random.Range(0, models.Length)]);
            }
        }
        
    }

    void Click()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; 
            if(Physics.Raycast(ray, out hit))
            {
                GeometryObjectModel model =
                    hit.collider.GetComponent<GeometryObjectModel>();
                
                if (model != null)
                {
                    model.ClickOnModel();
                }
            }
        }
    }
}
