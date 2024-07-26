using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherry : MonoBehaviour
{
    SpriteRenderer renderer;

    int score = 1;
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();

        float x = Random.Range(-7.0f, 7.0f);
        float y = Random.Range(4.0f, 5.0f);

        transform.position = new Vector3(x, y, 0);

        int type = Random.Range(1, 5);

        if (type == 1)
        {
            score = 3;

        }
        else if (type == 2)
        {
            score = 5;
            renderer.color = Color.green;
        }
        else if (type == 3)
        {
            score = -10;    
            renderer.color = Color.blue;
        }

        if (type == 4)
        {
            score = 3;
            renderer.color = Color.red;
        }

    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
