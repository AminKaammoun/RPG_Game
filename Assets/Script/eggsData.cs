using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class eggsData
{
    public int[] nestLevel = new int[3];
    public int[] eggType = new int[3];
    public int[] requiredEggs = new int[3];

    public eggsData(GameController player)
    {
        nestLevel[0] = eggShop.nestLevel[0];
        nestLevel[1] = eggShop.nestLevel[1];
        nestLevel[2] = eggShop.nestLevel[2];
       
        eggType[0] = eggShop.eggType[0];
        eggType[1] = eggShop.eggType[1];
        eggType[2] = eggShop.eggType[2];

        requiredEggs[0] = eggShop.requiredEggs[0];
        requiredEggs[1] = eggShop.requiredEggs[1];
        requiredEggs[2] = eggShop.requiredEggs[2];

    }
}
