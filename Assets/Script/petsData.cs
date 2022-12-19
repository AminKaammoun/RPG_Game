using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

//0 : name / 1 : level / 2 : xp / 3 : MaxXpNeeded / 4 : stars / 5 : BaseAtk / 6 : BaseDef / 7 : BaseSp / 8 : BaseAgi / 9 : BaseHp / 10: stats points /11 : BonusAtk / 12 : BonusDef / 13 : BonusSp / 14 : BonusAgi / 15 : BonusHp
public class petsData 
{
    public int usedPetListIndex;

    public string[] petName = new string[12];
    public string[] petLevel = new string[12];
    public string[] xp = new string[12];
    public string[] maxXp= new string[12];
    public string[] stars = new string[12];
    public string[] BaseAtk = new string[12];
    public string[] BaseDef = new string[12];
    public string[] BaseSp = new string[12];
    public string[] BaseAgi = new string[12];
    public string[] BaseHp = new string[12];
    public string[] statsPoint = new string[12];
    public string[] BonusAtk = new string[12];
    public string[] BonusDef = new string[12];
    public string[] BonusSp = new string[12];
    public string[] BonusAgi = new string[12];
    public string[] BonusHp = new string[12];
    public string[] Element = new string[12];
    public int length;
    public int index;

    public string[] usedPetName = new string[3];
    public string[] usedPetLevel = new string[3];
    public string[] usedXp = new string[3];
    public string[] usedMaxXp = new string[3];
    public string[] usedStars = new string[3];
    public string[] usedBaseAtk = new string[3];
    public string[] usedBaseDef = new string[3];
    public string[] usedBaseSp = new string[3];
    public string[] usedBaseAgi = new string[3];
    public string[] usedBaseHp = new string[3];
    public string[] usedStatsPoint = new string[3];
    public string[] usedBonusAtk = new string[3];
    public string[] usedBonusDef = new string[3];
    public string[] usedBonusSp = new string[3];
    public string[] usedBonusAgi = new string[3];
    public string[] usedBonusHp = new string[3];
    public string[] usedElement = new string[3];
    public string[] usedImage = new string[3];

    public petsData(GameController player)
    {
        usedPetListIndex = eggShop.usedPetListIndex;
        for (int i = 1; i <= eggShop.usedPetList.Count; i++)
        {

            usedPetName[i - 1] = eggShop.usedPetList[i][0];
            usedPetLevel[i - 1] = eggShop.usedPetList[i][1];
            usedXp[i - 1] = eggShop.usedPetList[i][2];
            usedMaxXp[i - 1] = eggShop.usedPetList[i][3];
            usedStars[i - 1] = eggShop.usedPetList[i][4];
            usedBaseAtk[i - 1] = eggShop.usedPetList[i][5];
            usedBaseDef[i - 1] = eggShop.usedPetList[i][6];
            usedBaseSp[i - 1] = eggShop.usedPetList[i][7];
            usedBaseAgi[i - 1] = eggShop.usedPetList[i][8];
            usedBaseHp[i - 1] = eggShop.usedPetList[i][9];
            usedStatsPoint[i - 1] = eggShop.usedPetList[i][10];
            usedBonusAtk[i - 1] = eggShop.usedPetList[i][11];
            usedBonusDef[i - 1] = eggShop.usedPetList[i][12];
            usedBonusSp[i - 1] = eggShop.usedPetList[i][13];
            usedBonusAgi[i - 1] = eggShop.usedPetList[i][14];
            usedBonusHp[i - 1] = eggShop.usedPetList[i][15];
            usedElement[i - 1] = eggShop.usedPetList[i][16]; 
        }
        length = GameController.petList.Count;
        for (int i =1;i<= GameController.petList.Count; i++)
        {
            petName[i-1] = GameController.petList[i][0];
            petLevel[i-1] = GameController.petList[i][1];
            xp[i-1] = GameController.petList[i][2];
            maxXp[i-1] = GameController.petList[i][3];
            stars[i-1] = GameController.petList[i][4];
            BaseAtk[i-1] = GameController.petList[i][5];
            BaseDef[i-1] = GameController.petList[i][6];
            BaseSp[i-1] = GameController.petList[i][7];
            BaseAgi[i-1] = GameController.petList[i][8];
            BaseHp[i-1] = GameController.petList[i][9];
            statsPoint[i-1] = GameController.petList[i][10];
            BonusAtk[i-1] = GameController.petList[i][11];
            BonusDef[i-1] = GameController.petList[i][12];
            BonusSp[i-1] = GameController.petList[i][13];
            BonusAgi[i-1] = GameController.petList[i][14];
            BonusHp[i-1] = GameController.petList[i][15];
            Element[i - 1] = GameController.petList[i][16];
        }
    }
    
}
