using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public interface ITimer
{
    void StartStop();
    void Reset();
    float GetElapsedTime();
}

public class Inheritance {
    public void PrintInheritance() {
        Debug.Log("This function is inherited from another class.");
    }
}


public class Timer : MonoBehaviour, ITimer
{
    [Header("Component")]
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI shadowText;

    // [Header("Timer settings")]
    private float elapsedTime;
    private bool isRunning;
    private float startTime;
    private bool isCountdown;

    public Timer() {
        elapsedTime = 0;
        isRunning = false;
        Debug.Log("Constructor function called");
    }

    // public Timer(float elapsedTime, float startTime, bool isCountdown) {
    //     this.elapsedTime = elapsedTime;
    //     this.startTime = startTime;
    //     this.isCountdown = isCountdown;
    // }

    // ~Timer() {
    //     isRunning = false;
    //     Debug.Log("Timer Destructed");
    // }

    public void StartStop() {
        isRunning = !isRunning;
    }
    public void Reset() {
        elapsedTime = 0;
    }

    public float GetElapsedTime() {
        return elapsedTime;
    }


    // Start is called before the first frame update
    void Start()
    {
        isRunning = true;
        Inheritance test = new Inheritance();
        test.PrintInheritance();
    }

    // Update is called once per frame
    void Update()
    {
        if(isRunning) {
            elapsedTime = isCountdown ? elapsedTime -= Time.deltaTime : elapsedTime += Time.deltaTime;
        }
        
        timerText.text = elapsedTime.ToString("0");
        shadowText.text = elapsedTime.ToString("0");

        if (Input.GetKeyDown("space"))
        {
            Debug.Log(GetElapsedTime());
        }
    }
}
