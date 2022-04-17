using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //starting time = bang
    float startingTime = 0;
    float pressedTime = 0;
    float speed = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shooting();
        
    }

    public void Shooting()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Shooted");
            pressedTime = Time.time;
            ShootTime();
        }
    }

    public void ShootTime()
    {
        speed = pressedTime - startingTime;
        Debug.Log(speed);
    }

    
}
