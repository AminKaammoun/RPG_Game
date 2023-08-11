using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltGears : MonoBehaviour
{
  
    public static bool isPlaced;
    public GameObject beltLevel1Gear;
    public GameObject beltLevel10Gear;
    public GameObject beltLevel20Gear;
    void Start()
    {
        
        Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
        switch (GameController.beltGear)
        {
            case "lvl 1 belt (equipmentObject)":
                var belt1gear = Instantiate(beltLevel1Gear, transform.position + add, Quaternion.identity) as GameObject;
                belt1gear.transform.SetParent(GameObject.FindGameObjectWithTag("beltGearSlot").transform, false);

                break;
            case "lvl 10 belt (equipmentObject)":
                var belt10gear = Instantiate(beltLevel10Gear, transform.position + add, Quaternion.identity) as GameObject;
                belt10gear.transform.SetParent(GameObject.FindGameObjectWithTag("beltGearSlot").transform, false);

                break;

            case "lvl 20 belt (equipmentObject)":
                var belt20gear = Instantiate(beltLevel20Gear, transform.position + add, Quaternion.identity) as GameObject;
                belt20gear.transform.SetParent(GameObject.FindGameObjectWithTag("beltGearSlot").transform, false);

                break;

            case "":
                break;
        }
    }
    void Update()
    {
        if (isPlaced)
        {
            isPlaced = false;
           
            Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
            switch (GameController.beltGear)
            {
                case "lvl 1 belt (equipmentObject)":
                    var hel1gear = Instantiate(beltLevel1Gear, transform.position + add, Quaternion.identity) as GameObject;
                    hel1gear.transform.SetParent(GameObject.FindGameObjectWithTag("beltGearSlot").transform, false);
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 3;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 6;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 3;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp + 10;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp + 7;
                    break;
                case "lvl 10 belt (equipmentObject)":
                    var belt10gear = Instantiate(beltLevel10Gear, transform.position + add, Quaternion.identity) as GameObject;
                    belt10gear.transform.SetParent(GameObject.FindGameObjectWithTag("beltGearSlot").transform, false);
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 15;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 30;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 15;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp + 50;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp + 35;
                    break;
                case "lvl 20 belt (equipmentObject)":
                    var belt20gear = Instantiate(beltLevel20Gear, transform.position + add, Quaternion.identity) as GameObject;
                    belt20gear.transform.SetParent(GameObject.FindGameObjectWithTag("beltGearSlot").transform, false);
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 75;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 150;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 75;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp + 250;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp + 175;
                    break;

                case "":
                    break;
            }
        }
    }
}
