using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
	public Transform seconds, minutes, hours;
	float degreesPerHour = 30f;
    float degreesperMinute = 6f;
    float degreesPerSecond = 6f;


	void Start()
	{
      
    }

	
	void Update()
	{
        hours.rotation = Quaternion.Euler(0f, DateTime.Now.Hour * degreesPerHour, 0f);
        minutes.rotation = Quaternion.Euler(0f, DateTime.Now.Minute * degreesperMinute, 0f);
        seconds.rotation = Quaternion.Euler(0f, DateTime.Now.Second * degreesPerSecond, 0f);

    }
}
