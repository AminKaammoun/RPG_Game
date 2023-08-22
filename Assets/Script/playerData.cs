using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class playerData 

{
    public float health;
    public int coins;
    public int diamonds;
    public int level;
    public int xp;
    public int miningLevel;
    public int miningXp;
    public int harvastLevel;
    public int harvastXp;
    public int huntingLevel;
    public int huntingXp;
    public int fishingLevel;
    public int fishingXp;
    public int farmingLevel;
    public int farmingXp;
    public int skill1Level;
    public int skill2Level;
    public int skill3Level;
    public int skill4Level;
    public int skill5Level;
    public int skillPoints;
    public int CurrentSkill;
    public string ability1;
    public string ability2;
    public string ability3;
    public string petName;
    

    public playerData(GameController player)
    {
        coins = GameController.coins;
        
        diamonds = GameController.diamonds;
        health = PlayerMovements.health;
       
        level = GameController.level.currentLevel;
        xp = GameController.level.experience;
        //level = 1;
        //xp = 0;
        if(level == 0)
        {
            level = 1;
        }

        miningLevel = GameController.miningLevel.currentLevel;
        miningXp = GameController.miningLevel.experience;
        //miningLevel = 1;
        //miningXp = 0;
        if(miningLevel == 0)
        {
            miningLevel = 1;
        }

        harvastLevel = GameController.harvestingLevel.currentLevel;
        harvastXp = GameController.harvestingLevel.experience;
        //harvastLevel = 1;
        //harvastXp = 0;
        if (harvastLevel == 0)
        {
            harvastLevel = 1;
        }

        huntingLevel = GameController.huntingLevel.currentLevel;
        huntingXp = GameController.huntingLevel.experience;
        //huntingLevel = 1;
        //huntingXp = 0;
        if(huntingLevel == 0)
        {
            huntingLevel = 1;
        }

        fishingLevel = GameController.fishingLevel.currentLevel;
        fishingXp = GameController.fishingLevel.experience;
        //fishingLevel = 1;
        //fishingXp = 0;
        if(fishingLevel == 0)
        {
            fishingLevel = 1;
        }

        farmingLevel = GameController.farmingLevel.currentLevel;
        farmingXp = GameController.farmingLevel.experience;
        //fishingLevel = 1;
        //fishingXp = 0;
        if (farmingLevel == 0)
        {
            farmingLevel = 1;
        }

        skill1Level = GameController.skill1Level;
        skill2Level = GameController.skill2Level;
        skill3Level = GameController.skill3Level;
        skill4Level = GameController.skill4Level;
        skill5Level = GameController.skill5Level;
       
        skillPoints = GameController.skillPoint;
        //skillPoints = 100;
        CurrentSkill = GameController.currentSkill;

        ability1 = GameController.ability1;
        ability2 = GameController.ability2;
        ability3 = GameController.ability3;

        petName = GameController.petName;
    }

}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   