using UnityEngine;
using System.Collections.Generic;

public class RTS_Manger : MonoBehaviour
{

    public static RTS_Manger instance;
    public List<PlayerSetupDefintation> player= new List<PlayerSetupDefintation>(); 

	// Use this for initialization
	void Start () {

	    if (instance == null)
	    {
	        instance = this;
	    }
	    foreach (var P in player)
	    {
	        foreach (var PU in P.StartingUnits)
	        {
	            GameObject.Instantiate(PU, P.Loc.position, P.Loc.rotation);
	        }
	    }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
