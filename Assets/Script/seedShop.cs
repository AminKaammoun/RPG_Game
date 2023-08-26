using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class seedShop : MonoBehaviour
{
    public InventoryObject inventory;
    public InventoryObject SeedsInventory;

    public ItemObject[] seeds;

    public GameObject page1;
    public GameObject page2;
    public GameObject page3;

    public GameObject alert;
    public Text cost;

    private int currentPotion;
    public InputField value;

    public AudioSource coinSound;
    public GameObject notEnoughMoneyText;
    public GameObject SeedShop;

    public GameObject buyPanel;
    public GameObject sellPanel;
   

    // Start is called before the first frame update
    void Start()
    {
        page1.SetActive(true);
        page2.SetActive(false);
        page3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
