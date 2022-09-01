using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class gearData 
{
    public string attackGear;
    public string defGear;
    public string beltGear;
    public string helmetGear;
    public string ringGear;

    public gearData(GameController player)
    {
        attackGear = GameController.attackGear;
        defGear = GameController.defGear;
        beltGear = GameController.beltGear;
        helmetGear = GameController.helmetGear;
        ringGear = GameController.ringGear;
    }
}
