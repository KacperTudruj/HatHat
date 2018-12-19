using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public float panSpeed = 30f; 
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.up * panSpeed * Time.deltaTime, Space.World);
        }

    }
}
