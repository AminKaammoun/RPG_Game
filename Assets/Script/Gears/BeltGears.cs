using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltGears : MonoBehaviour
{
    private string beltGear;

    public static bool isPlaced;
    public GameObject beltLevel1Gear;
    public GameObject beltLevel10Gear;
    void Start()
    {
        beltGear = PlayerPrefs.GetString("BeltGear");
        Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
        switch (beltGear)
        {
            case "lvl 1 belt (equipmentObject)":
                var belt1gear = Instantiate(beltLevel1Gear, transform.position + add, Quaternion.identity) as GameObject;
                belt1gear.transform.SetParent(GameObject.FindGameObjectWithTag("beltGearSlot").transform, false);

                break;
            case "lvl 10 belt (equipmentObject)":
                var belt10gear = Instantiate(beltLevel10Gear, transform.position + add, Quaternion.identity) as GameObject;
                belt10gear.transform.SetParent(GameObject.FindGameObjectWithTag("beltGearSlot").transform, false);

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
            beltGear = PlayerPrefs.GetString("BeltGear");
            Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
            switch (beltGear)
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

                    break;

                case "":
                    break;
            }
        }
    }
}
