using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public Camera playerCam;
	// Use this for initialization
	void Start () {
		playerCam = gameObject.GetComponent<Camera> ();	//making access to the camera easier in script
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
