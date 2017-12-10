using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class HomeScreen : MonoBehaviour {

	//Set top bar information
	public UnityEngine.UI.Text bitsCountDisplay;
	public UnityEngine.UI.Text monsterDropCountDisplay;
	public UnityEngine.UI.Text chunkCountDisplay;
    public UnityEngine.UI.Text prestigeDisplay;

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

    public GameObject prestige;
    public GameObject social;


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

    public AudioClip clotheChange;
    public AudioClip appearanceChange;
    public AudioClip sceneChange;



    // Use this for initialization
    void Start () {
        SoundManager.instance.PlayClip(sceneChange);

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
        
        if (gameStates.ChangesMade == true)
        {
            ClothAnim.SetInteger("ClothNum", gameStates.Cloth); // main clothing
            smHairAnim.SetBool("HairShort", gameStates.HairShort); // main hair shape 1 
            smHairAnim.SetInteger("HairColour", gameStates.HairColor); // main hair colour 2
            smHairBotAnim.SetInteger("hairColourBot", gameStates.HairColor); // main long hair bottom colour 3
            smFaceAnim.SetInteger("SkinColour", gameStates.SkinColor); // main skin colour 4
            smFaceAnim.SetInteger("FaceShape", gameStates.FaceShape); // main face shape 5
            smFaceAnim.SetInteger("SkinColour", gameStates.SkinColor); // main skin colour 4

            hairAnim.SetInteger("HairColour", gameStates.HairColor); // pop up hair colour 1
            hairAnim.SetBool("HairShort", gameStates.HairShort); // pop up hair shape 2
            hairLongAnim.SetInteger("hairColourBot", gameStates.HairColor); // pop up long hair bottom colour 3
            faceAnim.SetInteger("FaceShape", gameStates.FaceShape); // pop up face shape 5
            faceAnim.SetInteger("SkinColour", gameStates.SkinColor); // pop up hair skin colour 4

            print(gameStates.HairColor);
            print(gameStates.SkinColor);

            colourVar = gameStates.HairColor;
            smcolourVar = gameStates.HairColor;
            if (gameStates.HairShort == false)
            {
                smHairIsLong.enabled = true;
                hairIsLong.enabled = true;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {

		//Set top bar information
		bitsCountDisplay.text ="" + gameStates.Bits;
		monsterDropCountDisplay.text = "" + gameStates.MonsterDrops;
		chunkCountDisplay.text = "" + gameStates.Chunks;

        ClothAnim.SetInteger("ClothNum", gameStates.Cloth); // main clothing
        smHairAnim.SetBool("HairShort", gameStates.HairShort); // main hair shape 1 
        smHairAnim.SetInteger("HairColour", gameStates.HairColor); // main hair colour 2
        smHairBotAnim.SetInteger("hairColourBot", gameStates.HairColor); // main long hair bottom colour 3
        smFaceAnim.SetInteger("SkinColour", gameStates.SkinColor); // main skin colour 4
        smFaceAnim.SetInteger("FaceShape", gameStates.FaceShape); // main face shape 5

        hairAnim.SetInteger("HairColour", gameStates.HairColor); // pop up hair colour 1
        hairAnim.SetBool("HairShort", gameStates.HairShort); // pop up hair shape 2
        hairLongAnim.SetInteger("hairColourBot", gameStates.HairColor); // pop up long hair bottom colour 3
        faceAnim.SetInteger("SkinColour", gameStates.SkinColor); // pop up hair skin colour 4
        faceAnim.SetInteger("FaceShape", gameStates.FaceShape); // pop up face shape 5

        colourVar = gameStates.HairColor;
        smcolourVar = gameStates.HairColor;

        if (gameStates.HairShort == false)
        {
            smHairIsLong.enabled = true;
            hairIsLong.enabled = true;
        }
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
        print(gameStates.HairColor);
        print(gameStates.SkinColor);
        SceneManager.LoadScene("Town", LoadSceneMode.Single);
	}

	public void toStoreClick() {
		gameStates.Cloth = ClothAnim.GetInteger("ClothNum");
		gameStates.HairColor = hairAnim.GetInteger("HairColour");
		gameStates.HairShort = hairAnim.GetBool("HairShort");
		gameStates.SkinColor = faceAnim.GetInteger("SkinColour");
		gameStates.FaceShape = faceAnim.GetInteger("FaceShape");
		print(gameStates.HairColor);
		print(gameStates.SkinColor);

		gameStates.LastScene = 2;
		SceneManager.LoadScene("Store", LoadSceneMode.Single);
	}

	public void changeAppearance() {
        SoundManager.instance.PlayClip(sceneChange);
        if (PopUp.transform.position.x > 0) {
            PopUp.transform.position = new Vector3(-631, -348, 0);
            appearancePopUp.SetActive(false);

            prestige.transform.position = new Vector3(500, 650, 0);
            prestigeDisplay.transform.position = new Vector3(525, 600, 0);
        } 
        else { PopUp.transform.position = new Vector3(321, 600, 0);
            appearancePopUp.SetActive(true);

            prestige.transform.position = new Vector3(-400, 0, 0);
            prestigeDisplay.transform.position = new Vector3(-400, 0, 0);
        } 
        

    }

	public void closeAppearancePopUp(string choice) {
        SoundManager.instance.PlayClip(sceneChange);
        PopUp.transform.position = new Vector3(0, 0, 0);
        if ( choice == "continue") {
            appearancePopUp.SetActive(false);
            PopUp.transform.position = new Vector3(-631, -348, 0);

            prestige.transform.position = new Vector3(500, 650, 0);
            prestigeDisplay.transform.position = new Vector3(525, 600, 0);
        }
	}

    public void WardrobeSwitch()
    {
        SoundManager.instance.PlayClip(clotheChange);
        if (ClothAnim.GetInteger("ClothNum") < 7) { ClothAnim.SetInteger("ClothNum", ClothAnim.GetInteger("ClothNum") + 1); }
        else { ClothAnim.SetInteger("ClothNum", 0); }

        gameStates.Cloth = ClothAnim.GetInteger("ClothNum");
        gameStates.ChangesMade = true;

    }

    public void hairshape()
    {
        SoundManager.instance.PlayClip(appearanceChange);
        //pop up
        if (hairAnim.GetBool("HairShort")) { hairAnim.SetBool("HairShort", false); hairIsLong.enabled = true; }
        else { hairAnim.SetBool("HairShort", true); hairIsLong.enabled = false; }

        //main screen
        if (smHairAnim.GetBool("HairShort")) { smHairAnim.SetBool("HairShort", false); smHairIsLong.enabled = true; }
        else { smHairAnim.SetBool("HairShort", true); smHairIsLong.enabled = false; }

        gameStates.HairShort = hairAnim.GetBool("HairShort");
        gameStates.ChangesMade = true;
    }

    public void haircolour()
    {
        SoundManager.instance.PlayClip(appearanceChange);
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

        gameStates.HairColor = hairAnim.GetInteger("HairColour");
        gameStates.ChangesMade = true;
    }

    public void faceshape()
    {
        SoundManager.instance.PlayClip(appearanceChange);
        //pop up
        if (faceAnim.GetInteger("FaceShape") < 2) { faceAnim.SetInteger("FaceShape", faceAnim.GetInteger("FaceShape") + 1); }
        else { faceAnim.SetInteger("FaceShape", 0); }

        //main screen
        if (smFaceAnim.GetInteger("FaceShape") < 2) { smFaceAnim.SetInteger("FaceShape", smFaceAnim.GetInteger("FaceShape") + 1); }
        else { smFaceAnim.SetInteger("FaceShape", 0); }

        gameStates.FaceShape = faceAnim.GetInteger("FaceShape");
        gameStates.ChangesMade = true;
    }

    public void skincolour()
    {
        SoundManager.instance.PlayClip(appearanceChange);
        //pop up
        if(faceAnim.GetInteger("SkinColour") < 7) { faceAnim.SetInteger("SkinColour", faceAnim.GetInteger("SkinColour") + 1); }
        else { faceAnim.SetInteger("SkinColour", 0); }

        //main screen
        if (smFaceAnim.GetInteger("SkinColour") < 7) { smFaceAnim.SetInteger("SkinColour", smFaceAnim.GetInteger("SkinColour") + 1); }
        else { smFaceAnim.SetInteger("SkinColour", 0); }

        gameStates.SkinColor = faceAnim.GetInteger("SkinColour");
        gameStates.ChangesMade = true;
    }
}
