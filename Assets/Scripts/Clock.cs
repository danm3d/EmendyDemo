using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
	public Transform seconds, minutes, hours;
	float degreesPerHour = 30f;

	// Use this for initialization
	void Start()
	{
		hours.rotation=Quaternion.Euler(0f, DateTime.Now.Hour*degreesPerHour, 0f);
		hours.rotation = Quaternion.Euler(0f, DateTime.Now.Hour * degreesPerHour, 0f);

	}

	// Update is called once per frame
	void Update()
	{

	}
}
