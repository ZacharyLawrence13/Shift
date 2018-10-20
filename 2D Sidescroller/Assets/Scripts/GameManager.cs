using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject world1;
    public GameObject world2;

    public GameObject player;

    Vector2 playerStartingPosition = new Vector2(-30, 16);

    public int worldCounter = 0;

	void Start () {
        world2.SetActive(false);
	}
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.LeftShift))    // When left shift is pressed
        {
            worldCounter++;
            if(worldCounter % 2 == 0)
            {
                world1.SetActive(true);
                world2.SetActive(false);
            }
            else
            {
                world2.SetActive(true);
                world1.SetActive(false);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            player.transform.position = playerStartingPosition;
        }

    }

    public void ResetCharacterPosition()
    {

    }

}