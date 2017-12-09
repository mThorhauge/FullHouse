using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LeaderboardScript : MonoBehaviour {
    
	//Character customization states
	public GameObject Hair;
    public GameObject HairLong;
    public GameObject Face;
    private Animator hairAnim;
    private Animator hairLongAnim;
    private Animator faceAnim;
    private Renderer hairIsLong;

	public UnityEngine.UI.Text townNameDisplay;
	public UnityEngine.UI.Text prestigeDisplay;
	public UnityEngine.UI.Text favouriteBuildingDisplay;

	public string favouriteBuilding;

    // Use this for initialization
    void Start () {
        hairAnim = Hair.GetComponent<Animator>();
        hairLongAnim = HairLong.GetComponent<Animator>();
        faceAnim = Face.GetComponent<Animator>();
        hairIsLong = HairLong.GetComponent<Renderer>();

        hairAnim.SetInteger("HairColour", gameStates.HairColor); // pop up hair colour 1
        hairAnim.SetBool("HairShort", gameStates.HairShort); // pop up hair shape 2
        hairLongAnim.SetInteger("hairColourBot", gameStates.HairColor); // pop up long hair bottom colour 3
        faceAnim.SetInteger("FaceShape", gameStates.FaceShape); // pop up face shape 5
        faceAnim.SetInteger("SkinColour", gameStates.SkinColor); // pop up hair skin colour 4

        if (gameStates.HairShort == false)
        {
            hairIsLong.enabled = true;
        }
        if (gameStates.HairShort == true)
        {
            hairIsLong.enabled = false;
        }


    }
	
	// Update is called once per frame
	void Update () {

		var buildingList = new List<int> {gameStates.ApothecaryLvl, gameStates.BlacksmithLvl, gameStates.TavernLvl, gameStates.StableLvl, gameStates.FortuneTellerLvl, gameStates.WizardsTowerLvl, gameStates.GeneralStoreLvl, gameStates.TradingPostLvl, gameStates.TailorLvl, gameStates.GuardPostLvl};
		var buildingNameList = new List<string> {"Apothecary", "Blacksmith", "Tavern", "Stable", "Fortune Teller", "Wizard's Tower", "General Store", "Trading Post", "Tailor", "Guard Post"};

		var max = buildingList[0];
		for (int i = 1; i < 10; i++) {
			if (buildingList[i] > max) {
				max = buildingList[i];
				favouriteBuilding = buildingNameList[i];
			}
		}

		townNameDisplay.text = gameStates.TownName;
		prestigeDisplay.text = ""+ gameStates.PrestigeLvl;
		favouriteBuildingDisplay.text = favouriteBuilding + "("+ max +")";
    }

    public void toTownClicked()
    {
        SceneManager.LoadScene("Town", LoadSceneMode.Single);
    }

}
