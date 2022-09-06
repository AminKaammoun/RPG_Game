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
    public int skill1Level;
    public int skill2Level;
    public int skill3Level;
    public int skill4Level;
    public int skill5Level;
    public int skillPoints;
    public int CurrentSkill;

    public playerData(GameController player)
    {
        coins = GameController.coins;
        diamonds = GameController.diamonds;
        health = PlayerMovements.health;
        level = GameController.level.currentLevel;
        xp = GameController.level.experience;
        skill1Level = GameController.skill1Level;
        skill2Level = GameController.skill2Level;
        skill3Level = GameController.skill3Level;
        skill4Level = GameController.skill4Level;
        skill5Level = GameController.skill5Level;
        skillPoints = GameController.skillPoint;
        CurrentSkill = GameController.currentSkill;
    }

}
