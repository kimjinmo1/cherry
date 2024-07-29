using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer renderer;
    public float moveSpeed;
    //float right = 5.0f;
    //float left = -7.0f;
    float y = -1.4f;
    
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }


    void Update()//³«»ç¹æÁö
    {

        if(transform.position.x > 8.3)
        {
            renderer.flipX = true;
            transform.position = new Vector3(0 , y  , 0); 
        }

        if (transform.position.x < -8.3)
        {
            renderer.flipX = false;
            transform.position = new Vector3(0, y , 0); 
        }



            Move();//ÁÂ¿ìÀüÈ¯
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
