using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitializationScript : MonoBehaviour {

	// Use this for initialization
	void Start () {


        ////Set the gameStates to proper values
        /// will need to use save file data in future
        gameStates.Kills = 0;
        gameStates.Bits = 0;
        gameStates.Chunks = 0;
        gameStates.MonsterDrops = 0;
        gameStates.CHealth = 5;
        gameStates.FHealth = 5;

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)) {

            //set to dungeon for now as its the most finnished part of the game currently
            SceneManager.LoadScene("Prototype_Dungeon", LoadSceneMode.Single); 
            }
		
	}
}
