using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrestigeScript : MonoBehaviour {

    public UnityEngine.UI.Text prestigeDisplay;

    public int prestigeLevel;
    int currentBits;
    int totalBuildingLevels;

	// Use this for initialization
	void Start () {
        prestigeLevel = gameStates.PrestigeLvl;
        currentBits = gameStates.Bits;
	}
	
	// Update is called once per frame
	void Update () {
        //display the current prestige level as number of bitizens
        prestigeDisplay.text = gameStates.PrestigeLvl + " Bitizens";
	}

    public void prestigeClicked()
    {
        if (currentBits >= 10) //low for testing purposes
        {
            //add all the building levels together
            totalBuildingLevels = gameStates.ApothecaryLvl + gameStates.BlacksmithLvl + gameStates.TavernLvl + gameStates.FortuneTellerLvl;

            prestigeLevel += (totalBuildingLevels + currentBits) / 10;//added prestige is a percentage of building levels and bits
           
            //need to reset bits and building levels
            currentBits = 0;
            gameStates.Bits = 0;
            gameStates.PrestigeLvl = prestigeLevel;

            gameStates.ApothecaryLvl = 1;
            gameStates.BlacksmithLvl = 1;
            gameStates.TavernLvl = 1;
            gameStates.FortuneTellerLvl = 1;

        }
    }
}
