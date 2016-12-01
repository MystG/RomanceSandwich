using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class script_handler : MonoBehaviour {

	string [] lines;
	int lineCount;
	int curPos;
	public GameObject text_Box;
    public GameObject foodImage;
	public GameObject txtDirObj;
    public GameObject bg;
    script_directory textScript;
	script_option optionsScript;
	public Image curChar;
	string curName;

    public GameObject hamSprite;
    public GameObject mayoSprite;
    public GameObject lettuceSprite;
    public GameObject bunSprite;
    public GameObject cheeseSprite;

     






    public GameObject playerObject;
    DetectScript detector;




	// Use this for initialization
	void Start () {

		lineCount = 2;

        detector = playerObject.GetComponent<DetectScript>();

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
        curName = Name;
        setNewLines(textScript.getLines (Name, number));
        if (Name != "endCondition")
            curChar.sprite = Resources.Load<Sprite>(Name);
        else
            curChar.enabled  = false;

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
            //this.GetComponentInChildren<Text> ().text = "ERROR - text has reached the end of the given lines!";
            if(lines[curPos-1]== "HAM-WEEB OBTAINEDDDDDDDDDDDDDDDDD")
            {
                detector.gotFood(0);
                hamSprite.SetActive(false);
            }
            else if(lines[curPos - 1] == "LETTUCE-KUN OBTAINED!")
            {
                detector.gotFood(1);
                lettuceSprite.SetActive(false);
            }
            else if (lines[curPos - 1] == "111!!!!1!!!1111!!!!!!!11!!!1!!11!!!1!!!11!!1!11!!!1!!!!" || lines[curPos - 1] == "mayo obtained.")
            {
                detector.gotFood(2);
                mayoSprite.SetActive(false);
            }
            else if (lines[curPos - 1] == "BAEWBUEWN-fAW#SNDF AOBAWEVNETAEIWNTEDFSFA#EDE@#%T@# %@!%!@*'631u24")
            {
                detector.gotFood(3);
                bunSprite.SetActive(false);
            }
            else if (lines[curPos - 1] == "CHEEZE-CHAN OBTAINED???")
            {
                detector.gotFood(4);
                cheeseSprite.SetActive(false);
            }

            if(curName!="endCondition")
            { 
            text_Box.SetActive(false);
            foodImage.SetActive(false);
            bg.SetActive(false);
            playerObject.SetActive(true);
            }
            

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
