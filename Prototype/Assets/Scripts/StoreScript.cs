using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoreScript : MonoBehaviour {

	public UnityEngine.UI.Text bitsCountDisplay;
	public UnityEngine.UI.Text monsterDropCountDisplay;
	public UnityEngine.UI.Text chunkCountDisplay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		bitsCountDisplay.text ="" + gameStates.Bits;
		monsterDropCountDisplay.text = "" + gameStates.MonsterDrops;
		chunkCountDisplay.text = "" + gameStates.Chunks;
	}

	//since we can't actually charge you money, please take it for free
	public void purchaseOffer1() {
		gameStates.Chunks += 10;
	}

	public void purchaseOffer2() {
		gameStates.Chunks += 25;
	}

	public void purchaseOffer3() {
		gameStates.Chunks += 50;
	}

	public void purchaseOffer4() {
		gameStates.Chunks += 75;
	}

	public void toHomeClicked()
	{
		if (gameStates.LastScene == 1) {
			SceneManager.LoadScene ("Town", LoadSceneMode.Single);
		} else if (gameStates.LastScene == 2) {
			SceneManager.LoadScene ("Home", LoadSceneMode.Single);
		} else if (gameStates.LastScene == 3) {
			SceneManager.LoadScene ("Dungeon", LoadSceneMode.Single);
		} else if (gameStates.LastScene == 0) {
			SceneManager.LoadScene ("Town", LoadSceneMode.Single);
		}
	}
}
