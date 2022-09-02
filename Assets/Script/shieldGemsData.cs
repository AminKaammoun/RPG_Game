using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class shieldGemsData
{
    public string shieldRedGem;
    public string shieldBlueGem;
    public string shieldYellowGem;
    public string shieldOrangeGem;
    public string shieldGreenGem;
    public shieldGemsData(GameController player)
    {
        shieldRedGem = GameController.shieldRedGem;
        shieldBlueGem = GameController.shieldBlueGem;
        shieldYellowGem = GameController.shieldYellowGem;
        shieldOrangeGem = GameController.shieldOrangeGem;
        shieldGreenGem = GameController.shieldGreenGem;
    }
}
