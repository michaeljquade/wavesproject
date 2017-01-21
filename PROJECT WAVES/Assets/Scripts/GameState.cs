using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {
	public static int worldInfluence;//the total amount of influence
	public static int worldVisibility;
	public static int day;
	public static bool winCondition;//did the player meet the win conditions
	// Use this for initialization
	void Start () {
		day = 1;//starts on day1 ends at day3
		worldInfluence = 0;
		worldVisibility = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void checkGameStatus(){

		if (day == 3) {
			if (worldInfluence < 100) {
				winCondition = true;
				//Code that will win the game
			}
		}
	}
}
