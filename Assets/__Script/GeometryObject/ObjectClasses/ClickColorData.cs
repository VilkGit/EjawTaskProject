using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Project/ClickColorData", fileName = "ClickColorData")]
public class ClickColorData : ScriptableObject
{
    public int minClicksCount;
    public int maxClicksCount;
    public Color color = Color.white;
}
