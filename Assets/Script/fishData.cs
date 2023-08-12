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

    public bool Fish11Discovered;
    public bool Fish12Discovered;
    public bool Fish13Discovered;
    public bool Fish14Discovered;
    public bool Fish15Discovered;

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

        Fish11Discovered = GameController.Fish11Discovered;
        Fish12Discovered = GameController.Fish12Discovered;
        Fish13Discovered = GameController.Fish13Discovered;
        Fish14Discovered = GameController.Fish14Discovered;
        Fish15Discovered = GameController.Fish15Discovered;
    }

}
