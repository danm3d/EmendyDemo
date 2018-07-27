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

	public AudioSource tickSource;
	public AudioClip clip;

	void Start()
	{
		InvokeRepeating("PlayTickSound", 1f, 1f);
	}


	void Update()
	{
		hours.rotation = Quaternion.Euler(0f, 0f, DateTime.Now.Hour * degreesPerHour);
		minutes.rotation = Quaternion.Euler(0f, 0f, DateTime.Now.Minute * degreesperMinute);
		seconds.rotation = Quaternion.Euler(0f, 0f, DateTime.Now.Second * degreesPerSecond);
	}

	public void PlayTickSound()
	{
		tickSource.PlayOneShot(clip);
	}
}
