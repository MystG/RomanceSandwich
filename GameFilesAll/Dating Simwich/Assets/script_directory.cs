using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//i think thats required for dictionarys??? idk tell me later

public class script_directory : MonoBehaviour {

	Dictionary<string, List<string[]> > textDic = new Dictionary<string, List<string[]>>();

    /*
	 * NAMES ARE:
     Mayo, bunsan,endCondition,cheesechan,hamsama,lettuce,angerlettuce
	 * */

            void onEnable()
    {

    }


    // Use this for initialization
    void Start () {
		//testingLines();
		mayoInstantiate();
		cheeseInstantiate ();
		lettuceInstantiate();
		hamInstantiate();
		endConditionInstantiate ();
		bunSanInstantiate ();
	}

	void bunSanInstantiate(){
		/*
		 * 0-init talk
		 * 1- any choice
		 */ 
		string[] temp = new string[7];
		temp [0] = "Bun-San: Hey.";
		temp [1] = "Player: Hey.";
		temp [2] = "Bun-San: I totally don't want to be in your snawicd or anyewhing.";
		temp [3] = "Player: I do not understand what you mean?";
		temp [4] = "Bun-San: Yuwae fjdsaut ddont geeteteadfsadsa tewiadsf";
		temp [5] = "Bun-San: Eeawsfdlaewf ewASf fewaOyeasdfsDF ADSFf AFDS fewawefsdafA WEF????";
		temp [6] = "BranchingPath|FEWAF#WAFE 3aFEW#W|fEAWDSfaeWFsdAEWFf3@QRWAEFr32qwde|1|1|bunsan|bunsan";
		insertLines ("bunsan", temp);

		temp = new string[3];
		temp [0] = "Buadsf-Sfaews: FJAWEFALW#Ff aw3FW# FAFA#F AF#WEFA#W A#F";
		temp [1] = "Playwet32: AF@FA FA#  #AT#WT#WRT @#FAWE# FA#FA#A#R#WFE";
		temp [2] = "BAEWBUEWN-fAW#SNDF AOBAWEVNETAEIWNTEDFSFA#EDE@#%T@# %@!%!@*'631u24";
		insertLines ("bunsan", temp);

	}

	void endConditionInstantiate(){
		/*
		 *0 - no bread
		 *1 - too much mayo
		 *2- play but satsifying
		 *3 - tasty; mums ooking
		 *4- crisp and refreshing
		 *5- good end
		 *6 - dry and boring
         *7 - enter thingy
		 */ 


		string[] temp = new string[1];
		temp [0] = "You attempt to eat your sandwich. It falls apart as you have no bread to hold it together.";
		insertLines ("endCondition", temp);
		temp = new string[1];
		temp [0] = "You cannot eat your sandwich, as it has far too much mayo on it.";
		insertLines ("endCondition", temp);
		temp = new string[1];
		temp [0] = "You eat your sandwich. It is plain but satisfying.";
		insertLines ("endCondition", temp);
		temp = new string[1];
		temp [0] = "You eat your sandwich. It is delicious and reminds you of your mom's cooking.";
		insertLines ("endCondition", temp);
		temp = new string[1];
		temp [0] = "You eat your sandwich. It is crisp and refreshing.";
		insertLines ("endCondition", temp);
		temp = new string[3];
		temp [0] = "You eat your sandwich. It is the best sandwich you've ever had.";
		temp [1] = "The blood of those that have joined the sandwich only accents each bite with their tears and agony as they realize that they have been tricked.";
		temp [2] = "They have been fooled into sacrificing themselves for your hunger, being swiftly consumed. And it tastes great.";
		insertLines ("endCondition", temp);
		temp = new string[1];
		temp [0] = "You eat your sandwich. It is dry and boring and reminds you of sadness.";
		insertLines ("endCondition", temp);
        temp = new string[1];
        temp[0] = "You attempt to eat a non-existent sandwich. You accidentally bite your hand in the process.";
        insertLines("endCondition", temp);
	}

	void cheeseInstantiate(){
		/*
		 * 0-initial talk
		 * 1-play song
		 * 2-play yamaka
		 */

		string[] temp = new string[5];
		temp [0] = "Cheese-Chan: Hey, I heard you want me on your sandwich.";
		temp [1] = "Player: Yes, I desire you on my sandwich.";
		temp [2] = "Cheese-Chan: Well, I'm afraid I'm feeling kinda down today.";
		temp [3] = "Cheese-Chan: If you made me happy, I would be a part of your sandwich.";
		temp [4] = "BranchingPath|Play a song from your Yamaha P-45 Black 88-Key Digital Piano with Speaker|Play a song on your Yamaka|1|2|cheesechan|cheesechan";

		insertLines ("cheesechan", temp);

		temp = new string[5];
		temp [0] = "You play a wonderful song.";
		temp [1] = "Cheese-chan begins to dance.";
		temp [2] = "Cheese-chan: Okay, I'm happy now.";
		temp [3] = "Cheese-chan: Okay, I'll be a part of your sandwich now.";
		temp [4] = "CHEEZE-CHAN OBTAINED???";

		insertLines ("cheesechan", temp);

		temp = new string[6];
		temp [0] = "You attempt to play your Yamaka.";
		temp [1] = "Not only is a Yamaka not an instrument, but you also seem to lack a Yamaka.";
		temp [2] = "Cheese-chan is nevertheless enthralled by your determination.";
		temp [3] = "Cheese-chan: You're silly, ha ha.";
		temp [4] = "Cheese-chan: Sure, I'll be a part of your sandwich.";
		temp [5] = "CHEEZE-CHAN OBTAINED???";

		insertLines ("cheesechan", temp);
	
	}

	void hamInstantiate(){
		/*
		 * 0 - first talk
		 * 1 - accept
		 * 2 - reject
		 */

		string[] temp = new string[7];
		temp [0] = "Ham-Sama: What do you want?";
		temp [1] = "Player: I want you on my sandwich.";
		temp [2] = "Ham-Sama: OH, SO YOU WANT ME ON YOUR SANDWICH?";
		temp [3] = "HAM-SAMA: DO YOU THINK YOU HAVE WHAT IT TAKES";
		temp [4] = "HAM-SAMA: TO HAVE ME";
		temp [5] = "HAM-SAMA: ON YOUR SANDWICH?????????";
		temp [6] = "BranchingPath|Yes, it would be most desirable to have you upon and within my sandwich.|You're scary so I'm going to leave.|1|2|hamsama|hamsama";

		insertLines ("hamsama", temp);

		temp = new string[4];
		temp [0] = "HAM-SAMA: SAY PLEASE.";
		temp [1] = "Player: Please.";
		temp [2] = "Ham-Sama: Okay.";
		temp [3] = "HAM-WEEB OBTAINEDDDDDDDDDDDDDDDDD";

		insertLines ("hamsama", temp);

		temp = new string[3];
		temp [0] = "HAM-SAMA: OH I SCARE YOU, HUH???";
		temp [1] = "Player: Yes you are a scary ham please go away.";
		temp [2] = "Ham-Sama: Okay bye.";

		insertLines ("hamsama", temp);


	}

	void lettuceInstantiate(){
		/*
		 * 0 - first talk
		 * 1 - first reject
		 * 
		 * 0-angerlettuce fite
		 */

		string[] temp = new string[5];
		temp [0] = "Lettuce-Kun: Hi, I'm Lettuce-Kun. Who are you?";
		temp [1] = "Player: I'm a person that desires a good sandwich.";
		temp [2] = "Lettuce-Kun: Oh, you want me on your sandwich?";
		temp [3] = "Lettuce-Kun: Well...";
		temp [4] = "BranchingPath|Uh, yes?|Hell no!|0|1|angerlettuce|lettuce";

		insertLines ("lettuce", temp);

		temp = new string[2];
		temp[0] = "Lettuce-Kun: Alright. I'll join your sandwich.";
		temp[1] = "LETTUCE-KUN OBTAINED!";

		insertLines("lettuce",temp);

		temp = new string[5];
		temp [0] = "Lettuce-Kun: PUSH PAGE UP AS FAST AS YOU CAN!";
		temp [1] = "Lettuce-Kun: ...";
		temp [2] = "Lettuce-Kun: ......";
		temp [3] = "Lettuce-Kun: Alright, I was just joking. I'll join your sandwich.";
		temp [4] = "LETTUCE-KUN OBTAINED!";

		insertLines ("angerlettuce", temp);

	}


	void mayoInstantiate(){
		/*
		 * 0 - first talk
		 * 1 - first reject
		 * 2 - first accept
		 * 3 - second talk
		 * 4 - second reject
		 * 5 - second accept
		 */

		string[] temp= new string[6];
		temp [0] = "Mayo: Are you making a sandwich?";
		temp [1] = "Player: Yes, I am making a sandwich.";
		temp [2] = "Mayo: Can I be on your sandwich?";
		temp [3] = "Mayo: Please.";
		temp [4] = "Mayo: PLEASE!!!";
		temp [5] = "BranchingPath|No, I hate mayonnaise.|Yes, I want mayonnaise all over my entire sandwich.|1|2|Mayo|Mayo";

		insertLines ("Mayo", temp);

		temp = new string[3];
		temp [0] = "Mayo: What? You don't want me on your sandwich?";
		temp [1] = "Mayo: You're so mean!";
		temp [2] = "Mayo: I'm going to be on your sandwich no matter what!";

		insertLines ("Mayo", temp);

		temp = new string[5];
		temp [0] = "Mayo: Yay, I'm so glad I can be on your sandwich!";
		temp [1] = "Mayo puts a lot of her mayonnaise on your sandwich.";
		temp [2] = "Your sandwich now has a lot of mayonnaise on it.";
		temp [3] = "MAYO OBTAINED!!!!!!!!!!!!!111!!!11!1!!!!1111!!!!!!2";
		temp [4] = "111!!!!1!!!1111!!!!!!!11!!!1!!11!!!1!!!11!!1!11!!!1!!!!";

		insertLines ("Mayo", temp);

		temp = new string[3];
		temp [0] = "Mayo: Ok, so maybe I was a bit too aggressive last time.";
		temp [1] = "Mayo: Can I pretty please be on your sandwich?";
		temp [2] = "BranchingPath|No, I still hate mayonnaise.|Yes, I am okay with a little bit of mayonnaise.|4|5|Mayo|Mayo";

		insertLines ("Mayo", temp);

		temp = new string[2];
		temp [0] = "Mayo: Oh darn.";
		temp [1] = "Mayo: I really thought you would want me on your sandwich, but oh well.";

		insertLines ("Mayo", temp);

		temp = new string[3];
		temp [0] = "Mayo: Really? Yay!";
		temp [1] = "Mayo puts an agreeable amount of mayo on your sandwich.";
		temp [2] = "mayo obtained."; 

		insertLines ("Mayo", temp);
	}

	void testingLines()
	{
		string[] temp= new string[6];
		temp [0] = "Hey, you there!";
		temp [1] = "Is that a sandwich?";
		temp [2] = "Let me into your sandwich!";
		temp [3] = "If you don't...";
		temp [4] = "I'll kill you.";
		temp [5] = "BranchingPath|Okay|Nokay|1|0|Mayo|cheesechan";

		insertLines ("Mayo", temp);

		temp= new string[2];
		temp [0] = "Okay? Dokay.";
		temp [1] = "ended";

		insertLines ("Mayo", temp);

		temp= new string[3];
		temp [0] = "Nokay? Damn you";
		temp [1] = "owen is stupid";
		temp [2] = "kidneys";

		insertLines ("Mayo", temp);

		temp = new string[2];
		temp [0] = "chez?";
		temp [1] = "BranchingPath|Mayo halp|Lettuce Halp|2|0|Mayo|lettuce";

		insertLines ("cheesechan", temp);

		temp = new string[3];
		temp [0] = "hi";
		temp [1] = "how are you";
		temp [1] = "BranchingPath|oaky|iunno|1|0|lettuce|angerlettuce";

		insertLines ("lettuce", temp);

		temp = new string[2];
		temp [0] = "okay.";
		temp [1] = "END";

		insertLines ("lettuce", temp);


		temp = new string[2];
		temp [0] = "FITE MEEEEEEEEEEE.";
		temp [1] = "END";

		insertLines ("angerlettuce", temp);

	}

	public string[] getLines(string Name, int num){
		return textDic [Name] [num];
	}

	void insertLines(string Name, string [] givenLines){

		List<string[]> charLines;
        
        if (textDic.TryGetValue(Name, out charLines))
		{
			charLines.Add (givenLines);
		}
		else
		{
			charLines = new List<string[]>();
			charLines.Add(givenLines);
			textDic.Add (Name, charLines);

		}

		//idk if this is redudent lol
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
