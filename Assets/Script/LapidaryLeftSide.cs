using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public enum SelectedGear
{
    sword,
    shield,
    helmet,
    belt,
    ring
}
public class LapidaryLeftSide : MonoBehaviour
{
    public static SelectedGear currentgear;

    private string attackGear;
    private string defGear;
    private string helmetGear;
    private string beltGear;
    private string ringGear;

    public Text atkGemLevel;
    public Text defGemLevel;
    public Text helmetGemLevel;
    public Text beltGemLevel;
    public Text ringGemLevel;

    public GameObject effect;
    public GameObject icon;

    public InventoryObject inventory;
    public int Xstart;
    public int Ystart;
    public float XspaceBtwItem;
    public int NumberOfColumns;
    public float YspaceBtwItems;
    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();

    public static bool refreshInv = false;

    public Sprite atkLevel1Gear;
    public Sprite atkLevel10Gear;

    public Sprite defLevel1Gear;
    public Sprite defLevel10Gear;

    public Sprite helmetLevel1Gear;
    public Sprite helmetLevel10Gear;

    public Sprite beltLevel1Gear;
    public Sprite beltLevel10Gear;

    public Sprite ringLevel1Gear;
    public Sprite ringLevel10Gear;

    public Sprite AtkEmpty;
    public Sprite DefEmpty;
    public Sprite HelmetEmpty;
    public Sprite RingEmpty;
    public Sprite BeltEmpty;

    public Image AttackGear;
    public Image DefGear;
    public Image HelmetGear;
    public Image BeltGear;
    public Image RingGear;

    public Image CurrentGear;

    public GameObject atkButton;
    public GameObject DefButton;
    public GameObject HelmetButton;
    public GameObject BeltButton;
    public GameObject RingButton;

    public Text atkGearAtkText;
    public Text atkGearDefText;
    public Text atkGearSpText;
    public Text atkGearAgiText;
    public Text atkGearHpText;

    public Text defGearAtkText;
    public Text defGearDefText;
    public Text defGearSpText;
    public Text defGearAgiText;
    public Text defGearHpText;

    public Text HelmetGearAtkText;
    public Text HelmetGearDefText;
    public Text HelmetGearSpText;
    public Text HelmetGearAgiText;
    public Text HelmetGearHpText;

    public Text BeltGearAtkText;
    public Text BeltGearDefText;
    public Text BeltGearSpText;
    public Text BeltGearAgiText;
    public Text BeltGearHpText;

    public Text RingGearAtkText;
    public Text RingGearDefText;
    public Text RingGearSpText;
    public Text RingGearAgiText;
    public Text RingGearHpText;

    public GameObject NoAtkEquipTxt;
    public GameObject NoDefEquipTxt;
    public GameObject NoHelmetEquipTxt;
    public GameObject NoBeltEquipTxt;
    public GameObject NoRingEquipTxt;

    public static bool refresh = false;

    // Start is called before the first frame update
    void Start()
    {
        CreateDisplay();
        attackGear = PlayerPrefs.GetString("AttackGear");
        defGear = PlayerPrefs.GetString("DefGear");
        helmetGear = PlayerPrefs.GetString("HelmetGear");
        beltGear = PlayerPrefs.GetString("BeltGear");
        ringGear = PlayerPrefs.GetString("RingGear");

        switch (attackGear)
        {
            case "":
                AttackGear.sprite = AtkEmpty;
                atkButton.SetActive(false);
                NoAtkEquipTxt.SetActive(true);
                atkGearAtkText.text = "";
                atkGearDefText.text = "";
                atkGearSpText.text = "";
                atkGearAgiText.text = "";
                atkGearHpText.text = "";
                break;

            case "lvl 1 attack (equipmentObject)":
                atkButton.SetActive(true);
                NoAtkEquipTxt.SetActive(false);
                AttackGear.sprite = atkLevel1Gear;
                atkGearAtkText.text = "atk:10";
                atkGearDefText.text = "def:5";
                atkGearSpText.text = "sp:2";
                atkGearAgiText.text = "agi:3";
                atkGearHpText.text = "hp:5";
                break;

            case "lvl 10 attack (equipmentObject)":
                atkButton.SetActive(true);
                NoAtkEquipTxt.SetActive(false);
                AttackGear.sprite = atkLevel10Gear;
                atkGearAtkText.text = "atk:50";
                atkGearDefText.text = "def:25";
                atkGearSpText.text = "sp:10";
                atkGearAgiText.text = "agi:15";
                atkGearHpText.text = "hp:25";
                break;

            case "lvl 30 attack (equipmentObject)":

                break;
            case "lvl 50 attack (equipmentObject)":

                break;
            case "lvl 100 attack (equipmentObject)":

                break;

        }

        switch (defGear)
        {
            case "":
                NoDefEquipTxt.SetActive(true);
                DefButton.SetActive(false);
                DefGear.sprite = DefEmpty;
                defGearAtkText.text = "";
                defGearDefText.text = "";
                defGearSpText.text = "";
                defGearAgiText.text = "";
                defGearHpText.text = "";
                break;
            case "lvl 1 def (equipmentObject)":
                NoDefEquipTxt.SetActive(false);
                DefButton.SetActive(true);
                DefGear.sprite = defLevel1Gear;
                defGearAtkText.text = "atk:2";
                defGearDefText.text = "def:10";
                defGearSpText.text = "sp:2";
                defGearAgiText.text = "agi:2";
                defGearHpText.text = "hp:10";
                break;

            case "lvl 10 def (equipmentObject)":
                NoDefEquipTxt.SetActive(false);
                DefButton.SetActive(true);
                DefGear.sprite = defLevel10Gear;
                defGearAtkText.text = "atk:10";
                defGearDefText.text = "def:50";
                defGearSpText.text = "sp:10";
                defGearAgiText.text = "agi:10";
                defGearHpText.text = "hp:50";
                break;

            case "lvl 30 def (equipmentObject)":

                break;
            case "lvl 50 def (equipmentObject)":

                break;
            case "lvl 100 def (equipmentObject)":

                break;

        }

        switch (helmetGear)
        {
            case "":
                NoHelmetEquipTxt.SetActive(true);
                HelmetButton.SetActive(false);
                HelmetGear.sprite = HelmetEmpty;
                HelmetGearAtkText.text = "";
                HelmetGearDefText.text = "";
                HelmetGearSpText.text = "";
                HelmetGearAgiText.text = "";
                HelmetGearHpText.text = "";
                break;

            case "lvl 1 helmet (equipmentObject)":
                NoHelmetEquipTxt.SetActive(false);
                HelmetButton.SetActive(true);
                HelmetGear.sprite = helmetLevel1Gear;
                HelmetGearAtkText.text = "atk:3";
                HelmetGearDefText.text = "def:4";
                HelmetGearSpText.text = "sp:2";
                HelmetGearAgiText.text = "agi:10";
                HelmetGearHpText.text = "hp:8";
                break;

            case "lvl 10 helmet (equipmentObject)":
                NoHelmetEquipTxt.SetActive(false);
                HelmetButton.SetActive(true);
                HelmetGear.sprite = helmetLevel10Gear;
                HelmetGearAtkText.text = "atk:15";
                HelmetGearDefText.text = "def:20";
                HelmetGearSpText.text = "sp:10";
                HelmetGearAgiText.text = "agi:50";
                HelmetGearHpText.text = "hp:40";
                break;
            case "lvl 30 helmet (equipmentObject)":

                break;
            case "lvl 50 helmet (equipmentObject)":

                break;
            case "lvl 100 helmet (equipmentObject)":

                break;

        }

        switch (beltGear)
        {
            case "":
                NoBeltEquipTxt.SetActive(true);
                BeltButton.SetActive(false);
                BeltGear.sprite = BeltEmpty;
                BeltGearAtkText.text = "";
                BeltGearDefText.text = "";
                BeltGearSpText.text = "";
                BeltGearAgiText.text = "";
                BeltGearHpText.text = "";
                break;
            case "lvl 1 belt (equipmentObject)":
                NoBeltEquipTxt.SetActive(false);
                BeltButton.SetActive(true);
                BeltGear.sprite = beltLevel1Gear;
                BeltGearAtkText.text = "atk:3";
                BeltGearDefText.text = "def:6";
                BeltGearSpText.text = "sp:10";
                BeltGearAgiText.text = "agi:3";
                BeltGearHpText.text = "hp:7";
                break;

            case "lvl 10 belt (equipmentObject)":
                NoBeltEquipTxt.SetActive(false);
                BeltButton.SetActive(true);
                BeltGear.sprite = beltLevel10Gear;
                BeltGearAtkText.text = "atk:15";
                BeltGearDefText.text = "def:30";
                BeltGearSpText.text = "sp:50";
                BeltGearAgiText.text = "agi:15";
                BeltGearHpText.text = "hp:35";
                break;

            case "lvl 30 belt (equipmentObject)":

                break;
            case "lvl 50 belt (equipmentObject)":

                break;
            case "lvl 100 belt (equipmentObject)":

                break;

        }

        switch (ringGear)
        {
            case "":
                NoRingEquipTxt.SetActive(true);
                RingButton.SetActive(false);
                RingGear.sprite = RingEmpty;
                RingGearAtkText.text = "";
                RingGearDefText.text = "";
                RingGearSpText.text = "";
                RingGearAgiText.text = "";
                RingGearHpText.text = "";
                break;

            case "lvl 1 ring (equipmentObject)":
                NoRingEquipTxt.SetActive(false);
                RingButton.SetActive(true);
                RingGear.sprite = ringLevel1Gear;
                RingGearAtkText.text = "atk:2";
                RingGearDefText.text = "def:4";
                RingGearSpText.text = "sp:3";
                RingGearAgiText.text = "agi:2";
                RingGearHpText.text = "hp:50";
                break;

            case "lvl 10 ring (equipmentObject)":
                NoRingEquipTxt.SetActive(false);
                RingButton.SetActive(true);
                RingGear.sprite = ringLevel10Gear;
                RingGearAtkText.text = "atk:10";
                RingGearDefText.text = "def:20";
                RingGearSpText.text = "sp:15";
                RingGearAgiText.text = "agi:10";
                RingGearHpText.text = "hp:250";
                break;

            case "lvl 30 ring (equipmentObject)":

                break;
            case "lvl 50 ring (equipmentObject)":

                break;
            case "lvl 100 ring (equipmentObject)":

                break;

        }

    }

    // Update is called once per frame
    void Update()
    {

        if (refreshInv)
        {


            itemsDisplayed.Clear();
            GameObject[] gems = GameObject.FindGameObjectsWithTag("gemIcon");


            foreach (GameObject gem in gems)
            {
                Destroy(gem);
            }

            CreateDisplay();
            refreshInv = false;

        }



        if (refresh)
        {
            attackGear = PlayerPrefs.GetString("AttackGear");
            defGear = PlayerPrefs.GetString("DefGear");
            helmetGear = PlayerPrefs.GetString("HelmetGear");
            beltGear = PlayerPrefs.GetString("BeltGear");
            ringGear = PlayerPrefs.GetString("RingGear");
            refresh = false;

            switch (attackGear)
            {
                case "":
                    AttackGear.sprite = AtkEmpty;
                    atkButton.SetActive(false);
                    NoAtkEquipTxt.SetActive(true);
                    atkGearAtkText.text = "";
                    atkGearDefText.text = "";
                    atkGearSpText.text = "";
                    atkGearAgiText.text = "";
                    atkGearHpText.text = "";
                    break;

                case "lvl 1 attack (equipmentObject)":
                    atkButton.SetActive(true);
                    NoAtkEquipTxt.SetActive(false);
                    AttackGear.sprite = atkLevel1Gear;
                    atkGearAtkText.text = "atk:10";
                    atkGearDefText.text = "def:5";
                    atkGearSpText.text = "sp:2";
                    atkGearAgiText.text = "agi:3";
                    atkGearHpText.text = "hp:5";
                    break;

                case "lvl 10 attack (equipmentObject)":
                    atkButton.SetActive(true);
                    NoAtkEquipTxt.SetActive(false);
                    AttackGear.sprite = atkLevel10Gear;
                    atkGearAtkText.text = "atk:50";
                    atkGearDefText.text = "def:25";
                    atkGearSpText.text = "sp:10";
                    atkGearAgiText.text = "agi:15";
                    atkGearHpText.text = "hp:25";
                    break;

                case "lvl 30 attack (equipmentObject)":

                    break;
                case "lvl 50 attack (equipmentObject)":

                    break;
                case "lvl 100 attack (equipmentObject)":

                    break;

            }

            switch (defGear)
            {
                case "":
                    NoDefEquipTxt.SetActive(true);
                    DefButton.SetActive(false);
                    DefGear.sprite = DefEmpty;
                    defGearAtkText.text = "";
                    defGearDefText.text = "";
                    defGearSpText.text = "";
                    defGearAgiText.text = "";
                    defGearHpText.text = "";
                    break;
                case "lvl 1 def (equipmentObject)":
                    NoDefEquipTxt.SetActive(false);
                    DefButton.SetActive(true);
                    DefGear.sprite = defLevel1Gear;
                    defGearAtkText.text = "atk:2";
                    defGearDefText.text = "def:10";
                    defGearSpText.text = "sp:2";
                    defGearAgiText.text = "agi:2";
                    defGearHpText.text = "hp:10";
                    break;

                case "lvl 10 def (equipmentObject)":
                    NoDefEquipTxt.SetActive(false);
                    DefButton.SetActive(true);
                    DefGear.sprite = defLevel10Gear;
                    defGearAtkText.text = "atk:10";
                    defGearDefText.text = "def:50";
                    defGearSpText.text = "sp:10";
                    defGearAgiText.text = "agi:10";
                    defGearHpText.text = "hp:50";
                    break;

                case "lvl 30 def (equipmentObject)":

                    break;
                case "lvl 50 def (equipmentObject)":

                    break;
                case "lvl 100 def (equipmentObject)":

                    break;

            }

            switch (helmetGear)
            {
                case "":
                    NoHelmetEquipTxt.SetActive(true);
                    HelmetButton.SetActive(false);
                    HelmetGear.sprite = HelmetEmpty;
                    HelmetGearAtkText.text = "";
                    HelmetGearDefText.text = "";
                    HelmetGearSpText.text = "";
                    HelmetGearAgiText.text = "";
                    HelmetGearHpText.text = "";
                    break;

                case "lvl 1 helmet (equipmentObject)":
                    NoHelmetEquipTxt.SetActive(false);
                    HelmetButton.SetActive(true);
                    HelmetGear.sprite = helmetLevel1Gear;
                    HelmetGearAtkText.text = "atk:3";
                    HelmetGearDefText.text = "def:4";
                    HelmetGearSpText.text = "sp:2";
                    HelmetGearAgiText.text = "agi:10";
                    HelmetGearHpText.text = "hp:8";
                    break;

                case "lvl 10 helmet (equipmentObject)":
                    NoHelmetEquipTxt.SetActive(false);
                    HelmetButton.SetActive(true);
                    HelmetGear.sprite = helmetLevel10Gear;
                    HelmetGearAtkText.text = "atk:15";
                    HelmetGearDefText.text = "def:20";
                    HelmetGearSpText.text = "sp:10";
                    HelmetGearAgiText.text = "agi:50";
                    HelmetGearHpText.text = "hp:40";
                    break;
                case "lvl 30 helmet (equipmentObject)":

                    break;
                case "lvl 50 helmet (equipmentObject)":

                    break;
                case "lvl 100 helmet (equipmentObject)":

                    break;

            }

            switch (beltGear)
            {
                case "":
                    NoBeltEquipTxt.SetActive(true);
                    BeltButton.SetActive(false);
                    BeltGear.sprite = BeltEmpty;
                    BeltGearAtkText.text = "";
                    BeltGearDefText.text = "";
                    BeltGearSpText.text = "";
                    BeltGearAgiText.text = "";
                    BeltGearHpText.text = "";
                    break;
                case "lvl 1 belt (equipmentObject)":
                    NoBeltEquipTxt.SetActive(false);
                    BeltButton.SetActive(true);
                    BeltGear.sprite = beltLevel1Gear;
                    BeltGearAtkText.text = "atk:3";
                    BeltGearDefText.text = "def:6";
                    BeltGearSpText.text = "sp:10";
                    BeltGearAgiText.text = "agi:3";
                    BeltGearHpText.text = "hp:7";
                    break;

                case "lvl 10 belt (equipmentObject)":
                    NoBeltEquipTxt.SetActive(false);
                    BeltButton.SetActive(true);
                    BeltGear.sprite = beltLevel10Gear;
                    BeltGearAtkText.text = "atk:15";
                    BeltGearDefText.text = "def:30";
                    BeltGearSpText.text = "sp:50";
                    BeltGearAgiText.text = "agi:15";
                    BeltGearHpText.text = "hp:35";
                    break;

                case "lvl 30 belt (equipmentObject)":

                    break;
                case "lvl 50 belt (equipmentObject)":

                    break;
                case "lvl 100 belt (equipmentObject)":

                    break;

            }

            switch (ringGear)
            {
                case "":
                    NoRingEquipTxt.SetActive(true);
                    RingButton.SetActive(false);
                    RingGear.sprite = RingEmpty;
                    RingGearAtkText.text = "";
                    RingGearDefText.text = "";
                    RingGearSpText.text = "";
                    RingGearAgiText.text = "";
                    RingGearHpText.text = "";
                    break;

                case "lvl 1 ring (equipmentObject)":
                    NoRingEquipTxt.SetActive(false);
                    RingButton.SetActive(true);
                    RingGear.sprite = ringLevel1Gear;
                    RingGearAtkText.text = "atk:2";
                    RingGearDefText.text = "def:4";
                    RingGearSpText.text = "sp:3";
                    RingGearAgiText.text = "agi:2";
                    RingGearHpText.text = "hp:50";
                    break;

                case "lvl 10 ring (equipmentObject)":
                    NoRingEquipTxt.SetActive(false);
                    RingButton.SetActive(true);
                    RingGear.sprite = ringLevel10Gear;
                    RingGearAtkText.text = "atk:10";
                    RingGearDefText.text = "def:20";
                    RingGearSpText.text = "sp:15";
                    RingGearAgiText.text = "agi:10";
                    RingGearHpText.text = "hp:250";
                    break;

                case "lvl 30 ring (equipmentObject)":

                    break;
                case "lvl 50 ring (equipmentObject)":

                    break;
                case "lvl 100 ring (equipmentObject)":

                    break;

            }
        }
    }
    public void CreateDisplay()
    {

        for (int i = 0; i < inventory.Container.Count; i++)
        {

            var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
            obj.transform.SetParent(GameObject.FindGameObjectWithTag("LapidaryRightSide").transform, false);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            obj.GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
            itemsDisplayed.Add(inventory.Container[i], obj);

        }
    }
    public Vector3 GetPosition(int i)
    {
        return new Vector3(Xstart + (XspaceBtwItem * (i % NumberOfColumns)), Ystart + (-YspaceBtwItems * (i / NumberOfColumns)), 0f);
    }

    public void swordGear()
    {
        effect.SetActive(true);
        icon.SetActive(true);
        currentgear = SelectedGear.sword;
        CurrentGear.sprite = AttackGear.sprite;
        GameObject[] gemIcons = GameObject.FindGameObjectsWithTag("gemIconsEquipped");

        foreach (GameObject gemIcon in gemIcons)
        {
            Destroy(gemIcon);
        }

        string swordRedGem = PlayerPrefs.GetString("AttackGearRedGem");
        string swordBlueGem = PlayerPrefs.GetString("AttackGearBlueGem");
        string swordYellowGem = PlayerPrefs.GetString("AttackGearYellowGem");
        string swordOrangeGem = PlayerPrefs.GetString("AttackGearOrangeGem");
        string swordGreenGem = PlayerPrefs.GetString("AttackGearGreenGem");

        switch (swordRedGem)
        {
            case "":
                atkGemLevel.text = "";
                break;
            case "lvl1RedGem (gemObject)":
                redGems.isAtkGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 1";
                break;

        }
        switch (swordBlueGem)
        {
            case "":
                defGemLevel.text = "";
                break;
            case "lvl1BlueGem (gemObject)":
                blueGems.isAtkGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 1";
                break;
        }
        switch (swordYellowGem)
        {
            case "":
                helmetGemLevel.text = "";
                break;
            case "lvl1YellowGem (gemObject)":
                yellowGems.isAtkGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 1";
                break;
        }
        switch (swordOrangeGem)
        {
            case "":
                beltGemLevel.text = "";
                break;
            case "lvl1OrangeGem (gemObject)":
                orangeGems.isAtkGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 1";
                break;
        }
        switch (swordGreenGem)
        {
            case "":
                ringGemLevel.text = "";
                break;
            case "lvl1GreenGem (gemObject)":
                greenGems.isAtkGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 1";
                break;
        }
    }
    public void ShieldGear()
    {
        effect.SetActive(true);
        icon.SetActive(true);
        currentgear = SelectedGear.shield;
        CurrentGear.sprite = DefGear.sprite;

        GameObject[] gemIcons = GameObject.FindGameObjectsWithTag("gemIconsEquipped");

        foreach (GameObject gemIcon in gemIcons)
        {
            Destroy(gemIcon);
        }

        string ShieldRedGem = PlayerPrefs.GetString("DefGearRedGem");
        string shieldBlueGem = PlayerPrefs.GetString("DefGearBlueGem");
        string shieldYellowGem = PlayerPrefs.GetString("DefGearYellowGem");
        string shieldOrangeGem = PlayerPrefs.GetString("DefGearOrangeGem");
        string shieldGreenGem = PlayerPrefs.GetString("DefGearGreenGem");

        switch (ShieldRedGem)
        {
            case "":
                atkGemLevel.text = "";
                break;
            case "lvl1RedGem (gemObject)":
                redGems.isDefGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 1";
                break;
        }
        switch (shieldBlueGem)
        {
            case "":
                defGemLevel.text = "";
                break;
            case "lvl1BlueGem (gemObject)":
                blueGems.isDefGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 1";
                break;
        }
        switch (shieldYellowGem)
        {
            case "":
                helmetGemLevel.text = "";
                break;
            case "lvl1YellowGem (gemObject)":
                yellowGems.isDefGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 1";
                break;
        }
        switch (shieldOrangeGem)
        {
            case "":
               beltGemLevel.text = "";
                break;
            case "lvl1OrangeGem (gemObject)":
                orangeGems.isDefGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 1";
                break;
        }
        switch (shieldGreenGem)
        {
            case "":
                ringGemLevel.text = "";
                break;
            case "lvl1GreenGem (gemObject)":
                greenGems.isDefGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 1";
                break;
        }
    }
    public void helmetAgiGear()
    {
        effect.SetActive(true);
        icon.SetActive(true);
        currentgear = SelectedGear.helmet;
        CurrentGear.sprite = HelmetGear.sprite;

        GameObject[] gemIcons = GameObject.FindGameObjectsWithTag("gemIconsEquipped");

        foreach (GameObject gemIcon in gemIcons)
        {
            Destroy(gemIcon);
        }

        string HelmetRedGem = PlayerPrefs.GetString("HelmetGearRedGem");
        string helmetBlueGem = PlayerPrefs.GetString("HelmetGearBlueGem");
        string helmetYellowGem = PlayerPrefs.GetString("HelmetGearYellowGem");
        string helmetOrangeGem = PlayerPrefs.GetString("HelmetGearOrangeGem");
        string helmetGreenGem = PlayerPrefs.GetString("HelmetGearGreenGem");

        switch (HelmetRedGem)
        {
            case "":
                atkGemLevel.text = "";
                break;
            case "lvl1RedGem (gemObject)":
                redGems.isHelmetGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 1";
                break;
        }
        switch (helmetBlueGem)
        {
            case "":
               defGemLevel.text = "";
                break;
            case "lvl1BlueGem (gemObject)":
                blueGems.isHelmetGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 1";
                break;
        }
        switch (helmetYellowGem)
        {
            case "":
               helmetGemLevel.text = "";
                break;
            case "lvl1YellowGem (gemObject)":
                yellowGems.isHelmetGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 1";
                break;
        }
        switch (helmetOrangeGem)
        {
            case "":
                beltGemLevel.text = "";
                break;
            case "lvl1OrangeGem (gemObject)":
                orangeGems.isHelmetGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 1";
                break;
        }
        switch (helmetGreenGem)
        {
            case "":
                ringGemLevel.text = "";
                break;
            case "lvl1GreenGem (gemObject)":
                greenGems.isHelmetGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 1";
                break;
        }
    }
    public void beltSpGear()
    {
        effect.SetActive(true);
        icon.SetActive(true);
        currentgear = SelectedGear.belt;
        CurrentGear.sprite = BeltGear.sprite;
        GameObject[] gemIcons = GameObject.FindGameObjectsWithTag("gemIconsEquipped");

        foreach (GameObject gemIcon in gemIcons)
        {
            Destroy(gemIcon);
        }

        string BeltRedGem = PlayerPrefs.GetString("BeltGearRedGem");
        string beltBlueGem = PlayerPrefs.GetString("BeltGearBlueGem");
        string beltYellowGem = PlayerPrefs.GetString("BeltGearYellowGem");
        string beltOrangeGem = PlayerPrefs.GetString("BeltGearOrangeGem");
        string beltGreenGem = PlayerPrefs.GetString("BeltGearGreenGem");

        switch (BeltRedGem)
        {
            case "":
                atkGemLevel.text = "";
                break;
            case "lvl1RedGem (gemObject)":
                redGems.isBeltGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 1";
                break;
        }
        switch (beltBlueGem)
        {
            case "":
                defGemLevel.text = "";
                break;
            case "lvl1BlueGem (gemObject)":
                blueGems.isBeltGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 1";
                break;
        }
        switch (beltYellowGem)
        {
            case "":
                helmetGemLevel.text = "";
                break;
            case "lvl1YellowGem (gemObject)":
                yellowGems.isBeltGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 1";
                break;
        }
        switch (beltOrangeGem)
        {
            case "":
               beltGemLevel.text = "";
                break;
            case "lvl1OrangeGem (gemObject)":
                orangeGems.isBeltGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 1";
                break;
        }
        switch (beltGreenGem)
        {
            case "":
                ringGemLevel.text = "";
                break;
            case "lvl1GreenGem (gemObject)":
                greenGems.isHelmetGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 1";
                break;
        }
    }
    public void ringHpGear()
    {
        effect.SetActive(true);
        icon.SetActive(true);
        currentgear = SelectedGear.ring;
        CurrentGear.sprite = RingGear.sprite;
        GameObject[] gemIcons = GameObject.FindGameObjectsWithTag("gemIconsEquipped");

        foreach (GameObject gemIcon in gemIcons)
        {
            Destroy(gemIcon);
        }

        string RingRedGem = PlayerPrefs.GetString("RingGearRedGem");
        string ringBlueGem = PlayerPrefs.GetString("RingGearBlueGem");
        string ringYellowGem = PlayerPrefs.GetString("RingGearYellowGem");
        string ringOrangeGem = PlayerPrefs.GetString("RingGearOrangeGem");
        string ringGreenGem = PlayerPrefs.GetString("BeltGearGreenGem");

        switch (RingRedGem)
        {
            case "":
                atkGemLevel.text = "";
                break;
            case "lvl1RedGem (gemObject)":
                redGems.isRingGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 1";
                break;
        }
        switch (ringBlueGem)
        {
            case "":
                defGemLevel.text = "";
                break;
            case "lvl1BlueGem (gemObject)":
                blueGems.isRingGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 1";
                break;
        }
        switch (ringYellowGem)
        {
            case "":
                helmetGemLevel.text = "";
                break;
            case "lvl1YellowGem (gemObject)":
                yellowGems.isRingGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 1";
                break;
        }
        switch (ringOrangeGem)
        {
            case "":
                beltGemLevel.text = "";
                break;
            case "lvl1OrangeGem (gemObject)":
                orangeGems.isRingGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 1";
                break;
        }
        switch (ringGreenGem)
        {
            case "":
                ringGemLevel.text = "";
                break;
            case "lvl1GreenGem (gemObject)":
                greenGems.isHelmetGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 1";
                break;
        }
    }

}
