using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float totalSeconds = 0;
    float elaspsedSeconds = 0;
    bool started = false;
    bool running = false;

    public float Duration
    {
        set
        {
            if (!running)
            {
                totalSeconds = value;
            }
        }
    }

    public bool Finished
    {
        get { return started && !running; }
    }

    public bool Running
    {
        get
        {
            return running;
        }
    }
    public void Run()
    {
        if (totalSeconds > 0)
        {
            started = true;
            running = true;
            elaspsedSeconds = 0;

        }
    }

    // Start is called before the first frame update
    void Start()
    {
       // print("timer start");
        
    }

    // Update is called once per frame
    void Update()
    {
       // print("timer update call");
        if (running)
        {
            elaspsedSeconds += Time.deltaTime;
            if (elaspsedSeconds >= totalSeconds)
            {
                running = false;

            }
        }
        
    }
}
