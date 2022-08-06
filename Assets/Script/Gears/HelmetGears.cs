using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelmetGears : MonoBehaviour
{
    private string helmetGear;

    public static bool isPlaced;
    public GameObject helLevel1Gear;

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

                    break;

                case "":
                    break;
            }
        }
    }
}
