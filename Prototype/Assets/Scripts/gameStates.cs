﻿using System.Collections;
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
// -prestige level
// 
// </summary>
// 
public class gameStates : MonoBehaviour
{
    //Town Name
    private static string townName;

    //Last scene for store data
    private static int lastScene;

    //Dungeon states
    private static int kills, bits, chunks, monsterDrops, mDropCount, cHealth, fHealth;

    //Town States
    private static int apothecaryLvl, blacksmithLvl, tavernLvl, stableLvl, fortuneTellerLvl, wizardsTowerLvl, generalStoreLvl, tradingPostLvl, tailorLvl, guardPostLvl;

    //Town Initial Costs
    private static int blacksmithCost, tavernCost, apothecaryCost, stableCost, fortuneTellerCost, wizardsTowerCost, generalStoreCost, tradingPostCost, tailorCost, guardPostCost;

    //Building bonuses
    private static float clickDmg, autoPDmg, autoMDmg, goldIncrease;

    //Premium Bonuses
    private static float premiumDmg;

    // Home
    private static int cloth, hairColor, skinColor, faceShape;
    private static bool hairShort, changesMade;

    private static int prestigeLvl;

    /// <summary>
    /// Update Kills
    /// </summary>
	void Start() {

        //Sets a default town name
        townName = "Bittania";
        lastScene = 0; // 0 is going to be the store location

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
        stableLvl = 1;
        fortuneTellerLvl = 1;
        wizardsTowerLvl = 1;

        //premium buildings
        generalStoreLvl = 1;
        tradingPostLvl = 1;
        tailorLvl = 1;
        guardPostLvl = 1;


        prestigeLvl = 0;

        //Set starting building costs
        //Values are set in time without upgrades to achieve
        blacksmithCost = 10;
        tavernCost = 50;
        apothecaryCost = 200;
        stableCost = 440;
        wizardsTowerCost = 575;
        fortuneTellerCost = 720;
        generalStoreCost = 1400;
        tradingPostCost = 2000;
        tailorCost = 3600;
        guardPostCost = 5000;

        //Set starting bonuses
        //Values are all set to 100% aka 1 at start
        clickDmg = 1;
        autoPDmg = 1;
        autoMDmg = 1;
        goldIncrease = 1;

        //Set starting home stats
        cloth = 0;
        hairColor = 0;
        skinColor = 4;
        faceShape = 0;
        hairShort = true;
        changesMade = false;
    }

    /// <summary>
    /// Update town name
    /// </summary>
    public static string TownName {

        get {
            return townName;
        }

        set {
            townName = value;
        }
    }

    /// <summary>
    /// Update town name
    /// </summary>
    public static int LastScene {

        get {
            return lastScene;
        }

        set {
            lastScene = value;
        }
    }

    /// <summary>
    /// ////////////
    /// ////////////External Access Functions
    /// ////////////
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
    /// Update Monster Drop Count
    /// </summary>
    public static int MDropCount
    {

        get
        {
            return mDropCount;
        }

        set
        {
            mDropCount = value;
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
    /// Update Stable Level
    /// </summary>
    public static int StableLvl
    {
        get
        {
            return stableLvl;
        }
        set
        {
            stableLvl = value;
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
    /// Update Wizard Tower Level
    /// </summary>
    public static int WizardsTowerLvl
    {
        get
        {
            return wizardsTowerLvl;
        }
        set
        {
            wizardsTowerLvl = value;
        }

    }

    /// <summary>
    /// Update General Store Level
    /// </summary>
    public static int GeneralStoreLvl
    {
        get
        {
            return generalStoreLvl;
        }
        set
        {
            generalStoreLvl = value;
        }
    }


    /// <summary>
    /// Update Trading Post Level
    /// </summary>
    public static int TradingPostLvl
    {
        get
        {
            return tradingPostLvl;
        }
        set
        {
            tradingPostLvl = value;
        }

    }

    /// <summary>
    /// Update Guard Post Level
    /// </summary>
    public static int GuardPostLvl
    {
        get
        {
            return guardPostLvl;
        }
        set
        {
            guardPostLvl = value;
        }

    }

    /// <summary>
    /// Update Tailor Level
    /// </summary>
    public static int TailorLvl
    {
        get
        {
            return tailorLvl;
        }
        set
        {
            tailorLvl = value;
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
    /// Update Tavern Cost
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
    /// Update stableCost
    /// </summary>
    public static int StableCost
    {

        get
        {
            return stableCost;
        }

        set
        {
            stableCost = value;
        }
    }

    /// <summary>
    /// Update wizardsTowerCost
    /// </summary>
    public static int WizardsTowerCost
    {

        get
        {
            return wizardsTowerCost;
        }

        set
        {
            wizardsTowerCost = value;
        }
    }

    /// <summary>
    /// Update generalStoreCost
    /// </summary>
    public static int GeneralStoreCost
    {

        get
        {
            return generalStoreCost;
        }

        set
        {
            generalStoreCost = value;
        }
    }

    /// <summary>
    /// Update tradingPostCost
    /// </summary>
    public static int TradingPostCost
    {

        get
        {
            return tradingPostCost;
        }

        set
        {
            tradingPostCost = value;
        }
    }

    /// <summary>
    /// Update tailorCost
    /// </summary>
    public static int TailorCost
    {

        get
        {
            return tailorCost;
        }

        set
        {
            tailorCost = value;
        }
    }

    /// <summary>
    /// Update guardPostCost
    /// </summary>
    public static int GuardPostCost
    {

        get
        {
            return guardPostCost;
        }

        set
        {
            guardPostCost = value;
        }
    }

    // <summary>
    // Update Prestige Level
    // </summary>
    public static int PrestigeLvl
    {

        get
        {
            return prestigeLvl;
        }

        set
        {
            prestigeLvl = value;
        }
    }
    /// <summary>
    /// Update clickDmg
    /// </summary>
    public static float ClickDmg {

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
    public static float AutoPDmg {

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
    public static float AutoMDmg {

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
    public static float GoldIncrease {

        get {
            return goldIncrease;
        }

        set {
            goldIncrease = value;
        }
    }

    /// <summary>
	/// Update cloth
	/// </summary>
	public static int Cloth
    {

        get
        {
            return cloth;
        }

        set
        {
            cloth = value;
        }
    }

    /// <summary>
	/// Update hair colour
	/// </summary>
	public static int HairColor
    {

        get
        {
            return hairColor;
        }

        set
        {
            hairColor = value;
        }
    }

    /// <summary>
    /// Update hair shape
    /// </summary>
    public static bool HairShort
    {

        get
        {
            return hairShort;
        }

        set
        {
            hairShort = value;
        }
    }

    /// <summary>
	/// Update skin colour
	/// </summary>
	public static int SkinColor
    {

        get
        {
            return skinColor;
        }

        set
        {
            skinColor = value;
        }
    }

    /// <summary>
    /// Update hair shape
    /// </summary>
    public static bool ChangesMade
    {

        get
        {
            return changesMade;
        }

        set
        {
            changesMade = value;
        }
    }

    /// <summary>
	/// Update skin colour
	/// </summary>
	public static int FaceShape
    {

        get
        {
            return faceShape;
        }

        set
        {
            faceShape = value;
        }
    }

    /// <summary>
    /// Premium damage bonus from resetting the game
    /// </summary>
    public static float PremiumDmg {
    
        get {
            return premiumDmg;
        }

        set {
            premiumDmg = value;
        }

    }
    ///////////////////////
    /// Damage Calculations
    ///////////////////////

    public static void UpdateDamage() {

        ///////
        /////// Calculate Click Damage
        ///////
        float tempD = 2 * (0.1f * (blacksmithLvl)); // base dmg * dmg multiplier
        clickDmg = 2 + tempD;


        ///////
        /////// Calculate Physical Auto Damage
        ///////
        float tempPD = 2 * (0.5f * (tavernLvl)); // base dmg * dmg multiplier
        autoPDmg = 1 + tempPD;

    }

    public static void UpdatePremiumDamage()
    {
        //float tempPBonus = 2 * ( 0.1f * (prestigeLvl) ); // base dmg * dmg multiplier
        float tempPBonus = 2 + prestigeLvl;
        clickDmg += tempPBonus;
        autoPDmg += tempPBonus;
    }

    ///////////////////////////
    /// Gold Bonus Calculations
    ///////////////////////////
    public static void UpdateGoldBonus() {

        float tempSmallGB = 2 * (0.01f * (fortuneTellerLvl)); // base gold * gold multiplier
        goldIncrease = 1 + tempSmallGB;

    }

    //end
}
