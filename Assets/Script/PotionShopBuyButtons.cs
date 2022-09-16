using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionShopBuyButtons : MonoBehaviour
{
    public InventoryObject inventory;
    public InventoryObject potionsInventory;

    public ItemObject smallHealthPotion;
    public ItemObject bigHealthPotion;
    public ItemObject smallSheildPotion;
    public ItemObject bigSheildPotion;
    public ItemObject smallSpeedPotion;
    public ItemObject bigSpeedPotion;

    public GameObject alert;
    private int currentPotion;

    public Text cost;
    public InputField value;

    public AudioSource coinSound;
    public GameObject notEnoughMoneyText;
    public GameObject potionShop;

    public void smallHealthPotionBuy()
    {
        currentPotion = 1;
        alert.SetActive(true);

    }
    public void bigHealthPotionBuy()
    {
        currentPotion = 2;
        alert.SetActive(true);

    }
    public void smallSheildPotionBuy()
    {
        currentPotion = 3;
        alert.SetActive(true);

    }
    public void bigSheildPotionBuy()
    {
        currentPotion = 4;
        alert.SetActive(true);

    }
    public void smallSpeedPotionBuy()
    {
        currentPotion = 5;
        alert.SetActive(true);

    }
    public void bigSpeedPotionBuy()
    {
        currentPotion = 6;
        alert.SetActive(true);

    }

    public void PotionConfirm()
    {
        if (Int32.Parse(value.text) > 0 && value.text != null)
        {
            switch (currentPotion)
            {
                case 1:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 50000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(smallHealthPotion, 1);
                            inventory.save();
                            GameController.coins -= 50000;
                            potionsInventory.AddItem(smallHealthPotion, 1);
                            potionsInventory.save();
                        }

                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(potionShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;
                case 2:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 100000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(bigHealthPotion, 1);
                            inventory.save();
                            GameController.coins -= 100000;
                            potionsInventory.AddItem(bigHealthPotion, 1);
                            potionsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(potionShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 3:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 50000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(smallSheildPotion, 1);
                            inventory.save();
                            GameController.coins -= 50000;
                            potionsInventory.AddItem(smallSheildPotion, 1);
                            potionsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(potionShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 4:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 100000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(bigSheildPotion, 1);
                            inventory.save();
                            GameController.coins -= 100000;
                            potionsInventory.AddItem(bigSheildPotion, 1);
                            potionsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(potionShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 5:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 50000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(smallSpeedPotion, 1);
                            inventory.save();
                            GameController.coins -= 50000;
                            potionsInventory.AddItem(smallSpeedPotion, 1);
                            potionsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(potionShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case 6:
                    alert.SetActive(false);
                    if (GameController.coins >= Int32.Parse(value.text) * 100000)
                    {
                        for (int i = 0; i < Int32.Parse(value.text); i++)
                        {
                            inventory.AddItem(bigSpeedPotion, 1);
                            inventory.save();
                            GameController.coins -= 100000;
                            potionsInventory.AddItem(bigSpeedPotion, 1);
                            potionsInventory.save();
                        }
                        coinSound.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(notEnoughMoneyText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(potionShop.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;
            }
        }
    }


    public void closePanel()
    {
        alert.SetActive(false);
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