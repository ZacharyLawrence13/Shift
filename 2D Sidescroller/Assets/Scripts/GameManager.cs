using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject[] worldList[];

    private int currentWorldIndex

	void Start () {
        currentWorldIndex = 0;
        for (int i = 1; i < )
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftShift))    // When left shift is pressed
        {
            Debug.Log("Left Shift Pressed");
            if (World1.activeSelf == true)  // if world 1 is active
            {
                Debug.Log("World1 is active");
                World1.SetActive(false);    // set world 1 to false
                Debug.Log("World1 is set as false");
                World2.SetActive(true);     // set world 2 to true
                Debug.Log("World2 is set as true");
                world1JustActivated = false;
            }
            
            if (World2.activeSelf == true)
            {
                Debug.Log("World2 is active");
                World2.SetActive(false);
                Debug.Log("World2 is set as false");
                World1.SetActive(true);
                Debug.Log("World1 is set as true");
                return;
            }
        }
    }
}