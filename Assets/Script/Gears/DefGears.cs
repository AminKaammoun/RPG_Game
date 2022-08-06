using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefGears : MonoBehaviour
{
    private string defGear;

    public static bool isPlaced;
    public GameObject defLevel1Gear;
    //public GameObject atkLevel10Gear;

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

                    break;

                case "":
                    break;
            }
        }
    }
}
