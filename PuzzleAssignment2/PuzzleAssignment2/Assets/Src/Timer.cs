using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    static Timer instance;

    public Text timerText;

    private float startTime;
    private float currentTime;
    private bool trackTime = false;

    public string minutes;
    public string seconds;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        TrackTime();
    }

    private void TrackTime()
    {
        if (!trackTime)
        {
            return;
        }
        else
        {
            currentTime = Time.time - startTime;

            minutes = ((int)currentTime / 60).ToString();
            seconds = (currentTime % 60).ToString("f2");
        }
    }

    public void StartTimer()
    {
        trackTime = true;
    }

    public void StopTimer()
    {
        trackTime = false;
    }

    public void ResetTimer()
    {
        currentTime = startTime; 
    }
}
