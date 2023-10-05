using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string name;
    public int score;

    public void logPlayer() {
        Debug.Log("Player name: " + name);
        Debug.Log("Player score: " + score);
    }
}
