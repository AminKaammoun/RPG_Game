using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redGems : MonoBehaviour
{
    public GameObject lvl1RedGem;
    public GameObject lvl2RedGem;
    public GameObject lvl3RedGem;
    public GameObject lvl4RedGem;
    public GameObject lvl5RedGem;

    public static bool isAtkGearRedGemPlaced;
    public static bool isDefGearRedGemPlaced;
    public static bool isHelmetGearRedGemPlaced;
    public static bool isBeltGearRedGemPlaced;
    public static bool isRingGearRedGemPlaced;

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
        if (isAtkGearRedGemPlaced)
        {
            isAtkGearRedGemPlaced = false;

            switch (GameController.swordRedGem)
            {
                case "lvl1RedGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 5;
                        GameController.swordAtkGemBonus = 5;
                        atkGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1RedGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2RedGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 15;
                        GameController.swordAtkGemBonus = 15;
                        atkGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2RedGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3RedGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 45;
                        GameController.swordAtkGemBonus = 45;
                        atkGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3RedGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4RedGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 135;
                        GameController.swordAtkGemBonus = 135;
                        atkGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4RedGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5RedGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 405;
                        GameController.swordAtkGemBonus = 405;
                        atkGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5RedGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

            }
        }
        if (isDefGearRedGemPlaced)
        {
            isDefGearRedGemPlaced = false;

            switch (GameController.shieldRedGem)
            {
                case "lvl1RedGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 5;
                        GameController.shieldAtkGemBonus = 5;
                        defGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1RedGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2RedGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 15;
                        GameController.shieldAtkGemBonus = 15;
                        defGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2RedGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3RedGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 45;
                        GameController.shieldAtkGemBonus = 45;
                        defGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3RedGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4RedGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 135;
                        GameController.shieldAtkGemBonus = 135;
                        defGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4RedGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5RedGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 405;
                        GameController.shieldAtkGemBonus = 405;
                        defGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5RedGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isHelmetGearRedGemPlaced)
        {
            isHelmetGearRedGemPlaced = false;

            switch (GameController.helmetRedGem)
            {
                case "lvl1RedGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 5;
                        GameController.helmetAtkGemBonus = 5;
                        agiGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1RedGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2RedGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 15;
                        GameController.helmetAtkGemBonus = 15;
                        agiGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2RedGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3RedGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 45;
                        GameController.helmetAtkGemBonus = 45;
                        agiGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3RedGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4RedGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 135;
                        GameController.helmetAtkGemBonus = 135;
                        agiGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4RedGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5RedGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 405;
                        GameController.helmetAtkGemBonus = 405;
                        agiGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5RedGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

            }
        }
        if (isBeltGearRedGemPlaced)
        {
            isBeltGearRedGemPlaced = false;

            switch (GameController.beltRedGem)
            {
                case "lvl1RedGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 5;
                        GameController.beltAtkGemBonus = 5;
                        spGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1RedGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2RedGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 15;
                        GameController.beltAtkGemBonus = 15;
                        spGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2RedGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;


                case "lvl3RedGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 45;
                        GameController.beltAtkGemBonus = 45;
                        spGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3RedGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4RedGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 135;
                        GameController.beltAtkGemBonus = 135;
                        spGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4RedGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5RedGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 405;
                        GameController.beltAtkGemBonus = 405;
                        spGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5RedGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isRingGearRedGemPlaced)
        {
            isRingGearRedGemPlaced = false;

            switch (GameController.ringRedGem)
            {
                case "lvl1RedGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 5;
                        GameController.ringAtkGemBonus = 5;
                        hpGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1RedGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2RedGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 15;
                        GameController.ringAtkGemBonus = 15;
                        hpGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2RedGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3RedGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 45;
                        GameController.ringAtkGemBonus = 45;
                        hpGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3RedGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4RedGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 135;
                        GameController.ringAtkGemBonus = 135;
                        hpGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4RedGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5RedGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 405;
                        GameController.ringAtkGemBonus = 405;
                        hpGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5RedGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
    }
}
