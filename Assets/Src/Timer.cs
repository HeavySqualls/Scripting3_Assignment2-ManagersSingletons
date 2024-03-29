﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float startTime;
    private float currentTime;
    private bool trackTime = false;

    public string minutes;
    public string seconds;

    void Update()
    {
        TrackTime();
    }

    private void TrackTime()
    {
        if (trackTime)
        {
            currentTime = Time.time - startTime;

            minutes = ((int)currentTime / 60).ToString();
            seconds = (currentTime % 60).ToString("f2");
        }
    }

    public void StartTimer()
    {
        startTime = Time.time;
        trackTime = true;
    }

    public void StopTimer()
    {
        trackTime = false;
    }

    public void ResetTimer()
    {
        minutes = "0";
        seconds = "0";
    }
}
