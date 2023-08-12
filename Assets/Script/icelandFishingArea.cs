using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class icelandFishingArea : MonoBehaviour
{
    public InventoryObject inventory;
    public InventoryObject Inv;
    public InventoryObject meatInventory;
    public int Xstart;
    public int Ystart;
    public float XspaceBtwItem;
    public int NumberOfColumns;
    public float YspaceBtwItems;
    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();
    public static bool refreshInv;
    public GameObject panel;

    public Sprite[] fishSprites;
    public Image[] fishSpriteSlot;
    private string input;
    public InputField value;

    public ItemObject[] Fishs;
    public static string currentFish;

    private int Fish1Price;
    private int Fish2Price;
    private int Fish3Price;
    private int Fish4Price;
    private int Fish5Price;

    public Text fish1TodayPrice;
    public Text fish2TodayPrice;
    public Text fish3TodayPrice;
    public Text fish4TodayPrice;
    public Text fish5TodayPrice;

    public GameObject[] coinImage;

    public GameObject sell1;
    public GameObject sell2;
    public GameObject sell3;
    public GameObject sell4;
    public GameObject sell5;

    public AudioSource coinCollect;

    private int counter;

    public GameObject NotEnoughFishText;

    private bool reset = true;

    // Start is called before the first frame update
    void Start()
    {
        CreateDisplay();

        Fish1Price = Random.Range(40, 81);
        Fish2Price = Random.Range(80, 201);
        Fish3Price = Random.Range(200, 401);
        Fish4Price = Random.Range(400, 1001);
        Fish5Price = Random.Range(2000, 4001);

        int rand1 = Random.Range(0, 2);
        int rand2 = Random.Range(0, 2);
        int rand3 = Random.Range(0, 2);
        int rand4 = Random.Range(0, 2);
        int rand5 = Random.Range(0, 2);

        switch (rand1)
        {
            case 0:
                fish1TodayPrice.text = "todays offer : " + Fish1Price + "k  ";
                fish1TodayPrice.color = Color.white;
                coinImage[0].SetActive(true);
                sell1.SetActive(true);
                break;
            case 1:
                fish1TodayPrice.text = "not buying.";
                fish1TodayPrice.color = Color.red;
                coinImage[0].SetActive(false);
                sell1.SetActive(false);
                break;
        }

        switch (rand2)
        {
            case 0:
                fish2TodayPrice.text = "todays offer : " + Fish2Price + "k  ";
                fish2TodayPrice.color = Color.white;
                coinImage[1].SetActive(true);
                sell2.SetActive(true);
                break;
            case 1:
                fish2TodayPrice.text = "not buying.";
                fish2TodayPrice.color = Color.red;
                coinImage[1].SetActive(false);
                sell2.SetActive(false);
                break;
        }

        switch (rand3)
        {
            case 0:
                fish3TodayPrice.text = "todays offer : " + Fish3Price + "k  ";
                fish3TodayPrice.color = Color.white;
                coinImage[2].SetActive(true);
                sell3.SetActive(true);
                break;
            case 1:
                fish3TodayPrice.text = "not buying.";
                fish3TodayPrice.color = Color.red;
                coinImage[2].SetActive(false);
                sell3.SetActive(false);
                break;
        }

        switch (rand4)
        {
            case 0:
                fish4TodayPrice.text = "todays offer : " + Fish4Price + "k  ";
                fish4TodayPrice.color = Color.white;
                coinImage[3].SetActive(true);
                sell4.SetActive(true);
                break;
            case 1:
                fish4TodayPrice.text = "not buying.";
                fish4TodayPrice.color = Color.red;
                coinImage[3].SetActive(false);
                sell4.SetActive(false);
                break;
        }

        switch (rand5)
        {
            case 0:
                fish5TodayPrice.text = "todays offer : " + Fish5Price + "k  ";
                fish5TodayPrice.color = Color.white;
                coinImage[4].SetActive(true);
                sell5.SetActive(true);
                break;
            case 1:
                fish5TodayPrice.text = "not buying.";
                fish5TodayPrice.color = Color.red;
                coinImage[4].SetActive(false);
                sell5.SetActive(false);
                break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (refreshInv)
        {
            itemsDisplayed.Clear();
            GameObject[] fishs = GameObject.FindGameObjectsWithTag("fishIcons");

            foreach (GameObject fish in fishs)
            {
                Destroy(fish);
            }

            CreateDisplay();
            refreshInv = false;

        }
        if (GameController.Fish1Discovered)
        {
            fishSpriteSlot[0].sprite = fishSprites[0];
        }
        if (GameController.Fish2Discovered)
        {
            fishSpriteSlot[1].sprite = fishSprites[1];
        }
        if (GameController.Fish3Discovered)
        {
            fishSpriteSlot[2].sprite = fishSprites[2];
        }
        if (GameController.Fish4Discovered)
        {
            fishSpriteSlot[3].sprite = fishSprites[3];
        }
        if (GameController.Fish5Discovered)
        {
            fishSpriteSlot[4].sprite = fishSprites[4];
        }
        if (GameController.Fish6Discovered)
        {
            fishSpriteSlot[5].sprite = fishSprites[5];
        }
        if (GameController.Fish7Discovered)
        {
            fishSpriteSlot[6].sprite = fishSprites[6];
        }
        if (GameController.Fish8Discovered)
        {
            fishSpriteSlot[7].sprite = fishSprites[7];
        }
        if (GameController.Fish9Discovered)
        {
            fishSpriteSlot[8].sprite = fishSprites[8];
        }
        if (GameController.Fish10Discovered)
        {
            fishSpriteSlot[9].sprite = fishSprites[9];
        }
        if (GameController.Fish11Discovered)
        {
            fishSpriteSlot[10].sprite = fishSprites[10];
        }
        if (GameController.Fish12Discovered)
        {
            fishSpriteSlot[11].sprite = fishSprites[11];
        }
        if (GameController.Fish13Discovered)
        {
            fishSpriteSlot[12].sprite = fishSprites[12];
        }
        if (GameController.Fish14Discovered)
        {
            fishSpriteSlot[13].sprite = fishSprites[13];
        }
        if (GameController.Fish15Discovered)
        {
            fishSpriteSlot[14].sprite = fishSprites[14];
        }

        if (time.hour == 0)
        {
            if (reset)
            {
                resetFish();
                reset = false;
            }
        }
        if (time.hour == 1)
        {
            reset = true;
        }

    }

    public void CreateDisplay()
    {

        for (int i = 0; i < inventory.Container.Count; i++)
        {

            var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
            obj.transform.SetParent(GameObject.FindGameObjectWithTag("fishRightSide").transform, false);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            obj.GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
            itemsDisplayed.Add(inventory.Container[i], obj);

        }
    }

    public Vector3 GetPosition(int i)
    {
        return new Vector3(Xstart + (XspaceBtwItem * (i % NumberOfColumns)), Ystart + (-YspaceBtwItems * (i / NumberOfColumns)), 0f);
    }

    public void Fish1Sell()
    {
        panel.SetActive(true);
        currentFish = "fish11";
    }

    public void Fish2Sell()
    {
        panel.SetActive(true);
        currentFish = "fish12";
    }

    public void Fish3Sell()
    {
        panel.SetActive(true);
        currentFish = "fish13";
    }

    public void Fish4Sell()
    {
        panel.SetActive(true);
        currentFish = "fish14";
    }

    public void Fish5Sell()
    {
        panel.SetActive(true);
        currentFish = "fish15";
    }

    public void closePanel()
    {
        panel.SetActive(false);
    }
    public void ConfirmButton()
    {

        int number = int.Parse(value.text);
        if (number > 0)
        {
            switch (currentFish)
            {
                case "fish11":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item.name == "Hammerhead Shark")
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            Inv.RemoveItem(Fishs[0]);
                            inventory.RemoveItem(Fishs[0]);
                            meatInventory.RemoveItem(Fishs[0]);
                            Inv.save();
                            inventory.save();
                            meatInventory.save();
                            Inventory.refreshInv = true;
                            refreshInv = true;
                            GameController.coins += Fish1Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(this.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fish12":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item.name == "turtle")
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            Inv.RemoveItem(Fishs[1]);
                            inventory.RemoveItem(Fishs[1]);
                            meatInventory.RemoveItem(Fishs[1]);
                            Inv.save();
                            inventory.save();
                            meatInventory.save();
                            Inventory.refreshInv = true;
                            refreshInv = true;
                            GameController.coins += Fish2Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(this.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fish13":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item.name == "jellyfish")
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            Inv.RemoveItem(Fishs[2]);
                            inventory.RemoveItem(Fishs[2]);
                            meatInventory.RemoveItem(Fishs[2]);
                            Inv.save();
                            inventory.save();
                            meatInventory.save();
                            Inventory.refreshInv = true;
                            refreshInv = true;
                            GameController.coins += Fish3Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(this.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fish14":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item.name == "Squid")
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            Inv.RemoveItem(Fishs[3]);
                            inventory.RemoveItem(Fishs[3]);
                            meatInventory.RemoveItem(Fishs[3]);
                            Inv.save();
                            inventory.save();
                            meatInventory.save();
                            Inventory.refreshInv = true;
                            refreshInv = true;
                            GameController.coins += Fish4Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(this.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;

                case "fish15":
                    counter = 0;
                    for (int i = 0; i < inventory.Container.Count; i++)
                    {
                        if (inventory.Container[i].item.name == "Crawfish")
                        {
                            counter = inventory.Container[i].amount;
                        }
                    }
                    if (counter >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            Inv.RemoveItem(Fishs[4]);
                            inventory.RemoveItem(Fishs[4]);
                            meatInventory.RemoveItem(Fishs[4]);
                            Inv.save();
                            inventory.save();
                            meatInventory.save();
                            Inventory.refreshInv = true;
                            refreshInv = true;
                            GameController.coins += Fish5Price * 1000;
                        }
                        coinCollect.Play();
                    }
                    else
                    {
                        var forgedTxt = Instantiate(NotEnoughFishText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                        forgedTxt.transform.SetParent(this.gameObject.transform, false);
                        Destroy(forgedTxt, 1f);
                    }
                    break;
            }

            panel.SetActive(false);
        }
    }
    public void resetFish()
    {

        Fish1Price = Random.Range(40, 81);
        Fish2Price = Random.Range(80, 201);
        Fish3Price = Random.Range(200, 401);
        Fish4Price = Random.Range(400, 1001);
        Fish5Price = Random.Range(2000, 4001);


        int rand1 = Random.Range(0, 2);
        int rand2 = Random.Range(0, 2);
        int rand3 = Random.Range(0, 2);
        int rand4 = Random.Range(0, 2);
        int rand5 = Random.Range(0, 2);

        switch (rand1)
        {
            case 0:
                fish1TodayPrice.text = "todays offer : " + Fish1Price + "k  ";
                fish1TodayPrice.color = Color.white;
                coinImage[0].SetActive(true);
                sell1.SetActive(true);
                break;
            case 1:
                fish1TodayPrice.text = "not buying.";
                fish1TodayPrice.color = Color.red;
                coinImage[0].SetActive(false);
                sell1.SetActive(false);
                break;
        }

        switch (rand2)
        {
            case 0:
                fish2TodayPrice.text = "todays offer : " + Fish2Price + "k  ";
                fish2TodayPrice.color = Color.white;
                coinImage[1].SetActive(true);
                sell2.SetActive(true);
                break;
            case 1:
                fish2TodayPrice.text = "not buying.";
                fish2TodayPrice.color = Color.red;
                coinImage[1].SetActive(false);
                sell2.SetActive(false);
                break;
        }

        switch (rand3)
        {
            case 0:
                fish3TodayPrice.text = "todays offer : " + Fish3Price + "k  ";
                fish3TodayPrice.color = Color.white;
                coinImage[2].SetActive(true);
                sell3.SetActive(true);
                break;
            case 1:
                fish3TodayPrice.text = "not buying.";
                fish3TodayPrice.color = Color.red;
                coinImage[2].SetActive(false);
                sell3.SetActive(false);
                break;
        }

        switch (rand4)
        {
            case 0:
                fish4TodayPrice.text = "todays offer : " + Fish4Price + "k  ";
                fish4TodayPrice.color = Color.white;
                coinImage[3].SetActive(true);
                sell4.SetActive(true);
                break;
            case 1:
                fish4TodayPrice.text = "not buying.";
                fish4TodayPrice.color = Color.red;
                coinImage[3].SetActive(false);
                sell4.SetActive(false);
                break;
        }

        switch (rand5)
        {
            case 0:
                fish5TodayPrice.text = "todays offer : " + Fish5Price + "k  ";
                fish5TodayPrice.color = Color.white;
                coinImage[4].SetActive(true);
                sell5.SetActive(true);
                break;
            case 1:
                fish5TodayPrice.text = "not buying.";
                fish5TodayPrice.color = Color.red;
                coinImage[4].SetActive(false);
                sell5.SetActive(false);
                break;
        }
    }
}