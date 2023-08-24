using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class farmData 
{
    public List<GameObject> plants = new List<GameObject>();
    public List<Vector3> positions = new List<Vector3>();
    public List<float> plantStates = new List<float>();
    public farmData(GameController player)
    {
       // plants = GameController.plants;
       // positions = GameController.positions;
       // plantStates = GameController.plantStates;
    }
    
}
