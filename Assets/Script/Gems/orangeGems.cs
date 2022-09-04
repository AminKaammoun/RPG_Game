using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orangeGems : MonoBehaviour
{
    public GameObject lvl1OrangeGem;
    public GameObject lvl2OrangeGem;
    public GameObject lvl3OrangeGem;
    public GameObject lvl4OrangeGem;
    public GameObject lvl5OrangeGem;

    public static bool isAtkGearOrangeGemPlaced;
    public static bool isDefGearOrangeGemPlaced;
    public static bool isHelmetGearOrangeGemPlaced;
    public static bool isBeltGearOrangeGemPlaced;
    public static bool isRingGearOrangeGemPlaced;

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
        if (isAtkGearOrangeGemPlaced)
        {
            isAtkGearOrangeGemPlaced = false;

            switch (GameController.swordOrangeGem)
            {
                case "lvl1OrangeGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 5;
                        GameController.swordSpGemBonus = 5;
                        atkGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1OrangeGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2OrangeGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 15;
                        GameController.swordSpGemBonus = 15;
                        atkGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2OrangeGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3OrangeGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 45;
                        GameController.swordSpGemBonus = 45;
                        atkGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3OrangeGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4OrangeGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 135;
                        GameController.swordSpGemBonus = 135;
                        atkGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4OrangeGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5OrangeGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 405;
                        GameController.swordSpGemBonus = 405;
                        atkGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5OrangeGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isDefGearOrangeGemPlaced)
        {
            isDefGearOrangeGemPlaced = false;

            switch (GameController.shieldOrangeGem)
            {
                case "lvl1OrangeGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 5;
                        GameController.shieldSpGemBonus = 5;
                        defGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1OrangeGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2OrangeGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 15;
                        GameController.shieldSpGemBonus = 15;
                        defGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2OrangeGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3OrangeGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 45;
                        GameController.shieldSpGemBonus = 45;
                        defGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3OrangeGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4OrangeGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 135;
                        GameController.shieldSpGemBonus = 135;
                        defGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4OrangeGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5OrangeGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 405;
                        GameController.shieldSpGemBonus = 405;
                        defGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5OrangeGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isHelmetGearOrangeGemPlaced)
        {
            isHelmetGearOrangeGemPlaced = false;

            switch (GameController.helmetOrangeGem)
            {
                case "lvl1OrangeGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 5;
                        GameController.helmetSpGemBonus = 5;
                        agiGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1OrangeGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2OrangeGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 15;
                        GameController.helmetSpGemBonus = 15;
                        agiGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2OrangeGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3OrangeGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 45;
                        GameController.helmetSpGemBonus = 45;
                        agiGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3OrangeGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4OrangeGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 135;
                        GameController.helmetSpGemBonus = 135;
                        agiGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4OrangeGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5OrangeGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 405;
                        GameController.helmetSpGemBonus = 405;
                        agiGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5OrangeGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isBeltGearOrangeGemPlaced)
        {
            isBeltGearOrangeGemPlaced = false;

            switch (GameController.beltOrangeGem)
            {
                case "lvl1OrangeGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 5;
                        GameController.beltSpGemBonus = 5;
                        spGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1OrangeGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2OrangeGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 15;
                        GameController.beltSpGemBonus = 15;
                        spGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2OrangeGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3OrangeGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 45;
                        GameController.beltSpGemBonus = 45;
                        spGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3OrangeGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4OrangeGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 135;
                        GameController.beltSpGemBonus = 135;
                        spGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4OrangeGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5OrangeGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 405;
                        GameController.beltSpGemBonus = 405;
                        spGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5OrangeGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isRingGearOrangeGemPlaced)
        {
            isRingGearOrangeGemPlaced = false;

            switch (GameController.ringOrangeGem)
            {
                case "lvl1OrangeGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 5;
                        GameController.ringSpGemBonus = 5;
                        hpGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1OrangeGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;



                case "lvl2OrangeGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 15;
                        GameController.ringSpGemBonus = 15;
                        hpGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2OrangeGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3OrangeGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 45;
                        GameController.ringSpGemBonus = 45;
                        hpGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3OrangeGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4OrangeGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 135;
                        GameController.ringSpGemBonus = 135;
                        hpGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4OrangeGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5OrangeGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusSp = PlayerMovements.BonusSp + 405;
                        GameController.ringSpGemBonus = 405;
                        hpGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5OrangeGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
    }
}
