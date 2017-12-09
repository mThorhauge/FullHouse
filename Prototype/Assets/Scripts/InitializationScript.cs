using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitializationScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("initialization script");

		//Adding a default town name

		gameStates.LastScene 			= 0;
		gameStates.TownName 			= "Bittania";
        
		////Set the gameStates to proper values
        /// will need to use save file data in future
        gameStates.Kills                = 0;
        gameStates.Bits                 = 0;
        gameStates.Chunks               = 0;
        gameStates.Chunks               = 0;
        gameStates.MonsterDrops         = 0;
        gameStates.MDropCount           = 0;
        gameStates.CHealth              = 5;
        gameStates.FHealth              = 5;

        gameStates.ApothecaryLvl        = 1;
        gameStates.BlacksmithLvl        = 1;
        gameStates.TavernLvl            = 1;
        gameStates.FortuneTellerLvl     = 1;
		gameStates.StableLvl 			= 1;
		gameStates.GeneralStoreLvl 		= 1;
		gameStates.TradingPostLvl	 	= 1;
		gameStates.TailorLvl 			= 1;
		gameStates.GuardPostLvl 		= 1;
		gameStates.WizardsTowerLvl 		= 1;

		//Set starting building costs
		//Values are set in time without upgrades to achieve
		gameStates.BlacksmithCost       = 10;
		gameStates.TavernCost           = 50;
		gameStates.ApothecaryCost       = 200;
		gameStates.FortuneTellerCost    = 720;

		//Set starting bonuses
		//Values are all set to 100% aka 1 at start
		gameStates.ClickDmg             = 2;
		gameStates.AutoPDmg             = 1;
		gameStates.AutoMDmg             = 1;
		gameStates.GoldIncrease         = 1;

        }
	
	// Update is called once per frame
	void Update () {

        /*if (Input.GetMouseButtonDown(0)) {

            //set to dungeon for now as its the most finnished part of the game currently
            SceneManager.LoadScene("Town", LoadSceneMode.Single); 
            }
        */
		
	}
}
