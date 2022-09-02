using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowGems : MonoBehaviour
{
    public GameObject lvl1YellowGem;

    public static bool isAtkGearYellowGemPlaced;
    public static bool isDefGearYellowGemPlaced;
    public static bool isHelmetGearYellowGemPlaced;
    public static bool isBeltGearYellowGemPlaced;
    public static bool isRingGearYellowGemPlaced;

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
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1YellowGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isDefGearYellowGemPlaced)
        {
            isDefGearYellowGemPlaced = false;
           
            switch (GameController.shieldYellowGem)
            {
                case "lvl1YellowGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1YellowGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isHelmetGearYellowGemPlaced)
        {
            isHelmetGearYellowGemPlaced = false;
           
            switch (GameController.helmetYellowGem)
            {
                case "lvl1YellowGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1YellowGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isBeltGearYellowGemPlaced)
        {
            isBeltGearYellowGemPlaced = false;
           
            switch (GameController.beltYellowGem)
            {
                case "lvl1YellowGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1YellowGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
        if (isRingGearYellowGemPlaced)
        {
            isRingGearYellowGemPlaced = false;
          
            switch (GameController.ringYellowGem)
            {
                case "lvl1YellowGem (gemObject)":
                    Vector3 add = new Vector3(transform.position.x, transform.position.y, 0);
                    var redGem1 = Instantiate(lvl1YellowGem, transform.position - add, Quaternion.identity) as GameObject;
                    redGem1.transform.SetParent(GameObject.FindGameObjectWithTag("yellowGemSlot").transform, false);
                    redGem1.GetComponent<RectTransform>().sizeDelta = new Vector2(27, 27);
                    break;
            }
        }
    }
}
