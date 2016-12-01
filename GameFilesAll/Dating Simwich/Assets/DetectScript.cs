using UnityEngine;
using System;
using UnityEngine.UI;

public class DetectScript : MonoBehaviour
{
    public Rigidbody2D detector;
    public Rigidbody2D ham;
    public Rigidbody2D lettuce;
    public Rigidbody2D cheese;
    public Rigidbody2D bun;
    public Rigidbody2D mayo;

    public GameObject textBox;
    public GameObject backround;
    public GameObject optionOne;
    public GameObject optionTwo;
    public GameObject talkImage;

    script_handler txtBoxScript;
    public GameObject curPlayer;

    int[] visitedFoods;
    // visitedFoods equals ham,cheese,bun,lettuce,mayo in that order

    bool[] gottenFoods;

    public void gotFood(int i)
    {
        gottenFoods[i] = true;
    }


    // Use this for initialization
    void Start()
    {
        detector = GetComponent<Rigidbody2D>();
        ham = GetComponent<Rigidbody2D>();
        lettuce = GetComponent<Rigidbody2D>();
        cheese = GetComponent<Rigidbody2D>();
        bun = GetComponent<Rigidbody2D>();
        mayo = GetComponent<Rigidbody2D>();

        visitedFoods = new int[5];
        for(int i=0;i<visitedFoods.Length;i++)
        {
            visitedFoods[i] = 0;
        }

        gottenFoods = new bool[5];
        for(int i=0;i<gottenFoods.Length;i++)
        {
            gottenFoods[i] = false;
        }

        txtBoxScript = textBox.GetComponent<script_handler>();

        textBox.SetActive(false);
        optionOne.SetActive(false);
        optionTwo.SetActive(false);
        talkImage.SetActive(false);
        backround.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            computeScore();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ham"&& visitedFoods[0]==0)
        {
            visitedFoods[0]++;

            textBox.SetActive(true);
            talkImage.SetActive(true);
            backround.SetActive(true);
            curPlayer.SetActive(false);
            txtBoxScript.getScene("hamsama", 0);
        }
        else if (coll.gameObject.tag == "Lettuce" && visitedFoods[1] == 0)
        {
            visitedFoods[1]++;

            textBox.SetActive(true);
            talkImage.SetActive(true);
            backround.SetActive(true);
            curPlayer.SetActive(false);
            txtBoxScript.getScene("lettuce", 0);
        }
        else if (coll.gameObject.tag == "Mayo" && visitedFoods[2] == 0)
        {
            visitedFoods[2]++;

            textBox.SetActive(true);
            talkImage.SetActive(true);
            backround.SetActive(true);
            curPlayer.SetActive(false);
            txtBoxScript.getScene("Mayo", 0);
        }
        else if (coll.gameObject.tag == "Mayo" && visitedFoods[2] == 1&&gottenFoods[2]==false)
        {
            visitedFoods[2]++;

            textBox.SetActive(true);
            talkImage.SetActive(true);
            backround.SetActive(true);
            curPlayer.SetActive(false);
            txtBoxScript.getScene("Mayo", 3);
        }
        else if (coll.gameObject.tag == "Bun" && visitedFoods[3] == 0)
        {
            visitedFoods[3]++;

            textBox.SetActive(true);
            talkImage.SetActive(true);
            backround.SetActive(true);
            curPlayer.SetActive(false);
            txtBoxScript.getScene("bunsan", 0);
        }
        else if (coll.gameObject.tag == "Cheese" && visitedFoods[4] == 0)
        {
            visitedFoods[4]++;

            textBox.SetActive(true);
            talkImage.SetActive(true);
            backround.SetActive(true);
            curPlayer.SetActive(false);
            txtBoxScript.getScene("cheesechan", 0);
        }
    }

    void computeScore()
    {
        //use getscene, call final scene
        if (gottenFoods[0]==false && gottenFoods[3] == false && gottenFoods[1]==false && gottenFoods[2]==false && gottenFoods[4]==false)
        {
            textBox.SetActive(true);
            talkImage.SetActive(true);
            backround.SetActive(true);
            curPlayer.SetActive(false);
            txtBoxScript.getScene("endCondition", 7);
        }
        else if (gottenFoods[3] == false)
        {
            textBox.SetActive(true);
            talkImage.SetActive(true);
            backround.SetActive(true);
            curPlayer.SetActive(false);
            txtBoxScript.getScene("endCondition",0);
        }
        else if (visitedFoods[2] == 1 && gottenFoods[2]==true)
        {
            textBox.SetActive(true);
            talkImage.SetActive(true);
            backround.SetActive(true);
            curPlayer.SetActive(false);
            txtBoxScript.getScene("endCondition", 1);
        }
        else if (gottenFoods[4] == true || gottenFoods[0] == true && gottenFoods[2] == false && gottenFoods[1] == false)
        {
            textBox.SetActive(true);
            talkImage.SetActive(true);
            backround.SetActive(true);
            curPlayer.SetActive(false);
            txtBoxScript.getScene("endCondition", 2);
        }
        else if ((gottenFoods[0] == true && visitedFoods[2] == 1 && gottenFoods[2]==true && gottenFoods[1] == true) || (gottenFoods[1] == true && gottenFoods[4] == true && gottenFoods[0] == true))
        {
            textBox.SetActive(true);
            talkImage.SetActive(true);
            backround.SetActive(true);
            curPlayer.SetActive(false);
            txtBoxScript.getScene("endCondition", 3);
        }
        else if (gottenFoods[1] == true && gottenFoods[4] == false && gottenFoods[0] == false)
        {
            textBox.SetActive(true);
            talkImage.SetActive(true);
            backround.SetActive(true);
            curPlayer.SetActive(false);
            txtBoxScript.getScene("endCondition", 4);
        }
        else if (gottenFoods[1] == true && gottenFoods[4] == true && gottenFoods[0] == true && gottenFoods[3] == true)
        {
            textBox.SetActive(true);
            talkImage.SetActive(true);
            backround.SetActive(true);
            curPlayer.SetActive(false);
            txtBoxScript.getScene("endCondition", 5);
        }
        else if (gottenFoods[1] != true && gottenFoods[4] != true && gottenFoods[0] != true)
        {
            textBox.SetActive(true);
            talkImage.SetActive(true);
            backround.SetActive(true);
            curPlayer.SetActive(false);
            txtBoxScript.getScene("endCondition", 6);
        }
    }
}