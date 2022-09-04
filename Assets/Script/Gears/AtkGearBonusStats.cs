using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtkGearBonusStats : MonoBehaviour
{

    public Text AtkBonus;
    public Text DefBonus;
    public Text AgiBonus;
    public Text SpBonus;
    public Text HpBonus;

    public Sprite none;

    public Sprite[] lvl1Gems;
    public Sprite[] lvl2Gems;
    public Sprite[] lvl3Gems;
    public Sprite[] lvl4Gems;
    public Sprite[] lvl5Gems;

    public Text[] lvl1GemsName;
  

    public Image[] gemSpots;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.swordAtkGemBonus > 0)
        {
            AtkBonus.text = "+(" + GameController.swordAtkGemBonus + ")";
            switch (GameController.swordAtkGemBonus)
            {
                case 5:
                    gemSpots[0].sprite = lvl1Gems[0];
                    lvl1GemsName[0].text = "lvl 1 Atk gem";
                    lvl1GemsName[0].color = Color.white;
                    break;

                case 15:
                    gemSpots[0].sprite = lvl2Gems[0];
                    lvl1GemsName[0].text = "lvl 2 Atk gem";
                    lvl1GemsName[0].color = Color.green;
                    break;
              
                case 45:
                    gemSpots[0].sprite = lvl3Gems[0];
                    lvl1GemsName[0].text = "lvl 3 Atk gem";
                    lvl1GemsName[0].color = Color.blue;
                    break;

                case 135:
                    gemSpots[0].sprite = lvl4Gems[0];
                    lvl1GemsName[0].text = "lvl 4 Atk gem";
                    lvl1GemsName[0].color = new Color(0.5f, 0f, 1f, 1f);
                    break;

                case 405:
                    gemSpots[0].sprite = lvl5Gems[0];
                    lvl1GemsName[0].text = "lvl 5 Atk gem";
                    lvl1GemsName[0].color = Color.red;
                    break;
            }
        }
        else
        {
            gemSpots[0].sprite = none;
            lvl1GemsName[0].text = "not equipped.";
            lvl1GemsName[0].color = Color.white;
            AtkBonus.text = "";
        }

        if (GameController.swordDefGemBonus > 0)
        {
            DefBonus.text = "+(" + GameController.swordDefGemBonus + ")";
            switch (GameController.swordDefGemBonus)
            {
                case 5:
                    gemSpots[1].sprite = lvl1Gems[1];
                    lvl1GemsName[1].text = "lvl 1 def gem";
                    lvl1GemsName[1].color = Color.white;
                    break;

                case 15:
                    gemSpots[1].sprite = lvl2Gems[1];
                    lvl1GemsName[1].text = "lvl 2 def gem";
                    lvl1GemsName[1].color = Color.green;
                    break;

                case 45:
                    gemSpots[1].sprite = lvl3Gems[1];
                    lvl1GemsName[1].text = "lvl 3 def gem";
                    lvl1GemsName[1].color = Color.blue;
                    break;

                case 135:
                    gemSpots[1].sprite = lvl4Gems[1];
                    lvl1GemsName[1].text = "lvl 4 def gem";
                    lvl1GemsName[1].color = new Color(0.5f, 0f, 1f, 1f);
                    break;

                case 405:
                    gemSpots[1].sprite = lvl5Gems[1];
                    lvl1GemsName[1].text = "lvl 5 def gem";
                    lvl1GemsName[1].color = Color.red;
                    break;
            }
        }
        else
        {
            gemSpots[1].sprite = none;
            lvl1GemsName[1].text = "not equipped.";
            lvl1GemsName[1].color = Color.white;
            DefBonus.text = "";
        }

        if (GameController.swordAgiGemBonus > 0)
        {
            AgiBonus.text = "+(" + GameController.swordAgiGemBonus + ")";
            switch (GameController.swordAgiGemBonus)
            {
                case 5:
                    gemSpots[2].sprite = lvl1Gems[2];
                    lvl1GemsName[2].text = "lvl 1 agi gem";
                    lvl1GemsName[2].color = Color.white;
                    break;

                case 15:
                    gemSpots[2].sprite = lvl2Gems[2];
                    lvl1GemsName[2].text = "lvl 2 agi gem";
                    lvl1GemsName[2].color = Color.green;
                    break;

                case 45:
                    gemSpots[2].sprite = lvl3Gems[2];
                    lvl1GemsName[2].text = "lvl 3 agi gem";
                    lvl1GemsName[2].color = Color.blue;
                    break;

                case 135:
                    gemSpots[2].sprite = lvl4Gems[2];
                    lvl1GemsName[2].text = "lvl 4 agi gem";
                    lvl1GemsName[2].color = new Color(0.5f, 0f, 1f, 1f);
                    break;

                case 405:
                    gemSpots[2].sprite = lvl5Gems[2];
                    lvl1GemsName[2].text = "lvl 5 agi gem";
                    lvl1GemsName[2].color = Color.red;
                    break;
            }
        }
        else
        {
            gemSpots[2].sprite = none;
            lvl1GemsName[2].text = "not equipped.";
            lvl1GemsName[2].color = Color.white;
            AgiBonus.text = "";
        }

        if (GameController.swordSpGemBonus > 0)
        {
            SpBonus.text = "+(" + GameController.swordSpGemBonus + ")";
            switch (GameController.swordSpGemBonus)
            {
                case 5:
                    gemSpots[3].sprite = lvl1Gems[3];
                    lvl1GemsName[3].text = "lvl 1 sp gem";
                    lvl1GemsName[3].color = Color.white;
                    break;

                case 15:
                    gemSpots[3].sprite = lvl2Gems[3];
                    lvl1GemsName[3].text = "lvl 2 sp gem";
                    lvl1GemsName[3].color = Color.green;
                    break;

                case 45:
                    gemSpots[3].sprite = lvl3Gems[3];
                    lvl1GemsName[3].text = "lvl 3 sp gem";
                    lvl1GemsName[3].color = Color.blue;
                    break;

                case 135:
                    gemSpots[3].sprite = lvl4Gems[3];
                    lvl1GemsName[3].text = "lvl 4 sp gem";
                    lvl1GemsName[3].color = new Color(0.5f, 0f, 1f, 1f);
                    break;

                case 405:
                    gemSpots[3].sprite = lvl5Gems[3];
                    lvl1GemsName[3].text = "lvl 5 sp gem";
                    lvl1GemsName[3].color = Color.red;
                    break;
            }
        }
        else
        {
            gemSpots[3].sprite = none;
            lvl1GemsName[3].text = "not equipped.";
            lvl1GemsName[3].color = Color.white;
            SpBonus.text = "";
        }


        if (GameController.swordHpGemBonus > 0)
        {
            HpBonus.text = "+(" + GameController.swordHpGemBonus + ")";
            switch (GameController.swordHpGemBonus)
            {
                case 25:
                    gemSpots[4].sprite = lvl1Gems[4];
                    lvl1GemsName[4].text = "lvl 1 hp gem";
                    lvl1GemsName[4].color = Color.white;
                    break;

                case 75:
                    gemSpots[4].sprite = lvl2Gems[4];
                    lvl1GemsName[4].text = "lvl 2 hp gem";
                    lvl1GemsName[4].color = Color.green;
                    break;

                case 225:
                    gemSpots[4].sprite = lvl3Gems[4];
                    lvl1GemsName[4].text = "lvl 3 hp gem";
                    lvl1GemsName[4].color = Color.blue;
                    break;

                case 675:
                    gemSpots[4].sprite = lvl4Gems[4];
                    lvl1GemsName[4].text = "lvl 4 hp gem";
                    lvl1GemsName[4].color = new Color(0.5f, 0f, 1f, 1f);
                    break;

                case 2025:
                    gemSpots[4].sprite = lvl5Gems[4];
                    lvl1GemsName[4].text = "lvl 5 hp gem";
                    lvl1GemsName[4].color = Color.red;
                    break;
            }
        }
        else
        {
            gemSpots[4].sprite = none;
            lvl1GemsName[4].text = "not equipped.";
            lvl1GemsName[4].color = Color.white;
            HpBonus.text = "";
        }



    }
}
