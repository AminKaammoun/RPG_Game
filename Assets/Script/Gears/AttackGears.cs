using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackGears : MonoBehaviour
{

    private string attackGear;

    public static bool isPlaced;
    public GameObject atkLevel1Gear;
    public GameObject atkLevel10Gear;

    // Start is called before the first frame update
    void Start()
    {

        attackGear = PlayerPrefs.GetString("AttackGear");
        Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
        switch (attackGear)
        {
            case "lvl 1 attack (equipmentObject)":
                var atk1gear = Instantiate(atkLevel1Gear, transform.position + add, Quaternion.identity) as GameObject;
                atk1gear.transform.SetParent(GameObject.FindGameObjectWithTag("atkGearSlot").transform, false);

                break;
            case "lvl 10 attack (equipmentObject)":
                var atk10gear = Instantiate(atkLevel10Gear, transform.position + add, Quaternion.identity) as GameObject;
                atk10gear.transform.SetParent(GameObject.FindGameObjectWithTag("atkGearSlot").transform, false);

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
            attackGear = PlayerPrefs.GetString("AttackGear");
            Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
            switch (attackGear)
            {
                case "lvl 1 attack (equipmentObject)":
                    var atkgear = Instantiate(atkLevel1Gear, transform.position + add, Quaternion.identity) as GameObject;
                    atkgear.transform.SetParent(GameObject.FindGameObjectWithTag("atkGearSlot").transform, false);

                    break;
                case "lvl 10 attack (equipmentObject)":
                    var atk10gear = Instantiate(atkLevel10Gear, transform.position + add, Quaternion.identity) as GameObject;
                    atk10gear.transform.SetParent(GameObject.FindGameObjectWithTag("atkGearSlot").transform, false);

                    break;
                case "":
                    break;
            }
        }
    }
}