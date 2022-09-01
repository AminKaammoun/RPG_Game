using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class playerData 

{
    public float health;
    public int coins;
    public int diamonds ;
    public int level;
    public int xp;

    public playerData(GameController player)
    {
        coins = GameController.coins;
        diamonds = GameController.diamonds;
        health = PlayerMovements.health;
        level = GameController.level.currentLevel;
        xp = GameController.level.experience;
    }

}
