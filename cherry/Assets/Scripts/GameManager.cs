using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Cherry;
    void Start()
    {
        InvokeRepeating("MakeCherry", 2f, 0.5f);
        
    }

   
    void Update()
    {
        
    }

    void MakeCherry()
    {
        Instantiate(Cherry);
    }
}
