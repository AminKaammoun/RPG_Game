using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingGears : MonoBehaviour
{
    public static bool isPlaced;
    public GameObject ringLevel1Gear;
    public GameObject ringLevel10Gear;
    // Start is called before the first frame update
    void Start()
    {
       
        Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
        switch (GameController.ringGear)
        {
            case "lvl 1 ring (equipmentObject)":
                var ring1gear = Instantiate(ringLevel1Gear, transform.position + add, Quaternion.identity) as GameObject;
                ring1gear.transform.SetParent(GameObject.FindGameObjectWithTag("ringGearSlot").transform, false);

                break;
            case "lvl 10 ring (equipmentObject)":
                var ring10gear = Instantiate(ringLevel10Gear, transform.position + add, Quaternion.identity) as GameObject;
                ring10gear.transform.SetParent(GameObject.FindGameObjectWithTag("ringGearSlot").transform, false);

                break;

            case "":
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaced)
        {
            isPlaced = false;
          
            Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
            switch (GameController.ringGear)
            {
                case "lvl 1 ring (equipmentObject)":
                    var ring1gear = Instantiate(ringLevel1Gear, transform.position + add, Quaternion.identity) as GameObject;
                    ring1gear.transform.SetParent(GameObject.FindGameObjectWithTag("ringGearSlot").transform, false);
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 2;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 4;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 2;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp + 3;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp + 50;
                    break;
                case "lvl 10 ring (equipmentObject)":
                    var ring10gear = Instantiate(ringLevel10Gear, transform.position + add, Quaternion.identity) as GameObject;
                    ring10gear.transform.SetParent(GameObject.FindGameObjectWithTag("ringGearSlot").transform, false);
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 10;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 20;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 10;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp + 15;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp + 250;
                    break;
                case "":
                    break;
            }
        }
    }
}
