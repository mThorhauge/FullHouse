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
	public UnityEngine.UI.Text buildingDescription;
	public UnityEngine.UI.Text bitUpgradeText;
	public UnityEngine.UI.Text chunkUpgradeText;

	public int buildingNum = 0;

	public GameObject town;
	public GameObject blacksmithPopUp;
    public GameObject characterPopUp;

    public Sprite smith;
    public Sprite tavern;
    public Sprite apothecary;
    public Sprite stable;
    public Sprite wizard;
    public Sprite fortuneTeller;
    public Sprite generalStore;
    public Sprite tradingPost;
    public Sprite tailor;
    public Sprite guard;

    int blacksmithCostI;
    int tavernCostI;
    int apothecaryCostI;
    int stableCostI;
    int wizardsTowerCostI;
    int fortuneTellerCostI;
    int generalStoreCostI;
    int tradingPostCostI;
    int tailorCostI;
    int guardPostCostI;

    public AudioClip upgradeBitsSFX;
    public AudioClip upgradeChunksSFX;
    public AudioClip sceneChange;

	// Use this for initialization
	void Start () {
        SoundManager.instance.PlayClip(sceneChange);

        //setting the initial building costs
        // not sure why stable and wizard tower arent being initialised from game states
        //but it works if i put them here - AD
        gameStates.StableCost = 440;
        gameStates.WizardsTowerCost = 575;

        blacksmithCostI = gameStates.BlacksmithCost;
        tavernCostI = gameStates.TavernCost;
        apothecaryCostI = gameStates.ApothecaryCost;
        stableCostI = gameStates.StableCost;
        wizardsTowerCostI = gameStates.WizardsTowerCost;
        fortuneTellerCostI = gameStates.FortuneTellerCost;
        generalStoreCostI = gameStates.GeneralStoreCost;
        tradingPostCostI = gameStates.TradingPostCost;
        tailorCostI = gameStates.TailorCost;
        guardPostCostI = gameStates.GuardPostCost;
    }

	// Update is called once per frame
	void Update () {

		bitsCountDisplay.text = ""+ gameStates.Bits;
		monsterDropCountDisplay.text = "" + gameStates.MonsterDrops;
		chunkCountDisplay.text = "" + gameStates.Chunks;
		//townNameDisplay.text = (string)(gameStates.TownName);

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
        SoundManager.instance.PlayClip(sceneChange);
		//Switch between chosen building
		switch(buildingID) {
		case 1://blacksmith

			blacksmithPopUp.SetActive (true);
			buildingNum = 1;
            characterPopUp.GetComponent<Image>().sprite = smith;

			buildingName.text = "Blacksmith - Lvl " + gameStates.BlacksmithLvl;
			buildingDescription.text = "I can improve your weapons, and teach you a few new tricks. (increaes your click damage)";
			bitUpgradeText.text = "Upgrade with " + gameStates.BlacksmithCost + " Bits";
			chunkUpgradeText.text = "Upgrade with " + (int)(1+gameStates.BlacksmithCost / 600) + " Chunks";

			break;
		case 2://tavern

			blacksmithPopUp.SetActive (true);
			buildingNum = 2;
            characterPopUp.GetComponent<Image>().sprite = tavern;

			buildingName.text = "Tavern - Lvl " + gameStates.TavernLvl;
			buildingDescription.text = "Sit down, you never know what kind of adventurers you'll meet here. (increases your auto damage)";
			bitUpgradeText.text = "Upgrade with " + gameStates.TavernCost + " Bits";
			chunkUpgradeText.text = "Upgrade with " + (int)(1+gameStates.TavernCost / 600) + " Chunks";

			break;
		case 3://apothecary

			blacksmithPopUp.SetActive (true);
            buildingNum = 3;
            characterPopUp.GetComponent<Image>().sprite = apothecary;

			buildingName.text = "Apothecary - Lvl " + gameStates.ApothecaryLvl;
			buildingDescription.text = "Try one of my potions, you'll gain some extraordinary strength, mostly guaranteed. (increases click damage)";
			bitUpgradeText.text = "Upgrade with " + gameStates.ApothecaryCost + " Bits";
			chunkUpgradeText.text = "Upgrade with " + (int)(1+gameStates.ApothecaryCost / 600) + " Chunks";

			break;
		case 4://stable

			blacksmithPopUp.SetActive (true);
            buildingNum = 4;
            characterPopUp.GetComponent<Image>().sprite = stable;
            
			buildingName.text = "Stable - Lvl " + gameStates.StableLvl;
			buildingDescription.text = "I buy horses. Large? Small? Strange? Regular? I bought every horse I've ever seen. easy way to earn 'fast bits'. (increases  physical auto damage)";
            bitUpgradeText.text = "Upgrade with " + gameStates.StableCost + " Bits";
			chunkUpgradeText.text = "Upgrade with " + (int)(1+ gameStates.StableCost / 600) + " Chunks";

			break;

		case 5://wizards tower

			blacksmithPopUp.SetActive(true);
            buildingNum = 5;
            characterPopUp.GetComponent<Image>().sprite =  wizard;

			buildingName.text = "Wizard's Tower - Lvl " + gameStates.WizardsTowerLvl;
			buildingDescription.text = "I can teach your companions the path of magic. (increase magic auto damage).";
			bitUpgradeText.text = "Upgrade with " + gameStates.WizardsTowerCost + " Bits";
			chunkUpgradeText.text = "Upgrade with " + (int)(1 + gameStates.WizardsTowerCost / 600) + " Chunks";

			break;
		case 6://fortune teller

			blacksmithPopUp.SetActive(true);
            buildingNum = 6;
            characterPopUp.GetComponent<Image>().sprite = fortuneTeller;

			buildingName.text = "Fortune Teller - Lvl " + gameStates.FortuneTellerLvl;
			buildingDescription.text = "I can see in the heart of the cards, many bits await you. (increases bit drop rate)";
			bitUpgradeText.text = "Upgrade with " + gameStates.FortuneTellerCost + " Bits";
			chunkUpgradeText.text = "Upgrade with " + (int)(1 + gameStates.FortuneTellerCost / 600) + " Chunks";

			break;

		case 7://general store

			blacksmithPopUp.SetActive(true);
            buildingNum = 7;
            characterPopUp.GetComponent<Image>().sprite = generalStore;

			if (gameStates.PrestigeLvl > 0)
			{
				bitUpgradeText.text = "Upgrade with " + gameStates.GeneralStoreCost + " Bits";
				chunkUpgradeText.text = "Upgrade with " + (int)(1 + gameStates.GeneralStoreCost / 600) + " Chunks";
				buildingDescription.text = "Hello! I can help you increase your damage with my amazing wares!";
			}
			else
			{
				bitUpgradeText.text = "Prestige to Unlock!";
				chunkUpgradeText.text = "Prestige to Unlock!";
				buildingDescription.text = "If you gain some supporters by gaining some prestige, I can help you increase your damage";
			}

			buildingName.text = "General Store - Lvl " + gameStates.GeneralStoreLvl;

			break;
		case 8://trading post

			blacksmithPopUp.SetActive(true);
            buildingNum = 8;
            characterPopUp.GetComponent<Image>().sprite = tradingPost;

			buildingName.text = "Trading Post - Lvl " + gameStates.TradingPostLvl;
			if (gameStates.PrestigeLvl > 0)
			{
				bitUpgradeText.text = "Upgrade with " + gameStates.TradingPostCost + " Bits";
				chunkUpgradeText.text = "Upgrade with " + (int)(1 + gameStates.TradingPostCost / 600) + " Chunks";
				buildingDescription.text = "Let me show you how to get more bits out of monsters.";
			}
			else
			{
				bitUpgradeText.text = "Prestige to Unlock!";
				chunkUpgradeText.text = "Prestige to Unlock!";
				buildingDescription.text = "If you gain some prestige, I'd be willing to show you how to make more bits.";
			}

			break;

		case 9://tailor

			blacksmithPopUp.SetActive(true);
            buildingNum = 9;
            characterPopUp.GetComponent<Image>().sprite = tailor;

			buildingName.text = "Tailor - Lvl " + gameStates.TailorLvl;
			if (gameStates.PrestigeLvl > 0)
			{
				bitUpgradeText.text = "Upgrade with " + gameStates.TailorCost + " Bits";
				chunkUpgradeText.text = "Upgrade with " + (int)(1 + gameStates.TailorCost / 600) + " Chunks";
				buildingDescription.text = "Super chic. I can help improve your clothes to increase your damage.";
			}
			else
			{
				bitUpgradeText.text = "Prestige to Unlock!";
				chunkUpgradeText.text = "Prestige to Unlock!";
				buildingDescription.text = "Oh my god, you wear that? Gain some prestige and some better clothing and maybe I'll show you how to dress for success.";
			}

			break;
		case 10://guard post

			blacksmithPopUp.SetActive(true);
            buildingNum = 10;
            characterPopUp.GetComponent<Image>().sprite = guard;

			buildingName.text = "Guard Post - Lvl " + gameStates.GuardPostLvl;
			if (gameStates.PrestigeLvl > 0)
			{
				bitUpgradeText.text = "Upgrade with " + gameStates.GuardPostCost + " Bits";
				chunkUpgradeText.text = "Upgrade with " + (int)(1 + gameStates.GuardPostCost / 600) + " Chunks";
				buildingDescription.text = "Good day Knight, let me show you and your friends some new fighting tricks.";
			}
			else
			{
				bitUpgradeText.text = "Prestige to Unlock!";
				chunkUpgradeText.text = "Prestige to Unlock!";
				buildingDescription.text = "If you were more respected, I'd show you and your companions how to fight.";
			}

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
                SoundManager.instance.PlayClip(upgradeBitsSFX);
                
				gameStates.BlacksmithLvl += 1;
				gameStates.Bits -= gameStates.BlacksmithCost;
				int costIncrease = blacksmithCostI * (int)(Mathf.Pow(gameStates.BlacksmithLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.BlacksmithCost += costIncrease;
                gameStates.ClickDmg += 1;
				blacksmithPopUp.SetActive(false);
			}
			break;
		case 2://tavern
			if (gameStates.Bits >= (gameStates.TavernCost))
			{
                SoundManager.instance.PlayClip(upgradeBitsSFX);

                gameStates.TavernLvl += 1;
				gameStates.Bits -= gameStates.TavernCost;
				int costIncrease = tavernCostI * (int)(Mathf.Pow(gameStates.TavernLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.TavernCost += costIncrease;
                gameStates.AutoPDmg += 1;
                gameStates.AutoMDmg += 1;
				blacksmithPopUp.SetActive(false);
			}
			break;
		case 3://apothecary
			if (gameStates.Bits >= (gameStates.ApothecaryCost))
			{
                SoundManager.instance.PlayClip(upgradeBitsSFX);

                gameStates.ApothecaryLvl += 1;
				gameStates.Bits -= gameStates.ApothecaryCost;
                int costIncrease = apothecaryCostI * (int)(Mathf.Pow(gameStates.ApothecaryLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.ApothecaryCost += costIncrease;
				gameStates.ClickDmg += 2;
				blacksmithPopUp.SetActive(false);
                    print(gameStates.ApothecaryLvl);
			}
			break;
		case 4://stable
			if (gameStates.Bits >= (gameStates.StableCost))
            {
                SoundManager.instance.PlayClip(upgradeBitsSFX);

                gameStates.StableLvl += 1;
				gameStates.Bits -= gameStates.StableCost;
                int costIncrease = stableCostI * (int)(Mathf.Pow(gameStates.StableLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.StableCost += costIncrease;
				gameStates.AutoPDmg += 1;
				blacksmithPopUp.SetActive (false);
			}
			break;
		case 5: //wizards tower
			if (gameStates.Bits >= (gameStates.WizardsTowerCost))
			{
                SoundManager.instance.PlayClip(upgradeBitsSFX);

                gameStates.WizardsTowerLvl += 1;
				gameStates.Bits -= gameStates.WizardsTowerCost;
                int costIncrease = wizardsTowerCostI * (int)(Mathf.Pow(gameStates.WizardsTowerLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.WizardsTowerCost += costIncrease;
				gameStates.AutoMDmg += 1;
				blacksmithPopUp.SetActive(false);
			}
			break;
		case 6: //Fortune Teller
			if (gameStates.Bits >= (gameStates.FortuneTellerCost))
			{
                SoundManager.instance.PlayClip(upgradeBitsSFX);

                gameStates.FortuneTellerLvl += 1;
				gameStates.Bits -= gameStates.FortuneTellerCost;
                int costIncrease = fortuneTellerCostI * (int)(Mathf.Pow(gameStates.FortuneTellerLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.FortuneTellerCost += costIncrease;
				gameStates.GoldIncrease += 1;
				blacksmithPopUp.SetActive(false);
			}
			break;
		case 7: //General store
			if (gameStates.Bits >= (gameStates.GeneralStoreCost))
			{
                SoundManager.instance.PlayClip(upgradeBitsSFX);

                gameStates.GeneralStoreLvl += 1;
				gameStates.Bits -= gameStates.GeneralStoreCost;
                int costIncrease = generalStoreCostI * (int)(Mathf.Pow(gameStates.GeneralStoreLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.GeneralStoreCost += costIncrease;
				gameStates.GoldIncrease += 1;
				blacksmithPopUp.SetActive(false);
			}
			break;
		case 8: //trading post
			if (gameStates.Bits >= (gameStates.TradingPostCost))
			{
                SoundManager.instance.PlayClip(upgradeBitsSFX);

                gameStates.TradingPostLvl += 1;
				gameStates.Bits -= gameStates.TradingPostCost;
                int costIncrease = tradingPostCostI * (int)(Mathf.Pow(gameStates.TradingPostLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.TradingPostCost += costIncrease;
				gameStates.GoldIncrease += 1;
				blacksmithPopUp.SetActive(false);
			}
			break;
		case 9: //Tailor
			if (gameStates.Bits >= (gameStates.TailorCost))
			{
                SoundManager.instance.PlayClip(upgradeBitsSFX);

                gameStates.TailorLvl += 1;
				gameStates.Bits -= gameStates.TailorCost;
                int costIncrease = tailorCostI * (int)(Mathf.Pow(gameStates.TailorLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.TailorCost += costIncrease;
				gameStates.ClickDmg += 1;
				blacksmithPopUp.SetActive(false);
			}
			break;
		case 10: //guard post
			if (gameStates.Bits >= (gameStates.GuardPostCost))
			{
                SoundManager.instance.PlayClip(upgradeBitsSFX);

                gameStates.GuardPostLvl += 1;
				gameStates.Bits -= gameStates.GuardPostCost;
                int costIncrease = guardPostCostI * (int)(Mathf.Pow(gameStates.GuardPostLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.GuardPostCost += costIncrease;
				gameStates.ClickDmg += 1;
				gameStates.AutoPDmg += 1;
				gameStates.AutoMDmg += 1;
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
                SoundManager.instance.PlayClip(upgradeChunksSFX);

                gameStates.BlacksmithLvl += 1;
				gameStates.Chunks -= (int)(1 + gameStates.BlacksmithCost / 600);
                int costIncrease = blacksmithCostI * (int)(Mathf.Pow(gameStates.BlacksmithLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.BlacksmithCost += costIncrease;
				gameStates.ClickDmg += 1;
				blacksmithPopUp.SetActive(false);
			}
			break;
		case 2://tavern
			if (gameStates.Chunks >= (int)(1 + gameStates.TavernCost / 600))
			{
                SoundManager.instance.PlayClip(upgradeChunksSFX);

                gameStates.TavernLvl += 1;
				gameStates.Chunks -= (int)(1 + gameStates.TavernCost / 600);
                int costIncrease = tavernCostI * (int)(Mathf.Pow(gameStates.TavernLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.TavernCost += costIncrease;
				gameStates.AutoPDmg += 1;
				gameStates.AutoMDmg += 1;
				blacksmithPopUp.SetActive(false);
			}
			break;
		case 3://apothecary
			if (gameStates.Chunks >= (int)(1 + gameStates.ApothecaryCost / 600))
			{
                SoundManager.instance.PlayClip(upgradeChunksSFX);

                gameStates.ApothecaryLvl += 1;
				gameStates.Chunks -= (int)(1 + gameStates.ApothecaryCost / 600);
                int costIncrease = apothecaryCostI * (int)(Mathf.Pow(gameStates.ApothecaryLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.ApothecaryCost += costIncrease;
				gameStates.ClickDmg += 1;
				blacksmithPopUp.SetActive(false);
                    print(gameStates.ApothecaryLvl);
                }
			break;
		case 4://stable
			if (gameStates.Chunks >= (int)(1+gameStates.StableCost/600))
            {
                SoundManager.instance.PlayClip(upgradeChunksSFX);

                gameStates.StableLvl += 1;
				gameStates.Chunks -= (int)(1+gameStates.StableCost / 600);
                int costIncrease = stableCostI * (int)(Mathf.Pow(gameStates.StableLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.StableCost += costIncrease;
				gameStates.AutoPDmg += 1;
				blacksmithPopUp.SetActive (false);
			}
			break;
		case 5://wizards tower
			if (gameStates.Chunks >= (int)(1 + gameStates.WizardsTowerCost / 600))
			{
                SoundManager.instance.PlayClip(upgradeChunksSFX);

                gameStates.WizardsTowerLvl += 1;
				gameStates.Chunks -= (int)(1 + gameStates.WizardsTowerCost / 600);
                int costIncrease = wizardsTowerCostI * (int)(Mathf.Pow(gameStates.WizardsTowerLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.WizardsTowerCost += costIncrease;
				gameStates.AutoMDmg += 1;
				blacksmithPopUp.SetActive(false);
			}
			break;
		case 6://fortune teller
			if (gameStates.Chunks >= (int)(1 + gameStates.FortuneTellerCost / 600))
			{
                SoundManager.instance.PlayClip(upgradeChunksSFX);

                gameStates.FortuneTellerLvl += 1;
				gameStates.Chunks -= (int)(1 + gameStates.FortuneTellerCost / 600);
                int costIncrease = fortuneTellerCostI * (int)(Mathf.Pow(gameStates.FortuneTellerLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.FortuneTellerCost += costIncrease;
				gameStates.GoldIncrease += 1;
				blacksmithPopUp.SetActive(false);
			}
			break;
		case 7://general store
			if (gameStates.Chunks >= (int)(1 + gameStates.GeneralStoreCost / 600))
			{
                SoundManager.instance.PlayClip(upgradeChunksSFX);

                gameStates.GeneralStoreLvl += 1;
				gameStates.Chunks -= (int)(1 + gameStates.GeneralStoreCost / 600);
                int costIncrease = generalStoreCostI * (int)(Mathf.Pow(gameStates.GeneralStoreLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.GeneralStoreCost += costIncrease;
				gameStates.GoldIncrease += 1;
				blacksmithPopUp.SetActive(false);
			}
			break;
		case 8://trading post
			if (gameStates.Chunks >= (int)(1 + gameStates.TradingPostCost / 600))
			{
                SoundManager.instance.PlayClip(upgradeChunksSFX);

                gameStates.TradingPostLvl += 1;
				gameStates.Chunks -= (int)(1 + gameStates.TradingPostCost / 600);
                int costIncrease = tradingPostCostI * (int)(Mathf.Pow(gameStates.TradingPostLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.TradingPostCost += costIncrease;
				gameStates.GoldIncrease += 1;
				blacksmithPopUp.SetActive(false);
			}
			break;
		case 9://tailor
			if (gameStates.Chunks >= (int)(1 + gameStates.TailorCost / 600))
			{
                SoundManager.instance.PlayClip(upgradeChunksSFX);

                gameStates.TailorLvl += 1;
				gameStates.Chunks -= (int)(1 + gameStates.TailorCost / 600);
                int costIncrease = tailorCostI * (int)(Mathf.Pow(gameStates.TailorLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.TailorCost += costIncrease;
				gameStates.ClickDmg += 1;
				blacksmithPopUp.SetActive(false);
			}
			break;
		case 10://guard post
			if (gameStates.Chunks >= (int)(1 + gameStates.GuardPostCost / 600))
			{
                SoundManager.instance.PlayClip(upgradeChunksSFX);

                gameStates.GuardPostLvl += 1;
				gameStates.Chunks -= (int)(1 + gameStates.GuardPostCost / 600);
                int costIncrease = guardPostCostI * (int)(Mathf.Pow(gameStates.GuardPostLvl, 2));
                costIncrease = (costIncrease / 4) * 2;
                gameStates.GuardPostCost += costIncrease;
				gameStates.ClickDmg += 1;
				gameStates.AutoPDmg += 1;
				gameStates.AutoMDmg += 1;
				blacksmithPopUp.SetActive(false);
			}
			break;

		default:
			break;
		}
	}

	public void closePopUp(){
        SoundManager.instance.PlayClip(sceneChange);
        blacksmithPopUp.SetActive (false);
	}



}
