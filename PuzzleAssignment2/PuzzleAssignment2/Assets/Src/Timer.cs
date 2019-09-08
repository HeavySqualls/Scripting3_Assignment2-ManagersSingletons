using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    static Timer instance;

    public Text timerText;

    private float startTime;
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
            float t = Time.time - startTime;

            minutes = ((int)t / 60).ToString();
            seconds = (t % 60).ToString("f2");
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

    public void DisplayTime()
    {
        timerText.text = minutes + ":" + seconds;
    }
}
