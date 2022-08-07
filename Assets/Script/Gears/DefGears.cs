using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefGears : MonoBehaviour
{
    private string defGear;

    public static bool isPlaced;
    public GameObject defLevel1Gear;

    public GameObject defLevel10Gear;

    // Start is called before the first frame update
    void Start()
    {
        defGear = PlayerPrefs.GetString("DefGear");
        Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
        switch (defGear)
        {
            case "lvl 1 def (equipmentObject)":
                var def1gear = Instantiate(defLevel1Gear, transform.position + add, Quaternion.identity) as GameObject;
                def1gear.transform.SetParent(GameObject.FindGameObjectWithTag("defGearSlot").transform, false);

                break;
            case "lvl 10 def (equipmentObject)":
                var def10gear = Instantiate(defLevel10Gear, transform.position + add, Quaternion.identity) as GameObject;
                def10gear.transform.SetParent(GameObject.FindGameObjectWithTag("defGearSlot").transform, false);

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
            defGear = PlayerPrefs.GetString("DefGear");
            Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
            switch (defGear)
            {
                case "lvl 1 def (equipmentObject)":
                    var def1gear = Instantiate(defLevel1Gear, transform.position + add, Quaternion.identity) as GameObject;
                    def1gear.transform.SetParent(GameObject.FindGameObjectWithTag("defGearSlot").transform, false);
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 2;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 10;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 2;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp + 2;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp + 10;
                    break;
                case "lvl 10 def (equipmentObject)":
                    var def10gear = Instantiate(defLevel10Gear, transform.position + add, Quaternion.identity) as GameObject;
                    def10gear.transform.SetParent(GameObject.FindGameObjectWithTag("defGearSlot").transform, false);
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 10;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 50;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 10;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp + 10;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp + 50;
                    break;

                case "":
                    break;
            }
        }
    }
}
