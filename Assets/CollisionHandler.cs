using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.CompareTag("Enemy"))
        {
            Player.health--;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        //Debug.Log("Collision Stay");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        // Handle collision exit events here
        //Debug.Log("Collision Exit");
        Debug.Log(Player.health);
    }
}