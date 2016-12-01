using UnityEngine;
using System;

public class DetectScript : MonoBehaviour
{
    public Rigidbody2D detector;
    public Rigidbody2D ham;
    public Rigidbody2D lettuce;
    public Rigidbody2D cheese;
    public Rigidbody2D bun;
    public Rigidbody2D mayo;

    // Use this for initialization
    void Start()
    {
        detector = GetComponent<Rigidbody2D>();
        ham = GetComponent<Rigidbody2D>();
        lettuce = GetComponent<Rigidbody2D>();
        cheese = GetComponent<Rigidbody2D>();
        bun = GetComponent<Rigidbody2D>();
        mayo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ham")
        {
            print("potaat");
        }
    }
}