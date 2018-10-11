using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject world1;
    public GameObject world2;

    public int worldCounter = 2;

	void Start () {
        
	}
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.LeftShift))    // When left shift is pressed
        {
            worldCounter++;
            if(worldCounter % 2 == 0)
            {
                world1.SetActive(true);
            }
            else
            {
                world2.SetActive(true);
            }
        }
    }
}