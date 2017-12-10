using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

	public InputField townNameInput;
	public static string townName;
    //private static string defaultName;

	// Use this for initialization
	void Start () {
        string defaultName = "Bittania";
        if (townNameInput.text != null)
            townName = townNameInput.text;
        else
            townName = defaultName;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SaveTownName(string newName) {
		gameStates.TownName = townNameInput.text;
		SceneManager.LoadScene("Town", LoadSceneMode.Single);
	}
}
