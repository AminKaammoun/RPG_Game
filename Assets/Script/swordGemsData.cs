using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class swordGemsData
{
    public string swordRedGem;
    public string swordBlueGem;
    public string swordYellowGem;
    public string swordOrangeGem;
    public string swordGreenGem;
    public swordGemsData(GameController player)
    {
        swordRedGem = GameController.swordRedGem;
        swordBlueGem = GameController.swordBlueGem;
        swordYellowGem = GameController.swordYellowGem;
        swordOrangeGem = GameController.swordOrangeGem;
        swordGreenGem = GameController.swordGreenGem;
    }
}
