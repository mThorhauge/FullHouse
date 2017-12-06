
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

    //adjust health bar
    public RectTransform    healthBar;

    public Image            img_attackEffect; //image for attack effect

    public int              baseHealth              = 5; //health base number
    public int              baseGold                = 1; //how much gold each monster drops to start

    float                   fullHealth              = gameStates.FHealth; //saves previous full health
    float                   currentHealth           = gameStates.CHealth; //tracks current amount of monster health
    int                     currentBits             = gameStates.Bits; //tracks current amount of gold
    int                     currentChunks           = gameStates.Chunks; //track current amount of premium currency

    int                     dropCount               = gameStates.MDropCount; //calculate to drop a monster drop every X amount of damage
    int                     currentMonsterDrop      = gameStates.MonsterDrops; //total of monster drops

	public int              damagePerClick          = 1 * (int)(Mathf.Pow(gameStates.ClickDmg,2)); //how much damage is done per click

    int                     enemiesDefeated         = gameStates.Kills;

    public Image            ImageComponent;
    public Sprite[]         enemies;

    public Image            poofImage;
    public Sprite[]         poofSprites;

    /// <summary>
    /// Initializes game objects
    /// </summary>
    void Start() {
        img_attackEffect.enabled    = false;
        poofImage.enabled           = false;

        //Update Game data
        fullHealth              = gameStates.FHealth;      
        currentHealth           = gameStates.CHealth;
        currentBits             = gameStates.Bits;
        currentMonsterDrop      = gameStates.MonsterDrops;
        dropCount               = gameStates.MDropCount;

        gameStates.UpdateDamage();
        gameStates.UpdateGoldBonus();

        InvokeRepeating("autoDamage", 1.0f, 2.0f); //start suto damage after one second. Performe every 2 sec

        }

    /// <summary>
    /// Called Once per Frame
    /// </summary>
    void Update() {

        /////////////////UI UPDATES////////////////
        //healthDisplay.text = "Health: " + currentHealth;
        healthDisplay.text              = "Health: " + (currentHealth * 300.000 / fullHealth) * 1.000;

        //killCountDisplay.text = "Enemies Defeated: " + enemiesDefeated;
        goldCountDisplay.text           = "Bits: " + currentBits;

        dropCountDisplay.text           = "Until MD: " + dropCount + "/100";
        monsterDropCountDisplay.text    = "Monster Drops: " + currentMonsterDrop;

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

        if (currentHealth <= 0) {
            enemiesDefeated += 1;


            if (enemiesDefeated == 10) {
                enemiesDefeated = 0; // reset enemies in order
                }

            currentHealth = fullHealth + (float)(fullHealth * 0.2);
            fullHealth = currentHealth;

			currentBits += (int)(fullHealth / baseHealth) * (int)(baseGold * gameStates.GoldIncrease);

            dropCount += (int)(currentHealth);
            if (dropCount >= 100) {
                currentMonsterDrop += 1;
                dropCount = 0;
                }

            poofImage.enabled = true;
            StartCoroutine(animatePoof());

            //change enemy image
            ImageComponent.sprite = enemies[enemiesDefeated];

            poofImage.enabled = false;

            }

        healthBar.sizeDelta = new Vector2((int)(currentHealth * 300 / fullHealth), healthBar.sizeDelta.y);
        }

    /// <summary>
    /// Performs actions when Button_enemy is clicked
    /// </summary>
    public void enemyClicked() {

        currentHealth -= damagePerClick; //enemy takes damage
        img_attackEffect.transform.position = Input.mousePosition; //set image to click location 
        StartCoroutine(Appear(img_attackEffect, 0.1F));

        }

    /// <summary>
    /// Performs actions when Button_ToTown is clicked
    /// </summary>
    public void toTownClicked() {

        // Save gave states

        //Currencies
        gameStates.Bits             = currentBits; // save current amount of bits
        gameStates.Chunks           = currentChunks; // save current amount of chunks

        //Health stats
        gameStates.FHealth          = (int)fullHealth; //saves previous full health
        gameStates.CHealth          = (int)currentHealth; //tracks current amount of monster health

        //Monster drops
        gameStates.MDropCount       = dropCount; //calculate to drop a monster drop every X amount of damage
        gameStates.MonsterDrops     = currentMonsterDrop; //amount of monster drops collected

        //Kill count
        gameStates.Kills            = enemiesDefeated; // number of monsters defeated

        SceneManager.LoadScene("Town", LoadSceneMode.Single);
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

    IEnumerator WaitForFrames(int frameCount) {
        if (frameCount <= 0) {

            throw new ArgumentOutOfRangeException("frameCount", "cannot wait for less than 1 frame");
            }
        while (frameCount > 0) {
            frameCount--;
            yield return null;
            }
        }

    IEnumerator animatePoof() {

        for (int i = 0; i < 6; i++) {

            poofImage.sprite = poofSprites[i];
            yield return new WaitForSeconds(0.1f);

        }
    }

    /// <summary>
    /// AUtomatically damage enemies
    /// </summary>
    /// <returns></returns>
    void autoDamage() {

        if (gameStates.TavernLvl > 1) { //only if the tavern has been upgraded
            currentHealth -= gameStates.AutoMDmg + gameStates.AutoPDmg;
        }

    }
}
