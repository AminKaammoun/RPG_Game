using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenGems : MonoBehaviour
{
    public GameObject lvl1GreenGem;
    public GameObject lvl2GreenGem;
    public GameObject lvl3GreenGem;
    public GameObject lvl4GreenGem;
    public GameObject lvl5GreenGem;

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
                        GameController.swordHpGemBonus = 25;
                        atkGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1GreenGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2GreenGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 75;
                        GameController.swordHpGemBonus = 75;
                        atkGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2GreenGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3GreenGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 225;
                        GameController.swordHpGemBonus = 225;
                        atkGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3GreenGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4GreenGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 675;
                        GameController.swordHpGemBonus = 675;
                        atkGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4GreenGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5GreenGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 2025;
                        GameController.swordHpGemBonus = 2025;
                        atkGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5GreenGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
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
                        GameController.shieldHpGemBonus = 25;
                        defGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1GreenGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2GreenGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 75;
                        GameController.shieldHpGemBonus = 75;
                        defGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2GreenGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3GreenGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 225;
                        GameController.shieldHpGemBonus = 225;
                        defGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3GreenGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4GreenGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 675;
                        GameController.shieldHpGemBonus = 675;
                        defGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4GreenGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5GreenGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 2025;
                        GameController.shieldHpGemBonus = 2025;
                        defGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5GreenGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
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
                        GameController.helmetHpGemBonus = 25;
                        agiGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1GreenGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2GreenGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 75;
                        GameController.helmetHpGemBonus = 75;
                        agiGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2GreenGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3GreenGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 225;
                        GameController.helmetHpGemBonus = 225;
                        agiGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3GreenGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4GreenGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 675;
                        GameController.helmetHpGemBonus = 675;
                        agiGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4GreenGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5GreenGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 2025;
                        GameController.helmetHpGemBonus = 2025;
                        agiGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5GreenGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
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
                        GameController.beltHpGemBonus = 25;
                        spGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1GreenGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2GreenGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 75;
                        GameController.beltHpGemBonus = 75;
                        spGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2GreenGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3GreenGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 225;
                        GameController.beltHpGemBonus = 225;
                        spGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3GreenGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4GreenGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 675;
                        GameController.beltHpGemBonus = 675;
                        spGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4GreenGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5GreenGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 2025;
                        GameController.beltHpGemBonus = 2025;
                        spGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5GreenGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
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
                        GameController.ringHpGemBonus = 25;
                        hpGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1GreenGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2GreenGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 75;
                        GameController.ringHpGemBonus = 75;
                        hpGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2GreenGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3GreenGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 225;
                        GameController.ringHpGemBonus = 225;
                        hpGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3GreenGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4GreenGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 675;
                        GameController.ringHpGemBonus = 675;
                        hpGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4GreenGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5GreenGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusHp = PlayerMovements.BonusHp + 2025;
                        GameController.ringHpGemBonus = 2025;
                        hpGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5GreenGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("greenGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
    }
}
