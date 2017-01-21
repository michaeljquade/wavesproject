using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantPerson : Person {
	Person[] persons;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//when ImpPerson argues with another random NPC
	void Conversation(Person p){
		switch(p.feeling){
		case state.Approve:
			break;
		case state.Indifferent:
			break;
		case state.Against:
			break;
		case state.Rage:
			break;
		}
	}
}
