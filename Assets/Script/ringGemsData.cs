using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ringGemsData
{
    public string ringRedGem;
    public string ringBlueGem;
    public string ringYellowGem;
    public string ringOrangeGem;
    public string ringGreenGem;
    public ringGemsData(GameController player)
    {
        ringRedGem = GameController.ringRedGem;
        ringBlueGem = GameController.ringBlueGem;
        ringYellowGem = GameController.ringYellowGem;
        ringOrangeGem = GameController.ringOrangeGem;
        ringGreenGem = GameController.ringGreenGem;
    }
}
