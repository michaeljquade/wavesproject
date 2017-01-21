using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Person : MonoBehaviour {
	public enum state  {Approve,Indifferent,Against,Rage};
	string[] peopleSay; //stuff people say Vishnu will add it all in
	public state feeling;
	float Textvisible;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//method for when NPC talks to the player
	void convPlayer(){}
}
