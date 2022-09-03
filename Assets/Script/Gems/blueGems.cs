using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueGems : MonoBehaviour
{
    public GameObject lvl1BlueGem;
    public GameObject lvl2BlueGem;
    public GameObject lvl3BlueGem;
    public GameObject lvl4BlueGem;
    public GameObject lvl5BlueGem;

    public static bool isAtkGearBlueGemPlaced;
    public static bool isDefGearBlueGemPlaced;
    public static bool isHelmetGearBlueGemPlaced;
    public static bool isBeltGearBlueGemPlaced;
    public static bool isRingGearBlueGemPlaced;

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
        if (isAtkGearBlueGemPlaced)
        {
            isAtkGearBlueGemPlaced = false;

            switch (GameController.swordBlueGem)
            {

                case "lvl1BlueGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 5;
                        GameController.swordDefGemBonus = 5;
                        atkGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1BlueGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
                case "lvl2BlueGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 15;
                        GameController.swordDefGemBonus = 15;
                        atkGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2BlueGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3BlueGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 45;
                        GameController.swordDefGemBonus = 45;
                        atkGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3BlueGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4BlueGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 135;
                        GameController.swordDefGemBonus = 135;
                        atkGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4BlueGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5BlueGem (gemObject)":
                    if (atkGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 405;
                        GameController.swordDefGemBonus = 405;
                        atkGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5BlueGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;


            }
        }
        if (isDefGearBlueGemPlaced)
        {
            isDefGearBlueGemPlaced = false;

            switch (GameController.shieldBlueGem)
            {
                case "lvl1BlueGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 5;
                        GameController.shieldDefGemBonus = 5;
                        defGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1BlueGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
               
                case "lvl2BlueGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 15;
                        GameController.shieldDefGemBonus = 15;
                        defGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2BlueGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3BlueGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 45;
                        GameController.shieldDefGemBonus = 45;
                        defGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3BlueGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4BlueGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 135;
                        GameController.shieldDefGemBonus = 135;
                        defGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4BlueGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5BlueGem (gemObject)":
                    if (defGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 405;
                        GameController.shieldDefGemBonus = 405;
                        defGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5BlueGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;


            }
        }
        if (isHelmetGearBlueGemPlaced)
        {
            isHelmetGearBlueGemPlaced = false;

            switch (GameController.helmetBlueGem)
            {
                case "lvl1BlueGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 5;
                        GameController.helmetDefGemBonus = 5;
                        agiGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1BlueGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2BlueGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 15;
                        GameController.helmetDefGemBonus = 15;
                        agiGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2BlueGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3BlueGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 45;
                        GameController.helmetDefGemBonus = 45;
                        agiGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3BlueGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4BlueGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 135;
                        GameController.helmetDefGemBonus = 135;
                        agiGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4BlueGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5BlueGem (gemObject)":
                    if (agiGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 405;
                        GameController.helmetDefGemBonus = 405;
                        agiGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5BlueGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

            }
        }
        if (isBeltGearBlueGemPlaced)
        {
            isBeltGearBlueGemPlaced = false;

            switch (GameController.beltBlueGem)
            {
                case "lvl1BlueGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 5;
                        GameController.beltDefGemBonus = 5;
                        spGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1BlueGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2BlueGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 15;
                        GameController.beltDefGemBonus = 15;
                        spGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2BlueGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3BlueGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 45;
                        GameController.beltDefGemBonus = 45;
                        spGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3BlueGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4BlueGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 135;
                        GameController.beltDefGemBonus = 135;
                        spGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4BlueGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5BlueGem (gemObject)":
                    if (spGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 405;
                        GameController.beltDefGemBonus = 405;
                        spGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5BlueGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isRingGearBlueGemPlaced)
        {
            isRingGearBlueGemPlaced = false;

            switch (GameController.ringBlueGem)
            {
                case "lvl1BlueGem (gemObject)":

                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 5;
                        GameController.ringDefGemBonus = 5;
                        hpGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1BlueGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl2BlueGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 15;
                        GameController.ringDefGemBonus = 15;
                        hpGemIsAdded = false;
                    }
                    Vector3 add1 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem2 = Instantiate(lvl2BlueGem, transform.position - add1, Quaternion.identity) as GameObject;
                    redGem2.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem2.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl3BlueGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 45;
                        GameController.ringDefGemBonus = 45;
                        hpGemIsAdded = false;
                    }
                    Vector3 add2 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem3 = Instantiate(lvl3BlueGem, transform.position - add2, Quaternion.identity) as GameObject;
                    redGem3.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem3.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl4BlueGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 135;
                        GameController.ringDefGemBonus = 135;
                        hpGemIsAdded = false;
                    }
                    Vector3 add3 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem4 = Instantiate(lvl4BlueGem, transform.position - add3, Quaternion.identity) as GameObject;
                    redGem4.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem4.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;

                case "lvl5BlueGem (gemObject)":
                    if (hpGemIsAdded)
                    {
                        PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 405;
                        GameController.ringDefGemBonus = 405;
                        hpGemIsAdded = false;
                    }
                    Vector3 add4 = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem5 = Instantiate(lvl5BlueGem, transform.position - add4, Quaternion.identity) as GameObject;
                    redGem5.transform.SetParent(GameObject.FindGameObjectWithTag("blueGemSlot").transform, false);
                    redGem5.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
    }
}
