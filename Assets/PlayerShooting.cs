using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

    [SerializeField]
    int bulletSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject temp = Instantiate(bullet,this.gameObject.transform.position, Quaternion.identity);
            Physics2D.IgnoreCollision(temp.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
            Vector2 direction = transform.up;
            temp.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
        }
    }
}

