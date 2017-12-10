using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrestigeScript : MonoBehaviour {

    public UnityEngine.UI.Text prestigeDisplay;

    public int prestigeLevel;
    int currentBits;
    int totalBuildingLevels;

    public AudioClip prestigeSFX;

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
        totalBuildingLevels = (
            gameStates.ApothecaryLvl +
            gameStates.BlacksmithLvl +
            gameStates.TavernLvl +
            gameStates.StableLvl +
            gameStates.FortuneTellerLvl +
            gameStates.WizardsTowerLvl +
            gameStates.GeneralStoreLvl +
            gameStates.TradingPostLvl +
            gameStates.TailorLvl +
            gameStates.GuardPostLvl
            );

        if (totalBuildingLevels >= 5)
        {
            if (currentBits >= 10) //low for testing purposes
            {
                SoundManager.instance.PlayClip(prestigeSFX);

                //add all the building levels together
                prestigeLevel += (totalBuildingLevels + currentBits) / 10;//added prestige is a percentage of building levels and bits

                //reset bits and and save bits and prestige in the game states
                currentBits = 0;
                gameStates.Bits = 0;
                gameStates.PrestigeLvl = prestigeLevel;

                //reset building levels in the games states to level 1
                gameStates.ApothecaryLvl = 1;
                gameStates.BlacksmithLvl = 1;
                gameStates.TavernLvl = 1;
                gameStates.StableLvl = 1;
                gameStates.WizardsTowerLvl = 1;
                gameStates.FortuneTellerLvl = 1;
                gameStates.GeneralStoreLvl = 1;
                gameStates.TradingPostLvl = 1;
                gameStates.TailorLvl = 1;
                gameStates.GuardPostLvl = 1;

                //reset building cost
                gameStates.BlacksmithCost = 10;
                gameStates.TavernCost = 50;
                gameStates.ApothecaryCost = 200;
                gameStates.StableCost = 440;
                gameStates.WizardsTowerCost = 575;
                gameStates.FortuneTellerCost = 720;
                gameStates.GeneralStoreCost = 1400;
                gameStates.TradingPostCost = 2000;
                gameStates.TailorCost = 3600;
                gameStates.GuardPostCost = 5000;
            }
        }
    }
}
