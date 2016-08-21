using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class PlayerSetupDefintation
{

    public string name;
    public Transform Loc;
    public Color AccentColor;

    public List<GameObject> StartingUnits= new List<GameObject>();
    public bool isAi;
    public float Credits;
}
