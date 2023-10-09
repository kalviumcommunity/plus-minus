using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {
        isRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isRunning) {
            elapsedTime = isCountdown ? elapsedTime -= Time.deltaTime : elapsedTime += Time.deltaTime;
        }
        
        timerText.text = elapsedTime.ToString("0");
        shadowText.text = elapsedTime.ToString("0");
    }
}
