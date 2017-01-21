using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Person : MonoBehaviour {
	public enum state  {Approve,Indifferent,Against,Rage};
	string[] peopleSay; //stuff people say Vishnu will add it all in
	public state feeling;
	bool Textvisible;
	public float textTime;//how long the text will be visible for
	public Canvas personCanvas;//the box that will contain the textbox
	public Text personText;//the object that will contain the text and words that will show
	public GameObject canvasOb;//the gameobject that holds the canvas
	public GameObject playerVar;//the actual object of the player
	Vector3 canvOrient;//value that faces the textbox towards the player
	Vector3 playerLoc;//location of the player

	// Use this for initialization
	void Start () {
		canvasOb = gameObject.transform.GetChild (1).gameObject;//will get the Canvas object
		personCanvas = canvasOb.GetComponent<Canvas>();
		personText = canvasOb.GetComponent<Text> ();
		canvasOb.SetActive (false);//Turns off the textbox
		textTime = 5f;
		playerVar = GameObject.Find ("FirstPersonCharacter");
		playerLoc = playerVar.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Textvisible) {
			textTime -= Time.deltaTime;
			if (textTime <= 0) {
				Textvisible = false;
				canvasOb.SetActive (false);//Turns off the textbox
				textTime = 5f;
			}
			//orient the canvas so that it is facing the player
			//Faces at the front of the player for now
			/*playerLoc = playerVar.transform.position;
			Vector3 rotPos = playerLoc;
			rotPos.y = 0f;
			canvasOb.transform.LookAt(playerLoc,canvasOb.transform.up);*/
		}
	}

	//method for when NPC talks to the player
	void convPlayer(){}

	//When the colliders hit
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "MainCamera") {//checks to see if the person collides with the main character
			if (Textvisible) {
				return;//if the text is already showing it skips so that it doesn't continually reappear
			} else {
				canvasOb.SetActive (true);//Turns on the textbox
				Textvisible = true;//Makes it true an has the text appear for textTime length
			}
		}
	}
}
