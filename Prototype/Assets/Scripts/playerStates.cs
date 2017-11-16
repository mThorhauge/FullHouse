using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 
/// A static class to keep track of player inventory and states between scenes
/// 
///  -kills
///  -bits
///  -chuncks
///  -monsterdrops
///  
/// </summary>
public class playerStates : MonoBehaviour {

    private static int kills, bits, chunks, monsterDrops;


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
}
