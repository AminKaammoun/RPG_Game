using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redGems : MonoBehaviour
{
    public GameObject lvl1RedGem;

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
                        atkGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1RedGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
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
                        defGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1RedGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
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
                        agiGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1RedGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
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
                        spGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1RedGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
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
                        hpGemIsAdded = false;
                    }
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1RedGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("redGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
    }
}
