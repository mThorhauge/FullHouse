using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 
/// A static class to keep track of player inventory and game states between scenes
/// 
///  -bits
///  -chuncks
///  -monsterdrops
///  -buffs
/// -current health
/// -total defeated
/// 
/// </summary>
/// 
public class gameStates : MonoBehaviour
{

    //Dungeon states
    private static int kills, bits, chunks, monsterDrops, cHealth, fHealth;

    //Town States
    private static int apothecaryLvl, blacksmithLvl, tavernLvl, fortuneTellerLvl;

    /// <summary>
    /// Update Kills
    /// </summary>
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

    }

