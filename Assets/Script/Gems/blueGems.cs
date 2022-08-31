using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueGems : MonoBehaviour
{
    public GameObject lvl1BlueGem;

    public static bool isAtkGearBlueGemPlaced;
    public static bool isDefGearBlueGemPlaced;
    public static bool isHelmetGearBlueGemPlaced;
    public static bool isBeltGearBlueGemPlaced;
    public static bool isRingGearBlueGemPlaced;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isAtkGearBlueGemPlaced)
        {
            isAtkGearBlueGemPlaced = false;
            string attackGearRedGem = PlayerPrefs.GetString("AttackGearBlueGem");
            switch (attackGearRedGem)
            {
                case "lvl1BlueGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1BlueGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isDefGearBlueGemPlaced)
        {
            isDefGearBlueGemPlaced = false;
            string defGearRedGem = PlayerPrefs.GetString("DefGearBlueGem");
            switch (defGearRedGem)
            {
                case "lvl1BlueGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1BlueGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isHelmetGearBlueGemPlaced)
        {
            isHelmetGearBlueGemPlaced = false;
            string helmetGearRedGem = PlayerPrefs.GetString("HelmetGearBlueGem");
            switch (helmetGearRedGem)
            {
                case "lvl1BlueGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1BlueGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isBeltGearBlueGemPlaced)
        {
            isBeltGearBlueGemPlaced = false;
            string beltGearRedGem = PlayerPrefs.GetString("BeltGearBlueGem");
            switch (beltGearRedGem)
            {
                case "lvl1BlueGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1BlueGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isRingGearBlueGemPlaced)
        {
            isRingGearBlueGemPlaced = false;
            string ringGearRedGem = PlayerPrefs.GetString("RingGearBlueGem");
            switch (ringGearRedGem)
            {
                case "lvl1BlueGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1BlueGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
    }
}
