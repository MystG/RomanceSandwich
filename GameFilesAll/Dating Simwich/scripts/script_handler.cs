using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class script_handler : MonoBehaviour {

	string [] lines;
	int lineCount;
	int curPos;
	public Button text_Box;
	public GameObject txtDirObj;
	script_directory textScript;
	script_option optionsScript;
	public Image curChar;
	string curName;



	// Use this for initialization
	void Start () {

		lineCount = 2;

		lines = new string[lineCount];
		curPos = 0;

		lines [0] = "Testing";
		lines [1] = "ERORR";

		textScript = txtDirObj.GetComponent<script_directory> ();
		optionsScript = txtDirObj.GetComponent<script_option> ();
		curName = "cheesechan";
		getScene (curName, 0);

	}

	public void getScene(string Name, int number)
	{
		setNewLines(textScript.getLines (Name, number));
		curName = Name;
		curChar.sprite = Resources.Load<Sprite>(Name);

	}

	void setNewLines(string[] givenLines)
	{
		lineCount = givenLines.Length;
		lines = givenLines;
		curPos = 0;
		printLine ();
		//this also sets the text value to the inital thingy
	}

	public void printLine()
	{
		if (!(curPos < lineCount)) {
			this.GetComponentInChildren<Text> ().text = "ERROR - text has reached the end of the given lines!";
		} else {
			if (lines[curPos].Length<13||lines[curPos].Substring(0,13)!= "BranchingPath") {
				this.GetComponentInChildren<Text> ().text = lines [curPos];


				curPos++;
			} else {
				

				string tmp = lines [curPos].Substring (14, lines [curPos].Length-14);
				string OP1 = (tmp.Substring(0,tmp.IndexOf("|")));
				tmp = tmp.Substring (tmp.IndexOf (("|")) +1);
				string OP2 = (tmp.Substring(0,tmp.IndexOf("|")));
				tmp = tmp.Substring (tmp.IndexOf (("|")) +1);
				int OP1_num = int.Parse(tmp.Substring(0,tmp.IndexOf("|")));
				tmp = tmp.Substring (tmp.IndexOf (("|"))+1);
				int OP2_num = int.Parse(tmp.Substring(0,tmp.IndexOf("|")));
				tmp = tmp.Substring (tmp.IndexOf (("|"))+1);
				string name_one = (tmp.Substring(0,tmp.IndexOf("|")));
				tmp = tmp.Substring (tmp.IndexOf (("|"))+1);
				string name_two = (tmp);
				optionsScript.enableOptions (OP1, OP2, OP1_num, OP2_num, name_one, name_two);
			}
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
