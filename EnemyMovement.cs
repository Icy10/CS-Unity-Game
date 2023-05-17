using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    float enemySpeed;

    float speedLimiter = 0.7f;



    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Player").transform.position, enemySpeed*Time.deltaTime);

    }


    private void FixedUpdate()
    {

    }
}