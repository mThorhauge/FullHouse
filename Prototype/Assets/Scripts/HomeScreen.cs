using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class HomeScreen : MonoBehaviour {

	public GameObject appearancePopUp;
    public GameObject Clothing;
    private Animator ClothAnim;
    public GameObject PopUp;


    public GameObject Hair;
    public GameObject HairLong;
    public GameObject Face;
    private Animator hairAnim;
    private Animator hairLongAnim;
    private Animator faceAnim;
    private Renderer hairIsLong;


    //public Sprite img_popUp;
    //public Sprite img_mirror;


    // Use this for initialization
    void Start () {
        //img_popUp.enabled = false;
        ClothAnim = Clothing.GetComponent<Animator>();
        hairAnim = Hair.GetComponent<Animator>();
        hairLongAnim = HairLong.GetComponent<Animator>();
        faceAnim = Face.GetComponent<Animator>();
        hairIsLong = HairLong.GetComponent<Renderer>();

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
        
        if (PopUp.transform.position.x > 0) { PopUp.transform.position = new Vector3(-631, -348, 0); appearancePopUp.SetActive(false); } //remove this line and the if statement when switching to the confirmation thing.
        else { PopUp.transform.position = new Vector3(321, 608, 0); appearancePopUp.SetActive(true); } //keep this line just remove the else statment
        

    }

	public void closeAppearancePopUp(string choice) {
        PopUp.transform.position = new Vector3(0, 0, 0);
        if ( choice == "continue") {
            appearancePopUp.SetActive(false);
            PopUp.transform.position = new Vector3(-631, -348, 0); //this is the line that will be removed above
        }
	}

    public void WardrobeSwitch()
    {
        if (ClothAnim.GetInteger("ClothNum") < 7) { ClothAnim.SetInteger("ClothNum", ClothAnim.GetInteger("ClothNum")+1); }
        else { ClothAnim.SetInteger("ClothNum", 0); }

    }

    public void hairshape()
    {
        if (hairAnim.GetBool("HairShort")) { hairAnim.SetBool("HairShort", false); hairIsLong.enabled = true; }
        else { hairAnim.SetBool("HairShort", true); hairIsLong.enabled = false; }
        
    }

    public void haircolour()
    {
        if (hairAnim.GetInteger("HairColour") < 5) { hairAnim.SetInteger("HairColour", hairAnim.GetInteger("HairColour") + 1); }
        else { hairAnim.SetInteger("HairColour", 0); }
    }

    public void faceshape()
    {

    }

    public void skincolour()
    {

    }
}
