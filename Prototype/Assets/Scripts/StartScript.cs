using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

	public InputField townNameInput;
	public static string townName;

	// Use this for initialization
	void Start () {
		if(townNameInput.text != null)
			townName = townNameInput.text;
		else 
			townName = "Bittania";
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SaveTownName(string newName) {
		gameStates.TownName = townNameInput.text;
		SceneManager.LoadScene("Town", LoadSceneMode.Single);
	}
}
