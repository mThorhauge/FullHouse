using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TownScript : MonoBehaviour {

    public UnityEngine.UI.Text bitsCountDisplay;
    public UnityEngine.UI.Text monsterDropCountDisplay;
	public UnityEngine.UI.Text chunkCountDisplay;
	public UnityEngine.UI.Text townNameDisplay;

    public UnityEngine.UI.Text apothecaryLevelDisplay;
    public UnityEngine.UI.Text blacksmithLevelDisplay;
    public UnityEngine.UI.Text tavernLevelDisplay;
    public UnityEngine.UI.Text fortuneTellerLevelDisplay;

	//information in the pop up window

	public UnityEngine.UI.Text buildingName;
	//public UnityEngine.UI.Text buildingLevel;
	public UnityEngine.UI.Text bitUpgradeText;
	public UnityEngine.UI.Text chunkUpgradeText;

	public int buildingNum = 0;

    public GameObject town;
	public GameObject blacksmithPopUp;


    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        bitsCountDisplay.text = ""+ gameStates.Bits;
        monsterDropCountDisplay.text = "" + gameStates.MonsterDrops;
		chunkCountDisplay.text = "" + gameStates.Chunks;
		townNameDisplay.text = (string)(gameStates.TownName);

		//Testing code
		//apothecaryLevelDisplay.text = "Level " + gameStates.ApothecaryLvl + " Upgrade Cost " + gameStates.ApothecaryCost;
		//blacksmithLevelDisplay.text = "Level " + gameStates.BlacksmithLvl+ " Upgrade Cost " + gameStates.BlacksmithCost;
		//tavernLevelDisplay.text = "Level " + gameStates.TavernLvl+ " Upgrade Cost " + gameStates.TavernCost;
		//fortuneTellerLevelDisplay.text = "Level " + gameStates.FortuneTellerLvl + " Upgrade Cost " + gameStates.FortuneTellerCost;

        if (Input.GetMouseButton(0)) {

            Vector3 screenPoint = Camera.main.WorldToScreenPoint(town.transform.position);
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
            Vector3 offset = town.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;


            town.transform.position = curPosition;

            }

	}

    public void toDungeonClick() {
       
		SceneManager.LoadScene("Dungeon", LoadSceneMode.Single);
    }

	public void toLeaderboardClick() {

		SceneManager.LoadScene("Leaderboard", LoadSceneMode.Single);
	}

	public void toStoreClick() {

		gameStates.LastScene = 1;
		SceneManager.LoadScene("Store", LoadSceneMode.Single);
	}

    public void toHomeClicked()
    {
    	SceneManager.LoadScene("Home", LoadSceneMode.Single);
    }

    public void upgradeBuildingClick(int buildingID) {

		//Switch between chosen building
        switch(buildingID) {
		case 1://blacksmith

			blacksmithPopUp.SetActive (true);
			buildingNum = 1;

			buildingName.text = "Blacksmith - Lvl " + gameStates.BlacksmithLvl;
			bitUpgradeText.text = "Upgrade with " + gameStates.BlacksmithCost + " Bits";
			chunkUpgradeText.text = "Upgrade with " + (int)(1+gameStates.BlacksmithCost / 600) + " Chunks";

			break;
		case 2://tavern

			blacksmithPopUp.SetActive (true);
			buildingNum = 2;

			buildingName.text = "Tavern - Lvl " + gameStates.TavernLvl;
			bitUpgradeText.text = "Upgrade with " + gameStates.TavernCost + " Bits";
			chunkUpgradeText.text = "Upgrade with " + (int)(1+gameStates.TavernCost / 600) + " Chunks";

            break;
        case 3://apothecary

			blacksmithPopUp.SetActive (true);
			buildingNum = 3;

			buildingName.text = "Apothecary - Lvl " + gameStates.ApothecaryLvl;
			bitUpgradeText.text = "Upgrade with " + gameStates.ApothecaryCost + " Bits";
			chunkUpgradeText.text = "Upgrade with " + (int)(1+gameStates.ApothecaryCost / 600) + " Chunks";

            break;
        case 4://stable

			blacksmithPopUp.SetActive (true);
			buildingNum = 4;

			buildingName.text = "Stable - Lvl " + gameStates.StableLvl;
			bitUpgradeText.text = "Upgrade with " + gameStates.StableCost + " Bits";
			chunkUpgradeText.text = "Upgrade with " + (int)(1+gameStates.StableCost / 600) + " Chunks";

            break;

        case 5://wizards tower

            blacksmithPopUp.SetActive(true);
            buildingNum = 5;

            buildingName.text = "Wizard's Tower - Lvl " + gameStates.WizardsTowerLvl;
            bitUpgradeText.text = "Upgrade with " + gameStates.WizardsTowerCost + " Bits";
            chunkUpgradeText.text = "Upgrade with " + (int)(1 + gameStates.WizardsTowerCost / 600) + " Chunks";

            break;
        case 6://fortune teller

            blacksmithPopUp.SetActive(true);
            buildingNum = 6;

            buildingName.text = "Fortune Teller - Lvl " + gameStates.FortuneTellerLvl;
            bitUpgradeText.text = "Upgrade with " + gameStates.FortuneTellerCost + " Bits";
            chunkUpgradeText.text = "Upgrade with " + (int)(1 + gameStates.FortuneTellerCost / 600) + " Chunks";

            break;

        case 7://general store

            blacksmithPopUp.SetActive(true);
            buildingNum = 3;

            buildingName.text = "General Store - Lvl " + gameStates.GeneralStoreLvl;
            bitUpgradeText.text = "Upgrade with " + gameStates.GeneralStoreCost + " Bits";
            chunkUpgradeText.text = "Upgrade with " + (int)(1 + gameStates.GeneralStoreCost / 600) + " Chunks";

            break;
        case 8://trading post

            blacksmithPopUp.SetActive(true);
            buildingNum = 4;

            buildingName.text = "Trading Post - Lvl " + gameStates.TradingPostLvl;
            bitUpgradeText.text = "Upgrade with " + gameStates.TradingPostCost + " Bits";
            chunkUpgradeText.text = "Upgrade with " + (int)(1 + gameStates.TradingPostCost / 600) + " Chunks";

            break;

        case 9://tailor

            blacksmithPopUp.SetActive(true);
            buildingNum = 5;

            buildingName.text = "Tailor - Lvl " + gameStates.TailorLvl;
            bitUpgradeText.text = "Upgrade with " + gameStates.TailorCost + " Bits";
            chunkUpgradeText.text = "Upgrade with " + (int)(1 + gameStates.TailorCost / 600) + " Chunks";

            break;
        case 10://guard post

            blacksmithPopUp.SetActive(true);
            buildingNum = 6;

            buildingName.text = "Guard Post - Lvl " + gameStates.GuardPostLvl;
            bitUpgradeText.text = "Upgrade with " + gameStates.GuardPostCost + " Bits";
            chunkUpgradeText.text = "Upgrade with " + (int)(1 + gameStates.GuardPostCost / 600) + " Chunks";

            break;

            default:
            break;
        }

    }

	public void upgradeWithBitsClick() {

		//Switch between chosen building
		switch(buildingNum) {
		case 1://blacksmith
            if (gameStates.Bits >= (gameStates.BlacksmithCost))
            {
                gameStates.BlacksmithLvl += 1;
                gameStates.Bits -= gameStates.BlacksmithCost;
                gameStates.BlacksmithCost *= (int)(Mathf.Pow(gameStates.BlacksmithLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
                break;
		case 2://tavern
            if (gameStates.Bits >= (gameStates.TavernCost))
            {
                gameStates.TavernLvl += 1;
                gameStates.Bits -= gameStates.TavernCost;
                gameStates.TavernCost *= (int)(Mathf.Pow(gameStates.TavernLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
                break;
		case 3://apothecary cost
            if (gameStates.Bits >= (gameStates.ApothecaryCost))
            {
                gameStates.ApothecaryLvl += 1;
                gameStates.Bits -= gameStates.ApothecaryCost;
                gameStates.ApothecaryCost *= (int)(Mathf.Pow(gameStates.ApothecaryLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
                break;
		case 4://stable
			if (gameStates.Bits >= (gameStates.StableCost)) {
				gameStates.StableLvl += 1;
				gameStates.Bits -= gameStates.StableCost;
				gameStates.StableCost *= (int)(Mathf.Pow(gameStates.StableLvl, 2));
				gameStates.ClickDmg += 1;
				blacksmithPopUp.SetActive (false);
			}
			break;
        case 5: //wizards tower
            if (gameStates.Bits >= (gameStates.WizardsTowerCost))
            {
                gameStates.WizardsTowerLvl += 1;
                gameStates.Bits -= gameStates.WizardsTowerCost;
                gameStates.WizardsTowerCost *= (int)(Mathf.Pow(gameStates.WizardsTowerLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
            break;
        case 6: //Fortune Teller
            if (gameStates.Bits >= (gameStates.FortuneTellerCost))
            {
                gameStates.FortuneTellerLvl += 1;
                gameStates.Bits -= gameStates.FortuneTellerCost;
                gameStates.FortuneTellerCost *= (int)(Mathf.Pow(gameStates.FortuneTellerLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
            break;
        case 7: //General store
            if (gameStates.Bits >= (gameStates.GeneralStoreCost))
            {
                gameStates.GeneralStoreLvl += 1;
                gameStates.Bits -= gameStates.GeneralStoreCost;
                gameStates.GeneralStoreCost *= (int)(Mathf.Pow(gameStates.GeneralStoreLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
            break;
        case 8: //trading post
            if (gameStates.Bits >= (gameStates.TradingPostCost))
            {
                gameStates.TradingPostLvl += 1;
                gameStates.Bits -= gameStates.TradingPostCost;
                gameStates.TradingPostCost *= (int)(Mathf.Pow(gameStates.TradingPostLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
            break;
        case 9: //Tailor
            if (gameStates.Bits >= (gameStates.TailorCost))
            {
                gameStates.TailorLvl += 1;
                gameStates.Bits -= gameStates.TailorCost;
                gameStates.TailorCost *= (int)(Mathf.Pow(gameStates.TailorLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
            break;
        case 10: //guard post
            if (gameStates.Bits >= (gameStates.GuardPostCost))
            {
                gameStates.GuardPostLvl += 1;
                gameStates.Bits -= gameStates.GuardPostCost;
                gameStates.GuardPostCost *= (int)(Mathf.Pow(gameStates.GuardPostLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
            break;

            default:
			break;
		}
	}

	public void upgradeWithChunksClick() {

		//Switch between chosen building
		switch(buildingNum) {
		case 1://blacksmith
            if (gameStates.Chunks >= (int)(1 + gameStates.BlacksmithCost / 600))
            {
                gameStates.BlacksmithLvl += 1;
                gameStates.Chunks -= (int)(1 + gameStates.BlacksmithCost / 600);
                gameStates.BlacksmithCost *= (int)(Mathf.Pow(gameStates.BlacksmithLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
            break;
		case 2://tavern
            if (gameStates.Chunks >= (int)(1 + gameStates.TavernCost / 600))
            {
                gameStates.TavernLvl += 1;
                gameStates.Chunks -= (int)(1 + gameStates.TavernCost / 600);
                gameStates.TavernCost *= (int)(Mathf.Pow(gameStates.TavernLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
            break;
		case 3://apothecary
            if (gameStates.Chunks >= (int)(1 + gameStates.ApothecaryCost / 600))
            {
                gameStates.ApothecaryLvl += 1;
                gameStates.Chunks -= (int)(1 + gameStates.ApothecaryCost / 600);
                gameStates.ApothecaryCost *= (int)(Mathf.Pow(gameStates.ApothecaryLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
            break;
        case 4://stable
			if (gameStates.Chunks >= (int)(1+gameStates.StableCost/600)) {
				gameStates.StableLvl += 1;
				gameStates.Chunks -= (int)(1+gameStates.StableCost / 600);
				gameStates.StableCost *= (int)(Mathf.Pow(gameStates.StableLvl, 2));
				gameStates.ClickDmg += 1;
				blacksmithPopUp.SetActive (false);
			}
			break;
        case 5://wizards tower
            if (gameStates.Chunks >= (int)(1 + gameStates.WizardsTowerCost / 600))
            {
                gameStates.WizardsTowerLvl += 1;
                gameStates.Chunks -= (int)(1 + gameStates.WizardsTowerCost / 600);
                gameStates.WizardsTowerCost *= (int)(Mathf.Pow(gameStates.WizardsTowerLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
            break;
        case 6://fortune teller
            if (gameStates.Chunks >= (int)(1 + gameStates.FortuneTellerCost / 600))
            {
                gameStates.FortuneTellerLvl += 1;
                gameStates.Chunks -= (int)(1 + gameStates.FortuneTellerCost / 600);
                gameStates.FortuneTellerCost *= (int)(Mathf.Pow(gameStates.FortuneTellerLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
            break;
        case 7://general store
            if (gameStates.Chunks >= (int)(1 + gameStates.GeneralStoreCost / 600))
            {
                gameStates.GeneralStoreLvl += 1;
                gameStates.Chunks -= (int)(1 + gameStates.GeneralStoreCost / 600);
                gameStates.GeneralStoreCost *= (int)(Mathf.Pow(gameStates.GeneralStoreLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
            break;
        case 8://trading post
            if (gameStates.Chunks >= (int)(1 + gameStates.TradingPostCost / 600))
            {
                gameStates.TradingPostLvl += 1;
                gameStates.Chunks -= (int)(1 + gameStates.TradingPostCost / 600);
                gameStates.TradingPostCost *= (int)(Mathf.Pow(gameStates.TradingPostLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
            break;
        case 9://tailor
            if (gameStates.Chunks >= (int)(1 + gameStates.TailorCost / 600))
            {
                gameStates.TailorLvl += 1;
                gameStates.Chunks -= (int)(1 + gameStates.TailorCost / 600);
                gameStates.TailorCost *= (int)(Mathf.Pow(gameStates.TailorLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
            break;
        case 10://guard post
            if (gameStates.Chunks >= (int)(1 + gameStates.GuardPostCost / 600))
            {
                gameStates.GuardPostLvl += 1;
                gameStates.Chunks -= (int)(1 + gameStates.GuardPostCost / 600);
                gameStates.GuardPostCost *= (int)(Mathf.Pow(gameStates.GuardPostLvl, 2));
                gameStates.ClickDmg += 1;
                blacksmithPopUp.SetActive(false);
            }
            break;

            default:
			break;
		}
	}

	public void closePopUp(){
		blacksmithPopUp.SetActive (false);
	}

   

}
