using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowGems : MonoBehaviour
{
    public GameObject lvl1YellowGem;
    public GameObject lvl2YellowGem;
    public GameObject lvl3YellowGem;
    public GameObject lvl4YellowGem;
    public GameObject lvl5YellowGem;

    public static bool isAtkGearYellowGemPlaced;
    public static bool isDefGearYellowGemPlaced;
    public static bool isHelmetGearYellowGemPlaced;
    public static bool isBeltGearYellowGemPlaced;
    public static bool isRingGearYellowGemPlaced;

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
        if (isAtkGearYellowGemPlaced)
        {
            isAtkGearYellowGemPlaced = false;
           
            switch (GameController.swordYellowGem)
            {
                case "lvl1YellowGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 5;
                        GameController.swordAgiGemBonus = 5;
                        atkGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1YellowGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2YellowGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 15;
                        GameController.swordAgiGemBonus = 15;
                        atkGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2YellowGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3YellowGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 45;
                        GameController.swordAgiGemBonus = 45;
                        atkGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3YellowGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4YellowGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 135;
                        GameController.swordAgiGemBonus = 135;
                        atkGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4YellowGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5YellowGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 405;
                        GameController.swordAgiGemBonus = 405;
                        atkGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5YellowGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

            }
        }
        if (isDefGearYellowGemPlaced)
        {
            isDefGearYellowGemPlaced = false;
           
            switch (GameController.shieldYellowGem)
            {
                case "lvl1YellowGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 5;
                        GameController.shieldAgiGemBonus = 5;
                        defGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1YellowGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2YellowGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 15;
                        GameController.shieldAgiGemBonus = 15;
                        defGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2YellowGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3YellowGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 45;
                        GameController.shieldAgiGemBonus = 45;
                        defGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3YellowGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4YellowGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 135;
                        GameController.shieldAgiGemBonus = 135;
                        defGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4YellowGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5YellowGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 405;
                        GameController.shieldAgiGemBonus = 405;
                        defGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5YellowGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isHelmetGearYellowGemPlaced)
        {
            isHelmetGearYellowGemPlaced = false;
           
            switch (GameController.helmetYellowGem)
            {
                case "lvl1YellowGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 5;
                        GameController.helmetAgiGemBonus = 5;
                        agiGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1YellowGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2YellowGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 15;
                        GameController.helmetAgiGemBonus = 15;
                        agiGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2YellowGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3YellowGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 45;
                        GameController.helmetAgiGemBonus = 45;
                        agiGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3YellowGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4YellowGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 135;
                        GameController.helmetAgiGemBonus = 135;
                        agiGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4YellowGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5YellowGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 405;
                        GameController.helmetAgiGemBonus = 405;
                        agiGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5YellowGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isBeltGearYellowGemPlaced)
        {
            isBeltGearYellowGemPlaced = false;
           
            switch (GameController.beltYellowGem)
            {
                case "lvl1YellowGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 5;
                        GameController.beltAgiGemBonus = 5;
                        spGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1YellowGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2YellowGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 15;
                        GameController.beltAgiGemBonus = 15;
                        spGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2YellowGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3YellowGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 45;
                        GameController.beltAgiGemBonus = 45;
                        spGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3YellowGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4YellowGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 135;
                        GameController.beltAgiGemBonus = 135;
                        spGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4YellowGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5YellowGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 405;
                        GameController.beltAgiGemBonus = 405;
                        spGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5YellowGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isRingGearYellowGemPlaced)
        {
            isRingGearYellowGemPlaced = false;
          
            switch (GameController.ringYellowGem)
            {
                case "lvl1YellowGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 5;
                        GameController.ringAgiGemBonus = 5;
                        hpGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1YellowGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2YellowGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 15;
                        GameController.ringAgiGemBonus = 15;
                        hpGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2YellowGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3YellowGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 45;
                        GameController.ringAgiGemBonus = 45;
                        hpGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3YellowGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4YellowGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 135;
                        GameController.ringAgiGemBonus = 135;
                        hpGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4YellowGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5YellowGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 405;
                        GameController.ringAgiGemBonus = 405;
                        hpGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5YellowGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
    }
}
