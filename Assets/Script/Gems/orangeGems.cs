using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orangeGems : MonoBehaviour
{
    public GameObject lvl1OrangeGem;

    public static bool isAtkGearOrangeGemPlaced;
    public static bool isDefGearOrangeGemPlaced;
    public static bool isHelmetGearOrangeGemPlaced;
    public static bool isBeltGearOrangeGemPlaced;
    public static bool isRingGearOrangeGemPlaced;

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
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1OrangeGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isDefGearOrangeGemPlaced)
        {
            isDefGearOrangeGemPlaced = false;
         
            switch (GameController.shieldOrangeGem)
            {
                case "lvl1OrangeGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1OrangeGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isHelmetGearOrangeGemPlaced)
        {
            isHelmetGearOrangeGemPlaced = false;
         
            switch (GameController.helmetOrangeGem)
            {
                case "lvl1OrangeGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1OrangeGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isBeltGearOrangeGemPlaced)
        {
            isBeltGearOrangeGemPlaced = false;
           
            switch (GameController.beltOrangeGem)
            {
                case "lvl1OrangeGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1OrangeGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isRingGearOrangeGemPlaced)
        {
            isRingGearOrangeGemPlaced = false;
         
            switch (GameController.ringOrangeGem)
            {
                case "lvl1OrangeGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1OrangeGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("orangeGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
    }
}
