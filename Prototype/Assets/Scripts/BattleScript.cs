
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;



public class BattleScript : MonoBehaviour {

    public UnityEngine.UI.Text healthDisplay;
    public UnityEngine.UI.Text killCountDisplay;
	public UnityEngine.UI.Text goldCountDisplay;
	public UnityEngine.UI.Text monsterDropCountDisplay;
	public UnityEngine.UI.Text dropCountDisplay;
    public UnityEngine.UI.Text enemyName;

    public Image img_attackEffect; //image for attack effect

    public int baseHealth = 5; //health base number
	public int baseGold = 1; //how much gold each monster drops to start

    int fullHealth = 5; //saves previous full health
    int currentHealth = 5; //tracks current amount of monster health
	int currentBits = 0; //tracks current amount of gold

	int dropCount = 0; //calculate to drop a monster drop every X amount of damage
	int currentMonsterDrop = 0; //total of monster drops

    public int damagePerClick = 1; //how much damage is done per click

    int enemiesDefeated;

    public Image ImageComponent;
    public Sprite[] enemies;

    /// <summary>
    /// Initializes game objects
    /// </summary>
    void Start()
    {
        img_attackEffect.enabled = false;




    //Update Game data
    //fullHealth = gameStates.FHealth;      
    //currentHealth = gameStates.CHealth;
    //currentBits = gameStates.Bits;
    //currentMonsterDrop = gameStates.MonsterDrops;

    }

	/// <summary>
    /// Called Once per Frame
    /// </summary>
	void Update () {

        /////////////////UI UPDATES////////////////
        healthDisplay.text = "Health: " + currentHealth;
        killCountDisplay.text = "Enemies Defeated: " + enemiesDefeated;
		goldCountDisplay.text = "Gold: " + currentBits;

		dropCountDisplay.text = "Until MD: " + dropCount + "/100";
		monsterDropCountDisplay.text = "Monster Drops: "+ currentMonsterDrop;

        if (enemiesDefeated == 0) { enemyName.text = "Sumola"; }
        else if (enemiesDefeated == 1) { enemyName.text = "Nubrax"; }
        else if (enemiesDefeated == 2) { enemyName.text = "Cheliscor"; }
        else if (enemiesDefeated == 3) { enemyName.text = "Eusfish"; }
        else if (enemiesDefeated == 4) { enemyName.text = "Ohminoco"; }
        else if (enemiesDefeated == 5) { enemyName.text = "Lerinka"; }
        else if (enemiesDefeated == 6) { enemyName.text = "Gallock"; }
        else if (enemiesDefeated == 7) { enemyName.text = "Threskibis"; }
        else if (enemiesDefeated == 8) { enemyName.text = "Luckidisae"; }
        else if (enemiesDefeated == 9) { enemyName.text = "Bustrix"; }


        /////////////////ENEMY DEATH////////////////

        if (currentHealth <= 0)
        {
            enemiesDefeated += 1;
            currentHealth = fullHealth + (int)(fullHealth * 0.2);
            fullHealth = currentHealth;

            currentBits += (int)(fullHealth / baseHealth) * baseGold;

            dropCount += currentHealth;
            if (dropCount >= 100)
            {
                currentMonsterDrop += 1;
                dropCount = 0;
            }

            //change enemy image
            ImageComponent.sprite = enemies[enemiesDefeated];
            
        }
	}

    /// <summary>
    /// Performs actions when Button_enemy is clicked
    /// </summary>
    public void enemyClicked()
    {
        currentHealth -= damagePerClick; //enemy takes damage
        img_attackEffect.transform.position = Input.mousePosition; //set image to click location 
        StartCoroutine(Appear(img_attackEffect, 0.1F));

    }

    /// <summary>
    /// Performs actions when Button_ToTown is clicked
    /// </summary>
    public void toTownClicked() {

        SceneManager.LoadScene("Prototype_Town", LoadSceneMode.Single);

    }

    /// <summary>
    /// Delays apperance and disapperance of an image
    /// </summary>
    /// <returns></returns>
   IEnumerator Appear(Image img, float time) {

        img.enabled = true; //makes image visable
        yield return new WaitForSeconds(time); //wait for the specified time
        img.enabled = false; //makes image dissapear
    }
}
