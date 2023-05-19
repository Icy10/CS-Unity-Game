using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        if (Input.GetMouseButtonDown(0))
        {
            GameObject temp = Instantiate(bullet, this.gameObject.transform.position, Quaternion.identity);
            Physics2D.IgnoreCollision(temp.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
            Vector3 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            temp.GetComponent<Rigidbody2D>().velocity =  new Vector2(direction.x, direction.y).normalized * bulletSpeed;


            Vector3 rotation = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
            temp.transform.eulerAngles = new Vector3(0,0,rotZ);
        }
    }
}