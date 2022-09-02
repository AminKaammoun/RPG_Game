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

    public static bool atkGemIsAdded = false;
    public static bool defGemIsAdded = false;
    public static bool agiGemIsAdded = false;
    public static bool spGemIsAdded = false;
    public static bool hpGemIsAdded = false;

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
            
            switch (GameController.swordGreenGem)
            {
                case "lvl1GreenGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 25;
                        atkGemIsAdded = false;
                    }
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
           
            switch (GameController.shieldGreenGem)
            {
                case "lvl1GreenGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 25;
                        defGemIsAdded = false;
                    }
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
         
            switch (GameController.helmetGreenGem)
            {
                case "lvl1GreenGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 25;
                        agiGemIsAdded = false;
                    }
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
           
            switch (GameController.beltGreenGem)
            {
                case "lvl1GreenGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 25;
                        spGemIsAdded = false;
                    }
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
           
            switch (GameController.ringGreenGem)
            {
                case "lvl1GreenGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 25;
                        hpGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1GreenGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
    }
}