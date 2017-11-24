using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class HomeScreen : MonoBehaviour {

	public GameObject appearancePopUp;

	//public Sprite img_popUp;
    //public Sprite img_mirror;


    // Use this for initialization
    void Start () {
        //img_popUp.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
		
	/// <summary>
	/// Performs actions when Button_ToTown is clicked
	/// </summary>
	public void toTownClicked() {

		SceneManager.LoadScene("Town", LoadSceneMode.Single);
	}

	public void changeAppearance() {
		appearancePopUp.SetActive(true);
	}

	public void closeAppearancePopUp(string choice) {
		if( choice == "continue") {
			appearancePopUp.SetActive(false);
		}
	}
}
