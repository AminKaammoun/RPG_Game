using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenGems : MonoBehaviour
{
    public GameObject lvl1GreenGem;

    public static bool isAtkGearGreenGemPlaced;
    public static bool isDefGearGreenGemPlaced;
    public static bool isHelmetGearGreenGemPlaced;
    public static bool isBeltGearGreenGemPlaced;
    public static bool isRingGearGreenGemPlaced;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isAtkGearGreenGemPlaced)
        {
            isAtkGearGreenGemPlaced = false;
            string attackGearRedGem = PlayerPrefs.GetString("AttackGearGreenGem");
            switch (attackGearRedGem)
            {
                case "lvl1GreenGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1GreenGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isDefGearGreenGemPlaced)
        {
            isDefGearGreenGemPlaced = false;
            string defGearRedGem = PlayerPrefs.GetString("DefGearGreenGem");
            switch (defGearRedGem)
            {
                case "lvl1GreenGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1GreenGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isHelmetGearGreenGemPlaced)
        {
            isHelmetGearGreenGemPlaced = false;
            string helmetGearRedGem = PlayerPrefs.GetString("HelmetGearGreenGem");
            switch (helmetGearRedGem)
            {
                case "lvl1GreenGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1GreenGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isBeltGearGreenGemPlaced)
        {
            isBeltGearGreenGemPlaced = false;
            string beltGearRedGem = PlayerPrefs.GetString("BeltGearGreenGem");
            switch (beltGearRedGem)
            {
                case "lvl1GreenGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1GreenGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isRingGearGreenGemPlaced)
        {
            isRingGearGreenGemPlaced = false;
            string ringGearRedGem = PlayerPrefs.GetString("RingGearGreenGem");
            switch (ringGearRedGem)
            {
                case "lvl1GreenGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1GreenGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
    }
}
