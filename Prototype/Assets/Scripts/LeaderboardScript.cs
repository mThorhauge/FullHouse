using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LeaderboardScript : MonoBehaviour {
    public GameObject Hair;
    public GameObject HairLong;
    public GameObject Face;
    private Animator hairAnim;
    private Animator hairLongAnim;
    private Animator faceAnim;
    private Renderer hairIsLong;
    // Use this for initialization
    void Start () {
        hairAnim = Hair.GetComponent<Animator>();
        hairLongAnim = HairLong.GetComponent<Animator>();
        faceAnim = Face.GetComponent<Animator>();
        hairIsLong = HairLong.GetComponent<Renderer>();

        hairAnim.SetInteger("HairColour", gameStates.HairColor); // pop up hair colour 1
        hairAnim.SetBool("HairShort", gameStates.HairShort); // pop up hair shape 2
        hairLongAnim.SetInteger("hairColourBot", gameStates.HairColor); // pop up long hair bottom colour 3
        faceAnim.SetInteger("FaceShape", gameStates.FaceShape); // pop up face shape 5
        faceAnim.SetInteger("SkinColour", gameStates.SkinColor); // pop up hair skin colour 4

        if (gameStates.HairShort == false)
        {
            hairIsLong.enabled = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void toTownClicked()
    {
        SceneManager.LoadScene("Town", LoadSceneMode.Single);
    }
}
