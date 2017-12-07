using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoreScript : MonoBehaviour {

	public UnityEngine.UI.Text bitsCountDisplay;
	public UnityEngine.UI.Text monsterDropCountDisplay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		bitsCountDisplay.text ="" + gameStates.Bits;
		monsterDropCountDisplay.text = "MDs: " + gameStates.MonsterDrops;

	}

	public void toHomeClicked()
	{
		SceneManager.LoadScene("Home", LoadSceneMode.Single);
	}
}
