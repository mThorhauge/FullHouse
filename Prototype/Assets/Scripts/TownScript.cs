using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TownScript : MonoBehaviour {

    public UnityEngine.UI.Text bitsCountDisplay;
    public UnityEngine.UI.Text monsterDropCountDisplay;

    public UnityEngine.UI.Text apothecaryLevelDisplay;
    public UnityEngine.UI.Text blacksmithLevelDisplay;
    public UnityEngine.UI.Text tavernLevelDisplay;
    public UnityEngine.UI.Text fortuneTellerLevelDisplay;

    public GameObject town;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        bitsCountDisplay.text = "Bits: " + gameStates.Bits;
        monsterDropCountDisplay.text = "Monster Drops: " + gameStates.MonsterDrops;

		apothecaryLevelDisplay.text = "Level " + gameStates.ApothecaryLvl + " Upgrade Cost " + gameStates.ApothecaryCost;
		blacksmithLevelDisplay.text = "Level " + gameStates.BlacksmithLvl+ " Upgrade Cost " + gameStates.BlacksmithCost;
		tavernLevelDisplay.text = "Level " + gameStates.TavernLvl+ " Upgrade Cost " + gameStates.TavernCost;
		fortuneTellerLevelDisplay.text = "Level " + gameStates.FortuneTellerLvl + " Upgrade Cost " + gameStates.FortuneTellerCost;

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

    public void upgradeBuildingClick(int buildingID) {

		//Switch between chosen building
        switch(buildingID) {
		case 1:
			if (gameStates.Bits >= (gameStates.ApothecaryCost *(gameStates.ApothecaryLvl^2))) {
				gameStates.ApothecaryLvl += 1;
				gameStates.Bits -= gameStates.ApothecaryCost;
			}
			break;
        case 2:

			if (gameStates.Bits >= (gameStates.BlacksmithCost *(gameStates.BlacksmithLvl^2))) {
				gameStates.BlacksmithLvl += 1;
				gameStates.Bits -= gameStates.BlacksmithCost;
			}
            break;
        case 3:
			if (gameStates.Bits >= (gameStates.TavernCost *(gameStates.TavernLvl^2))) {
				gameStates.TavernLvl += 1;
				gameStates.Bits -= gameStates.TavernCost;
			}
            break;
        case 4:
			if (gameStates.Bits >= (gameStates.FortuneTellerCost *(gameStates.FortuneTellerLvl^2))) {
				gameStates.FortuneTellerLvl += 1;
				gameStates.Bits -= gameStates.FortuneTellerCost;
			}
            break;
        default:
            break;
        }

    }
}
