using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour {
	public enum state  {Approve,Indifferent,Against,Rage};

	public state feeling;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//method for when NPC talks to the player
	void convPlayer(){}
}
