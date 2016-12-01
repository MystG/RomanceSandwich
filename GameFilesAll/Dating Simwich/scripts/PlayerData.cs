using UnityEngine;
using System;

public class PlayerData : MonoBehaviour
{
    public float speed = .0f;
    private Vector3 velocity;
    private Rigidbody2D PlayerObj;
    private Vector3 move;
    // Use this for initialization
    void Start()
    {
        velocity = Vector3.zero;
        move = Vector3.zero;
        PlayerObj = GetComponent<Rigidbody2D>();
        speed = 1.8f;
    }

// Update is called once per frame
    void Update()
    {
        Control();
    }

    void Control()
    {
        float xChange = .0f;
        float yChange = .0f;
        if (Input.GetKeyUp(KeyCode.LeftShift))
            speed = 1.8f;
        if (Input.GetKeyDown(KeyCode.LeftShift))
            speed = 4f;
        Vector3 change = transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            xChange -= speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            yChange += speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            yChange -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            xChange += speed;
        }
        if (xChange != 0 && yChange != 0)
        {
            xChange /= 1.5f;
            yChange /= 1.5f;
        }
        change.x += xChange;
        change.y += yChange;
        move = change - transform.position;
        velocity = move.normalized * speed;
    }

    void FixedUpdate()
    {
        PlayerObj.velocity = velocity;
    }
}