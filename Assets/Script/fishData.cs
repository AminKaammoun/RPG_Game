using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class fishData
{
    public bool Fish1Discovered;
    public bool Fish2Discovered;
    public bool Fish3Discovered;
    public bool Fish4Discovered;
    public bool Fish5Discovered;

    public bool Fish6Discovered;
    public bool Fish7Discovered;
    public bool Fish8Discovered;
    public bool Fish9Discovered;
    public bool Fish10Discovered;

    public fishData(GameController player)
    {
        Fish1Discovered = GameController.Fish1Discovered;
        Fish2Discovered = GameController.Fish2Discovered;
        Fish3Discovered = GameController.Fish3Discovered;
        Fish4Discovered = GameController.Fish4Discovered;
        Fish5Discovered = GameController.Fish5Discovered;

        Fish6Discovered = GameController.Fish6Discovered;
        Fish7Discovered = GameController.Fish7Discovered;
        Fish8Discovered = GameController.Fish8Discovered;
        Fish9Discovered = GameController.Fish9Discovered;
        Fish10Discovered = GameController.Fish10Discovered;
    }

}
