using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeMovement : MonoBehaviour
{

    Rigidbody2D rb;
    float walkSpeed = 40f;
    [SerializeField]
    float speedLimiter = 0.7f;
    float inputHorizontal;
    float inputVertical;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

    }


    private void FixedUpdate()
    {
        if(inputHorizontal!=0||inputVertical != 0)
        {
            if(inputHorizontal!= 0 && inputVertical!= 0)
            {
                inputHorizontal *= speedLimiter;
                inputVertical *=speedLimiter;
            }


            rb.velocity = new Vector2(inputHorizontal *walkSpeed, inputVertical*walkSpeed);
        }
        else
        {
            rb.velocity = new Vector2(0f,0f);
        }
    }
}
