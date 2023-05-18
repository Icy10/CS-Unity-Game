using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float walkSpeed = 40f;

    [SerializeField]
    GameObject enemyObject;

    float speedLimiter = 0.7f;
    float inputHorizontal;
    float inputVertical;

    void Start()
    {
         rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        //Spawn an Ememy when I press space
        if (Input.GetKeyDown("e"))
        {
            Instantiate(enemyObject, new Vector3(0f, 0f, 0f), Quaternion.identity);
        }
    }
    private void FixedUpdate()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
        if (inputHorizontal != 0 || inputVertical != 0)
        {
            if (inputHorizontal != 0 && inputVertical != 0)
            {
                inputHorizontal *= speedLimiter;
                inputVertical *= speedLimiter;
            }
            rb.velocity = new Vector2(inputHorizontal * walkSpeed, inputVertical * walkSpeed);
            transform.up = rb.velocity.normalized;
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }


}