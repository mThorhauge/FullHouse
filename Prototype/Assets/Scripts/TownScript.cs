using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TownScript : MonoBehaviour {

    public UnityEngine.UI.Text bitsCountDisplay;
    public UnityEngine.UI.Text monsterDropCountDisplay;

    public GameObject town;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        bitsCountDisplay.text = "Bits: " + gameStates.Bits;
        monsterDropCountDisplay.text = "Monster Drops: " + gameStates.MonsterDrops;

        if (Input.GetMouseButton(0)) {

            Vector3 screenPoint = Camera.main.WorldToScreenPoint(town.transform.position);
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
            Vector3 offset = town.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;


            town.transform.position = curPosition;

            }

	}

    public void toDungeonClick() {

        SceneManager.LoadScene("Prototype_Dungeon", LoadSceneMode.Single);

    }

    public void upgradeBuildingClick(int buildingID) {

        //Switch between chosen building
        switch(buildingID) {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                break;
            }
 

    }
}
