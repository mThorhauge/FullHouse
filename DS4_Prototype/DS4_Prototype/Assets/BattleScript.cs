
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class BattleScript : MonoBehaviour {

    public UnityEngine.UI.Text healthDisplay;
    public UnityEngine.UI.Text killCountDisplay;
	public UnityEngine.UI.Text goldCountDisplay;
	public UnityEngine.UI.Text monsterDropCountDisplay;
	public UnityEngine.UI.Text dropCountDisplay;

    public int baseHealth = 5; //health base number
	public int baseGold = 1; //how much gold each monster drops to start

    int fullHealth = 5; //saves previous full health
    int currentHealth = 5; //tracks current amount of monster health
	int currentGold = 0; //tracks current amount of gold

	int dropCount = 0; //calculate to drop a monster drop every X amount of damage
	int currentMonsterDrop = 0; //total of monster drops

    public int damagePerClick = 1; //how much damage is done per click

    int enemiesDefeated;
	
	// Update is called once per frame
	void Update () {
        healthDisplay.text = "Health: " + currentHealth;
        killCountDisplay.text = "Enemies Defeated: " + enemiesDefeated;
		goldCountDisplay.text = "Gold: " + currentGold;

		dropCountDisplay.text = "Until MD: " + dropCount + "/100";
		monsterDropCountDisplay.text = "Monster Drops: "+ currentMonsterDrop;

        if (currentHealth <= 0)
        {
            enemiesDefeated += 1;
            currentHealth = fullHealth + (int)(fullHealth * 0.2);
            fullHealth = currentHealth;

			currentGold += (int)(fullHealth / baseHealth) * baseGold;

			dropCount += currentHealth;
			if(dropCount >= 100)
			{
				currentMonsterDrop += 1;
				dropCount = 0;
			}
        }
	}

    public void Clicked()
    {

        currentHealth -= damagePerClick;

    }
}
