using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {

	public Transform seconds, 
		minutes, 
		hours;

	float secondDegrees, 
		minuteDegrees, 
		hourDegrees;

	// Use this for initialization
	void Start ()
	{
		secondDegrees = 360f / 60;
		minuteDegrees = secondDegrees / 60f;
		hourDegrees = minuteDegrees / 60;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
