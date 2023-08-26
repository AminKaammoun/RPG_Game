using NUnit;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;
using static UnityEngine.Rendering.DebugUI;


public class seedShop : MonoBehaviour
{
    public InventoryObject inventory;
    public InventoryObject SeedsInventory;

    public ItemObject[] seeds;
    public ItemObject[] fruits;

    public GameObject page1;
    public GameObject page2;
    public GameObject page3;

    public GameObject alert;
    public Text cost;
    public Text costSell;

    private int currentPotion;
    public InputField value;
    public InputField valueSell;

    public AudioSource coinSound;
    public GameObject notEnoughMoneyText;
    public GameObject SeedShop;

    public GameObject buyPanel;
    public GameObject sellPanel;

    public GameObject panel;
    private String currentFruit;

    public Text[] fruitTodayPrice;
    public GameObject[] coinImage;
    public GameObject[] sellButtons;

    private int counter;

    int Fruit1Price;
    int Fruit2Price;
    int Fruit3Price;
    int fruit4Price;
    int Fruit5Price;
    int Fruit6Price;
    int Fruit7Price;
    int Fruit8Price;
    int fruit9Price;
    int Fruit10Price;
    int Fruit11Price;
    int Fruit12Price;
    int Fruit13Price;
    int fruit14Price;
    int Fruit15Price;
    int Fruit16Price;
    int Fruit17Price;
    int Fruit18Price;
    int fruit19Price;
    int Fruit20Price;
    int Fruit21Price;

    public AudioSource coinCollect;
    public GameObject NotEnoughFishText;
    public GameObject SeedsPanel;

    private bool reset = true;

    // Start is called before the first frame update
    void Start()
    {
        page1.SetActive(true);
        page2.SetActive(false);
        page3.SetActive(false);

         Fruit1Price = UnityEngine.Random.Range(10, 13);
         Fruit2Price = UnityEngine.Random.Range(12, 16);
       Fruit3Price = UnityEngine.Random.Range(14, 18);
       fruit4Price = UnityEngine.Random.Range(16, 20);
       Fruit5Price = UnityEngine.Random.Range(18, 23);
   Fruit6Price = UnityEngine.Random.Range(21, 26);
     Fruit7Price = UnityEngine.Random.Range(24, 30);
       Fruit8Price = UnityEngine.Random.Range(27, 34);
        fruit9Price = UnityEngine.Random.Range(30, 38);
    Fruit10Price = UnityEngine.Random.Range(34, 42);
      Fruit11Price = UnityEngine.Random.Range(38, 47);
      Fruit12Price = UnityEngine.Random.Range(42, 52);
    Fruit13Price = UnityEngine.Random.Range(46, 57);
       fruit14Price = UnityEngine.Random.Range(51, 63);
   Fruit15Price = UnityEngine.Random.Range(56, 69);
        Fruit16Price = UnityEngine.Random.Range(62, 76);
         Fruit17Price = UnityEngine.Random.Range(68, 83);
        Fruit18Price = UnityEngine.Random.Range(75, 92);
    fruit19Price = UnityEngine.Random.Range(85, 104);
       Fruit20Price = UnityEngine.Random.Range(95, 116);
      Fruit21Price = UnityEngine.Random.Range(105, 128);

        float rand1 = UnityEngine.Random.Range(0, 2);
        float rand2 = UnityEngine.Random.Range(0, 2);
        float rand3 = UnityEngine.Random.Range(0, 2);
        float rand4 = UnityEngine.Random.Range(0, 2);
        float rand5 = UnityEngine.Random.Range(0, 2);
        float rand6 = UnityEngine.Random.Range(0, 2);
        float rand7 = UnityEngine.Random.Range(0, 2);
        float rand8 = UnityEngine.Random.Range(0, 2);
        float rand9 = UnityEngine.Random.Range(0, 2);
        float rand10 = UnityEngine.Random.Range(0, 2);
        float rand11 = UnityEngine.Random.Range(0, 2);
        float rand12 = UnityEngine.Random.Range(0, 2);
        float rand13 = UnityEngine.Random.Range(0, 2);
        float rand14 = UnityEngine.Random.Range(0, 2);
        float rand15 = UnityEngine.Random.Range(0, 2);
        float rand16 = UnityEngine.Random.Range(0, 2);
        float rand17 = UnityEngine.Random.Range(0, 2);
        float rand18 = UnityEngine.Random.Range(0, 2);
        float rand19 = UnityEngine.Random.Range(0, 2);
        float rand20 = UnityEngine.Random.Range(0, 2);
        float rand21 = UnityEngine.Random.Range(0, 2);

        switch (rand1)
        {
            case 0:
                fruitTodayPrice[0].text = "todays offer : " + Fruit1Price + "k  ";
                fruitTodayPrice[0].color = Color.white;
                coinImage[0].SetActive(true);
                sellButtons[0].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[0].text = "not buying.";
                fruitTodayPrice[0].color = Color.red;
                coinImage[0].SetActive(false);
                sellButtons[0].SetActive(false);
                break;
        }

        switch (rand2)
        {
            case 0:
                fruitTodayPrice[1].text = "todays offer : " + Fruit2Price + "k  ";
                fruitTodayPrice[1].color = Color.white;
                coinImage[1].SetActive(true);
                sellButtons[1].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[1].text = "not buying.";
                fruitTodayPrice[1].color = Color.red;
                coinImage[1].SetActive(false);
                sellButtons[1].SetActive(false);
                break;
        }

        switch (rand3)
        {
            case 0:
                fruitTodayPrice[2].text = "todays offer : " + Fruit3Price + "k  ";
                fruitTodayPrice[2].color = Color.white;
                coinImage[2].SetActive(true);
                sellButtons[2].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[2].text = "not buying.";
                fruitTodayPrice[2].color = Color.red;
                coinImage[2].SetActive(false);
                sellButtons[2].SetActive(false);
                break;
        }

        switch (rand4)
        {
            case 0:
                fruitTodayPrice[3].text = "todays offer : " + fruit4Price + "k  ";
                fruitTodayPrice[3].color = Color.white;
                coinImage[3].SetActive(true);
                sellButtons[3].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[3].text = "not buying.";
                fruitTodayPrice[3].color = Color.red;
                coinImage[3].SetActive(false);
                sellButtons[3].SetActive(false);
                break;
        }

        switch (rand5)
        {
            case 0:
                fruitTodayPrice[4].text = "todays offer : " + Fruit5Price + "k  ";
                fruitTodayPrice[4].color = Color.white;
                coinImage[4].SetActive(true);
                sellButtons[4].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[4].text = "not buying.";
                fruitTodayPrice[4].color = Color.red;
                coinImage[4].SetActive(false);
                sellButtons[4].SetActive(false);
                break;
        }

        switch (rand6)
        {
            case 0:
                fruitTodayPrice[5].text = "todays offer : " + Fruit6Price + "k  ";
                fruitTodayPrice[5].color = Color.white;
                coinImage[5].SetActive(true);
                sellButtons[5].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[5].text = "not buying.";
                fruitTodayPrice[5].color = Color.red;
                coinImage[5].SetActive(false);
                sellButtons[5].SetActive(false);
                break;
        }

        switch (rand7)
        {
            case 0:
                fruitTodayPrice[6].text = "todays offer : " + Fruit7Price + "k  ";
                fruitTodayPrice[6].color = Color.white;
                coinImage[6].SetActive(true);
                sellButtons[6].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[6].text = "not buying.";
                fruitTodayPrice[6].color = Color.red;
                coinImage[6].SetActive(false);
                sellButtons[6].SetActive(false);
                break;
        }

        switch (rand8)
        {
            case 0:
                fruitTodayPrice[7].text = "todays offer : " + Fruit8Price + "k  ";
                fruitTodayPrice[7].color = Color.white;
                coinImage[7].SetActive(true);
                sellButtons[7].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[7].text = "not buying.";
                fruitTodayPrice[7].color = Color.red;
                coinImage[7].SetActive(false);
                sellButtons[7].SetActive(false);
                break;
        }

        switch (rand9)
        {
            case 0:
                fruitTodayPrice[8].text = "todays offer : " + fruit9Price + "k  ";
                fruitTodayPrice[8].color = Color.white;
                coinImage[8].SetActive(true);
                sellButtons[8].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[8].text = "not buying.";
                fruitTodayPrice[8].color = Color.red;
                coinImage[8].SetActive(false);
                sellButtons[8].SetActive(false);
                break;
        }

        switch (rand10)
        {
            case 0:
                fruitTodayPrice[9].text = "todays offer : " + Fruit10Price + "k  ";
                fruitTodayPrice[9].color = Color.white;
                coinImage[9].SetActive(true);
                sellButtons[9].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[9].text = "not buying.";
                fruitTodayPrice[9].color = Color.red;
                coinImage[9].SetActive(false);
                sellButtons[9].SetActive(false);
                break;
        }

        switch (rand11)
        {
            case 0:
                fruitTodayPrice[10].text = "todays offer : " + Fruit11Price + "k  ";
                fruitTodayPrice[10].color = Color.white;
                coinImage[10].SetActive(true);
                sellButtons[10].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[10].text = "not buying.";
                fruitTodayPrice[10].color = Color.red;
                coinImage[10].SetActive(false);
                sellButtons[10].SetActive(false);
                break;
        }
        switch (rand12)
        {
            case 0:
                fruitTodayPrice[11].text = "todays offer : " + Fruit12Price + "k  ";
                fruitTodayPrice[11].color = Color.white;
                coinImage[11].SetActive(true);
                sellButtons[11].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[11].text = "not buying.";
                fruitTodayPrice[11].color = Color.red;
                coinImage[11].SetActive(false);
                sellButtons[11].SetActive(false);
                break;
        }

        switch (rand13)
        {
            case 0:
                fruitTodayPrice[12].text = "todays offer : " + Fruit13Price + "k  ";
                fruitTodayPrice[12].color = Color.white;
                coinImage[12].SetActive(true);
                sellButtons[12].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[12].text = "not buying.";
                fruitTodayPrice[12].color = Color.red;
                coinImage[12].SetActive(false);
                sellButtons[12].SetActive(false);
                break;
        }

        switch (rand14)
        {
            case 0:
                fruitTodayPrice[13].text = "todays offer : " + fruit14Price + "k  ";
                fruitTodayPrice[13].color = Color.white;
                coinImage[13].SetActive(true);
                sellButtons[13].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[13].text = "not buying.";
                fruitTodayPrice[13].color = Color.red;
                coinImage[13].SetActive(false);
                sellButtons[13].SetActive(false);
                break;
        }

        switch (rand15)
        {
            case 0:
                fruitTodayPrice[14].text = "todays offer : " + Fruit15Price + "k  ";
                fruitTodayPrice[14].color = Color.white;
                coinImage[14].SetActive(true);
                sellButtons[14].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[14].text = "not buying.";
                fruitTodayPrice[14].color = Color.red;
                coinImage[14].SetActive(false);
                sellButtons[14].SetActive(false);
                break;
        }

        switch (rand16)
        {
            case 0:
                fruitTodayPrice[15].text = "todays offer : " + Fruit16Price + "k  ";
                fruitTodayPrice[15].color = Color.white;
                coinImage[15].SetActive(true);
                sellButtons[15].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[15].text = "not buying.";
                fruitTodayPrice[15].color = Color.red;
                coinImage[15].SetActive(false);
                sellButtons[15].SetActive(false);
                break;
        }

        switch (rand17)
        {
            case 0:
                fruitTodayPrice[16].text = "todays offer : " + Fruit17Price + "k  ";
                fruitTodayPrice[16].color = Color.white;
                coinImage[16].SetActive(true);
                sellButtons[16].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[16].text = "not buying.";
                fruitTodayPrice[16].color = Color.red;
                coinImage[16].SetActive(false);
                sellButtons[16].SetActive(false);
                break;
        }

        switch (rand18)
        {
            case 0:
                fruitTodayPrice[17].text = "todays offer : " + Fruit18Price + "k  ";
                fruitTodayPrice[17].color = Color.white;
                coinImage[17].SetActive(true);
                sellButtons[17].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[17].text = "not buying.";
                fruitTodayPrice[17].color = Color.red;
                coinImage[17].SetActive(false);
                sellButtons[17].SetActive(false);
                break;
        }

        switch (rand19)
        {
            case 0:
                fruitTodayPrice[18].text = "todays offer : " + fruit19Price + "k  ";
                fruitTodayPrice[18].color = Color.white;
                coinImage[18].SetActive(true);
                sellButtons[18].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[18].text = "not buying.";
                fruitTodayPrice[18].color = Color.red;
                coinImage[18].SetActive(false);
                sellButtons[18].SetActive(false);
                break;
        }

        switch (rand20)
        {
            case 0:
                fruitTodayPrice[19].text = "todays offer : " + Fruit20Price + "k  ";
                fruitTodayPrice[19].color = Color.white;
                coinImage[19].SetActive(true);
                sellButtons[19].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[19].text = "not buying.";
                fruitTodayPrice[19].color = Color.red;
                coinImage[19].SetActive(false);
                sellButtons[19].SetActive(false);
                break;
        }

        switch (rand21)
        {
            case 0:
                fruitTodayPrice[20].text = "todays offer : " + Fruit21Price + "k  ";
                fruitTodayPrice[20].color = Color.white;
                coinImage[20].SetActive(true);
                sellButtons[20].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[20].text = "not buying.";
                fruitTodayPrice[20].color = Color.red;
                coinImage[20].SetActive(false);
                sellButtons[20].SetActive(false);
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (time.hour == 0)
        {
            if (reset)
            {
                resetFruits();
                reset = false;
            }
        }
        if (time.hour == 1)
        {
            reset = true;
        }
    }

    public void rightButton()
    {
        if(page1.activeSelf) 
        {
            page1.SetActive(false);
            page2.SetActive(true); 
            page3.SetActive(false);
        }else if (page2.activeSelf)
        {
            page1.SetActive(false);
            page2.SetActive(false);
            page3.SetActive(true);
        }

    }

    public void leftButton()
    {
        if (page3.activeSelf)
        {
            page1.SetActive(false);
            page2.SetActive(true);
            page3.SetActive(false);
        }
        else if (page2.activeSelf)
        {
            page1.SetActive(true);
            page2.SetActive(false);
            page3.SetActive(false);
        }

    }

    public void buyCornSeed()
    {
        currentPotion = 1;
        alert.SetActive(true);
    }

    public void buyStrawberrySeed()
    {
        currentPotion = 2;
        alert.SetActive(true);
    }


    public void buyCarrotSeed()
    {
        currentPotion = 3;
        alert.SetActive(true);
    }

    public void buyCherrySeed()
    {
        currentPotion = 4;
        alert.SetActive(true);
    }

    public void buyBlueBerrySeed()
    {
        currentPotion = 5;
        alert.SetActive(true);
    }

    public void buyGreenGrapeSeed()
    {
        currentPotion = 6;
        alert.SetActive(true);
    }

    public void buyPurpleGrapeSeed()
    {
        currentPotion = 7;
        alert.SetActive(true);
    }

    public void buyKiwiSeed()
    {
        currentPotion = 8;
        alert.SetActive(true);
    }
    public void buyTomatoSeed()
    {
        currentPotion = 9;
        alert.SetActive(true);
    }
    public void buyOrangePepperSeed()
    {
        currentPotion = 10;
        alert.SetActive(true);
    }
    public void buyYellowPepperSeed()
    {
        currentPotion = 11;
        alert.SetActive(true);
    }
    public void buyRedPepperSeed()
    {
        currentPotion = 12;
        alert.SetActive(true);
    }
    public void buyeggPlantSeed()
    {
        currentPotion = 13;
        alert.SetActive(true);
    }
    public void buyTurnipSeed()
    {
        currentPotion = 14;
        alert.SetActive(true);
    }
    public void buyPotatoSeed()
    {
        currentPotion = 15;
        alert.SetActive(true);
    }
    public void buyCauliflowerSeed()
    {
        currentPotion = 16;
        alert.SetActive(true);
    }

    public void buyCabbageSeed()
    {
        currentPotion = 17;
        alert.SetActive(true);
    }

    public void buyPineappleSeed()
    {
        currentPotion = 18;
        alert.SetActive(true);
    }

    public void buyPumpkinSeed()
    {
        currentPotion = 19;
        alert.SetActive(true);
    }
    public void buyMelonrSeed()
    {
        currentPotion = 20;
        alert.SetActive(true);
    }
    public void buyWaterMelonSeed()
    {
        currentPotion = 21;
        alert.SetActive(true);
    }


    public void closePanel()
    {
        alert.SetActive(false);
        panel.SetActive(false);
    }

    public void PotionConfirm()
    {
        if (Int32.Parse(value.text) > 0 && value.text != null)
        {
            switch (currentPotion)
            {
                case 1:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 10000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[0], 1);
                            inventory.save();
                            GameController.coins -= 10000;
                            SeedsInventory.AddItem(seeds[0], 1);
                            SeedsInventory.save();
                        }

                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;
                case 2:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 12000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[1], 1);
                            inventory.save();
                            GameController.coins -= 12000;
                            SeedsInventory.AddItem(seeds[1], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 3:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 14000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[2], 1);
                            inventory.save();
                            GameController.coins -= 14000;
                            SeedsInventory.AddItem(seeds[2], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 4:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 16000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[3], 1);
                            inventory.save();
                            GameController.coins -= 16000;
                            SeedsInventory.AddItem(seeds[3], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 5:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 18000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[4], 1);
                            inventory.save();
                            GameController.coins -= 18000;
                            SeedsInventory.AddItem(seeds[4], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 6:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 21000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[5], 1);
                            inventory.save();
                            GameController.coins -= 21000;
                            SeedsInventory.AddItem(seeds[5], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;
                
                case 7:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 24000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[6], 1);
                            inventory.save();
                            GameController.coins -= 24000;
                            SeedsInventory.AddItem(seeds[6], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 8:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 27000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[7], 1);
                            inventory.save();
                            GameController.coins -= 27000;
                            SeedsInventory.AddItem(seeds[7], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 9:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 30000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[8], 1);
                            inventory.save();
                            GameController.coins -= 30000;
                            SeedsInventory.AddItem(seeds[8], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 10:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 34000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[9], 1);
                            inventory.save();
                            GameController.coins -= 34000;
                            SeedsInventory.AddItem(seeds[9], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 11:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 38000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[10], 1);
                            inventory.save();
                            GameController.coins -= 38000;
                            SeedsInventory.AddItem(seeds[10], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 12:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 42000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[11], 1);
                            inventory.save();
                            GameController.coins -= 42000;
                            SeedsInventory.AddItem(seeds[11], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 13:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 46000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[12], 1);
                            inventory.save();
                            GameController.coins -= 46000;
                            SeedsInventory.AddItem(seeds[12], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 14:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 51000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[13], 1);
                            inventory.save();
                            GameController.coins -= 51000;
                            SeedsInventory.AddItem(seeds[13], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 15:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 56000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[14], 1);
                            inventory.save();
                            GameController.coins -= 56000;
                            SeedsInventory.AddItem(seeds[14], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 16:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 62000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[15], 1);
                            inventory.save();
                            GameController.coins -= 62000;
                            SeedsInventory.AddItem(seeds[15], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 17:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 68000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[16], 1);
                            inventory.save();
                            GameController.coins -= 68000;
                            SeedsInventory.AddItem(seeds[16], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;
                case 18:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 75000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[17], 1);
                            inventory.save();
                            GameController.coins -= 75000;
                            SeedsInventory.AddItem(seeds[17], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;
                case 19:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 85000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[18], 1);
                            inventory.save();
                            GameController.coins -= 85000;
                            SeedsInventory.AddItem(seeds[18], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;
                case 20:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 95000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[19], 1);
                            inventory.save();
                            GameController.coins -= 95000;
                            SeedsInventory.AddItem(seeds[19], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;
                case 21:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 105000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[20], 1);
                            inventory.save();
                            GameController.coins -= 105000;
                            SeedsInventory.AddItem(seeds[20], 1);
                            SeedsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;
            }
        }
    }


    public void valueChange()
    {
        try
        {
            int[] multipliers = { 10, 12, 14, 16, 18, 21, 24, 27, 30, 34, 38, 42, 46 ,51, 56 , 62, 68, 75, 85 ,95,105};

            int num = Int32.Parse(value.text);
            int multiplier = multipliers[currentPotion - 1]; // Array index is 0-based

            int multipliedValue = num * multiplier;

            if (multipliedValue > 999)
            {
                cost.text = (multipliedValue * 0.001).ToString("F2") + "M";
            }
            else
            {
                cost.text = multipliedValue + "K";
            }
        }
        catch
        {
            cost.text = "0";
        }
    }

    public void valueChangeSell()
    {
        try
        {
            int[] multipliers = { Fruit1Price, Fruit2Price, Fruit3Price, fruit4Price, Fruit5Price, Fruit6Price,
                Fruit7Price, Fruit8Price, fruit9Price, Fruit10Price, Fruit11Price, Fruit12Price, Fruit13Price,
                fruit14Price, Fruit15Price, Fruit16Price, Fruit17Price, Fruit18Price, fruit19Price, Fruit20Price, Fruit21Price };

            int num = Int32.Parse(valueSell.text);
            int multiplier = multipliers[currentPotion - 1]; // Array index is 0-based

            int multipliedValue = num * multiplier;

            if (multipliedValue > 999)
            {
                costSell.text = (multipliedValue * 0.001).ToString("F2") + "M";
            }
            else
            {
                costSell.text = multipliedValue + "K";
            }
        }
        catch
        {
            costSell.text = "0";
        }
    }

    public void buyButton()
    {
        buyPanel.SetActive(true);
        sellPanel.SetActive(false);
    }

    public void sellButton()
    {
        buyPanel.SetActive(false);
        sellPanel.SetActive(true);
    }

    public void resetFruits()
    {
        Fruit1Price = UnityEngine.Random.Range(10, 13);
        Fruit2Price = UnityEngine.Random.Range(12, 16);
        Fruit3Price = UnityEngine.Random.Range(14, 18);
        fruit4Price = UnityEngine.Random.Range(16, 20);
        Fruit5Price = UnityEngine.Random.Range(18, 23);
        Fruit6Price = UnityEngine.Random.Range(21, 26);
        Fruit7Price = UnityEngine.Random.Range(24, 30);
        Fruit8Price = UnityEngine.Random.Range(27, 34);
        fruit9Price = UnityEngine.Random.Range(30, 38);
        Fruit10Price = UnityEngine.Random.Range(34, 42);
        Fruit11Price = UnityEngine.Random.Range(38, 47);
        Fruit12Price = UnityEngine.Random.Range(42, 52);
        Fruit13Price = UnityEngine.Random.Range(46, 57);
        fruit14Price = UnityEngine.Random.Range(51, 63);
        Fruit15Price = UnityEngine.Random.Range(56, 69);
        Fruit16Price = UnityEngine.Random.Range(62, 76);
        Fruit17Price = UnityEngine.Random.Range(68, 83);
        Fruit18Price = UnityEngine.Random.Range(75, 92);
        fruit19Price = UnityEngine.Random.Range(85, 104);
        Fruit20Price = UnityEngine.Random.Range(95, 116);
        Fruit21Price = UnityEngine.Random.Range(105, 128);

        float rand1 = UnityEngine.Random.Range(0, 2);
        float rand2 = UnityEngine.Random.Range(0, 2);
        float rand3 = UnityEngine.Random.Range(0, 2);
        float rand4 = UnityEngine.Random.Range(0, 2);
        float rand5 = UnityEngine.Random.Range(0, 2);
        float rand6 = UnityEngine.Random.Range(0, 2);
        float rand7 = UnityEngine.Random.Range(0, 2);
        float rand8 = UnityEngine.Random.Range(0, 2);
        float rand9 = UnityEngine.Random.Range(0, 2);
        float rand10 = UnityEngine.Random.Range(0, 2);
        float rand11 = UnityEngine.Random.Range(0, 2);
        float rand12 = UnityEngine.Random.Range(0, 2);
        float rand13 = UnityEngine.Random.Range(0, 2);
        float rand14 = UnityEngine.Random.Range(0, 2);
        float rand15 = UnityEngine.Random.Range(0, 2);
        float rand16 = UnityEngine.Random.Range(0, 2);
        float rand17 = UnityEngine.Random.Range(0, 2);
        float rand18 = UnityEngine.Random.Range(0, 2);
        float rand19 = UnityEngine.Random.Range(0, 2);
        float rand20 = UnityEngine.Random.Range(0, 2);
        float rand21 = UnityEngine.Random.Range(0, 2);

        switch (rand1)
        {
            case 0:
                fruitTodayPrice[0].text = "todays offer : " + Fruit1Price + "k  ";
                fruitTodayPrice[0].color = Color.white;
                coinImage[0].SetActive(true);
                sellButtons[0].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[0].text = "not buying.";
                fruitTodayPrice[0].color = Color.red;
                coinImage[0].SetActive(false);
                sellButtons[0].SetActive(false);
                break;
        }

        switch (rand2)
        {
            case 0:
                fruitTodayPrice[1].text = "todays offer : " + Fruit2Price + "k  ";
                fruitTodayPrice[1].color = Color.white;
                coinImage[1].SetActive(true);
                sellButtons[1].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[1].text = "not buying.";
                fruitTodayPrice[1].color = Color.red;
                coinImage[1].SetActive(false);
                sellButtons[1].SetActive(false);
                break;
        }

        switch (rand3)
        {
            case 0:
                fruitTodayPrice[2].text = "todays offer : " + Fruit3Price + "k  ";
                fruitTodayPrice[2].color = Color.white;
                coinImage[2].SetActive(true);
                sellButtons[2].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[2].text = "not buying.";
                fruitTodayPrice[2].color = Color.red;
                coinImage[2].SetActive(false);
                sellButtons[2].SetActive(false);
                break;
        }

        switch (rand4)
        {
            case 0:
                fruitTodayPrice[3].text = "todays offer : " + fruit4Price + "k  ";
                fruitTodayPrice[3].color = Color.white;
                coinImage[3].SetActive(true);
                sellButtons[3].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[3].text = "not buying.";
                fruitTodayPrice[3].color = Color.red;
                coinImage[3].SetActive(false);
                sellButtons[3].SetActive(false);
                break;
        }

        switch (rand5)
        {
            case 0:
                fruitTodayPrice[4].text = "todays offer : " + Fruit5Price + "k  ";
                fruitTodayPrice[4].color = Color.white;
                coinImage[4].SetActive(true);
                sellButtons[4].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[4].text = "not buying.";
                fruitTodayPrice[4].color = Color.red;
                coinImage[4].SetActive(false);
                sellButtons[4].SetActive(false);
                break;
        }

        switch (rand6)
        {
            case 0:
                fruitTodayPrice[5].text = "todays offer : " + Fruit6Price + "k  ";
                fruitTodayPrice[5].color = Color.white;
                coinImage[5].SetActive(true);
                sellButtons[5].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[5].text = "not buying.";
                fruitTodayPrice[5].color = Color.red;
                coinImage[5].SetActive(false);
                sellButtons[5].SetActive(false);
                break;
        }

        switch (rand7)
        {
            case 0:
                fruitTodayPrice[6].text = "todays offer : " + Fruit7Price + "k  ";
                fruitTodayPrice[6].color = Color.white;
                coinImage[6].SetActive(true);
                sellButtons[6].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[6].text = "not buying.";
                fruitTodayPrice[6].color = Color.red;
                coinImage[6].SetActive(false);
                sellButtons[6].SetActive(false);
                break;
        }

        switch (rand8)
        {
            case 0:
                fruitTodayPrice[7].text = "todays offer : " + Fruit8Price + "k  ";
                fruitTodayPrice[7].color = Color.white;
                coinImage[7].SetActive(true);
                sellButtons[7].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[7].text = "not buying.";
                fruitTodayPrice[7].color = Color.red;
                coinImage[7].SetActive(false);
                sellButtons[7].SetActive(false);
                break;
        }

        switch (rand9)
        {
            case 0:
                fruitTodayPrice[8].text = "todays offer : " + fruit9Price + "k  ";
                fruitTodayPrice[8].color = Color.white;
                coinImage[8].SetActive(true);
                sellButtons[8].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[8].text = "not buying.";
                fruitTodayPrice[8].color = Color.red;
                coinImage[8].SetActive(false);
                sellButtons[8].SetActive(false);
                break;
        }

        switch (rand10)
        {
            case 0:
                fruitTodayPrice[9].text = "todays offer : " + Fruit10Price + "k  ";
                fruitTodayPrice[9].color = Color.white;
                coinImage[9].SetActive(true);
                sellButtons[9].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[9].text = "not buying.";
                fruitTodayPrice[9].color = Color.red;
                coinImage[9].SetActive(false);
                sellButtons[9].SetActive(false);
                break;
        }

        switch (rand11)
        {
            case 0:
                fruitTodayPrice[10].text = "todays offer : " + Fruit11Price + "k  ";
                fruitTodayPrice[10].color = Color.white;
                coinImage[10].SetActive(true);
                sellButtons[10].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[10].text = "not buying.";
                fruitTodayPrice[10].color = Color.red;
                coinImage[10].SetActive(false);
                sellButtons[10].SetActive(false);
                break;
        }
        switch (rand12)
        {
            case 0:
                fruitTodayPrice[11].text = "todays offer : " + Fruit12Price + "k  ";
                fruitTodayPrice[11].color = Color.white;
                coinImage[11].SetActive(true);
                sellButtons[11].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[11].text = "not buying.";
                fruitTodayPrice[11].color = Color.red;
                coinImage[11].SetActive(false);
                sellButtons[11].SetActive(false);
                break;
        }

        switch (rand13)
        {
            case 0:
                fruitTodayPrice[12].text = "todays offer : " + Fruit13Price + "k  ";
                fruitTodayPrice[12].color = Color.white;
                coinImage[12].SetActive(true);
                sellButtons[12].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[12].text = "not buying.";
                fruitTodayPrice[12].color = Color.red;
                coinImage[12].SetActive(false);
                sellButtons[12].SetActive(false);
                break;
        }

        switch (rand14)
        {
            case 0:
                fruitTodayPrice[13].text = "todays offer : " + fruit14Price + "k  ";
                fruitTodayPrice[13].color = Color.white;
                coinImage[13].SetActive(true);
                sellButtons[13].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[13].text = "not buying.";
                fruitTodayPrice[13].color = Color.red;
                coinImage[13].SetActive(false);
                sellButtons[13].SetActive(false);
                break;
        }

        switch (rand15)
        {
            case 0:
                fruitTodayPrice[14].text = "todays offer : " + Fruit15Price + "k  ";
                fruitTodayPrice[14].color = Color.white;
                coinImage[14].SetActive(true);
                sellButtons[14].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[14].text = "not buying.";
                fruitTodayPrice[14].color = Color.red;
                coinImage[14].SetActive(false);
                sellButtons[14].SetActive(false);
                break;
        }

        switch (rand16)
        {
            case 0:
                fruitTodayPrice[15].text = "todays offer : " + Fruit16Price + "k  ";
                fruitTodayPrice[15].color = Color.white;
                coinImage[15].SetActive(true);
                sellButtons[15].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[15].text = "not buying.";
                fruitTodayPrice[15].color = Color.red;
                coinImage[15].SetActive(false);
                sellButtons[15].SetActive(false);
                break;
        }

        switch (rand17)
        {
            case 0:
                fruitTodayPrice[16].text = "todays offer : " + Fruit17Price + "k  ";
                fruitTodayPrice[16].color = Color.white;
                coinImage[16].SetActive(true);
                sellButtons[16].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[16].text = "not buying.";
                fruitTodayPrice[16].color = Color.red;
                coinImage[16].SetActive(false);
                sellButtons[16].SetActive(false);
                break;
        }

        switch (rand18)
        {
            case 0:
                fruitTodayPrice[17].text = "todays offer : " + Fruit18Price + "k  ";
                fruitTodayPrice[17].color = Color.white;
                coinImage[17].SetActive(true);
                sellButtons[17].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[17].text = "not buying.";
                fruitTodayPrice[17].color = Color.red;
                coinImage[17].SetActive(false);
                sellButtons[17].SetActive(false);
                break;
        }

        switch (rand19)
        {
            case 0:
                fruitTodayPrice[18].text = "todays offer : " + fruit19Price + "k  ";
                fruitTodayPrice[18].color = Color.white;
                coinImage[18].SetActive(true);
                sellButtons[18].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[18].text = "not buying.";
                fruitTodayPrice[18].color = Color.red;
                coinImage[18].SetActive(false);
                sellButtons[18].SetActive(false);
                break;
        }

        switch (rand20)
        {
            case 0:
                fruitTodayPrice[19].text = "todays offer : " + Fruit20Price + "k  ";
                fruitTodayPrice[19].color = Color.white;
                coinImage[19].SetActive(true);
                sellButtons[19].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[19].text = "not buying.";
                fruitTodayPrice[19].color = Color.red;
                coinImage[19].SetActive(false);
                sellButtons[19].SetActive(false);
                break;
        }

        switch (rand21)
        {
            case 0:
                fruitTodayPrice[20].text = "todays offer : " + Fruit21Price + "k  ";
                fruitTodayPrice[20].color = Color.white;
                coinImage[20].SetActive(true);
                sellButtons[20].SetActive(true);
                break;
            case 1:
                fruitTodayPrice[20].text = "not buying.";
                fruitTodayPrice[20].color = Color.red;
                coinImage[20].SetActive(false);
                sellButtons[20].SetActive(false);
                break;
        }
    }
    public void sellFruit1()
    {
        panel.SetActive(true);
        currentFruit = "fruit1";
        currentPotion = 1;
    }

    public void sellFruit2()
    {
        panel.SetActive(true);
        currentFruit = "fruit2";
        currentPotion = 2;
    }

    public void sellFruit3()
    {
        panel.SetActive(true);
        currentFruit = "fruit3";
        currentPotion = 3;
    }

    public void sellFruit4()
    {
        panel.SetActive(true);
        currentFruit = "fruit4";
        currentPotion = 4;
    }

    public void sellFruit5()
    {
        panel.SetActive(true);
        currentFruit = "fruit5";
        currentPotion = 5;
    }

    public void sellFruit6()
    {
        panel.SetActive(true);
        currentFruit = "fruit6";
        currentPotion = 6;
    }

    public void sellFruit7()
    {
        panel.SetActive(true);
        currentFruit = "fruit7";
        currentPotion = 7;
    }

    public void sellFruit8()
    {
        panel.SetActive(true);
        currentFruit = "fruit8";

        currentPotion = 8;
    }

    public void sellFruit9()
    {
        panel.SetActive(true);
        currentFruit = "fruit9";
        currentPotion = 9;
    }

    public void sellFruit10()
    {
        panel.SetActive(true);
        currentFruit = "fruit10";
        currentPotion = 10;
    }

    public void sellFruit11()
    {
        panel.SetActive(true);
        currentFruit = "fruit11"; 
        currentPotion = 11;
    }

    public void sellFruit12()
    {
        panel.SetActive(true);
        currentFruit = "fruit12";
        currentPotion = 12;
    }

    public void sellFruit13()
    {
        panel.SetActive(true);
        currentFruit = "fruit13";
        currentPotion = 13;
    }
    public void sellFruit14()
    {
        panel.SetActive(true);
        currentFruit = "fruit14";
        currentPotion = 14;
    }
    public void sellFruit15()
    {
        panel.SetActive(true);
        currentFruit = "fruit15";
        currentPotion = 15;
    }
    public void sellFruit16()
    {
        panel.SetActive(true);
        currentFruit = "fruit16";
        currentPotion = 16;
    }
    public void sellFruit17()
    {
        panel.SetActive(true);
        currentFruit = "fruit17";
        currentPotion = 17;
    }
    public void sellFruit18()
    {
        panel.SetActive(true);
        currentFruit = "fruit18";
        currentPotion = 18;
    }
    public void sellFruit19()
    {
        panel.SetActive(true);
        currentFruit = "fruit19";
        currentPotion = 19;
    }
    public void sellFruit20()
    {
        panel.SetActive(true);
        currentFruit = "fruit20";
        currentPotion = 20;
    }
    public void sellFruit21()
    {
        panel.SetActive(true);
        currentFruit = "fruit21";
        currentPotion = 21;
    }
    public void ConfirmButton()
    {

        int number = int.Parse(valueSell.text);
        if (number > 0)
        {
            switch (currentFruit)
            {

                case "fruit1":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[0])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[0]);
                            SeedsInventory.RemoveItem(fruits[0]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;
                          
                            GameController.coins += Fruit1Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit2":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[1])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[1]);
                            SeedsInventory.RemoveItem(fruits[1]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit2Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit3":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[2])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[2]);
                            SeedsInventory.RemoveItem(fruits[2]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit3Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit4":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[3])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[3]);
                            SeedsInventory.RemoveItem(fruits[3]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += fruit4Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit5":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[4])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[4]);
                            SeedsInventory.RemoveItem(fruits[4]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit5Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit6":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[5])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[5]);
                            SeedsInventory.RemoveItem(fruits[5]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit6Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit7":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[6])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[6]);
                            SeedsInventory.RemoveItem(fruits[6]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit7Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit8":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[7])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[7]);
                            SeedsInventory.RemoveItem(fruits[7]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit8Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit9":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[8])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[8]);
                            SeedsInventory.RemoveItem(fruits[8]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += fruit9Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit10":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[9])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[9]);
                            SeedsInventory.RemoveItem(fruits[9]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit10Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit11":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[10])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[10]);
                            SeedsInventory.RemoveItem(fruits[10]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit11Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit12":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[11])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[11]);
                            SeedsInventory.RemoveItem(fruits[11]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit12Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit13":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[12])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[12]);
                            SeedsInventory.RemoveItem(fruits[12]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit13Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit14":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[13])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[13]);
                            SeedsInventory.RemoveItem(fruits[13]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += fruit14Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit15":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[14])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[14]);
                            SeedsInventory.RemoveItem(fruits[14]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit15Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit16":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[15])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[15]);
                            SeedsInventory.RemoveItem(fruits[15]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit16Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit17":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[16])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[16]);
                            SeedsInventory.RemoveItem(fruits[16]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit17Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit18":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[17])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[17]);
                            SeedsInventory.RemoveItem(fruits[17]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit18Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit19":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[18])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[18]);
                            SeedsInventory.RemoveItem(fruits[18]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += fruit19Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit20":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[19])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[19]);
                            SeedsInventory.RemoveItem(fruits[19]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit20Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fruit21":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item == fruits[20])
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            inventory.RemoveItem(fruits[20]);
                            SeedsInventory.RemoveItem(fruits[20]);
                            inventory.save();
                            SeedsInventory.save();
                            Inventory.refreshInv = true;

                            GameController.coins += Fruit21Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(SeedsPanel.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;
            }

            panel.SetActive(false);
        }
    }
}
