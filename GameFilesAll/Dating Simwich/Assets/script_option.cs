using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class script_option : MonoBehaviour {

	public GameObject but1;
	public GameObject but2;
	public Button textBox;

	int option1;
	int option2;
	string gibName_one;
	string gibName_two;

	// Use this for initialization
	void Start () {
		but1.SetActive (false);
		but2.SetActive (false);
		gibName_one = "herpderphelp";
		gibName_two = "herpderpwhelp";
		option1 = 9999999;
		option2 = 9999999;

	}

	public void enableOptions(string OptionOne, string OptionTwo, int reroute1, int reroute2, string name_one, string name_two){
		but1.GetComponentInChildren<Text> ().text = OptionOne;
		but2.GetComponentInChildren<Text> ().text = OptionTwo;
		option1 = reroute1;
		option2 = reroute2;
		but1.SetActive (true);
		but2.SetActive (true);
		gibName_one = name_one;
		gibName_two = name_two;
	}

	public void choiceOne(){
		textBox.GetComponent<script_handler> ().getScene(gibName_one, option1);
		disableOptions ();
	}

	public void choiceTwo(){
		textBox.GetComponent<script_handler>().getScene(gibName_two,option2);
		disableOptions ();
	}

	void disableOptions(){
		but1.SetActive (false);
		but2.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
