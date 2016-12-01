using UnityEngine;
using System.Collections;

public class FinalConsequence : MonoBehaviour
{
    private bool hamGet;
    private int mayoGet;
    private bool lettuceGet;
    private bool bunGet;
    private bool cheeseGet;
	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            print("Press Enter again to complete sandwich");
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                computeScore();
            }
        }
    }

    void computeScore()
    {
        if (bunGet != true)
            print("You attempt to eat your sandwich. It falls apart as you have no bread to hold it together.");
        else if (mayoGet == 2)
            print("You cannot eat your sandwich, as it has far too much mayo on it.");
        else if (cheeseGet == true || hamGet == true && mayoGet == 0 && lettuceGet == false)
            print("You eat your sandwich. It is plain but satisfying.");
        else if ((hamGet == true && mayoGet == 1 && lettuceGet == true) || (lettuceGet == true && cheeseGet == true && hamGet == true))
            print("You eat your sandwich. It is delicious and reminds you of your mom's cooking.");
        else if (lettuceGet == true && cheeseGet == false && hamGet == false)
            print("You eat your sandwich. It is crisp and refreshing.");
        else if (lettuceGet == true && cheeseGet == true && hamGet == true && mayoGet == 1)
            print("You eat your sandwich. It is the best sandwich you've ever had.");
        else if ((lettuceGet != true && cheeseGet != true && hamGet != true) && (mayoGet == 1 || mayoGet == 0))
            print("You eat your sandwich. It is dry and boring and reminds you of sadness.");
    }
}
