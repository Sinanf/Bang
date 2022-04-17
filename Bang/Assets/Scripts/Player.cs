using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    //starting time = bang
    
    float pressedTime = 0;
    float speed = 0;

    public TMP_Text speedText;

    public CountdownController countdownController;    


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
        float bangTime = countdownController.bangTime;
        speed = Mathf.Round((pressedTime - bangTime) * 100f) *0.01f;        
        Debug.Log(speed);
        speedText.text = "Speed: " + speed.ToString();
    }

    
}
