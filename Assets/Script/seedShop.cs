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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[0], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[1], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[2], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[3], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[4], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[5], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[6], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[7], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[8], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[9], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[10], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[11], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[12], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[13], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[14], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[15], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[16], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[17], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[18], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[19], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
                    if (GameController.coins >= Int32.Parse(value.text) * 1000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(seeds[20], 1);
                            inventory.save();
                            GameController.coins -= 1000;
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
            switch (currentPotion)
            {
                case 1:
                    int num = Int32.Parse(value.text);

                    if (num > 19)
                    {
                        cost.text = num * 0.05 + "M";
                    }
                    else
                    {
                        cost.text = num * 50 + "K";
                    }
                    break;

                case 2:
                    int num1 = Int32.Parse(value.text);
                    if (num1 > 9)
                    {
                        cost.text = num1 * 0.1 + "M";
                    }
                    else
                    {
                        cost.text = num1 * 100 + "K";
                    }
                    break;

                case 3:
                    int num2 = Int32.Parse(value.text);

                    if (num2 > 19)
                    {
                        cost.text = num2 * 0.05 + "M";
                    }
                    else
                    {
                        cost.text = num2 * 50 + "K";
                    }
                    break;

                case 4:
                    int num3 = Int32.Parse(value.text);

                    if (num3 > 9)
                    {
                        cost.text = num3 * 0.1 + "M";
                    }
                    else
                    {
                        cost.text = num3 * 100 + "K";
                    }
                    break;

                case 5:
                    int num4 = Int32.Parse(value.text);

                    if (num4 > 19)
                    {
                        cost.text = num4 * 0.05 + "M";
                    }
                    else
                    {
                        cost.text = num4 * 50 + "K";
                    }
                    break;

                case 6:
                    int num5 = Int32.Parse(value.text);

                    if (num5 > 9)
                    {
                        cost.text = num5 * 0.1 + "M";
                    }
                    else
                    {
                        cost.text = num5 * 100 + "K";
                    }

                    break;
            }

        }
        catch
        {
            cost.text = "0";
        }
    }
}
