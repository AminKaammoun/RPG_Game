using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lapidary : MonoBehaviour
{
    private string attackGear;
    private string defGear;
    private string helmetGear;
    private string beltGear;
    private string ringGear;

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

    public Image AttackGear;
    public Image DefGear;
    public Image HelmetGear;
    public Image BeltGear;
    public Image RingGear;

    public static bool refresh = false;

    // Start is called before the first frame update
    void Start()
    {
        attackGear = PlayerPrefs.GetString("AttackGear");
        defGear = PlayerPrefs.GetString("DefGear");
        helmetGear = PlayerPrefs.GetString("HelmetGear");
        beltGear = PlayerPrefs.GetString("BeltGear");
        ringGear = PlayerPrefs.GetString("RingGear");

        switch (attackGear)
        {
            case "lvl 1 attack (equipmentObject)":
                AttackGear.sprite = atkLevel1Gear;
                break;

            case "lvl 10 attack (equipmentObject)":
                AttackGear.sprite = atkLevel10Gear;
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
            case "lvl 1 def (equipmentObject)":
                DefGear.sprite = defLevel1Gear;
                break;

            case "lvl 10 def (equipmentObject)":
                DefGear.sprite = defLevel10Gear;
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
            case "lvl 1 helmet (equipmentObject)":
                HelmetGear.sprite = helmetLevel1Gear;
                break;

            case "lvl 10 helmet (equipmentObject)":
                HelmetGear.sprite = helmetLevel10Gear;
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
            case "lvl 1 belt (equipmentObject)":
                BeltGear.sprite = beltLevel1Gear;
                break;

            case "lvl 10 belt (equipmentObject)":
                BeltGear.sprite = beltLevel10Gear;
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
            case "lvl 1 ring (equipmentObject)":
                RingGear.sprite = ringLevel1Gear;
                break;

            case "lvl 10 ring (equipmentObject)":
                RingGear.sprite = ringLevel10Gear;
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
                case "lvl 1 attack (equipmentObject)":
                    AttackGear.sprite = atkLevel1Gear;
                    break;

                case "lvl 10 attack (equipmentObject)":
                    AttackGear.sprite = atkLevel10Gear;
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
                case "lvl 1 def (equipmentObject)":
                    DefGear.sprite = defLevel1Gear;
                    break;

                case "lvl 10 def (equipmentObject)":
                    DefGear.sprite = defLevel10Gear;
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
                case "lvl 1 helmet (equipmentObject)":
                    HelmetGear.sprite = helmetLevel1Gear;
                    break;

                case "lvl 10 helmet (equipmentObject)":
                    HelmetGear.sprite = helmetLevel10Gear;
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
                case "lvl 1 belt (equipmentObject)":
                    BeltGear.sprite = beltLevel1Gear;
                    break;

                case "lvl 10 belt (equipmentObject)":
                    BeltGear.sprite = beltLevel10Gear;
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
                case "lvl 1 ring (equipmentObject)":
                    RingGear.sprite = ringLevel1Gear;
                    break;

                case "lvl 10 ring (equipmentObject)":
                    RingGear.sprite = ringLevel10Gear;
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
}
