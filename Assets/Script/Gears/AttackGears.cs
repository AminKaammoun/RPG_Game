using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackGears : MonoBehaviour
{

    public static bool isPlaced;
  
    public GameObject atkLevel1Gear;
    public GameObject atkLevel10Gear;

 

    // Start is called before the first frame update
    void Start()
    {

       
        Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
        switch (GameController.attackGear)
        {
            case "lvl 1 attack (equipmentObject)":
                var atk1gear = Instantiate(atkLevel1Gear, transform.position + add, Quaternion.identity) as GameObject;
                atk1gear.transform.SetParent(GameObject.FindGameObjectWithTag("atkGearSlot").transform, false);

                break;
            case "lvl 10 attack (equipmentObject)":
                var atk10gear = Instantiate(atkLevel10Gear, transform.position + add, Quaternion.identity) as GameObject;
                atk10gear.transform.SetParent(GameObject.FindGameObjectWithTag("atkGearSlot").transform, false);

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
            switch (GameController.attackGear)
            {
                case "lvl 1 attack (equipmentObject)":
                    var atkgear = Instantiate(atkLevel1Gear, transform.position + add, Quaternion.identity) as GameObject;
                    atkgear.transform.SetParent(GameObject.FindGameObjectWithTag("atkGearSlot").transform, false);
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 10;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 5;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 3;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp + 2;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp + 5;
                    break;
                case "lvl 10 attack (equipmentObject)":
                    var atk10gear = Instantiate(atkLevel10Gear, transform.position + add, Quaternion.identity) as GameObject;
                    atk10gear.transform.SetParent(GameObject.FindGameObjectWithTag("atkGearSlot").transform, false);
                    PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 50;
                    PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 25;
                    PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 15;
                    PlayerMovements.BonusSp = PlayerMovements.BonusSp + 10;
                    PlayerMovements.BonusHp = PlayerMovements.BonusHp + 25;
                    break;

            }
        }

        
    }
}
