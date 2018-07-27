using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    
    
        public Transform seconds, minutes, hours;

        public bool continuous;

        float degreesPerHour = 30f;
        float degreesperMinute = 6f;
        float degreesPerSecond = 6f;

    

    private void Update()
    {
        if (continuous)
        {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscrete();
        }
    }

   


    void UpdateContinuous()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;

        hours.rotation = Quaternion.Euler(0f, 0f, (float)time.TotalHours * degreesPerHour);
        minutes.rotation = Quaternion.Euler(0f, 0f, (float)time.TotalMinutes * degreesperMinute);
        seconds.rotation = Quaternion.Euler(0f, 0f, (float)time.TotalSeconds * degreesPerSecond);

    }

   

    void UpdateDiscrete()
    {
        hours.rotation = Quaternion.Euler(0f, 0f, DateTime.Now.Hour * degreesPerHour);
        minutes.rotation = Quaternion.Euler(0f, 0f, DateTime.Now.Minute * degreesperMinute);
        seconds.rotation = Quaternion.Euler(0f, 0f, DateTime.Now.Second * degreesPerSecond);
        
    }
}

