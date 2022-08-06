using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingGears : MonoBehaviour
{
    private string ringGear;

    public static bool isPlaced;
    public GameObject ringLevel1Gear;
    public GameObject ringLevel10Gear;
    // Start is called before the first frame update
    void Start()
    {
        ringGear = PlayerPrefs.GetString("RingGear");
        Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
        switch (ringGear)
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
            ringGear = PlayerPrefs.GetString("RingGear");
            Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
            switch (ringGear)
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
    }
}
