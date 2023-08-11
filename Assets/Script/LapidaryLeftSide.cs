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
    ring,
    nothing
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
    public Sprite atkLevel20Gear;

    public Sprite defLevel1Gear;
    public Sprite defLevel10Gear;
    public Sprite defLevel20Gear;

    public Sprite helmetLevel1Gear;
    public Sprite helmetLevel10Gear;
    public Sprite helmetLevel20Gear;

    public Sprite beltLevel1Gear;
    public Sprite beltLevel10Gear;
    public Sprite beltLevel20Gear;

    public Sprite ringLevel1Gear;
    public Sprite ringLevel10Gear;
    public Sprite ringLevel20Gear;

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

    public GameObject atkText1;
    public GameObject defText1;
    public GameObject helmetText1;
    public GameObject beltText1;
    public GameObject ringText1;

    public GameObject atkText2;
    public GameObject defText2;
    public GameObject helmetText2;
    public GameObject beltText2;
    public GameObject ringText2;

    public GameObject atkText3;
    public GameObject defText3;
    public GameObject helmetText3;
    public GameObject beltText3;
    public GameObject ringText3;

    public GameObject atkText4;
    public GameObject defText4;
    public GameObject helmetText4;
    public GameObject beltText4;
    public GameObject ringText4;

    public GameObject atkText5;
    public GameObject defText5;
    public GameObject helmetText5;
    public GameObject beltText5;
    public GameObject ringText5;
    public GameObject[] slot;
    public GameObject[] slotTxt;
    public GameObject[] GearButton;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        CreateDisplay();
        currentgear = SelectedGear.nothing;

        switch (GameController.attackGear)
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
                atkText1.SetActive(false);
                defText1.SetActive(false);
                helmetText1.SetActive(false);
                beltText1.SetActive(false);
                ringText1.SetActive(false);
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
                atkText1.SetActive(true);
                defText1.SetActive(true);
                helmetText1.SetActive(true);
                beltText1.SetActive(true);
                ringText1.SetActive(true);
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
                atkText1.SetActive(true);
                defText1.SetActive(true);
                helmetText1.SetActive(true);
                beltText1.SetActive(true);
                ringText1.SetActive(true);
                break;

            case "lvl 20 attack (equipmentObject)":
                atkButton.SetActive(true);
                NoAtkEquipTxt.SetActive(false);
                AttackGear.sprite = atkLevel20Gear;
                atkGearAtkText.text = "atk:250";
                atkGearDefText.text = "def:125";
                atkGearSpText.text = "sp:50";
                atkGearAgiText.text = "agi:75";
                atkGearHpText.text = "hp:125";
                atkText1.SetActive(true);
                defText1.SetActive(true);
                helmetText1.SetActive(true);
                beltText1.SetActive(true);
                ringText1.SetActive(true);
                break;
            case "lvl 50 attack (equipmentObject)":

                break;
            case "lvl 100 attack (equipmentObject)":

                break;

        }

        switch (GameController.defGear)
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
                atkText2.SetActive(false);
                defText2.SetActive(false);
                helmetText2.SetActive(false);
                beltText2.SetActive(false);
                ringText2.SetActive(false);
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
                atkText2.SetActive(true);
                defText2.SetActive(true);
                helmetText2.SetActive(true);
                beltText2.SetActive(true);
                ringText2.SetActive(true);
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
                atkText2.SetActive(true);
                defText2.SetActive(true);
                helmetText2.SetActive(true);
                beltText2.SetActive(true);
                ringText2.SetActive(true);
                break;

            case "lvl 20 def (equipmentObject)":
                NoDefEquipTxt.SetActive(false);
                DefButton.SetActive(true);
                DefGear.sprite = defLevel20Gear;
                defGearAtkText.text = "atk:50";
                defGearDefText.text = "def:250";
                defGearSpText.text = "sp:50";
                defGearAgiText.text = "agi:50";
                defGearHpText.text = "hp:250";
                atkText2.SetActive(true);
                defText2.SetActive(true);
                helmetText2.SetActive(true);
                beltText2.SetActive(true);
                ringText2.SetActive(true);
                break;
            case "lvl 50 def (equipmentObject)":

                break;
            case "lvl 100 def (equipmentObject)":

                break;

        }

        switch (GameController.helmetGear)
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
                atkText3.SetActive(false);
                defText3.SetActive(false);
                helmetText3.SetActive(false);
                beltText3.SetActive(false);
                ringText3.SetActive(false);
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
                atkText3.SetActive(true);
                defText3.SetActive(true);
                helmetText3.SetActive(true);
                beltText3.SetActive(true);
                ringText3.SetActive(true);
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
                atkText3.SetActive(true);
                defText3.SetActive(true);
                helmetText3.SetActive(true);
                beltText3.SetActive(true);
                ringText3.SetActive(true);
                break;
            case "lvl 20 helmet (equipmentObject)":
                NoHelmetEquipTxt.SetActive(false);
                HelmetButton.SetActive(true);
                HelmetGear.sprite = helmetLevel20Gear;
                HelmetGearAtkText.text = "atk:75";
                HelmetGearDefText.text = "def:100";
                HelmetGearSpText.text = "sp:50";
                HelmetGearAgiText.text = "agi:250";
                HelmetGearHpText.text = "hp:200";
                atkText3.SetActive(true);
                defText3.SetActive(true);
                helmetText3.SetActive(true);
                beltText3.SetActive(true);
                ringText3.SetActive(true);
                break;
            case "lvl 50 helmet (equipmentObject)":

                break;
            case "lvl 100 helmet (equipmentObject)":

                break;

        }

        switch (GameController.beltGear)
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
                atkText4.SetActive(false);
                defText4.SetActive(false);
                helmetText4.SetActive(false);
                beltText4.SetActive(false);
                ringText4.SetActive(false);
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
                atkText4.SetActive(true);
                defText4.SetActive(true);
                helmetText4.SetActive(true);
                beltText4.SetActive(true);
                ringText4.SetActive(true);
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
                atkText4.SetActive(true);
                defText4.SetActive(true);
                helmetText4.SetActive(true);
                beltText4.SetActive(true);
                ringText4.SetActive(true);
                break;

            case "lvl 20 belt (equipmentObject)":
                NoBeltEquipTxt.SetActive(false);
                BeltButton.SetActive(true);
                BeltGear.sprite = beltLevel20Gear;
                BeltGearAtkText.text = "atk:75";
                BeltGearDefText.text = "def:150";
                BeltGearSpText.text = "sp:250";
                BeltGearAgiText.text = "agi:75";
                BeltGearHpText.text = "hp:175";
                atkText4.SetActive(true);
                defText4.SetActive(true);
                helmetText4.SetActive(true);
                beltText4.SetActive(true);
                ringText4.SetActive(true);
                break;
            case "lvl 50 belt (equipmentObject)":

                break;
            case "lvl 100 belt (equipmentObject)":

                break;

        }

        switch (GameController.ringGear)
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
                atkText5.SetActive(false);
                defText5.SetActive(false);
                helmetText5.SetActive(false);
                beltText5.SetActive(false);
                ringText5.SetActive(false);
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
                atkText5.SetActive(true);
                defText5.SetActive(true);
                helmetText5.SetActive(true);
                beltText5.SetActive(true);
                ringText5.SetActive(true);
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
                atkText5.SetActive(true);
                defText5.SetActive(true);
                helmetText5.SetActive(true);
                beltText5.SetActive(true);
                ringText5.SetActive(true);
                break;

            case "lvl 20 ring (equipmentObject)":
                NoRingEquipTxt.SetActive(false);
                RingButton.SetActive(true);
                RingGear.sprite = ringLevel20Gear;
                RingGearAtkText.text = "atk:50";
                RingGearDefText.text = "def:100";
                RingGearSpText.text = "sp:75";
                RingGearAgiText.text = "agi:50";
                RingGearHpText.text = "hp:1250";
                atkText5.SetActive(true);
                defText5.SetActive(true);
                helmetText5.SetActive(true);
                beltText5.SetActive(true);
                ringText5.SetActive(true);
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

        for(int i = 0; i < 5;i++)
        {
            if (GearButton[i].activeSelf)
            {
                counter++;
            }
        }
        if(counter == 0)
        {
            for (int i = 0; i < 5; i++)
            {
                slot[i].SetActive(false);
                slotTxt[i].SetActive(false);
            }
        }

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

        if (currentgear == SelectedGear.nothing)
        {
            effect.SetActive(false);
            icon.SetActive(false);
            GameObject[] gemIcons = GameObject.FindGameObjectsWithTag("gemIconsEquipped");
            foreach (GameObject gemIcon in gemIcons)
            {
                Destroy(gemIcon);
            }
            atkGemLevel.text = "";
            defGemLevel.text = "";
            helmetGemLevel.text = "";
            beltGemLevel.text = "";
            ringGemLevel.text = "";
            for (int i = 0; i < 5; i++)
            {
                slot[i].SetActive(false);
                slotTxt[i].SetActive(false);
            }
        }

        if (refresh)
        {

            refresh = false;

            switch (GameController.attackGear)
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
                    atkText1.SetActive(false);
                    defText1.SetActive(false);
                    helmetText1.SetActive(false);
                    beltText1.SetActive(false);
                    ringText1.SetActive(false);
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
                    atkText1.SetActive(true);
                    defText1.SetActive(true);
                    helmetText1.SetActive(true);
                    beltText1.SetActive(true);
                    ringText1.SetActive(true);
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
                    atkText1.SetActive(true);
                    defText1.SetActive(true);
                    helmetText1.SetActive(true);
                    beltText1.SetActive(true);
                    ringText1.SetActive(true);
                    break;

                case "lvl 20 attack (equipmentObject)":
                    atkButton.SetActive(true);
                    NoAtkEquipTxt.SetActive(false);
                    AttackGear.sprite = atkLevel20Gear;
                    atkGearAtkText.text = "atk:250";
                    atkGearDefText.text = "def:125";
                    atkGearSpText.text = "sp:50";
                    atkGearAgiText.text = "agi:75";
                    atkGearHpText.text = "hp:125";
                    atkText1.SetActive(true);
                    defText1.SetActive(true);
                    helmetText1.SetActive(true);
                    beltText1.SetActive(true);
                    ringText1.SetActive(true);
                    break;
                case "lvl 50 attack (equipmentObject)":

                    break;
                case "lvl 100 attack (equipmentObject)":

                    break;

            }

            switch (GameController.defGear)
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
                    atkText2.SetActive(false);
                    defText2.SetActive(false);
                    helmetText2.SetActive(false);
                    beltText2.SetActive(false);
                    ringText2.SetActive(false);
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
                    atkText2.SetActive(true);
                    defText2.SetActive(true);
                    helmetText2.SetActive(true);
                    beltText2.SetActive(true);
                    ringText2.SetActive(true);
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
                    atkText2.SetActive(true);
                    defText2.SetActive(true);
                    helmetText2.SetActive(true);
                    beltText2.SetActive(true);
                    ringText2.SetActive(true);
                    break;

                case "lvl 20 def (equipmentObject)":
                    NoDefEquipTxt.SetActive(false);
                    DefButton.SetActive(true);
                    DefGear.sprite = defLevel20Gear;
                    defGearAtkText.text = "atk:50";
                    defGearDefText.text = "def:250";
                    defGearSpText.text = "sp:50";
                    defGearAgiText.text = "agi:50";
                    defGearHpText.text = "hp:250";
                    atkText2.SetActive(true);
                    defText2.SetActive(true);
                    helmetText2.SetActive(true);
                    beltText2.SetActive(true);
                    ringText2.SetActive(true);
                    break;
                case "lvl 50 def (equipmentObject)":

                    break;
                case "lvl 100 def (equipmentObject)":

                    break;

            }

            switch (GameController.helmetGear)
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
                    atkText3.SetActive(false);
                    defText3.SetActive(false);
                    helmetText3.SetActive(false);
                    beltText3.SetActive(false);
                    ringText3.SetActive(false);
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
                    atkText3.SetActive(true);
                    defText3.SetActive(true);
                    helmetText3.SetActive(true);
                    beltText3.SetActive(true);
                    ringText3.SetActive(true);
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
                    atkText3.SetActive(true);
                    defText3.SetActive(true);
                    helmetText3.SetActive(true);
                    beltText3.SetActive(true);
                    ringText3.SetActive(true);
                    break;
                case "lvl 20 helmet (equipmentObject)":
                    NoHelmetEquipTxt.SetActive(false);
                    HelmetButton.SetActive(true);
                    HelmetGear.sprite = helmetLevel20Gear;
                    HelmetGearAtkText.text = "atk:75";
                    HelmetGearDefText.text = "def:100";
                    HelmetGearSpText.text = "sp:50";
                    HelmetGearAgiText.text = "agi:250";
                    HelmetGearHpText.text = "hp:200";
                    atkText3.SetActive(true);
                    defText3.SetActive(true);
                    helmetText3.SetActive(true);
                    beltText3.SetActive(true);
                    ringText3.SetActive(true);
                    break;
                case "lvl 50 helmet (equipmentObject)":

                    break;
                case "lvl 100 helmet (equipmentObject)":

                    break;

            }

            switch (GameController.beltGear)
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
                    atkText4.SetActive(false);
                    defText4.SetActive(false);
                    helmetText4.SetActive(false);
                    beltText4.SetActive(false);
                    ringText4.SetActive(false);
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
                    atkText4.SetActive(true);
                    defText4.SetActive(true);
                    helmetText4.SetActive(true);
                    beltText4.SetActive(true);
                    ringText4.SetActive(true);
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
                    atkText4.SetActive(true);
                    defText4.SetActive(true);
                    helmetText4.SetActive(true);
                    beltText4.SetActive(true);
                    ringText4.SetActive(true);
                    break;

                case "lvl 20 belt (equipmentObject)":
                    NoBeltEquipTxt.SetActive(false);
                    BeltButton.SetActive(true);
                    BeltGear.sprite = beltLevel20Gear;
                    BeltGearAtkText.text = "atk:75";
                    BeltGearDefText.text = "def:150";
                    BeltGearSpText.text = "sp:250";
                    BeltGearAgiText.text = "agi:75";
                    BeltGearHpText.text = "hp:175";
                    atkText4.SetActive(true);
                    defText4.SetActive(true);
                    helmetText4.SetActive(true);
                    beltText4.SetActive(true);
                    ringText4.SetActive(true);
                    break;
                case "lvl 50 belt (equipmentObject)":

                    break;
                case "lvl 100 belt (equipmentObject)":

                    break;

            }

            switch (GameController.ringGear)
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
                    atkText5.SetActive(false);
                    defText5.SetActive(false);
                    helmetText5.SetActive(false);
                    beltText5.SetActive(false);
                    ringText5.SetActive(false);
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
                    atkText5.SetActive(true);
                    defText5.SetActive(true);
                    helmetText5.SetActive(true);
                    beltText5.SetActive(true);
                    ringText5.SetActive(true);
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
                    atkText5.SetActive(true);
                    defText5.SetActive(true);
                    helmetText5.SetActive(true);
                    beltText5.SetActive(true);
                    ringText5.SetActive(true);
                    break;

                case "lvl 20 ring (equipmentObject)":
                    NoRingEquipTxt.SetActive(false);
                    RingButton.SetActive(true);
                    RingGear.sprite = ringLevel20Gear;
                    RingGearAtkText.text = "atk:50";
                    RingGearDefText.text = "def:100";
                    RingGearSpText.text = "sp:75";
                    RingGearAgiText.text = "agi:50";
                    RingGearHpText.text = "hp:1250";
                    atkText5.SetActive(true);
                    defText5.SetActive(true);
                    helmetText5.SetActive(true);
                    beltText5.SetActive(true);
                    ringText5.SetActive(true);
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
        for(int i = 0; i<5; i++)
        {
            slot[i].SetActive(true);
            slotTxt[i].SetActive(true);
        }
        effect.SetActive(true);
        icon.SetActive(true);
        currentgear = SelectedGear.sword;
        CurrentGear.sprite = AttackGear.sprite;
        GameObject[] gemIcons = GameObject.FindGameObjectsWithTag("gemIconsEquipped");

        foreach (GameObject gemIcon in gemIcons)
        {
            Destroy(gemIcon);
        }

        switch (GameController.swordRedGem)
        {
            case "":
                atkGemLevel.text = "";
                redGems.isAtkGearRedGemPlaced = false;
                break;
            case "lvl1RedGem (gemObject)":
                redGems.isAtkGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 1";
                break;
            case "lvl2RedGem (gemObject)":
                redGems.isAtkGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 2";
                break;
            case "lvl3RedGem (gemObject)":
                redGems.isAtkGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 3";
                break;
            case "lvl4RedGem (gemObject)":
                redGems.isAtkGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 4";
                break;
            case "lvl5RedGem (gemObject)":
                redGems.isAtkGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 5";
                break;
            default:
                atkGemLevel.text = "";
                break;
        }
        switch (GameController.swordBlueGem)
        {
            case "":
                defGemLevel.text = "";
                break;
            case "lvl1BlueGem (gemObject)":
                blueGems.isAtkGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 1";
                break;
            case "lvl2BlueGem (gemObject)":
                blueGems.isAtkGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 2";
                break;
            case "lvl3BlueGem (gemObject)":
                blueGems.isAtkGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 3";
                break;
            case "lvl4BlueGem (gemObject)":
                blueGems.isAtkGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 4";
                break;
            case "lvl5BlueGem (gemObject)":
                blueGems.isAtkGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 5";
                break;
            default:
                defGemLevel.text = "";
                break;
        }
        switch (GameController.swordYellowGem)
        {
            case "":
                helmetGemLevel.text = "";
                break;
            case "lvl1YellowGem (gemObject)":
                yellowGems.isAtkGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 1";
                break;
            case "lvl2YellowGem (gemObject)":
                yellowGems.isAtkGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 2";
                break;
            case "lvl3YellowGem (gemObject)":
                yellowGems.isAtkGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 3";
                break;
            case "lvl4YellowGem (gemObject)":
                yellowGems.isAtkGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 4";
                break;
            case "lvl5YellowGem (gemObject)":
                yellowGems.isAtkGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 5";
                break;
            default:
                helmetGemLevel.text = "";
                break;
        }
        switch (GameController.swordOrangeGem)
        {
            case "":
                beltGemLevel.text = "";
                break;
            case "lvl1OrangeGem (gemObject)":
                orangeGems.isAtkGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 1";
                break;
            case "lvl2OrangeGem (gemObject)":
                orangeGems.isAtkGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 2";
                break;
            case "lvl3OrangeGem (gemObject)":
                orangeGems.isAtkGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 3";
                break;
            case "lvl4OrangeGem (gemObject)":
                orangeGems.isAtkGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 4";
                break;
            case "lvl5OrangeGem (gemObject)":
                orangeGems.isAtkGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 5";
                break;
            default:
                beltGemLevel.text = "";
                break;
        }
        switch (GameController.swordGreenGem)
        {
            case "":
                ringGemLevel.text = "";
                greenGems.isAtkGearGreenGemPlaced = false;
                break;
            case "lvl1GreenGem (gemObject)":
                greenGems.isAtkGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 1";
                break;
            case "lvl2GreenGem (gemObject)":
                greenGems.isAtkGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 2";
                break;
            case "lvl3GreenGem (gemObject)":
                greenGems.isAtkGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 3";
                break;
            case "lvl4GreenGem (gemObject)":
                greenGems.isAtkGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 4";
                break;
            case "lvl5GreenGem (gemObject)":
                greenGems.isAtkGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 5";
                break;
            default:
                ringGemLevel.text = "";
                break;
        }
    }
    public void ShieldGear()
    {
        for (int i = 0; i < 5; i++)
        {
            slot[i].SetActive(true);
            slotTxt[i].SetActive(true);
        }
        effect.SetActive(true);
        icon.SetActive(true);
        currentgear = SelectedGear.shield;
        CurrentGear.sprite = DefGear.sprite;

        GameObject[] gemIcons = GameObject.FindGameObjectsWithTag("gemIconsEquipped");

        foreach (GameObject gemIcon in gemIcons)
        {
            Destroy(gemIcon);
        }

        switch (GameController.shieldRedGem)
        {
            case "":
                atkGemLevel.text = "";
                break;

            case "lvl1RedGem (gemObject)":
                redGems.isDefGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 1";
                break;
            case "lvl2RedGem (gemObject)":
                redGems.isDefGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 2";
                break;
            case "lvl3RedGem (gemObject)":
                redGems.isDefGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 3";
                break;
            case "lvl4RedGem (gemObject)":
                redGems.isDefGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 4";
                break;
            case "lvl5RedGem (gemObject)":
                redGems.isDefGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 5";
                break;
            default:
                atkGemLevel.text = "";
                break;
        }
        switch (GameController.shieldBlueGem)
        {
            case "":
                defGemLevel.text = "";
                break;

            case "lvl1BlueGem (gemObject)":
                blueGems.isDefGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 1";

                break;
            case "lvl2BlueGem (gemObject)":
                blueGems.isDefGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 2";
                break;
            case "lvl3BlueGem (gemObject)":
                blueGems.isDefGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 3";
                break;
            case "lvl4BlueGem (gemObject)":
                blueGems.isDefGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 4";
                break;
            case "lvl5BlueGem (gemObject)":
                blueGems.isDefGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 5";
                break;
            default:
                defGemLevel.text = "";
                break;
        }
        switch (GameController.shieldYellowGem)
        {
            case "":
                helmetGemLevel.text = "";
                break;

            case "lvl1YellowGem (gemObject)":
                yellowGems.isDefGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 1";
                break;
            case "lvl2YellowGem (gemObject)":
                yellowGems.isDefGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 2";
                break;
            case "lvl3YellowGem (gemObject)":
                yellowGems.isDefGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 3";
                break;
            case "lvl4YellowGem (gemObject)":
                yellowGems.isDefGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 4";
                break;
            case "lvl5YellowGem (gemObject)":
                yellowGems.isDefGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 5";
                break;
            default:
                helmetGemLevel.text = "";
                break;
        }
        switch (GameController.shieldOrangeGem)
        {
            case "":
                beltGemLevel.text = "";
                break;
            case "lvl1OrangeGem (gemObject)":
                orangeGems.isDefGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 1";
                break;
            case "lvl2OrangeGem (gemObject)":
                orangeGems.isDefGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 2";
                break;
            case "lvl3OrangeGem (gemObject)":
                orangeGems.isDefGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 3";
                break;
            case "lvl4OrangeGem (gemObject)":
                orangeGems.isDefGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 4";
                break;
            case "lvl5OrangeGem (gemObject)":
                orangeGems.isDefGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 5";
                break;
            default:
                beltGemLevel.text = "";
                break;
        }
        switch (GameController.shieldGreenGem)
        {
            case "":
                ringGemLevel.text = "";
                break;
            case "lvl1GreenGem (gemObject)":
                greenGems.isDefGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 1";
                break;
            case "lvl2GreenGem (gemObject)":
                greenGems.isDefGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 2";
                break;
            case "lvl3GreenGem (gemObject)":
                greenGems.isDefGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 3";
                break;
            case "lvl4GreenGem (gemObject)":
                greenGems.isDefGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 4";
                break;
            case "lvl5GreenGem (gemObject)":
                greenGems.isDefGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 5";
                break;
            default:
                ringGemLevel.text = "";
                break;
        }
    }
    public void helmetAgiGear()
    {
        for (int i = 0; i < 5; i++)
        {
            slot[i].SetActive(true);
            slotTxt[i].SetActive(true);
        }
        effect.SetActive(true);
        icon.SetActive(true);
        currentgear = SelectedGear.helmet;
        CurrentGear.sprite = HelmetGear.sprite;

        GameObject[] gemIcons = GameObject.FindGameObjectsWithTag("gemIconsEquipped");

        foreach (GameObject gemIcon in gemIcons)
        {
            Destroy(gemIcon);
        }

        switch (GameController.helmetRedGem)
        {
            case "":
                atkGemLevel.text = "";
                break;
            case "lvl1RedGem (gemObject)":
                redGems.isHelmetGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 1";
                break;
            case "lvl2RedGem (gemObject)":
                redGems.isHelmetGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 2";
                break;
            case "lvl3RedGem (gemObject)":
                redGems.isHelmetGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 3";
                break;
            case "lvl4RedGem (gemObject)":
                redGems.isHelmetGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 4";
                break;
            case "lvl5RedGem (gemObject)":
                redGems.isHelmetGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 5";
                break;
            default:
                atkGemLevel.text = "";
                break;
        }
        switch (GameController.helmetBlueGem)
        {
            case "":
                defGemLevel.text = "";
                break;
            case "lvl1BlueGem (gemObject)":
                blueGems.isHelmetGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 1";
                break;
            case "lvl2BlueGem (gemObject)":
                blueGems.isHelmetGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 2";
                break;
            case "lvl3BlueGem (gemObject)":
                blueGems.isHelmetGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 3";
                break;
            case "lvl4BlueGem (gemObject)":
                blueGems.isHelmetGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 4";
                break;
            case "lvl5BlueGem (gemObject)":
                blueGems.isHelmetGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 5";
                break;
            default:
                defGemLevel.text = "";
                break;
        }
        switch (GameController.helmetYellowGem)
        {
            case "":
                helmetGemLevel.text = "";
                break;
            case "lvl1YellowGem (gemObject)":
                yellowGems.isHelmetGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 1";
                break;
            case "lvl2YellowGem (gemObject)":
                yellowGems.isHelmetGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 2";
                break;
            case "lvl3YellowGem (gemObject)":
                yellowGems.isHelmetGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 3";
                break;
            case "lvl4YellowGem (gemObject)":
                yellowGems.isHelmetGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 4";
                break;
            case "lvl5YellowGem (gemObject)":
                yellowGems.isHelmetGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 5";
                break;
            default:
                helmetGemLevel.text = "";
                break;
        }
        switch (GameController.helmetOrangeGem)
        {
            case "":
                beltGemLevel.text = "";
                break;
            case "lvl1OrangeGem (gemObject)":
                orangeGems.isHelmetGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 1";
                break;
            case "lvl2OrangeGem (gemObject)":
                orangeGems.isHelmetGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 2";
                break;
            case "lvl3OrangeGem (gemObject)":
                orangeGems.isHelmetGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 3";
                break;
            case "lvl4OrangeGem (gemObject)":
                orangeGems.isHelmetGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 4";
                break;
            case "lvl5OrangeGem (gemObject)":
                orangeGems.isHelmetGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 5";
                break;
            default:
                beltGemLevel.text = "";
                break;
        }
        switch (GameController.helmetGreenGem)
        {
            case "":
                ringGemLevel.text = "";
                break;
            case "lvl1GreenGem (gemObject)":
                greenGems.isHelmetGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 1";
                break;
            case "lvl2GreenGem (gemObject)":
                greenGems.isHelmetGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 2";
                break;
            case "lvl3GreenGem (gemObject)":
                greenGems.isHelmetGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 3";
                break;
            case "lvl4GreenGem (gemObject)":
                greenGems.isHelmetGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 4";
                break;
            case "lvl5GreenGem (gemObject)":
                greenGems.isHelmetGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 5";
                break;
            default:
                ringGemLevel.text = "";
                break;
        }
    }
    public void beltSpGear()
    {
        for (int i = 0; i < 5; i++)
        {
            slot[i].SetActive(true);
            slotTxt[i].SetActive(true);
        }
        effect.SetActive(true);
        icon.SetActive(true);
        currentgear = SelectedGear.belt;
        CurrentGear.sprite = BeltGear.sprite;
        GameObject[] gemIcons = GameObject.FindGameObjectsWithTag("gemIconsEquipped");

        foreach (GameObject gemIcon in gemIcons)
        {
            Destroy(gemIcon);
        }

        switch (GameController.beltRedGem)
        {
            case "":
                atkGemLevel.text = "";
                break;
            case "lvl1RedGem (gemObject)":
                redGems.isBeltGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 1";
                break;
            case "lvl2RedGem (gemObject)":
                redGems.isBeltGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 2";
                break;
            case "lvl3RedGem (gemObject)":
                redGems.isBeltGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 3";
                break;
            case "lvl4RedGem (gemObject)":
                redGems.isBeltGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 4";
                break;
            case "lvl5RedGem (gemObject)":
                redGems.isBeltGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 5";
                break;
            default:
                atkGemLevel.text = "";
                break;
        }
        switch (GameController.beltBlueGem)
        {
            case "":
                defGemLevel.text = "";
                break;
            case "lvl1BlueGem (gemObject)":
                blueGems.isBeltGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 1";
                break;
            case "lvl2BlueGem (gemObject)":
                blueGems.isBeltGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 2";
                break;
            case "lvl3BlueGem (gemObject)":
                blueGems.isBeltGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 3";
                break;
            case "lvl4BlueGem (gemObject)":
                blueGems.isBeltGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 4";
                break;
            case "lvl5BlueGem (gemObject)":
                blueGems.isBeltGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 5";
                break;
            default:
                defGemLevel.text = "";
                break;
        }
        switch (GameController.beltYellowGem)
        {
            case "":
                helmetGemLevel.text = "";
                break;
            case "lvl1YellowGem (gemObject)":
                yellowGems.isBeltGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 1";
                break;
            case "lvl2YellowGem (gemObject)":
                yellowGems.isBeltGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 2";
                break;
            case "lvl3YellowGem (gemObject)":
                yellowGems.isBeltGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 3";
                break;
            case "lvl4YellowGem (gemObject)":
                yellowGems.isBeltGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 4";
                break;
            case "lvl5YellowGem (gemObject)":
                yellowGems.isBeltGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 5";
                break;
            default:
                helmetGemLevel.text = "";
                break;
        }
        switch (GameController.beltOrangeGem)
        {
            case "":
                beltGemLevel.text = "";
                break;
            case "lvl1OrangeGem (gemObject)":
                orangeGems.isBeltGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 1";
                break;
            case "lvl2OrangeGem (gemObject)":
                orangeGems.isBeltGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 2";
                break;
            case "lvl3OrangeGem (gemObject)":
                orangeGems.isBeltGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 3";
                break;
            case "lvl4OrangeGem (gemObject)":
                orangeGems.isBeltGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 4";
                break;
            case "lvl5OrangeGem (gemObject)":
                orangeGems.isBeltGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 5";
                break;
            default:
                beltGemLevel.text = "";
                break;
        }
        switch (GameController.beltGreenGem)
        {
            case "":
                ringGemLevel.text = "";
                break;
            case "lvl1GreenGem (gemObject)":
                greenGems.isBeltGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 1";
                break;
            case "lvl2GreenGem (gemObject)":
                greenGems.isBeltGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 2";
                break;
            case "lvl3GreenGem (gemObject)":
                greenGems.isBeltGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 3";
                break;
            case "lvl4GreenGem (gemObject)":
                greenGems.isBeltGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 4";
                break;
            case "lvl5GreenGem (gemObject)":
                greenGems.isBeltGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 5";
                break;
            default:
                ringGemLevel.text = "";
                break;
        }
    }
    public void ringHpGear()
    {
        for (int i = 0; i < 5; i++)
        {
            slot[i].SetActive(true);
            slotTxt[i].SetActive(true);
        }
        effect.SetActive(true);
        icon.SetActive(true);
        currentgear = SelectedGear.ring;
        CurrentGear.sprite = RingGear.sprite;
        GameObject[] gemIcons = GameObject.FindGameObjectsWithTag("gemIconsEquipped");

        foreach (GameObject gemIcon in gemIcons)
        {
            Destroy(gemIcon);
        }

        switch (GameController.ringRedGem)
        {
            case "":
                atkGemLevel.text = "";
                redGems.isRingGearRedGemPlaced = false;
                break;
            case "lvl1RedGem (gemObject)":
                redGems.isRingGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 1";
                break;
            case "lvl2RedGem (gemObject)":
                redGems.isRingGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 2";
                break;
            case "lvl3RedGem (gemObject)":
                redGems.isRingGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 3";
                break;
            case "lvl4RedGem (gemObject)":
                redGems.isRingGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 4";
                break;
            case "lvl5RedGem (gemObject)":
                redGems.isRingGearRedGemPlaced = true;
                atkGemLevel.text = "lvl 5";
                break;
            default:
                atkGemLevel.text = "";
                break;
        }
        switch (GameController.ringBlueGem)
        {
            case "":
                defGemLevel.text = "";
                break;
            case "lvl1BlueGem (gemObject)":
                blueGems.isRingGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 1";
                break;
            case "lvl2BlueGem (gemObject)":
                blueGems.isRingGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 2";
                break;
            case "lvl3BlueGem (gemObject)":
                blueGems.isRingGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 3";
                break;
            case "lvl4BlueGem (gemObject)":
                blueGems.isRingGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 4";
                break;
            case "lvl5BlueGem (gemObject)":
                blueGems.isRingGearBlueGemPlaced = true;
                defGemLevel.text = "lvl 5";
                break;
            default:
                defGemLevel.text = "";
                break;
        }
        switch (GameController.ringYellowGem)
        {
            case "":
                helmetGemLevel.text = "";
                break;
            case "lvl1YellowGem (gemObject)":
                yellowGems.isRingGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 1";
                break;
            case "lvl2YellowGem (gemObject)":
                yellowGems.isRingGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 2";
                break;
            case "lvl3YellowGem (gemObject)":
                yellowGems.isRingGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 3";
                break;
            case "lvl4YellowGem (gemObject)":
                yellowGems.isRingGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 4";
                break;
            case "lvl5YellowGem (gemObject)":
                yellowGems.isRingGearYellowGemPlaced = true;
                helmetGemLevel.text = "lvl 5";
                break;
            default:
                helmetGemLevel.text = "";
                break;
        }
        switch (GameController.ringOrangeGem)
        {
            case "":
                beltGemLevel.text = "";
                break;
            case "lvl1OrangeGem (gemObject)":
                orangeGems.isRingGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 1";
                break;
            case "lvl2OrangeGem (gemObject)":
                orangeGems.isRingGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 2";
                break;
            case "lvl3OrangeGem (gemObject)":
                orangeGems.isRingGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 3";
                break;
            case "lvl4OrangeGem (gemObject)":
                orangeGems.isRingGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 4";
                break;
            case "lvl5OrangeGem (gemObject)":
                orangeGems.isRingGearOrangeGemPlaced = true;
                beltGemLevel.text = "lvl 5";
                break;
            default:
                beltGemLevel.text = "";
                break;
        }
        switch (GameController.ringGreenGem)
        {
            case "":
                ringGemLevel.text = "";
                break;
            case "lvl1GreenGem (gemObject)":
                greenGems.isRingGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 1";
                break;
            case "lvl2GreenGem (gemObject)":
                greenGems.isRingGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 2";
                break;
            case "lvl3GreenGem (gemObject)":
                greenGems.isRingGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 3";
                break;
            case "lvl4GreenGem (gemObject)":
                greenGems.isRingGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 4";
                break;
            case "lvl5GreenGem (gemObject)":
                greenGems.isRingGearGreenGemPlaced = true;
                ringGemLevel.text = "lvl 5";
                break;
            default:
                ringGemLevel.text = "";
                break;
        }
    }

}
