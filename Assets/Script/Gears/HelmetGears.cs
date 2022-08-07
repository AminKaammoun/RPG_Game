using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelmetGears : MonoBehaviour
{
    private string helmetGear;

    public static bool isPlaced;
    public GameObject helLevel1Gear;
    public GameObject helLevel10Gear;
    // Start is called before the first frame update
    void Start()
    {
        helmetGear = PlayerPrefs.GetString("HelmetGear");
        Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
        switch (helmetGear)
        {
            case "lvl 1 helmet (equipmentObject)":
                var hel1gear = Instantiate(helLevel1Gear, transform.position + add, Quaternion.identity) as GameObject;
                hel1gear.transform.SetParent(GameObject.FindGameObjectWithTag("helGearSlot").transform, false);

                break;
            case "lvl 10 helmet (equipmentObject)":
                var hel10gear = Instantiate(helLevel10Gear, transform.position + add, Quaternion.identity) as GameObject;
                hel10gear.transform.SetParent(GameObject.FindGameObjectWithTag("helGearSlot").transform, false);

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
            helmetGear = PlayerPrefs.GetString("HelmetGear");
            Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
            switch (helmetGear)
            {
                case "lvl 1 helmet (equipmentObject)":
                    var hel1gear = Instantiate(helLevel1Gear, transform.position + add, Quaternion.identity) as GameObject;
                    hel1gear.transform.SetParent(GameObject.FindGameObjectWithTag("helGearSlot").transform, false);
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 3;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 4;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 10;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp + 2;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp + 8;
                    break;
                case "lvl 10 helmet (equipmentObject)":
                    var hel10gear = Instantiate(helLevel10Gear, transform.position + add, Quaternion.identity) as GameObject;
                    hel10gear.transform.SetParent(GameObject.FindGameObjectWithTag("helGearSlot").transform, false);
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 15;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 20;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 50;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp + 10;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp + 40;
                    break;
                case "":
                    break;
            }
        }
    }
}
