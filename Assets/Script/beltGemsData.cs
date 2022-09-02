using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class beltGemsData
{
    public string beltRedGem;
    public string beltBlueGem;
    public string beltYellowGem;
    public string beltOrangeGem;
    public string beltGreenGem;
    public beltGemsData(GameController player)
    {
        beltRedGem = GameController.beltRedGem;
        beltBlueGem = GameController.beltBlueGem;
        beltYellowGem = GameController.beltYellowGem;
        beltOrangeGem = GameController.beltOrangeGem;
        beltGreenGem = GameController.beltGreenGem;
    }

}
