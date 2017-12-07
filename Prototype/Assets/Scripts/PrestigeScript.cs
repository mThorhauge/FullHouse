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
        prestigeDisplay.text = gameStates.PrestigeLvl + " Bitizens";
	}

    public void prestigeClicked()
    {
        if (currentBits >= 10) //low for testing purposes
        {
            totalBuildingLevels = gameStates.ApothecaryLvl + gameStates.BlacksmithLvl + gameStates.TavernLvl + gameStates.FortuneTellerLvl;

            prestigeLevel += (totalBuildingLevels + currentBits) / 4;
            //need to reset bits and building levels
            currentBits = 0;
            gameStates.Bits = 0;
            gameStates.PrestigeLvl = prestigeLevel;

        }
    }
}
