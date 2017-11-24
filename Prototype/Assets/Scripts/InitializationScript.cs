using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitializationScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("initialization script");

        ////Set the gameStates to proper values
        /// will need to use save file data in future
        gameStates.Kills = 0;
        gameStates.Bits = 0;
        gameStates.Chunks = 0;
        gameStates.MonsterDrops = 0;
        gameStates.CHealth = 5;
        gameStates.FHealth = 5;

        gameStates.ApothecaryLvl = 1;
        gameStates.BlacksmithLvl = 1;
        gameStates.TavernLvl = 1;
        gameStates.FortuneTellerLvl = 1;

		//Set starting building costs
		//Values are set in time without upgrades to achieve
		gameStates.BlacksmithCost = 60;
		gameStates.TavernCost = 180;
		gameStates.ApothecaryCost = 300;
		gameStates.FortuneTellerCost = 720;

        }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)) {

            //set to dungeon for now as its the most finnished part of the game currently
            SceneManager.LoadScene("Town", LoadSceneMode.Single); 
            }
		
	}
}
