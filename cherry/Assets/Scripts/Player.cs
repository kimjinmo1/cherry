using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public SpriteRenderer renderer;
    public float moveSpeed;
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        Move();
        if(Input.GetKey(KeyCode.D))
        {
            renderer.flipX = false;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            renderer.flipX = true;
        }
        
    }

  
 
    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        Vector3 moveVelocity = new Vector3(x, 0, 0) * moveSpeed * Time.deltaTime;
        this.transform.position += moveVelocity;
    }
}
