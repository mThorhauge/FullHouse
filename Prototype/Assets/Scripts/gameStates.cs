using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// <summary>
// 
// A static class to keep track of player inventory and game states between scenes
// 
//  -bits
//  -chuncks
//  -monsterdrops
//  -buffs
// -current health
// -total defeated
// 
// </summary>
// 
public class gameStates : MonoBehaviour
{
	

    //Dungeon states
    private static int kills, bits, chunks, monsterDrops, cHealth, fHealth;

    //Town States
    private static int apothecaryLvl, blacksmithLvl, tavernLvl, fortuneTellerLvl;

	//Town Initial Costs
	private static int blacksmithCost, tavernCost, apothecaryCost, fortuneTellerCost;

	//Building bonuses
	private static int clickDmg, autoPDmg, autoMDmg, goldIncrease;

    /// <summary>
    /// Update Kills
    /// </summary>
	void Start () {


		////Set the gameStates to proper values
		/// will need to use save file data in future
		kills = 0;
		bits = 0;
		chunks = 0;
		monsterDrops = 0;
		cHealth = 5;
		fHealth = 5;

		apothecaryLvl = 1;
		blacksmithLvl = 1;
		tavernLvl = 1;
		fortuneTellerLvl = 1;

		//Set starting building costs
		//Values are set in time without upgrades to achieve
		blacksmithCost = 10;
		tavernCost = 50;
		apothecaryCost = 200;
		fortuneTellerCost = 720;

		//Set starting bonuses
		//Values are all set to 100% aka 1 at start
		clickDmg = 1;
		autoPDmg = 1;
		autoMDmg = 1;
		goldIncrease = 1;

	}
		

	public static int Kills {

        get {
            return kills;
        }

        set {
            kills = value;
        }
    }

    /// <summary>
    /// Update Bits
    /// </summary>
    public static int Bits {

        get {
            return bits;
        }

        set {
            bits = value;
        }
    }

    /// <summary>
    /// Update Chunks 
    /// </summary>
    public static int Chunks {

        get {
            return chunks;
        }

        set {
            chunks = value;
        }
    }

    /// <summary>
    /// Update Monster Drops
    /// </summary>
    public static int MonsterDrops {

        get {
            return monsterDrops;
        }

        set {
            monsterDrops = value;
        }
    }

    /// <summary>
    /// Update Monster current health
    /// </summary>
    public static int CHealth {

        get {
            return cHealth;
            }

        set {
            cHealth = value;
            }
        }

    /// <summary>
    /// Update Monster full Health
    /// </summary>
    public static int FHealth {

        get {
            return fHealth;
            }

        set {
            fHealth = value;
            }
        }

    /// <summary>
    /// Update Apothecary Level
    /// </summary>
    public static int ApothecaryLvl {

        get {
            return apothecaryLvl;
            }
        set {
            apothecaryLvl = value;
            }
        }

    /// <summary>
    /// Update Blacksmith Level
    /// </summary>
    public static int BlacksmithLvl {
        get {
            return blacksmithLvl;
            }
        set {
            blacksmithLvl = value;
            }
        }

    /// <summary>
    /// Update Tavern Level
    /// </summary>
    public static int TavernLvl {
        get {
            return tavernLvl;
            }
        set {
            tavernLvl = value;
            }

        }

    /// <summary>
    /// Fortune Teller Level
    /// </summary>
    public static int FortuneTellerLvl {
        get {
            return fortuneTellerLvl;
            }
        set {
            fortuneTellerLvl = value;
            }

        }

	/// <summary>
	/// Update Blacksmith Cost
	/// </summary>
	public static int BlacksmithCost {

		get {
			return blacksmithCost;
		}

		set {
			blacksmithCost = value;
		}
	}
	/// <summary>
	/// Update tavernCost
	/// </summary>
	public static int TavernCost {

		get {
			return tavernCost;
		}

		set {
			tavernCost = value;
		}
	}
	/// <summary>
	/// Update apothecaryCost
	/// </summary>
	public static int ApothecaryCost {

		get {
			return apothecaryCost;
		}

		set {
			apothecaryCost = value;
		}
	}
	/// <summary>
	/// Update fortuneTellerCost
	/// </summary>
	public static int FortuneTellerCost {

		get {
			return fortuneTellerCost;
		}

		set {
			fortuneTellerCost = value;
		}
	}

	/// <summary>
	/// Update clickDmg
	/// </summary>
	public static int ClickDmg {

		get {
			return clickDmg;
		}

		set {
			clickDmg = value;
		}
	}
	/// <summary>
	/// Update autoPDmg
	/// </summary>
	public static int AutoPDmg {

		get {
			return autoPDmg;
		}

		set {
			autoPDmg = value;
		}
	}

	/// <summary>
	/// Update autoMDmg
	/// </summary>
	public static int AutoMDmg {

		get {
			return autoMDmg;
		}

		set {
			autoMDmg = value;
		}
	}

	/// <summary>
	/// Update goldIncrease
	/// </summary>
	public static int GoldIncrease {

		get {
			return goldIncrease;
		}

		set {
			goldIncrease = value;
		}
	}

	//end
    }
