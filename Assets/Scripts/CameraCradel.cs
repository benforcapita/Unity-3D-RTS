using UnityEngine;
using System.Collections;

public class CameraCradel : MonoBehaviour
{

    private float speed = 30f;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	transform.Translate(Input.GetAxis("Horizontal")*speed*Time.deltaTime, 
        Input.GetAxis("Vertical") * speed * Time.deltaTime,0
        );
	}
}
