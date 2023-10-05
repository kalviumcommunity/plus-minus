using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    private Player P1;

    // Start is called before the first frame update
    void Start()
    {
        P1 = new Player();  
        P1.name = "Test";
        P1.score = 100;
        P1.logPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
