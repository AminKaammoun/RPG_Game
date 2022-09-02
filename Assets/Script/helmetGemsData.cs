using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class helmetGemsData
{
    public string helmetRedGem;
    public string helmetBlueGem;
    public string helmetYellowGem;
    public string helmetOrangeGem;
    public string helmetGreenGem;
    public helmetGemsData(GameController player)
    {
        helmetRedGem = GameController.helmetRedGem;
        helmetBlueGem = GameController.helmetBlueGem;
        helmetYellowGem = GameController.helmetYellowGem;
        helmetOrangeGem = GameController.helmetOrangeGem;
        helmetGreenGem = GameController.helmetGreenGem;
    }
}
