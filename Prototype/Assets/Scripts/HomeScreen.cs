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
    public GameObject smFace;
    private Animator smFaceAnim;
    public GameObject smHair;
    private Animator smHairAnim;
    public GameObject smHairBot;
    private Animator smHairBotAnim;
    private Renderer smHairIsLong;
    public GameObject PopUp;


    public GameObject Hair;
    public GameObject HairLong;
    public GameObject Face;
    private Animator hairAnim;
    private Animator hairLongAnim;
    private Animator faceAnim;
    private Renderer hairIsLong;

    private int colourVar;
    private int smcolourVar;
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
        smFaceAnim = smFace.GetComponent<Animator>();
        smHairAnim = smHair.GetComponent<Animator>();
        smHairBotAnim = smHairBot.GetComponent<Animator>();
        smHairIsLong = smHairBot.GetComponent<Renderer>();


        colourVar = 0;
        smcolourVar = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
		
	/// <summary>
	/// Performs actions when Button_ToTown is clicked
	/// </summary>
	public void toTownClicked() {
        gameStates.Cloth = ClothAnim.GetInteger("ClothNum");
        gameStates.HairColor = hairAnim.GetInteger("HairColour");
        gameStates.HairShort = hairAnim.GetBool("HairShort");
        gameStates.SkinColor = faceAnim.GetInteger("SkinColour");
        gameStates.FaceShape = faceAnim.GetInteger("FaceShape");

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

        gameStates.ChangesMade = true;

    }

    public void hairshape()
    {
        //pop up
        if (hairAnim.GetBool("HairShort")) { hairAnim.SetBool("HairShort", false); hairIsLong.enabled = true; }
        else { hairAnim.SetBool("HairShort", true); hairIsLong.enabled = false; }

        //main screen
        if (smHairAnim.GetBool("HairShort")) { smHairAnim.SetBool("HairShort", false); smHairIsLong.enabled = true; }
        else { smHairAnim.SetBool("HairShort", true); smHairIsLong.enabled = false; }

        gameStates.ChangesMade = true;
    }

    public void haircolour()
    {
        //pop up
        if (hairAnim.GetInteger("HairColour") < 5) { hairAnim.SetInteger("HairColour", hairAnim.GetInteger("HairColour") + 1); colourVar = colourVar + 1; }
        else { hairAnim.SetInteger("HairColour", 0); colourVar = 0; }

        if (colourVar <= 5) { hairLongAnim.SetInteger("hairColourBot", colourVar); }
        else { hairLongAnim.SetInteger("hairColourBot", 0); }

        //main screen
        if (smHairAnim.GetInteger("HairColour") < 5) { smHairAnim.SetInteger("HairColour", smHairAnim.GetInteger("HairColour") + 1); smcolourVar = smcolourVar + 1; }
        else { smHairAnim.SetInteger("HairColour", 0); smcolourVar = 0; }

        if (smcolourVar <= 5) { smHairBotAnim.SetInteger("hairColourBot", smcolourVar); }
        else { smHairBotAnim.SetInteger("hairColourBot", 0); }

        gameStates.ChangesMade = true;
    }

    public void faceshape()
    {
        //pop up
        if (faceAnim.GetInteger("FaceShape") < 2) { faceAnim.SetInteger("FaceShape", faceAnim.GetInteger("FaceShape") + 1); }
        else { faceAnim.SetInteger("FaceShape", 0); }

        //main screen
        if (smFaceAnim.GetInteger("FaceShape") < 2) { smFaceAnim.SetInteger("FaceShape", smFaceAnim.GetInteger("FaceShape") + 1); }
        else { smFaceAnim.SetInteger("FaceShape", 0); }

        gameStates.ChangesMade = true;
    }

    public void skincolour()
    {
        //pop up
        if(faceAnim.GetInteger("SkinColour") < 7) { faceAnim.SetInteger("SkinColour", faceAnim.GetInteger("SkinColour") + 1); }
        else { faceAnim.SetInteger("SkinColour", 0); }

        //main screen
        if (smFaceAnim.GetInteger("SkinColour") < 7) { smFaceAnim.SetInteger("SkinColour", smFaceAnim.GetInteger("SkinColour") + 1); }
        else { smFaceAnim.SetInteger("SkinColour", 0); }

        gameStates.ChangesMade = true;
    }
}
