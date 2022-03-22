using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider2 : MonoBehaviour
{
    public GameObject MovementController;
    public GameObject player;
    public int testint = 7;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(player.transform.position.x > testint)
        {
            MovementController.SetActive(false);
        }
    }

    public void Exit()
    {
        MovementController.SetActive(true);
        testint += 1;
        print("sasaf");
    }


}
