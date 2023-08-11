using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using TMPro;
using System;
using Random = UnityEngine.Random;
using System.Collections.Generic;

public enum PlayerMap
{
    Village,
    Village1,
    forrest,
    beach,
    forrestDungeon,
    forrestDungeon2,
    forrestDungeon3,
    forrestDungeon4,
    forrestDungeon2nd,
    forrestDungeon2nd1,
    forrestDungeon2nd2,
    forrestMiningArea,
    forrestTreesArea,
    beachDun,
    beachDun1,
    beachDun2,
    beachDun3,
    beachDun4,
    Library,
    castle1,
    shipOutside,
    ship1,
    ship2,
    water1,
    water2,
    water3,
    water4,
    water5,
    iceland


}

public class GameController : MonoBehaviour
{
    public Text levelText;

    public InventoryObject Inv;
    public InventoryObject GemInv;
    public InventoryObject FishInv;
    public InventoryObject meatInv;
    public InventoryObject potionInv;
    public InventoryObject materialInv;
    public InventoryObject gearsInv;

    public float TimeBtwLeafSpawn;
    public float TimeBtwBubbleSpawn;
    public float StartTime = 0.25f;

    public Camera mainCamera;

    [SerializeField] private Texture2D NormalCursor;

    public GameObject inventory;
    public GameObject[] leafSpawner;
    public GameObject[] crowSpawner;
    public GameObject[] bubbleSpawner;
    public GameObject alert;
    public GameObject kitAlert;
    public GameObject[] panel;
    public GameObject leaf;
    public GameObject[] bubble;
    public GameObject crow;
    public GameObject dashUi;
    public GameObject player;
    private GameObject pet;
    public GameObject loadingPanel;
    public GameObject tpPanel;
    public GameObject Dun1Panel;
    public GameObject Dun2Panel;
    public GameObject MiningAreaPanel;
    public GameObject TreesAreaPanel;
    public GameObject FishingAreaPanel;
    public GameObject PotionShopPanel;
    public GameObject theVillage;
    public GameObject theForrest;
    public GameObject theBeach;
    public GameObject cockAudio;
    public GameObject BlackSmithPanel;
    public GameObject BeachBlackSmithPanel;
    public GameObject GemCraftingPanel;
    public GameObject beachGemCraftingPanel;
    public GameObject volume;
    public GameObject ultDirection;
    public GameObject BrownUltDirection;
    public GameObject PinkUltDirection;
    public GameObject GreenUltDirection;
    public GameObject ultSlash;
    public GameObject ultEffect;
    public GameObject thunder;
    public GameObject gainedBp;
    public GameObject skillPointPanel;
    public GameObject ForestfishPanel;
    public GameObject BeachFishPanel;
    public GameObject butcherPanel;
    public GameObject eggPanel;
    public GameObject rock;
    public GameObject skulls;
    public GameObject Wind;
    public GameObject WindEffect;
    public GameObject redDot;

    public Toggle swapGemsToggle;

    public Image loadingSlot;
    public Sprite[] mapSprite;

    public AudioSource audioSource;
    public AudioSource musicSource;

    public AudioSource chestAudio;
    public AudioSource ultimateSound;
    public AudioSource electricityAudio;
    public AudioSource equipAudio;

    public AudioClip forestAudio;
    public AudioClip forestNightAudio;
    public AudioClip villageSound;
    public AudioClip villageMusic;
    public AudioClip LibraryMusic;
    public AudioClip CaslteMusic;
    public AudioClip forestMusic;
    public AudioClip dunMusic;
    public AudioClip beachMusic;
    public AudioClip beachAudio;
    public AudioClip iceMusic;
    public AudioClip iceAudio;
    public AudioClip dunSound;


    public GameObject forestDoor1;
    public GameObject forestDoor3;

    public static bool silverKeyDoorReset = false;
    public static bool goldKeyDoorReset = false;

    public static bool swapGems = false;

    public static LevelSystem level;
    public XpBar xpBar;
    public ultBar UltBar;
    public oxygenBar OxygenBar;

    private float currentTime;
    private float startTime = 3f;
    public static bool dashed = false;
    public static bool wantTp = false;

    public Text dashTimer;
    public Text loading;
    public Text lvl;
    public Text XP;
    public Text coinText;
    public Text coinTextPotionShop;
    public Text coinsToolTipText;

    public Text attackValue;
    public Text defValue;
    public Text agilityValue;
    public Text SpValue;
    public Text HpValue;

    public Text attackBonus;
    public Text defBonus;
    public Text agilityBonus;
    public Text SpBonus;
    public Text HpBonus;
    public Text Hp;
    public Text UltText;
    public Text diamondsText;
    public Text oxyAmountText;

    public TextMeshProUGUI battlePowerText;

    public static PlayerMap currentMap;

    private float startLoadingTime = 0.35f;
    public float TimeBtwLoading;

    private float TimeBtwCrows;
    private float startCrowTime = 2f;

    public static int coins;
    public static int diamonds;
    public static int xp;
    public static int Level;
    public static int skillPoint;
    public static int skill1Level;
    public static int skill2Level;
    public static int skill3Level;
    public static int skill4Level;
    public static int skill5Level;
    public static int currentSkill;
    public static float ultValue;

    private int value;
    public static bool showAlert = false;
    public static bool returnDunMusic = false;
    public static bool returnBeachMusic = false;
    public static bool enemyBeaten = false;
    public static bool ultPressed = false;
    public static bool attack3rd = false;
    private bool openUltimate = false;
    public static float BattlePower;
    public static bool gearExist = false;
    public static bool enterLibrary = false;
    public static bool quitLibrary = false;
    public static bool enterCastle = false;
    public static bool quitCastle = false;
    public static bool canUlt = false;
  

    private Vector2 cursorHotspot;

    public static string attackGear;
    public static string defGear;
    public static string beltGear;
    public static string helmetGear;
    public static string ringGear;

    public static string swordRedGem;
    public static string swordBlueGem;
    public static string swordYellowGem;
    public static string swordOrangeGem;
    public static string swordGreenGem;

    public static string shieldRedGem;
    public static string shieldBlueGem;
    public static string shieldYellowGem;
    public static string shieldOrangeGem;
    public static string shieldGreenGem;

    public static string helmetRedGem;
    public static string helmetBlueGem;
    public static string helmetYellowGem;
    public static string helmetOrangeGem;
    public static string helmetGreenGem;

    public static string beltRedGem;
    public static string beltBlueGem;
    public static string beltYellowGem;
    public static string beltOrangeGem;
    public static string beltGreenGem;

    public static string ringRedGem;
    public static string ringBlueGem;
    public static string ringYellowGem;
    public static string ringOrangeGem;
    public static string ringGreenGem;

    public static int swordAtkGemBonus;
    public static int swordDefGemBonus;
    public static int swordAgiGemBonus;
    public static int swordSpGemBonus;
    public static int swordHpGemBonus;

    public static int shieldAtkGemBonus;
    public static int shieldDefGemBonus;
    public static int shieldAgiGemBonus;
    public static int shieldSpGemBonus;
    public static int shieldHpGemBonus;

    public static int helmetAtkGemBonus;
    public static int helmetDefGemBonus;
    public static int helmetAgiGemBonus;
    public static int helmetSpGemBonus;
    public static int helmetHpGemBonus;

    public static int beltAtkGemBonus;
    public static int beltDefGemBonus;
    public static int beltAgiGemBonus;
    public static int beltSpGemBonus;
    public static int beltHpGemBonus;

    public static int ringAtkGemBonus;
    public static int ringDefGemBonus;
    public static int ringAgiGemBonus;
    public static int ringSpGemBonus;
    public static int ringHpGemBonus;

    public static int petAtkBonus;
    public static int pet1AtkBonus;
    public static int pet2AtkBonus;
    public static int pet3AtkBonus;

    public static int petDefBonus;
    public static int pet1DefBonus;
    public static int pet2DefBonus;
    public static int pet3DefBonus;

    public static int petSpBonus;
    public static int pet1SpBonus;
    public static int pet2SpBonus;
    public static int pet3SpBonus;

    public static int petAgiBonus;
    public static int pet1AgiBonus;
    public static int pet2AgiBonus;
    public static int pet3AgiBonus;

    public static int petHpBonus;
    public static int pet1HpBonus;
    public static int pet2HpBonus;
    public static int pet3HpBonus;

    public static bool Fish1Discovered;
    public static bool Fish2Discovered;
    public static bool Fish3Discovered;
    public static bool Fish4Discovered;
    public static bool Fish5Discovered;

    public static bool Fish6Discovered;
    public static bool Fish7Discovered;
    public static bool Fish8Discovered;
    public static bool Fish9Discovered;
    public static bool Fish10Discovered;

    public static string ability1;
    public static string ability2;
    public static string ability3;

    public Image skill;
    public Sprite[] skills;

    public static bool enemyUlt;


    public static Dictionary<int, string[]> petList = new Dictionary<int, string[]>();
    public static int numberOfPets = 0;

    public static string petName = "";

    public GameObject statsPanel;

    public Image[] usedPetImage;
    public GameObject[] highlight;
    public GameObject eggShopPanel;

    public static bool cacodeamonUltEffect = false;
    public static bool isCacodeamonDead = false;
    public GameObject boxColliderIsland;
    public GameObject oxygenBarUi;

    public static float oxygenAmount = 100f;

    // Start is called before the first frame update

    void Awake()
    {
        LoadData();
        //PlayerPrefs.SetInt("CacoShowed", 0);
        //PlayerPrefs.SetInt("haveDivingMask", 0);
       
        //pets 
        if (eggShop.savedUsedPetList[1][0] != null && eggShop.savedUsedPetList[2][0] == null && eggShop.savedUsedPetList[3][0] == null)
        {
            eggShop.usedPetList.Add(1, eggShop.savedUsedPetList[1]);


        }
        else if (eggShop.savedUsedPetList[1][0] != null && eggShop.savedUsedPetList[2][0] != null && eggShop.savedUsedPetList[3][0] == null)
        {
            eggShop.usedPetList.Add(1, eggShop.savedUsedPetList[1]);
            eggShop.usedPetList.Add(2, eggShop.savedUsedPetList[2]);


        }
        else if (eggShop.savedUsedPetList[1][0] != null && eggShop.savedUsedPetList[2][0] != null && eggShop.savedUsedPetList[3][0] != null)
        {
            eggShop.usedPetList.Add(1, eggShop.savedUsedPetList[1]);
            eggShop.usedPetList.Add(2, eggShop.savedUsedPetList[2]);
            eggShop.usedPetList.Add(3, eggShop.savedUsedPetList[3]);

        }



        //gears
        switch (attackGear)
        {
            case "lvl 1 attack (equipmentObject)":

                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 10;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 5;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 3;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 2;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 5;


                break;
            case "lvl 10 attack (equipmentObject)":

                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 50;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 25;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 15;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 10;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 25;
                break;
            
            case "lvl 20 attack (equipmentObject)":

                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 250;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 125;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 75;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 50;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 125;
                break;

            case "":
                PlayerMovements.BonusAttack = 0;
                break;
        }


        switch (defGear)
        {
            case "lvl 1 def (equipmentObject)":

                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 2;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 10;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 2;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 2;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 10;
                break;
            case "lvl 10 def (equipmentObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 10;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 50;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 10;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 10;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 50;

                break;
            case "lvl 20 def (equipmentObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 50;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 250;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 50;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 50;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 250;

                break;
        }
        switch (beltGear)
        {
            case "lvl 1 belt (equipmentObject)":

                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 3;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 6;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 3;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 10;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 7;
                break;
            case "lvl 10 belt (equipmentObject)":

                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 15;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 30;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 15;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 50;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 35;
                break;
            case "lvl 20 belt (equipmentObject)":

                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 75;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 150;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 75;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 250;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 175;
                break;
        }
        switch (helmetGear)
        {
            case "lvl 1 helmet (equipmentObject)":

                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 3;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 4;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 10;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 2;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 8;
                break;
            case "lvl 10 helmet (equipmentObject)":

                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 15;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 20;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 50;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 10;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 40;
                break;
            case "lvl 20 helmet (equipmentObject)":

                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 75;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 100;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 250;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 50;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 200;
                break;
        }
        switch (ringGear)
        {
            case "lvl 1 ring (equipmentObject)":

                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 2;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 4;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 2;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 3;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 50;
                break;
            case "lvl 10 ring (equipmentObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 10;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 20;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 10;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 15;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 250;

                break;
            case "lvl 20 ring (equipmentObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 50;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 100;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 50;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 75;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 1250;

                break;
        }
        //Red Gems
        switch (swordRedGem)
        {

            case "lvl1RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 5;
                swordAtkGemBonus = 5;
                break;

            case "lvl2RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 15;
                swordAtkGemBonus = 15;
                break;

            case "lvl3RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 45;
                swordAtkGemBonus = 45;
                break;

            case "lvl4RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 135;
                swordAtkGemBonus = 135;
                break;

            case "lvl5RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 405;
                swordAtkGemBonus = 405;
                break;
        }
        switch (shieldRedGem)
        {
            case "lvl1RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 5;
                shieldAtkGemBonus = 5;
                break;

            case "lvl2RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 15;
                shieldAtkGemBonus = 15;
                break;

            case "lvl3RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 45;
                shieldAtkGemBonus = 45;
                break;

            case "lvl4RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 135;
                shieldAtkGemBonus = 135;
                break;

            case "lvl5RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 405;
                shieldAtkGemBonus = 405;
                break;
        }
        switch (helmetRedGem)
        {
            case "lvl1RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 5;
                helmetAtkGemBonus = 5;
                break;

            case "lvl2RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 15;
                helmetAtkGemBonus = 15;
                break;

            case "lvl3RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 45;
                helmetAtkGemBonus = 45;
                break;

            case "lvl4RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 135;
                helmetAtkGemBonus = 135;
                break;

            case "lvl5RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 405;
                helmetAtkGemBonus = 405;
                break;
        }
        switch (beltRedGem)
        {
            case "lvl1RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 5;
                beltAtkGemBonus = 5;
                break;

            case "lvl2RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 15;
                beltAtkGemBonus = 15;
                break;

            case "lvl3RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 45;
                beltAtkGemBonus = 45;
                break;

            case "lvl4RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 135;
                beltAtkGemBonus = 135;
                break;

            case "lvl5RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 405;
                beltAtkGemBonus = 405;
                break;
        }
        switch (ringRedGem)
        {
            case "lvl1RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 5;
                ringAtkGemBonus = 5;
                break;

            case "lvl2RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 15;
                ringAtkGemBonus = 15;
                break;

            case "lvl3RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 45;
                ringAtkGemBonus = 45;
                break;

            case "lvl4RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 135;
                ringAtkGemBonus = 135;
                break;

            case "lvl5RedGem (gemObject)":
                PlayerMovements.BonusAttack = PlayerMovements.BonusAttack + 405;
                ringAtkGemBonus = 405;
                break;
        }

        //Blue Gems
        switch (swordBlueGem)
        {
            case "lvl1BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 5;
                swordDefGemBonus = 5;
                break;

            case "lvl2BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 15;
                swordDefGemBonus = 15;
                break;

            case "lvl3BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 45;
                swordDefGemBonus = 45;
                break;

            case "lvl4BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 135;
                swordDefGemBonus = 135;
                break;

            case "lvl5BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 405;
                swordDefGemBonus = 405;
                break;
        }
        switch (shieldBlueGem)
        {
            case "lvl1BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 5;
                shieldDefGemBonus = 5;
                break;

            case "lvl2BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 15;
                shieldDefGemBonus = 15;
                break;

            case "lvl3BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 45;
                shieldDefGemBonus = 45;
                break;

            case "lvl4BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 135;
                shieldDefGemBonus = 135;
                break;

            case "lvl5BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 405;
                shieldDefGemBonus = 405;
                break;
        }
        switch (helmetBlueGem)
        {
            case "lvl1BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 5;
                helmetDefGemBonus = 5;
                break;

            case "lvl2BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 15;
                helmetDefGemBonus = 15;
                break;

            case "lvl3BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 45;
                helmetDefGemBonus = 45;
                break;

            case "lvl4BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 135;
                helmetDefGemBonus = 135;
                break;

            case "lvl5BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 405;
                helmetDefGemBonus = 405;
                break;
        }
        switch (beltBlueGem)
        {
            case "lvl1BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 5;
                beltDefGemBonus = 5;
                break;

            case "lvl2BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 15;
                beltDefGemBonus = 15;
                break;

            case "lvl3BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 45;
                beltDefGemBonus = 45;
                break;

            case "lvl4BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 135;
                beltDefGemBonus = 135;
                break;

            case "lvl5BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 405;
                beltDefGemBonus = 405;
                break;
        }
        switch (ringBlueGem)
        {
            case "lvl1BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 5;
                ringDefGemBonus = 5;
                break;

            case "lvl2BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 15;
                ringDefGemBonus = 15;
                break;

            case "lvl3BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 45;
                ringDefGemBonus = 45;
                break;

            case "lvl4BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 135;
                ringDefGemBonus = 135;
                break;

            case "lvl5BlueGem (gemObject)":
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 405;
                ringDefGemBonus = 405;
                break;
        }

        //Yellow Gems
        switch (swordYellowGem)
        {
            case "lvl1YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 5;
                swordAgiGemBonus = 5;
                break;

            case "lvl2YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 15;
                swordAgiGemBonus = 15;
                break;

            case "lvl3YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 45;
                swordAgiGemBonus = 45;
                break;

            case "lvl4YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 135;
                swordAgiGemBonus = 135;
                break;

            case "lvl5YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 405;
                swordAgiGemBonus = 405;
                break;
        }
        switch (shieldYellowGem)
        {
            case "lvl1YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 5;
                shieldAgiGemBonus = 5;
                break;

            case "lvl2YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 15;
                shieldAgiGemBonus = 15;
                break;

            case "lvl3YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 45;
                shieldAgiGemBonus = 45;
                break;

            case "lvl4YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 135;
                shieldAgiGemBonus = 135;
                break;

            case "lvl5YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 405;
                shieldAgiGemBonus = 405;
                break;
        }
        switch (helmetYellowGem)
        {
            case "lvl1YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 5;
                helmetAgiGemBonus = 5;
                break;

            case "lvl2YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 15;
                helmetAgiGemBonus = 15;
                break;

            case "lvl3YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 45;
                helmetAgiGemBonus = 45;
                break;

            case "lvl4YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 135;
                helmetAgiGemBonus = 135;
                break;

            case "lvl5YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 405;
                helmetAgiGemBonus = 405;
                break;
        }
        switch (beltYellowGem)
        {
            case "lvl1YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 5;
                beltAgiGemBonus = 5;
                break;
            case "lvl2YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 15;
                beltAgiGemBonus = 15;
                break;

            case "lvl3YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 45;
                beltAgiGemBonus = 45;
                break;

            case "lvl4YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 135;
                beltAgiGemBonus = 135;
                break;

            case "lvl5YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 405;
                beltAgiGemBonus = 405;
                break;
        }
        switch (ringYellowGem)
        {
            case "lvl1YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 5;
                ringAgiGemBonus = 5;
                break;

            case "lvl2YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 15;
                ringAgiGemBonus = 15;
                break;

            case "lvl3YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 45;
                ringAgiGemBonus = 45;
                break;

            case "lvl4YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 135;
                ringAgiGemBonus = 135;
                break;

            case "lvl5YellowGem (gemObject)":
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 405;
                ringAgiGemBonus = 405;
                break;
        }

        //Orange Gems

        switch (swordOrangeGem)
        {
            case "lvl1OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 5;
                swordSpGemBonus = 5;
                break;

            case "lvl2OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 15;
                swordSpGemBonus = 15;
                break;

            case "lvl3OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 45;
                swordSpGemBonus = 45;
                break;

            case "lvl4OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 135;
                swordSpGemBonus = 135;
                break;

            case "lvl5OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 405;
                swordSpGemBonus = 405;
                break;
        }
        switch (shieldOrangeGem)
        {
            case "lvl1OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 5;
                shieldSpGemBonus = 5;
                break;
            case "lvl2OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 15;
                shieldSpGemBonus = 15;
                break;

            case "lvl3OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 45;
                shieldSpGemBonus = 45;
                break;

            case "lvl4OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 135;
                shieldSpGemBonus = 135;
                break;

            case "lvl5OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 405;
                shieldSpGemBonus = 405;
                break;
        }
        switch (helmetOrangeGem)
        {
            case "lvl1OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 5;
                helmetSpGemBonus = 5;
                break;

            case "lvl2OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 15;
                helmetSpGemBonus = 15;
                break;

            case "lvl3OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 45;
                helmetSpGemBonus = 45;
                break;

            case "lvl4OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 135;
                helmetSpGemBonus = 135;
                break;

            case "lvl5OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 405;
                helmetSpGemBonus = 405;
                break;
        }
        switch (beltOrangeGem)
        {
            case "lvl1OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 5;
                beltSpGemBonus = 5;
                break;


            case "lvl2OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 15;
                beltSpGemBonus = 15;
                break;

            case "lvl3OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 45;
                beltSpGemBonus = 45;
                break;

            case "lvl4OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 135;
                beltSpGemBonus = 135;
                break;

            case "lvl5OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 405;
                beltSpGemBonus = 405;
                break;
        }
        switch (ringOrangeGem)
        {
            case "lvl1OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 5;
                ringSpGemBonus = 5;
                break;
            case "lvl2OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 15;
                ringSpGemBonus = 15;
                break;

            case "lvl3OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 45;
                ringSpGemBonus = 45;
                break;

            case "lvl4OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 135;
                ringSpGemBonus = 135;
                break;

            case "lvl5OrangeGem (gemObject)":
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 405;
                ringSpGemBonus = 405;
                break;
        }


        //Green Gems

        switch (swordGreenGem)
        {
            case "lvl1GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 25;
                swordHpGemBonus = 25;
                break;
            case "lvl2GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 75;
                swordHpGemBonus = 75;
                break;

            case "lvl3GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 225;
                swordHpGemBonus = 225;
                break;

            case "lvl4GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 675;
                swordHpGemBonus = 675;
                break;

            case "lvl5GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 2025;
                swordHpGemBonus = 2025;
                break;
        }
        switch (shieldGreenGem)
        {
            case "lvl1GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 25;
                shieldHpGemBonus = 25;
                break;

            case "lvl2GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 75;
                shieldHpGemBonus = 75;
                break;

            case "lvl3GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 225;
                shieldHpGemBonus = 225;
                break;

            case "lvl4GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 675;
                shieldHpGemBonus = 675;
                break;

            case "lvl5GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 2025;
                shieldHpGemBonus = 2025;
                break;
        }
        switch (helmetGreenGem)
        {
            case "lvl1GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 25;
                helmetHpGemBonus = 25;
                break;

            case "lvl2GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 75;
                helmetHpGemBonus = 75;
                break;

            case "lvl3GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 225;
                helmetHpGemBonus = 225;
                break;

            case "lvl4GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 675;
                helmetHpGemBonus = 675;
                break;

            case "lvl5GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 2025;
                helmetHpGemBonus = 2025;
                break;
        }
        switch (beltGreenGem)
        {
            case "lvl1GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 25;
                beltHpGemBonus = 25;
                break;


            case "lvl2GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 75;
                beltHpGemBonus = 75;
                break;

            case "lvl3GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 225;
                beltHpGemBonus = 225;
                break;

            case "lvl4GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 675;
                beltHpGemBonus = 675;
                break;

            case "lvl5GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 2025;
                beltHpGemBonus = 2025;
                break;
        }
        switch (ringGreenGem)
        {
            case "lvl1GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 25;
                ringHpGemBonus = 25;
                break;

            case "lvl2GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 75;
                ringHpGemBonus = 75;
                break;

            case "lvl3GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 225;
                ringHpGemBonus = 225;
                break;

            case "lvl4GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 675;
                ringHpGemBonus = 675;
                break;

            case "lvl5GreenGem (gemObject)":
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 2025;
                ringHpGemBonus = 2025;
                break;
        }


        int a = PlayerPrefs.GetInt("swapGems");
        if (a == 1)
        {
            swapGemsToggle.isOn = true;
        }
        else
        {
            swapGemsToggle.isOn = false;
        }


        level = new LevelSystem(Level, OnLevelUp);
        level.experience = xp;
        BattlePower = PlayerPrefs.GetInt("BattlePower");
        currentTime = startTime;
        TimeBtwCrows = startCrowTime;
        leafSpawner = GameObject.FindGameObjectsWithTag("LeafSpawner");
        crowSpawner = GameObject.FindGameObjectsWithTag("crowSpawner");
        bubbleSpawner = GameObject.FindGameObjectsWithTag("BubbleSpawner");
        currentMap = PlayerMap.beach;

    }

    public void SaveData()
    {
        saveSystem.SavePlayer(this);
        saveSystem.SaveGears(this);
        saveSystem.SaveSwordGems(this);
        saveSystem.SaveShieldGems(this);
        saveSystem.SaveHelmetGems(this);
        saveSystem.SaveBeltGems(this);
        saveSystem.SaveRingGems(this);
        saveSystem.SaveFishs(this);
        saveSystem.SaveEggs(this);
        saveSystem.SavePets(this);
    }

    public void LoadData()
    {
        playerData data = saveSystem.LoadPlayer();

        coins = data.coins;
        diamonds = data.diamonds;
        PlayerMovements.health = data.health;
        xp = data.xp;
        Level = data.level;
        skill1Level = data.skill1Level;
        skill2Level = data.skill2Level;
        skill3Level = data.skill3Level;
        skill4Level = data.skill4Level;
        skill5Level = data.skill5Level;
        skillPoint = data.skillPoints;
        currentSkill = data.CurrentSkill;
        ability1 = data.ability1;
        ability2 = data.ability2;
        ability3 = data.ability3;

        gearData data1 = saveSystem.LoadGears();

        attackGear = data1.attackGear;
        defGear = data1.defGear;
        beltGear = data1.beltGear;
        helmetGear = data1.helmetGear;
        ringGear = data1.ringGear;

        swordGemsData data2 = saveSystem.LoadSwordGems();

        swordRedGem = data2.swordRedGem;
        swordBlueGem = data2.swordBlueGem;
        swordYellowGem = data2.swordYellowGem;
        swordOrangeGem = data2.swordOrangeGem;
        swordGreenGem = data2.swordGreenGem;

        shieldGemsData data3 = saveSystem.LoadShieldGems();

        shieldRedGem = data3.shieldRedGem;
        shieldBlueGem = data3.shieldBlueGem;
        shieldYellowGem = data3.shieldYellowGem;
        shieldOrangeGem = data3.shieldOrangeGem;
        shieldGreenGem = data3.shieldGreenGem;

        helmetGemsData data4 = saveSystem.LoadHelmetGems();

        helmetRedGem = data4.helmetRedGem;
        helmetBlueGem = data4.helmetBlueGem;
        helmetYellowGem = data4.helmetYellowGem;
        helmetOrangeGem = data4.helmetOrangeGem;
        helmetGreenGem = data4.helmetGreenGem;

        beltGemsData data5 = saveSystem.LoadBeltGems();

        beltRedGem = data5.beltRedGem;
        beltBlueGem = data5.beltBlueGem;
        beltYellowGem = data5.beltYellowGem;
        beltOrangeGem = data5.beltOrangeGem;
        beltGreenGem = data5.beltGreenGem;

        ringGemsData data6 = saveSystem.LoadRingGems();

        ringRedGem = data6.ringRedGem;
        ringBlueGem = data6.ringBlueGem;
        ringYellowGem = data6.ringYellowGem;
        ringOrangeGem = data6.ringOrangeGem;
        ringGreenGem = data6.ringGreenGem;

        fishData data7 = saveSystem.LoadFishs();

        Fish1Discovered = data7.Fish1Discovered;
        Fish2Discovered = data7.Fish2Discovered;
        Fish3Discovered = data7.Fish3Discovered;
        Fish4Discovered = data7.Fish4Discovered;
        Fish5Discovered = data7.Fish5Discovered;

        Fish6Discovered = data7.Fish6Discovered;
        Fish7Discovered = data7.Fish7Discovered;
        Fish8Discovered = data7.Fish8Discovered;
        Fish9Discovered = data7.Fish9Discovered;
        Fish10Discovered = data7.Fish10Discovered;

        eggsData data8 = saveSystem.LoadEggs();

        eggShop.nestLevel[0] = data8.nestLevel[0];
        eggShop.nestLevel[1] = data8.nestLevel[1];
        eggShop.nestLevel[2] = data8.nestLevel[2];

        eggShop.eggType[0] = data8.eggType[0];
        eggShop.eggType[1] = data8.eggType[1];
        eggShop.eggType[2] = data8.eggType[2];

        eggShop.requiredEggs[0] = data8.requiredEggs[0];
        eggShop.requiredEggs[1] = data8.requiredEggs[1];
        eggShop.requiredEggs[2] = data8.requiredEggs[2];

        petsData data9 = saveSystem.LoadPets();

       
            switch (data9.usedPetName.Length)
            {

                case 1:
                    eggShop.savedUsedPetList.Add(1, new string[] { data9.usedPetName[0], data9.usedPetLevel[0], data9.usedXp[0], data9.usedMaxXp[0], data9.usedStars[0], data9.usedBaseAtk[0], data9.usedBaseDef[0], data9.usedBaseSp[0], data9.usedBaseAgi[0], data9.usedBaseHp[0], data9.usedStatsPoint[0], data9.usedBonusAtk[0], data9.usedBonusDef[0], data9.usedBonusSp[0], data9.usedBonusAgi[0], data9.usedBonusHp[0], data9.usedElement[0] });
                    break;
                case 2:
                    eggShop.savedUsedPetList.Add(1, new string[] { data9.usedPetName[0], data9.usedPetLevel[0], data9.usedXp[0], data9.usedMaxXp[0], data9.usedStars[0], data9.usedBaseAtk[0], data9.usedBaseDef[0], data9.usedBaseSp[0], data9.usedBaseAgi[0], data9.usedBaseHp[0], data9.usedStatsPoint[0], data9.usedBonusAtk[0], data9.usedBonusDef[0], data9.usedBonusSp[0], data9.usedBonusAgi[0], data9.usedBonusHp[0], data9.usedElement[0] });
                    eggShop.savedUsedPetList.Add(2, new string[] { data9.usedPetName[1], data9.usedPetLevel[1], data9.usedXp[1], data9.usedMaxXp[1], data9.usedStars[1], data9.usedBaseAtk[1], data9.usedBaseDef[1], data9.usedBaseSp[1], data9.usedBaseAgi[1], data9.usedBaseHp[1], data9.usedStatsPoint[1], data9.usedBonusAtk[1], data9.usedBonusDef[1], data9.usedBonusSp[1], data9.usedBonusAgi[1], data9.usedBonusHp[1] });
                    break;
                case 3:
                    eggShop.savedUsedPetList.Add(1, new string[] { data9.usedPetName[0], data9.usedPetLevel[0], data9.usedXp[0], data9.usedMaxXp[0], data9.usedStars[0], data9.usedBaseAtk[0], data9.usedBaseDef[0], data9.usedBaseSp[0], data9.usedBaseAgi[0], data9.usedBaseHp[0], data9.usedStatsPoint[0], data9.usedBonusAtk[0], data9.usedBonusDef[0], data9.usedBonusSp[0], data9.usedBonusAgi[0], data9.usedBonusHp[0], data9.usedElement[0] });
                    eggShop.savedUsedPetList.Add(2, new string[] { data9.usedPetName[1], data9.usedPetLevel[1], data9.usedXp[1], data9.usedMaxXp[1], data9.usedStars[1], data9.usedBaseAtk[1], data9.usedBaseDef[1], data9.usedBaseSp[1], data9.usedBaseAgi[1], data9.usedBaseHp[1], data9.usedStatsPoint[1], data9.usedBonusAtk[1], data9.usedBonusDef[1], data9.usedBonusSp[1], data9.usedBonusAgi[1], data9.usedBonusHp[1], data9.usedElement[1] });
                    eggShop.savedUsedPetList.Add(3, new string[] { data9.usedPetName[2], data9.usedPetLevel[2], data9.usedXp[2], data9.usedMaxXp[2], data9.usedStars[2], data9.usedBaseAtk[2], data9.usedBaseDef[2], data9.usedBaseSp[2], data9.usedBaseAgi[2], data9.usedBaseHp[2], data9.usedStatsPoint[2], data9.usedBonusAtk[2], data9.usedBonusDef[2], data9.usedBonusSp[2], data9.usedBonusAgi[2], data9.usedBonusHp[2], data9.usedElement[2] });
                    break;
            }
       

        for (int i = 1; i<= data9.length; i++)
        {
            petList.Add(i, new string[] { data9.petName[i-1], data9.petLevel[i-1], data9.xp[i - 1], data9.maxXp[i - 1], data9.stars[i - 1], data9.BaseAtk[i - 1], data9.BaseDef[i - 1], data9.BaseSp[i - 1], data9.BaseAgi[i - 1], data9.BaseHp[i - 1], data9.statsPoint[i - 1], data9.BonusAtk[i - 1], data9.BonusDef[i - 1], data9.BonusSp[i - 1], data9.BonusAgi[i - 1], data9.BonusHp[i - 1], data9.Element[i -1] });
        }

        }
    
    
    private void OnApplicationQuit()
    {
        SaveData();

    }


    void FixedUpdate()
    {


    }

    void Update()
    {

        switch (eggShop.usedPetList.Count)
        {
            case 0:
                GameController.petAtkBonus = 0;
                GameController.petDefBonus = 0;
                GameController.petSpBonus = 0;
                GameController.petAgiBonus = 0;
                GameController.petHpBonus = 0;
                break;
            case 1:

                switch (eggShop.usedPetList[1][4])
                {
                    case "2":
                        GameController.pet1AtkBonus = int.Parse(eggShop.usedPetList[1][5]) * eggShop.Atk2starsPet + int.Parse(eggShop.usedPetList[1][11]) * eggShop.Atk2starsPet;
                        GameController.pet1DefBonus = int.Parse(eggShop.usedPetList[1][6]) * eggShop.Def2starsPet + int.Parse(eggShop.usedPetList[1][12]) * eggShop.Def2starsPet;
                        GameController.pet1SpBonus = int.Parse(eggShop.usedPetList[1][7]) * eggShop.Sp2starsPet + int.Parse(eggShop.usedPetList[1][13]) * eggShop.Sp2starsPet;
                        GameController.pet1AgiBonus = int.Parse(eggShop.usedPetList[1][8]) * eggShop.Agi2starsPet + int.Parse(eggShop.usedPetList[1][14]) * eggShop.Agi2starsPet;
                        GameController.pet1HpBonus = int.Parse(eggShop.usedPetList[1][9]) * eggShop.Hp2starsPet + int.Parse(eggShop.usedPetList[1][15]) * eggShop.Hp2starsPet;
                        break;
                    case "3":
                        GameController.pet1AtkBonus = int.Parse(eggShop.usedPetList[1][5]) * eggShop.Atk3starsPet + int.Parse(eggShop.usedPetList[1][11]) * eggShop.Atk3starsPet;
                        GameController.pet1DefBonus = int.Parse(eggShop.usedPetList[1][6]) * eggShop.Def3starsPet + int.Parse(eggShop.usedPetList[1][12]) * eggShop.Def3starsPet;
                        GameController.pet1SpBonus = int.Parse(eggShop.usedPetList[1][7]) * eggShop.Sp3starsPet + int.Parse(eggShop.usedPetList[1][13]) * eggShop.Sp3starsPet;
                        GameController.pet1AgiBonus = int.Parse(eggShop.usedPetList[1][8]) * eggShop.Agi3starsPet + int.Parse(eggShop.usedPetList[1][14]) * eggShop.Agi3starsPet;
                        GameController.pet1HpBonus = int.Parse(eggShop.usedPetList[1][9]) * eggShop.Hp3starsPet + int.Parse(eggShop.usedPetList[1][15]) * eggShop.Hp3starsPet;
                        break;
                    case "4":
                        GameController.pet1AtkBonus = int.Parse(eggShop.usedPetList[1][5]) * eggShop.Atk4starsPet + int.Parse(eggShop.usedPetList[1][11]) * eggShop.Atk4starsPet;
                        GameController.pet1DefBonus = int.Parse(eggShop.usedPetList[1][6]) * eggShop.Def4starsPet + int.Parse(eggShop.usedPetList[1][12]) * eggShop.Def4starsPet;
                        GameController.pet1SpBonus = int.Parse(eggShop.usedPetList[1][7]) * eggShop.Sp4starsPet + int.Parse(eggShop.usedPetList[1][13]) * eggShop.Sp4starsPet;
                        GameController.pet1AgiBonus = int.Parse(eggShop.usedPetList[1][8]) * eggShop.Agi4starsPet + int.Parse(eggShop.usedPetList[1][14]) * eggShop.Agi4starsPet;
                        GameController.pet1HpBonus = int.Parse(eggShop.usedPetList[1][9]) * eggShop.Hp4starsPet + int.Parse(eggShop.usedPetList[1][15]) * eggShop.Hp4starsPet;
                        break;
                    case "5":
                        GameController.pet1AtkBonus = int.Parse(eggShop.usedPetList[1][5]) * eggShop.Atk5starsPet + int.Parse(eggShop.usedPetList[1][11]) * eggShop.Atk5starsPet;
                        GameController.pet1DefBonus = int.Parse(eggShop.usedPetList[1][6]) * eggShop.Def5starsPet + int.Parse(eggShop.usedPetList[1][12]) * eggShop.Def5starsPet;
                        GameController.pet1SpBonus = int.Parse(eggShop.usedPetList[1][7]) * eggShop.Sp5starsPet + int.Parse(eggShop.usedPetList[1][13]) * eggShop.Sp5starsPet;
                        GameController.pet1AgiBonus = int.Parse(eggShop.usedPetList[1][8]) * eggShop.Agi5starsPet + int.Parse(eggShop.usedPetList[1][14]) * eggShop.Agi5starsPet;
                        GameController.pet1HpBonus = int.Parse(eggShop.usedPetList[1][9]) * eggShop.Hp5starsPet + int.Parse(eggShop.usedPetList[1][15]) * eggShop.Hp5starsPet;
                        break;

                }

                break;

            case 2:

                switch (eggShop.usedPetList[1][4])
                {
                    case "2":
                        GameController.pet1AtkBonus = int.Parse(eggShop.usedPetList[1][5]) * eggShop.Atk2starsPet + int.Parse(eggShop.usedPetList[1][11]) * eggShop.Atk2starsPet;
                        GameController.pet1DefBonus = int.Parse(eggShop.usedPetList[1][6]) * eggShop.Def2starsPet + int.Parse(eggShop.usedPetList[1][12]) * eggShop.Def2starsPet;
                        GameController.pet1SpBonus = int.Parse(eggShop.usedPetList[1][7]) * eggShop.Sp2starsPet + int.Parse(eggShop.usedPetList[1][13]) * eggShop.Sp2starsPet;
                        GameController.pet1AgiBonus = int.Parse(eggShop.usedPetList[1][8]) * eggShop.Agi2starsPet + int.Parse(eggShop.usedPetList[1][14]) * eggShop.Agi2starsPet;
                        GameController.pet1HpBonus = int.Parse(eggShop.usedPetList[1][9]) * eggShop.Hp2starsPet + int.Parse(eggShop.usedPetList[1][15]) * eggShop.Hp2starsPet;
                        break;
                    case "3":
                        GameController.pet1AtkBonus = int.Parse(eggShop.usedPetList[1][5]) * eggShop.Atk3starsPet + int.Parse(eggShop.usedPetList[1][11]) * eggShop.Atk3starsPet;
                        GameController.pet1DefBonus = int.Parse(eggShop.usedPetList[1][6]) * eggShop.Def3starsPet + int.Parse(eggShop.usedPetList[1][12]) * eggShop.Def3starsPet;
                        GameController.pet1SpBonus = int.Parse(eggShop.usedPetList[1][7]) * eggShop.Sp3starsPet + int.Parse(eggShop.usedPetList[1][13]) * eggShop.Sp3starsPet;
                        GameController.pet1AgiBonus = int.Parse(eggShop.usedPetList[1][8]) * eggShop.Agi3starsPet + int.Parse(eggShop.usedPetList[1][14]) * eggShop.Agi3starsPet;
                        GameController.pet1HpBonus = int.Parse(eggShop.usedPetList[1][9]) * eggShop.Hp3starsPet + int.Parse(eggShop.usedPetList[1][15]) * eggShop.Hp3starsPet;
                        break;
                    case "4":
                        GameController.pet1AtkBonus = int.Parse(eggShop.usedPetList[1][5]) * eggShop.Atk4starsPet + int.Parse(eggShop.usedPetList[1][11]) * eggShop.Atk4starsPet;
                        GameController.pet1DefBonus = int.Parse(eggShop.usedPetList[1][6]) * eggShop.Def4starsPet + int.Parse(eggShop.usedPetList[1][12]) * eggShop.Def4starsPet;
                        GameController.pet1SpBonus = int.Parse(eggShop.usedPetList[1][7]) * eggShop.Sp4starsPet + int.Parse(eggShop.usedPetList[1][13]) * eggShop.Sp4starsPet;
                        GameController.pet1AgiBonus = int.Parse(eggShop.usedPetList[1][8]) * eggShop.Agi4starsPet + int.Parse(eggShop.usedPetList[1][14]) * eggShop.Agi4starsPet;
                        GameController.pet1HpBonus = int.Parse(eggShop.usedPetList[1][9]) * eggShop.Hp4starsPet + int.Parse(eggShop.usedPetList[1][15]) * eggShop.Hp4starsPet;
                        break;
                    case "5":
                        GameController.pet1AtkBonus = int.Parse(eggShop.usedPetList[1][5]) * eggShop.Atk5starsPet + int.Parse(eggShop.usedPetList[1][11]) * eggShop.Atk5starsPet;
                        GameController.pet1DefBonus = int.Parse(eggShop.usedPetList[1][6]) * eggShop.Def5starsPet + int.Parse(eggShop.usedPetList[1][12]) * eggShop.Def5starsPet;
                        GameController.pet1SpBonus = int.Parse(eggShop.usedPetList[1][7]) * eggShop.Sp5starsPet + int.Parse(eggShop.usedPetList[1][13]) * eggShop.Sp5starsPet;
                        GameController.pet1AgiBonus = int.Parse(eggShop.usedPetList[1][8]) * eggShop.Agi5starsPet + int.Parse(eggShop.usedPetList[1][14]) * eggShop.Agi5starsPet;
                        GameController.pet1HpBonus = int.Parse(eggShop.usedPetList[1][9]) * eggShop.Hp5starsPet + int.Parse(eggShop.usedPetList[1][15]) * eggShop.Hp5starsPet;
                        break;

                }


                switch (eggShop.usedPetList[2][4])
                {
                    case "2":
                        GameController.pet2AtkBonus = int.Parse(eggShop.usedPetList[2][5]) * eggShop.Atk2starsPet + int.Parse(eggShop.usedPetList[2][11]) * eggShop.Atk2starsPet;
                        GameController.pet2DefBonus = int.Parse(eggShop.usedPetList[2][6]) * eggShop.Def2starsPet + int.Parse(eggShop.usedPetList[2][12]) * eggShop.Def2starsPet;
                        GameController.pet2SpBonus = int.Parse(eggShop.usedPetList[2][7]) * eggShop.Sp2starsPet + int.Parse(eggShop.usedPetList[2][13]) * eggShop.Sp2starsPet;
                        GameController.pet2AgiBonus = int.Parse(eggShop.usedPetList[2][8]) * eggShop.Agi2starsPet + int.Parse(eggShop.usedPetList[2][14]) * eggShop.Agi2starsPet;
                        GameController.pet2HpBonus = int.Parse(eggShop.usedPetList[2][9]) * eggShop.Hp2starsPet + int.Parse(eggShop.usedPetList[2][15]) * eggShop.Hp2starsPet;
                        break;
                    case "3":
                        GameController.pet2AtkBonus = int.Parse(eggShop.usedPetList[2][5]) * eggShop.Atk3starsPet + int.Parse(eggShop.usedPetList[2][11]) * eggShop.Atk3starsPet;
                        GameController.pet2DefBonus = int.Parse(eggShop.usedPetList[2][6]) * eggShop.Def3starsPet + int.Parse(eggShop.usedPetList[2][12]) * eggShop.Def3starsPet;
                        GameController.pet2SpBonus = int.Parse(eggShop.usedPetList[2][7]) * eggShop.Sp3starsPet + int.Parse(eggShop.usedPetList[2][13]) * eggShop.Sp3starsPet;
                        GameController.pet2AgiBonus = int.Parse(eggShop.usedPetList[2][8]) * eggShop.Agi3starsPet + int.Parse(eggShop.usedPetList[2][14]) * eggShop.Agi3starsPet;
                        GameController.pet2HpBonus = int.Parse(eggShop.usedPetList[2][9]) * eggShop.Hp3starsPet + int.Parse(eggShop.usedPetList[2][15]) * eggShop.Hp3starsPet;
                        break;
                    case "4":
                        GameController.pet2AtkBonus = int.Parse(eggShop.usedPetList[2][5]) * eggShop.Atk4starsPet + int.Parse(eggShop.usedPetList[2][11]) * eggShop.Atk4starsPet;
                        GameController.pet2DefBonus = int.Parse(eggShop.usedPetList[2][6]) * eggShop.Def4starsPet + int.Parse(eggShop.usedPetList[2][12]) * eggShop.Def4starsPet;
                        GameController.pet2SpBonus = int.Parse(eggShop.usedPetList[2][7]) * eggShop.Sp4starsPet + int.Parse(eggShop.usedPetList[2][13]) * eggShop.Sp4starsPet;
                        GameController.pet2AgiBonus = int.Parse(eggShop.usedPetList[2][8]) * eggShop.Agi4starsPet + int.Parse(eggShop.usedPetList[2][14]) * eggShop.Agi4starsPet;
                        GameController.pet2HpBonus = int.Parse(eggShop.usedPetList[2][9]) * eggShop.Hp4starsPet + int.Parse(eggShop.usedPetList[2][15]) * eggShop.Hp4starsPet;
                        break;
                    case "5":
                        GameController.pet2AtkBonus = int.Parse(eggShop.usedPetList[2][5]) * eggShop.Atk5starsPet + int.Parse(eggShop.usedPetList[2][11]) * eggShop.Atk5starsPet;
                        GameController.pet2DefBonus = int.Parse(eggShop.usedPetList[2][6]) * eggShop.Def5starsPet + int.Parse(eggShop.usedPetList[2][12]) * eggShop.Def5starsPet;
                        GameController.pet2SpBonus = int.Parse(eggShop.usedPetList[2][7]) * eggShop.Sp5starsPet + int.Parse(eggShop.usedPetList[2][13]) * eggShop.Sp5starsPet;
                        GameController.pet2AgiBonus = int.Parse(eggShop.usedPetList[2][8]) * eggShop.Agi5starsPet + int.Parse(eggShop.usedPetList[2][14]) * eggShop.Agi5starsPet;
                        GameController.pet2HpBonus = int.Parse(eggShop.usedPetList[2][9]) * eggShop.Hp5starsPet + int.Parse(eggShop.usedPetList[2][15]) * eggShop.Hp5starsPet;
                        break;

                }
                break;

            case 3:

                switch (eggShop.usedPetList[1][4])
                {
                    case "2":
                        GameController.pet1AtkBonus = int.Parse(eggShop.usedPetList[1][5]) * eggShop.Atk2starsPet + int.Parse(eggShop.usedPetList[1][11]) * eggShop.Atk2starsPet;
                        GameController.pet1DefBonus = int.Parse(eggShop.usedPetList[1][6]) * eggShop.Def2starsPet + int.Parse(eggShop.usedPetList[1][12]) * eggShop.Def2starsPet;
                        GameController.pet1SpBonus = int.Parse(eggShop.usedPetList[1][7]) * eggShop.Sp2starsPet + int.Parse(eggShop.usedPetList[1][13]) * eggShop.Sp2starsPet;
                        GameController.pet1AgiBonus = int.Parse(eggShop.usedPetList[1][8]) * eggShop.Agi2starsPet + int.Parse(eggShop.usedPetList[1][14]) * eggShop.Agi2starsPet;
                        GameController.pet1HpBonus = int.Parse(eggShop.usedPetList[1][9]) * eggShop.Hp2starsPet + int.Parse(eggShop.usedPetList[1][15]) * eggShop.Hp2starsPet;
                        break;
                    case "3":
                        GameController.pet1AtkBonus = int.Parse(eggShop.usedPetList[1][5]) * eggShop.Atk3starsPet + int.Parse(eggShop.usedPetList[1][11]) * eggShop.Atk3starsPet;
                        GameController.pet1DefBonus = int.Parse(eggShop.usedPetList[1][6]) * eggShop.Def3starsPet + int.Parse(eggShop.usedPetList[1][12]) * eggShop.Def3starsPet;
                        GameController.pet1SpBonus = int.Parse(eggShop.usedPetList[1][7]) * eggShop.Sp3starsPet + int.Parse(eggShop.usedPetList[1][13]) * eggShop.Sp3starsPet;
                        GameController.pet1AgiBonus = int.Parse(eggShop.usedPetList[1][8]) * eggShop.Agi3starsPet + int.Parse(eggShop.usedPetList[1][14]) * eggShop.Agi3starsPet;
                        GameController.pet1HpBonus = int.Parse(eggShop.usedPetList[1][9]) * eggShop.Hp3starsPet + int.Parse(eggShop.usedPetList[1][15]) * eggShop.Hp3starsPet;
                        break;
                    case "4":
                        GameController.pet1AtkBonus = int.Parse(eggShop.usedPetList[1][5]) * eggShop.Atk4starsPet + int.Parse(eggShop.usedPetList[1][11]) * eggShop.Atk4starsPet;
                        GameController.pet1DefBonus = int.Parse(eggShop.usedPetList[1][6]) * eggShop.Def4starsPet + int.Parse(eggShop.usedPetList[1][12]) * eggShop.Def4starsPet;
                        GameController.pet1SpBonus = int.Parse(eggShop.usedPetList[1][7]) * eggShop.Sp4starsPet + int.Parse(eggShop.usedPetList[1][13]) * eggShop.Sp4starsPet;
                        GameController.pet1AgiBonus = int.Parse(eggShop.usedPetList[1][8]) * eggShop.Agi4starsPet + int.Parse(eggShop.usedPetList[1][14]) * eggShop.Agi4starsPet;
                        GameController.pet1HpBonus = int.Parse(eggShop.usedPetList[1][9]) * eggShop.Hp4starsPet + int.Parse(eggShop.usedPetList[1][15]) * eggShop.Hp4starsPet;
                        break;
                    case "5":
                        GameController.pet1AtkBonus = int.Parse(eggShop.usedPetList[1][5]) * eggShop.Atk5starsPet + int.Parse(eggShop.usedPetList[1][11]) * eggShop.Atk5starsPet;
                        GameController.pet1DefBonus = int.Parse(eggShop.usedPetList[1][6]) * eggShop.Def5starsPet + int.Parse(eggShop.usedPetList[1][12]) * eggShop.Def5starsPet;
                        GameController.pet1SpBonus = int.Parse(eggShop.usedPetList[1][7]) * eggShop.Sp5starsPet + int.Parse(eggShop.usedPetList[1][13]) * eggShop.Sp5starsPet;
                        GameController.pet1AgiBonus = int.Parse(eggShop.usedPetList[1][8]) * eggShop.Agi5starsPet + int.Parse(eggShop.usedPetList[1][14]) * eggShop.Agi5starsPet;
                        GameController.pet1HpBonus = int.Parse(eggShop.usedPetList[1][9]) * eggShop.Hp5starsPet + int.Parse(eggShop.usedPetList[1][15]) * eggShop.Hp5starsPet;
                        break;
                }


                switch (eggShop.usedPetList[2][4])
                {
                    case "2":
                        GameController.pet2AtkBonus = int.Parse(eggShop.usedPetList[2][5]) * eggShop.Atk2starsPet + int.Parse(eggShop.usedPetList[2][11]) * eggShop.Atk2starsPet;
                        GameController.pet2DefBonus = int.Parse(eggShop.usedPetList[2][6]) * eggShop.Def2starsPet + int.Parse(eggShop.usedPetList[2][12]) * eggShop.Def2starsPet;
                        GameController.pet2SpBonus = int.Parse(eggShop.usedPetList[2][7]) * eggShop.Sp2starsPet + int.Parse(eggShop.usedPetList[2][13]) * eggShop.Sp2starsPet;
                        GameController.pet2AgiBonus = int.Parse(eggShop.usedPetList[2][8]) * eggShop.Agi2starsPet + int.Parse(eggShop.usedPetList[2][14]) * eggShop.Agi2starsPet;
                        GameController.pet2HpBonus = int.Parse(eggShop.usedPetList[2][9]) * eggShop.Hp2starsPet + int.Parse(eggShop.usedPetList[2][15]) * eggShop.Hp2starsPet;
                        break;
                    case "3":
                        GameController.pet2AtkBonus = int.Parse(eggShop.usedPetList[2][5]) * eggShop.Atk3starsPet + int.Parse(eggShop.usedPetList[2][11]) * eggShop.Atk3starsPet;
                        GameController.pet2DefBonus = int.Parse(eggShop.usedPetList[2][6]) * eggShop.Def3starsPet + int.Parse(eggShop.usedPetList[2][12]) * eggShop.Def3starsPet;
                        GameController.pet2SpBonus = int.Parse(eggShop.usedPetList[2][7]) * eggShop.Sp3starsPet + int.Parse(eggShop.usedPetList[2][13]) * eggShop.Sp3starsPet;
                        GameController.pet2AgiBonus = int.Parse(eggShop.usedPetList[2][8]) * eggShop.Agi3starsPet + int.Parse(eggShop.usedPetList[2][14]) * eggShop.Agi3starsPet;
                        GameController.pet2HpBonus = int.Parse(eggShop.usedPetList[2][9]) * eggShop.Hp3starsPet + int.Parse(eggShop.usedPetList[2][15]) * eggShop.Hp3starsPet;
                        break;
                    case "4":
                        GameController.pet2AtkBonus = int.Parse(eggShop.usedPetList[2][5]) * eggShop.Atk4starsPet + int.Parse(eggShop.usedPetList[2][11]) * eggShop.Atk4starsPet;
                        GameController.pet2DefBonus = int.Parse(eggShop.usedPetList[2][6]) * eggShop.Def4starsPet + int.Parse(eggShop.usedPetList[2][12]) * eggShop.Def4starsPet;
                        GameController.pet2SpBonus = int.Parse(eggShop.usedPetList[2][7]) * eggShop.Sp4starsPet + int.Parse(eggShop.usedPetList[2][13]) * eggShop.Sp4starsPet;
                        GameController.pet2AgiBonus = int.Parse(eggShop.usedPetList[2][8]) * eggShop.Agi4starsPet + int.Parse(eggShop.usedPetList[2][14]) * eggShop.Agi4starsPet;
                        GameController.pet2HpBonus = int.Parse(eggShop.usedPetList[2][9]) * eggShop.Hp4starsPet + int.Parse(eggShop.usedPetList[2][15]) * eggShop.Hp4starsPet;
                        break;
                    case "5":
                        GameController.pet2AtkBonus = int.Parse(eggShop.usedPetList[2][5]) * eggShop.Atk5starsPet + int.Parse(eggShop.usedPetList[2][11]) * eggShop.Atk5starsPet;
                        GameController.pet2DefBonus = int.Parse(eggShop.usedPetList[2][6]) * eggShop.Def5starsPet + int.Parse(eggShop.usedPetList[2][12]) * eggShop.Def5starsPet;
                        GameController.pet2SpBonus = int.Parse(eggShop.usedPetList[2][7]) * eggShop.Sp5starsPet + int.Parse(eggShop.usedPetList[2][13]) * eggShop.Sp5starsPet;
                        GameController.pet2AgiBonus = int.Parse(eggShop.usedPetList[2][8]) * eggShop.Agi5starsPet + int.Parse(eggShop.usedPetList[2][14]) * eggShop.Agi5starsPet;
                        GameController.pet2HpBonus = int.Parse(eggShop.usedPetList[2][9]) * eggShop.Hp5starsPet + int.Parse(eggShop.usedPetList[2][15]) * eggShop.Hp5starsPet;
                        break;
                }
                switch (eggShop.usedPetList[3][4])
                {

                    case "2":
                        GameController.pet3AtkBonus = int.Parse(eggShop.usedPetList[3][5]) * eggShop.Atk2starsPet + int.Parse(eggShop.usedPetList[3][11]) * eggShop.Atk2starsPet;
                        GameController.pet3DefBonus = int.Parse(eggShop.usedPetList[3][6]) * eggShop.Def2starsPet + int.Parse(eggShop.usedPetList[3][12]) * eggShop.Def2starsPet;
                        GameController.pet3SpBonus = int.Parse(eggShop.usedPetList[3][7]) * eggShop.Sp2starsPet + int.Parse(eggShop.usedPetList[3][13]) * eggShop.Sp2starsPet;
                        GameController.pet3AgiBonus = int.Parse(eggShop.usedPetList[3][8]) * eggShop.Agi2starsPet + int.Parse(eggShop.usedPetList[3][14]) * eggShop.Agi2starsPet;
                        GameController.pet3HpBonus = int.Parse(eggShop.usedPetList[3][9]) * eggShop.Hp2starsPet + int.Parse(eggShop.usedPetList[3][15]) * eggShop.Hp2starsPet;
                        break;
                    case "3":
                        GameController.pet3AtkBonus = int.Parse(eggShop.usedPetList[3][5]) * eggShop.Atk3starsPet + int.Parse(eggShop.usedPetList[3][11]) * eggShop.Atk3starsPet;
                        GameController.pet3DefBonus = int.Parse(eggShop.usedPetList[3][6]) * eggShop.Def3starsPet + int.Parse(eggShop.usedPetList[3][12]) * eggShop.Def3starsPet;
                        GameController.pet3SpBonus = int.Parse(eggShop.usedPetList[3][7]) * eggShop.Sp3starsPet + int.Parse(eggShop.usedPetList[3][13]) * eggShop.Sp3starsPet;
                        GameController.pet3AgiBonus = int.Parse(eggShop.usedPetList[3][8]) * eggShop.Agi3starsPet + int.Parse(eggShop.usedPetList[3][14]) * eggShop.Agi3starsPet;
                        GameController.pet3HpBonus = int.Parse(eggShop.usedPetList[3][9]) * eggShop.Hp3starsPet + int.Parse(eggShop.usedPetList[3][15]) * eggShop.Hp3starsPet;

                        break;
                    case "4":
                        GameController.pet3AtkBonus = int.Parse(eggShop.usedPetList[3][5]) * eggShop.Atk4starsPet + int.Parse(eggShop.usedPetList[3][11]) * eggShop.Atk4starsPet;
                        GameController.pet3DefBonus = int.Parse(eggShop.usedPetList[3][6]) * eggShop.Def4starsPet + int.Parse(eggShop.usedPetList[3][12]) * eggShop.Def4starsPet;
                        GameController.pet3SpBonus = int.Parse(eggShop.usedPetList[3][7]) * eggShop.Sp4starsPet + int.Parse(eggShop.usedPetList[3][13]) * eggShop.Sp4starsPet;
                        GameController.pet3AgiBonus = int.Parse(eggShop.usedPetList[3][8]) * eggShop.Agi4starsPet + int.Parse(eggShop.usedPetList[3][14]) * eggShop.Agi4starsPet;
                        GameController.pet3HpBonus = int.Parse(eggShop.usedPetList[3][9]) * eggShop.Hp4starsPet + int.Parse(eggShop.usedPetList[3][15]) * eggShop.Hp4starsPet;

                        break;
                    case "5":
                        GameController.pet3AtkBonus = int.Parse(eggShop.usedPetList[3][5]) * eggShop.Atk5starsPet + int.Parse(eggShop.usedPetList[3][11]) * eggShop.Atk5starsPet;
                        GameController.pet3DefBonus = int.Parse(eggShop.usedPetList[3][6]) * eggShop.Def5starsPet + int.Parse(eggShop.usedPetList[3][12]) * eggShop.Def5starsPet;
                        GameController.pet3SpBonus = int.Parse(eggShop.usedPetList[3][7]) * eggShop.Sp5starsPet + int.Parse(eggShop.usedPetList[3][13]) * eggShop.Sp5starsPet;
                        GameController.pet3AgiBonus = int.Parse(eggShop.usedPetList[3][8]) * eggShop.Agi5starsPet + int.Parse(eggShop.usedPetList[3][14]) * eggShop.Agi5starsPet;
                        GameController.pet3HpBonus = int.Parse(eggShop.usedPetList[3][9]) * eggShop.Hp5starsPet + int.Parse(eggShop.usedPetList[3][15]) * eggShop.Hp5starsPet;
                        break;

                }
                break;
        }

        GameController.petAtkBonus = GameController.pet1AtkBonus + GameController.pet2AtkBonus + GameController.pet3AtkBonus;
        GameController.petDefBonus = GameController.pet1DefBonus + GameController.pet2DefBonus + GameController.pet3DefBonus;
        GameController.petSpBonus = GameController.pet1SpBonus + GameController.pet2SpBonus + GameController.pet3SpBonus;
        GameController.petAgiBonus = GameController.pet1AgiBonus + GameController.pet2AgiBonus + GameController.pet3AgiBonus;
        GameController.petHpBonus = GameController.pet1HpBonus + GameController.pet2HpBonus + GameController.pet3HpBonus;


        switch (PlayerMovements.currentWeapon)
        {
            case PlayerWeapon.sword:
                highlight[0].SetActive(true);
                highlight[1].SetActive(false);
                highlight[2].SetActive(false);
                highlight[3].SetActive(false);
                highlight[4].SetActive(false);
                break;
            case PlayerWeapon.bow:
                highlight[0].SetActive(false);
                highlight[1].SetActive(true);
                highlight[2].SetActive(false);
                highlight[3].SetActive(false);
                highlight[4].SetActive(false);
                break;
        }
        if (ultValue >= 10)
        {
            canUlt = true;
        }
        UltBar.SetUltValue(ultValue);
        if (ultValue >= 10)
        {
            UltText.text = "READY!";
        }
        else
        {
            UltText.text = ultValue + "/10";
        }

        switch (GameController.currentSkill)
        {
            case 0:
                skill.sprite = skills[0];
                break;
            case 1:
                skill.sprite = skills[1];
                break;
            case 2:
                skill.sprite = skills[2];
                break;
            case 3:
                skill.sprite = skills[3];
                break;
            case 4:
                skill.sprite = skills[4];
                break;

        }

        if (enterLibrary)
        {
            changeBGM(LibraryMusic, musicSource);
            changeBGS(dunMusic, audioSource);
            enterLibrary = false;
        }
        if (quitLibrary)
        {
            changeBGM(villageMusic, musicSource);
            changeBGS(villageSound, audioSource);
            quitLibrary = false;
        }
        if (enterCastle)
        {
            changeBGM(CaslteMusic, musicSource);
            changeBGS(dunMusic, audioSource);
            enterCastle = false;
        }
        if (quitCastle)
        {
            changeBGM(villageMusic, musicSource);
            changeBGS(villageSound, audioSource);
            quitCastle = false;
        }

        if (swapGemsToggle.isOn)
        {
            swapGems = true;
            PlayerPrefs.SetInt("swapGems", 1);
        }
        else
        {
            swapGems = false;
            PlayerPrefs.SetInt("swapGems", 0);
        }
        checkForCockSound();
        SetStats();
        Hp.text = PlayerMovements.health.ToString() + "/" + ((100 + Level * 10) + PlayerMovements.BonusHp + petHpBonus).ToString();
        resetForestDoors();


        if (coins < 1000000 && coins >= 1000)
        {
            value = coins / 1000;
            coinText.text = value.ToString() + "K";
            coinTextPotionShop.text = value.ToString() + "K";
        }
        else if (coins >= 1000000)
        {
            value = coins / 1000000;
            int rest = coins - 1000000 * value;
            int restInK = rest / 10000;
            if (restInK < 10)
            {
                coinText.text = value.ToString() + "." + "0" + restInK + "M";
                coinTextPotionShop.text = value.ToString() + "." + "0" + restInK + "M";
            }
            else
            {
                coinText.text = value.ToString() + "." + restInK + "M";
                coinTextPotionShop.text = value.ToString() + "." + restInK + "M";
            }
        }
        else
        {
            coinText.text = coins.ToString();
            coinTextPotionShop.text = coins.ToString();
        }

        diamondsText.text = diamonds.ToString();

        updateLevelStats();
        checkIfCanDash();
        ControlLoadingPageIfExist();

        if (openUltimate)
        {
            mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, 12, 4f * Time.deltaTime);
        }
        else
        {
            mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, 8, 4f * Time.deltaTime);
        }

        if (wantTp)
        {
            tpPanel.SetActive(true);
            int rand = Random.Range(0, 5);
            loadingSlot.sprite = mapSprite[rand];
            ArrowSpawn.canShoot = false;
        }
        if (enemyBeaten)
        {
            mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, 5, 4f * Time.deltaTime);
            var Volumes = volume.GetComponent<Volume>();
            if (Volumes.profile.TryGet<ChromaticAberration>(out var chromaticAberration))
            {
                chromaticAberration.intensity.value = 1f;
            }
            if (Volumes.profile.TryGet<LensDistortion>(out var lensDistortions))
            {
                lensDistortions.intensity.value = Mathf.Lerp(lensDistortions.intensity.value, 0.5f, 0.5f * Time.deltaTime);
            }
            StartCoroutine(backFromSlowMo());
        }

        if (ultPressed)
        {
            mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, 5, 4f * Time.deltaTime);
            if (Input.GetMouseButton(0))
            {

                PlayerMovements.animator.SetBool("ulting", false);
                ultimateSound.Play();
                ultPressed = false;
                ultDirection.SetActive(false);
                BrownUltDirection.SetActive(false);
                PinkUltDirection.SetActive(false);
                GreenUltDirection.SetActive(false);
                openUltimate = true;
                Time.timeScale = 1f;
                Time.fixedDeltaTime = 0.02f;

                switch (currentSkill)
                {
                    case 0:
                        Instantiate(ultSlash, player.transform.position, ultDirection.transform.rotation);
                        Instantiate(ultEffect, player.transform.position, ultDirection.transform.rotation);
                        Instantiate(thunder, player.transform.position, ultDirection.transform.rotation);
                        break;
                    case 1:
                        Instantiate(rock, player.transform.position, BrownUltDirection.transform.rotation);
                        Instantiate(thunder, player.transform.position, BrownUltDirection.transform.rotation);
                        break;
                    case 2:
                        Instantiate(skulls, player.transform.position, PinkUltDirection.transform.rotation);
                        break;
                    case 3:
                        //Instantiate(thunder, player.transform.position, ultDirection.transform.rotation);
                        Instantiate(Wind, player.transform.position, GreenUltDirection.transform.rotation);
                        Instantiate(WindEffect, player.transform.position, GreenUltDirection.transform.rotation);
                        break;
                    case 4:
                        skill5.spawn = true;
                        electricityAudio.Play();
                        CameraMovement.SuperLongUltShake = true;
                        StartCoroutine(stopSkill5());
                        break;
                }

            }
            StartCoroutine(backFromSlowMo());
        }
       
        if (attack3rd)
        {
            mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, 5, 4f * Time.deltaTime);

           

        }

        panel = GameObject.FindGameObjectsWithTag("panel");
        InventoryControl();
        checkCurrentMap();

        if (returnDunMusic)
        {
            changeBGM(dunMusic, musicSource);
            returnDunMusic = false;
        }
        if (returnBeachMusic)
        {
            changeBGM(dunSound, musicSource);
            returnBeachMusic = false;
        }
        if (chest.playChestAudio)
        {
            chestAudio.Play();
            chest.playChestAudio = false;
        }

        if (enemyUlt)
        {
            mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, 12, 4f * Time.deltaTime);
           
            StartCoroutine(backFromEnemyUlt());
        }
        else
        {
            mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, 8, 4f * Time.deltaTime);
        }
    
        if(cacodeamonUltEffect)
        {
            var Volumes = volume.GetComponent<Volume>();
            if (Volumes.profile.TryGet<ChromaticAberration>(out var chromaticAberration))
            {
                chromaticAberration.intensity.value = 1f;
            }
            if (Volumes.profile.TryGet<LensDistortion>(out var lensDistortions))
            {
                lensDistortions.intensity.value = Mathf.Lerp(lensDistortions.intensity.value, 0f, 0.5f * Time.deltaTime);
            }
            if (Volumes.profile.TryGet<Vignette>(out var vignette))
            {
                vignette.rounded.value = false;
                vignette.intensity.value = 0.5f;
                vignette.smoothness.value = 1f;
                vignette.center.value= new Vector2(0.5f, 0.8f);
                vignette.color.value = new Color(14f/255, 14f/255, 14f/255);
            }
        }
        else
        {
            var Volumes = volume.GetComponent<Volume>();
            if (Volumes.profile.TryGet<ChromaticAberration>(out var chromaticAberration))
            {
                chromaticAberration.intensity.value = 0f;
            }
            if (Volumes.profile.TryGet<LensDistortion>(out var lensDistortions))
            {
                lensDistortions.intensity.value = Mathf.Lerp(lensDistortions.intensity.value, 0f, 0f * Time.deltaTime);
            }
            if (Volumes.profile.TryGet<Vignette>(out var vignette))
            {
               
                vignette.intensity.value = 0f;
             
            }
        }


        if (isCacodeamonDead)
        {
            changeBGM(beachAudio, musicSource);
            boxColliderIsland.SetActive(false);
            currentMap = PlayerMap.water4;
            isCacodeamonDead = false;
        }
        
        if(oxygenAmount < 25f)
        {
            oxyAmountText.color = Color.red;
        }
        else
        {
            oxyAmountText.color = Color.white;
        }
   
    }

    IEnumerator backFromEnemyUlt()
    {
        yield return new WaitForSeconds(3f);
        enemyUlt = false;
    }

    public void resetForestDoors()
    {
        if (silverKeyDoorReset)
        {
            forestDoor1.SetActive(true);
            silverKeyDoorReset = false;
        }

        if (goldKeyDoorReset)
        {

            forestDoor3.SetActive(true);
            goldKeyDoorReset = false;
        }
    }
    public void closeInventory()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        Inventory.description = "";
        inventory.SetActive(false);
        Inv.save();
        materialInv.save();
        potionInv.save();
        GemInv.save();
        gearsInv.save();
        meatInv.save();
        PlayerMovements.invIsOpen = false;
        foreach (GameObject r in panel)
        {
            r.SetActive(false);
        }
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);

    }
    public void closeAlertButton()
    {

        alert.SetActive(false);
        showAlert = false;
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }
    public void closeKitAlertButton()
    {

        kitAlert.SetActive(false);
        showAlert = false;
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }

    public void closeTpPanel()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        tpPanel.SetActive(false);
        wantTp = false;
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }

    public void closeDun1Pnanel()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        Dun1Panel.SetActive(false);
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }

    public void closeForestBlackSmithPanel()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        BlackSmithPanel.SetActive(false);
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }

    public void closeBeachBlackSmithPanel()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        BeachBlackSmithPanel.SetActive(false);
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }

    public void closeSkillPointsPanel()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        skillPointPanel.SetActive(false);
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }

    public void closeGemCraftingPanel()
    {
        GemInv.save();
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        LapidaryLeftSide.currentgear = SelectedGear.nothing;
        GemCraftingPanel.SetActive(false);
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }
    public void closebeachGemCraftingPanel()
    {
        GemInv.save();
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        LapidaryLeftSide.currentgear = SelectedGear.nothing;
        beachGemCraftingPanel.SetActive(false);
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }

    public void closeDun2Panel()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        Dun2Panel.SetActive(false);
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }

    public void closeMiningAreaPnanel()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        MiningAreaPanel.SetActive(false);
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }

    public void closeFishPnanel()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        ForestfishPanel.SetActive(false);
        BeachFishPanel.SetActive(false);
        FishInv.save();
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }

    public void closeTreesAreaPnanel()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        TreesAreaPanel.SetActive(false);
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }

    public void closeFishingAreaPanel()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        FishingAreaPanel.SetActive(false);
        FishInv.save();
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }

    public void closeButcherPanel()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        butcherPanel.SetActive(false);
        meatInv.save();
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }

    public void closeEggPanel()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        eggPanel.SetActive(false);
        meatInv.save();
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }
    public void VillageTpButton()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        changeBGM(villageMusic, musicSource);
        changeBGS(villageSound, audioSource);
        musicSource.loop = true;
        tpPanel.SetActive(false);
        wantTp = false;
        player.transform.position = new Vector3(21.36f, 0.56f, 0f);
        try
        {
            pet = GameObject.FindGameObjectWithTag("pet");
            pet.transform.position = new Vector3(21.36f, 0.56f, 0f);
        }
        catch (System.NullReferenceException)
        {

            try
            {
                pet = GameObject.FindGameObjectWithTag("pumpkin_Pet");
                pet = GameObject.FindGameObjectWithTag("eye_Pet");
                pet = GameObject.FindGameObjectWithTag("crab_Pet");
                pet = GameObject.FindGameObjectWithTag("greenDragon_Pet");
                pet = GameObject.FindGameObjectWithTag("dog_Pet");
                pet = GameObject.FindGameObjectWithTag("snowDog_Pet");
                pet = GameObject.FindGameObjectWithTag("rock_pet");
                pet = GameObject.FindGameObjectWithTag("snake_Pet");
                pet = GameObject.FindGameObjectWithTag("worm_Pet");
                pet = GameObject.FindGameObjectWithTag("bee_Pet");
                pet = GameObject.FindGameObjectWithTag("red_dragon");
                pet.transform.position = new Vector3(21.36f, 0.56f, 0f);
            }
            catch (System.NullReferenceException)
            {

            }

        }

        currentMap = PlayerMap.Village;
        loadingPanel.SetActive(true);
        StartCoroutine(removeLoadingPanel());
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }
    public void ForrestTpButton()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        changeBGM(forestMusic, musicSource);
        if (time.hour >= 5 && time.hour <= 20)
        {
            changeBGS(forestAudio, audioSource);
        }
        else
        {
            changeBGS(forestNightAudio, audioSource);
        }

        musicSource.loop = true;
        tpPanel.SetActive(false);
        wantTp = false;
        player.transform.position = new Vector3(47.66f, 3.1f, 0f);

        try
        {
            pet = GameObject.FindGameObjectWithTag("pet");
            pet.transform.position = new Vector3(47.66f, 3.1f, 0f);
        }
        catch (System.NullReferenceException)
        {

            try
            {
                pet = GameObject.FindGameObjectWithTag("pumpkin_Pet");
                pet = GameObject.FindGameObjectWithTag("eye_Pet");
                pet = GameObject.FindGameObjectWithTag("crab_Pet");
                pet = GameObject.FindGameObjectWithTag("greenDragon_Pet");
                pet = GameObject.FindGameObjectWithTag("dog_Pet");
                pet = GameObject.FindGameObjectWithTag("snowDog_Pet");
                pet = GameObject.FindGameObjectWithTag("rock_pet");
                pet = GameObject.FindGameObjectWithTag("snake_Pet");
                pet = GameObject.FindGameObjectWithTag("worm_Pet");
                pet = GameObject.FindGameObjectWithTag("bee_Pet");
                pet = GameObject.FindGameObjectWithTag("red_dragon");
                pet.transform.position = new Vector3(47.66f, 3.1f, 0f);
            }
            catch (System.NullReferenceException)
            {

            }

        }
        currentMap = PlayerMap.forrest;
        loadingPanel.SetActive(true);
        StartCoroutine(removeLoadingPanel());
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }
    public void BeachTpButton()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        changeBGM(beachMusic, musicSource);
        changeBGS(beachAudio, audioSource);
        musicSource.loop = false;
        tpPanel.SetActive(false);
        wantTp = false;
        player.transform.position = new Vector3(68.16f, 129.6f, 0f);
        try
        {
            pet = GameObject.FindGameObjectWithTag("pet");
            pet.transform.position = new Vector3(68.16f, 129.6f, 0f);
        }
        catch (System.NullReferenceException)
        {

            try
            {
                pet = GameObject.FindGameObjectWithTag("pumpkin_Pet");
                pet = GameObject.FindGameObjectWithTag("eye_Pet");
                pet = GameObject.FindGameObjectWithTag("crab_Pet");
                pet = GameObject.FindGameObjectWithTag("greenDragon_Pet");
                pet = GameObject.FindGameObjectWithTag("dog_Pet");
                pet = GameObject.FindGameObjectWithTag("snowDog_Pet");
                pet = GameObject.FindGameObjectWithTag("rock_pet");
                pet = GameObject.FindGameObjectWithTag("snake_Pet");
                pet = GameObject.FindGameObjectWithTag("worm_Pet");
                pet = GameObject.FindGameObjectWithTag("bee_Pet");
                pet = GameObject.FindGameObjectWithTag("red_dragon");
                pet.transform.position = new Vector3(68.16f, 129.6f, 0f);
            }
            catch (System.NullReferenceException)
            {

            }

        }
        currentMap = PlayerMap.beach;
        loadingPanel.SetActive(true);
        StartCoroutine(removeLoadingPanel());
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }

    public void IceLandTpButton()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        changeBGM(iceMusic, musicSource);
        changeBGS(iceAudio, audioSource);
        musicSource.loop = false;
        tpPanel.SetActive(false);
        wantTp = false;
        player.transform.position = new Vector3(224.21f, 71.54f, 0f);
        try
        {
            pet = GameObject.FindGameObjectWithTag("pet");
            pet.transform.position = new Vector3(223.21f, 71.54f, 0f);
        }
        catch (System.NullReferenceException)
        {

            try
            {
                pet = GameObject.FindGameObjectWithTag("pumpkin_Pet");
                pet = GameObject.FindGameObjectWithTag("eye_Pet");
                pet = GameObject.FindGameObjectWithTag("crab_Pet");
                pet = GameObject.FindGameObjectWithTag("greenDragon_Pet");
                pet = GameObject.FindGameObjectWithTag("dog_Pet");
                pet = GameObject.FindGameObjectWithTag("snowDog_Pet");
                pet = GameObject.FindGameObjectWithTag("rock_pet");
                pet = GameObject.FindGameObjectWithTag("snake_Pet");
                pet = GameObject.FindGameObjectWithTag("worm_Pet");
                pet = GameObject.FindGameObjectWithTag("bee_Pet");
                pet = GameObject.FindGameObjectWithTag("red_dragon");
                pet.transform.position = new Vector3(223.21f, 71.54f, 0f);
            }
            catch (System.NullReferenceException)
            {

            }

        }
        currentMap = PlayerMap.iceland;
        loadingPanel.SetActive(true);
        StartCoroutine(removeLoadingPanel());
        cursorHotspot = new Vector2(0, -1);
        Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
    }

    public void potionShop()
    {
        PotionShopPanel.SetActive(true);
        ArrowSpawn.canShoot = false;
    }
    public void ForestBlackSmithPanel()
    {
        BlackSmithPanel.SetActive(true);
        ArrowSpawn.canShoot = false;
    }

    public void beachBlackSmithPanel()
    {
        BeachBlackSmithPanel.SetActive(true);
        ArrowSpawn.canShoot = false;
    }
    public void SkillPointsPanel()
    {
        skillPointPanel.SetActive(true);
        ArrowSpawn.canShoot = false;
    }
    public void FishPanel()
    {
        ForestfishPanel.SetActive(true);
        fishingShop.refreshInv = true;
        ArrowSpawn.canShoot = false;
    }

    public void BeachfishPanel()
    {
        BeachFishPanel.SetActive(true);
        BeachFishingShop.refreshInv = true;
        ArrowSpawn.canShoot = false;
    }

    public void ButcherPanel()
    {
        butcherPanel.SetActive(true);

        ArrowSpawn.canShoot = false;

    }

    public void EggPanel()
    {
        eggPanel.SetActive(true);

        ArrowSpawn.canShoot = false;

    }
    public void gemCraftingPanel()
    {
        GemCraftingPanel.SetActive(true);
        ArrowSpawn.canShoot = false;
    }

    public void BeachGemCraftingPanel()
    {
        beachGemCraftingPanel.SetActive(true);
        ArrowSpawn.canShoot = false;
    }

    public void closePanels()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        PotionShopPanel.SetActive(false);

    }
    public void OnLevelUp()
    {
        PlayerMovements.isLevelUp = true;
    }
    IEnumerator removeLoadingPanel()
    {
        yield return new WaitForSeconds(1f);
        loading.text = "LOADING";
        loadingPanel.SetActive(false);
        if (currentMap == PlayerMap.Village)
        {
            theVillage.SetActive(true);
            StartCoroutine(removeText());

        }
        else if (currentMap == PlayerMap.forrest)
        {
            theForrest.SetActive(true);
            StartCoroutine(removeText());
        }
        else if (currentMap == PlayerMap.beach)
        {
            theBeach.SetActive(true);
            StartCoroutine(removeText());
        }
    }
    IEnumerator removeText()
    {
        yield return new WaitForSeconds(2f);
        theVillage.SetActive(false);
        theForrest.SetActive(false);
        theBeach.SetActive(false);
    }

    IEnumerator backFromSlowMo()
    {
        yield return new WaitForSeconds(1f);
        ultDirection.SetActive(false);
        PinkUltDirection.SetActive(false);
        GreenUltDirection.SetActive(false);
        BrownUltDirection.SetActive(false);
        mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, 8, 4f * Time.deltaTime);
        Time.fixedDeltaTime = 0.02f;
        Time.timeScale = 1;
        var Volumes = volume.GetComponent<Volume>();
        if (Volumes.profile.TryGet<ChromaticAberration>(out var chromaticAberration))
        {
            chromaticAberration.intensity.value = 0f;
        }
        if (Volumes.profile.TryGet<LensDistortion>(out var lensDistortions))
        {
            lensDistortions.intensity.value = Mathf.Lerp(lensDistortions.intensity.value, 0f, 0.5f * Time.deltaTime);
        }
        if (Volumes.profile.TryGet<Vignette>(out var vignette))
        {
            vignette.rounded.value = false;
            vignette.intensity.value = 0.45f;
            vignette.smoothness.value = 0.1f;
        }
        redDot.SetActive(false);
        enemyBeaten = false;
        ultPressed = false;
        openUltimate = false;
    }

    IEnumerator stopSkill5()
    {
        yield return new WaitForSeconds(7f);
        skill5.spawn = false;
    }
    public void updateLevelStats()
    {
        lvl.text = "Lv. " + level.currentLevel;
        int currentXp = level.experience - level.GetXPforLevel(level.currentLevel);
        int xpToNextLevel = (level.GetXPforLevel(level.currentLevel + 1) - level.GetXPforLevel(level.currentLevel));
        float levelFinishPercentage = (float)currentXp / xpToNextLevel;
        xpBar.SetXp(levelFinishPercentage);
        XP.text = currentXp + "/" + xpToNextLevel + "(" + (int)(levelFinishPercentage * 100) + "%)";

    }
    public void checkIfCanDash()
    {
        dashTimer.text = ((int)currentTime).ToString();
        if (dashed)
        {
            dashUi.SetActive(true);
            if (currentTime <= 0)
            {
                currentTime = startTime;
                dashUi.GetComponent<Image>().fillAmount = 1f;
                dashUi.SetActive(false);
                PlayerMovements.canDash = true;
                dashed = false;
            }
            else
            {
                PlayerMovements.canDash = false;
                dashUi.GetComponent<Image>().fillAmount -= 0.33f * Time.deltaTime;
                currentTime -= Time.deltaTime;
            }

        }
        if (PlayerMovements.isDashButtonDown)
        {
            dashUi.SetActive(true);

        }

    }
    public void ControlLoadingPageIfExist()
    {
        if (loadingPanel.activeSelf)
        {
            if (TimeBtwLoading <= 0)
            {
                loading.text = loading.text + ".";
                TimeBtwLoading = startLoadingTime;
            }
            else
            {
                TimeBtwLoading -= Time.deltaTime;
            }
        }

    }
    public void InventoryControl()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {

            ArrowSpawn.canShoot = false;
            inventory.SetActive(true);
            Inv.load();
            PlayerMovements.invIsOpen = true;
        }
        if (PlayerMovements.invIsOpen == false)
        {
            inventory.SetActive(false);
        }
        if (showAlert)
        {
            alert.SetActive(true);
        }
    }
    public void checkCurrentMap()
    {
        if (currentMap == PlayerMap.forrest)
        {

            CameraMovement.maxPosition = new Vector2(235.72f, 20.77f);
            CameraMovement.minPosition = new Vector2(58.54f, -1.37f);

            if (TimeBtwLeafSpawn <= 0)
            {
                int rand = Random.Range(0, 27);

                Instantiate(leaf, leafSpawner[rand].transform.position, Quaternion.identity);
                TimeBtwLeafSpawn = StartTime;
            }
            else
            {
                TimeBtwLeafSpawn -= Time.deltaTime;
            }

        }

        if (currentMap == PlayerMap.forrestDungeon)
        {

            CameraMovement.maxPosition = new Vector2(100f, 45.61f);
            CameraMovement.minPosition = new Vector2(0f, 21.55f);
        }
        else if (currentMap == PlayerMap.forrestDungeon2)
        {
            CameraMovement.maxPosition = new Vector2(200f, 66.66f);
            CameraMovement.minPosition = new Vector2(0f, 59.27f);
        }
        else if (currentMap == PlayerMap.forrestDungeon3 && !enemyBeaten)
        {
            CameraMovement.maxPosition = new Vector2(200f, 80.28f);
            CameraMovement.minPosition = new Vector2(0f, 80.21f);
        }
        else if (currentMap == PlayerMap.forrestDungeon3 && enemyBeaten)
        {
            CameraMovement.maxPosition = new Vector2(200f, 76.77f);
            CameraMovement.minPosition = new Vector2(0f, 76.76f);
        }
        else if (currentMap == PlayerMap.forrestMiningArea)
        {
            CameraMovement.maxPosition = new Vector2(177f, -26.3f);
            CameraMovement.minPosition = new Vector2(114.9f, -30.88f);
        }

        else if (currentMap == PlayerMap.forrestTreesArea)
        {
            CameraMovement.maxPosition = new Vector2(224.29f, 44.32f);
            CameraMovement.minPosition = new Vector2(198.64f, 35.36f);
        }

        else if (currentMap == PlayerMap.Village)
        {
            CameraMovement.maxPosition = new Vector2(10.79f, 2.2f);
            CameraMovement.minPosition = new Vector2(-48.68f, -0.12f);


        }
        else if (currentMap == PlayerMap.Village1)
        {
            CameraMovement.minPosition = new Vector2(-37.68f, 21.51f);
            CameraMovement.maxPosition = new Vector2(-18.38f, 64f);


        }
        else if (currentMap == PlayerMap.forrestDungeon2nd)
        {
            CameraMovement.maxPosition = new Vector2(167.38f, 55.65f);
            CameraMovement.minPosition = new Vector2(140f, 55.41f);
        }
        else if (currentMap == PlayerMap.forrestDungeon2nd1)
        {
            CameraMovement.maxPosition = new Vector2(185.2f, 83.59f);
            CameraMovement.minPosition = new Vector2(124.02f, 69.05f);
        }
        else if (currentMap == PlayerMap.forrestDungeon2nd2)
        {
            CameraMovement.maxPosition = new Vector2(167.38f, 97.28f);
            CameraMovement.minPosition = new Vector2(143.54f, 97.02f);
        }
        else if (currentMap == PlayerMap.beach)
        {
            PlayerMovements.spawnDivingGear = false;
            oxygenBarUi.SetActive(false);
            oxygenAmount = 100f;
            CameraMovement.minPosition = new Vector2(78.23f, 100f);
            CameraMovement.maxPosition = new Vector2(175.6f, 160f);

            if (TimeBtwCrows <= 0)
            {
                int rand = Random.Range(0, 6);
                Instantiate(crow, crowSpawner[rand].transform.position, Quaternion.identity);
                TimeBtwCrows = startCrowTime;
            }
            else
            {
                TimeBtwCrows -= Time.deltaTime;
            }
        }
        else if (currentMap == PlayerMap.beachDun)
        {
            CameraMovement.minPosition = new Vector2(94f, 172.13f);
            CameraMovement.maxPosition = new Vector2(117.22f, 172.46f);
        }
        else if (currentMap == PlayerMap.beachDun1)
        {
            CameraMovement.minPosition = new Vector2(96.55f, 178.81f);
            CameraMovement.maxPosition = new Vector2(97.38f, 184.59f);
        }
        else if (currentMap == PlayerMap.beachDun2)
        {
            CameraMovement.minPosition = new Vector2(76f, 197.07f);
            CameraMovement.maxPosition = new Vector2(99f, 198.57f);
        }
        else if (currentMap == PlayerMap.beachDun3)
        {
            CameraMovement.minPosition = new Vector2(75.63f, 211.02f);
            CameraMovement.maxPosition = new Vector2(118.17f, 225.61f);
        }
        else if (currentMap == PlayerMap.beachDun4)
        {
            CameraMovement.minPosition = new Vector2(73.44f, 239f);
            CameraMovement.maxPosition = new Vector2(97.34f, 240.53f);


        }
        else if (currentMap == PlayerMap.Library)
        {
            CameraMovement.minPosition = new Vector2(-60.58f, -26.29f);
            CameraMovement.maxPosition = new Vector2(-25.45f, -20.38f);


        }
        else if (currentMap == PlayerMap.castle1)
        {
            CameraMovement.minPosition = new Vector2(-29.7f, 80.01f);
            CameraMovement.maxPosition = new Vector2(-24.26f, 92.89f);
        }
        else if (currentMap == PlayerMap.shipOutside)
        {
            CameraMovement.minPosition = new Vector2(169f, 176f);
            CameraMovement.maxPosition = new Vector2(187.12f, 178f);

            if (TimeBtwCrows <= 0)
            {
                int rand = Random.Range(0, 6);
                Instantiate(crow, crowSpawner[rand].transform.position, Quaternion.identity);
                TimeBtwCrows = startCrowTime;
            }
            else
            {
                TimeBtwCrows -= Time.deltaTime;
            }
        }
        else if (currentMap == PlayerMap.ship1)
        {
            CameraMovement.minPosition = new Vector2(206f, 194.85f);
            CameraMovement.maxPosition = new Vector2(213.7f, 195.04f);
        }
        else if (currentMap == PlayerMap.ship2)
        {
            CameraMovement.minPosition = new Vector2(206.31f, 213.76f);
            CameraMovement.maxPosition = new Vector2(213.7f, 214.13f);
        }
        else if (currentMap == PlayerMap.water1)
        {
            oxygenBarUi.SetActive(true);
            CameraMovement.minPosition = new Vector2(213.37f, 234.14f);
            CameraMovement.maxPosition = new Vector2(223.59f, 241.92f);
            PlayerMovements.spawnDivingGear = true;
            if (TimeBtwBubbleSpawn <= 0)
            {
                int rand = Random.Range(0, 30);
                int rand1 = Random.Range(0,5);

                Instantiate(bubble[rand1], bubbleSpawner[rand].transform.position, Quaternion.identity);
                TimeBtwBubbleSpawn = StartTime;
            }

            else
            {
                TimeBtwBubbleSpawn -= Time.deltaTime;
            }

            if (oxygenAmount > 0)
            {
                oxygenAmount -= Time.deltaTime;
                OxygenBar.SetOxyValue(oxygenAmount);
                oxyAmountText.text = ((int)oxygenAmount).ToString();
            }
            else
            {
                Debug.Log("dead");
            }

        }else if(currentMap == PlayerMap.water2)
        {
            CameraMovement.minPosition = new Vector2(217.65f, 262.86f);
            CameraMovement.maxPosition = new Vector2(236.55f, 274.42f);
            if (TimeBtwBubbleSpawn <= 0)
            {
                int rand = Random.Range(0, 30);
                int rand1 = Random.Range(0, 5);

                Instantiate(bubble[rand1], bubbleSpawner[rand].transform.position, Quaternion.identity);
                TimeBtwBubbleSpawn = StartTime;
            }
            else
            {
                TimeBtwBubbleSpawn -= Time.deltaTime;
            }

            if (oxygenAmount > 0)
            {
                oxygenAmount -= Time.deltaTime;
                OxygenBar.SetOxyValue(oxygenAmount);
                oxyAmountText.text = ((int)oxygenAmount).ToString();
            }
            else
            {
                Debug.Log("dead");
            }

        }
        else if (currentMap == PlayerMap.water3)
        {
            CameraMovement.minPosition = new Vector2(217.29f, 297.04f);
            CameraMovement.maxPosition = new Vector2(225.56f, 299.92f);
            oxygenBarUi.SetActive(false);
            oxygenAmount = 100f;
        }
        else if (currentMap == PlayerMap.water4)
        {
            CameraMovement.minPosition = new Vector2(217.29f, 278.61f);
            CameraMovement.maxPosition = new Vector2(271.54f, 299.92f);
        }
        else if (currentMap == PlayerMap.water5)
        {
            PlayerMovements.spawnDivingGear = true;
            oxygenBarUi.SetActive(true);
            CameraMovement.minPosition = new Vector2(275.28f, 250.78f);
            CameraMovement.maxPosition = new Vector2(276.67f, 258.9f);
            if (TimeBtwBubbleSpawn <= 0)
            {
                int rand = Random.Range(0, 30);
                int rand1 = Random.Range(0, 5);

                Instantiate(bubble[rand1], bubbleSpawner[rand].transform.position, Quaternion.identity);
                TimeBtwBubbleSpawn = StartTime;
            }
            else
            {
                TimeBtwBubbleSpawn -= Time.deltaTime;
            }
            if (oxygenAmount > 0)
            {
                oxygenAmount -= Time.deltaTime;
                OxygenBar.SetOxyValue(oxygenAmount);
                oxyAmountText.text = ((int)oxygenAmount).ToString();
            }
            else
            {
                Debug.Log("dead");
            }

        }
        else if (currentMap == PlayerMap.iceland)
        {
            CameraMovement.minPosition = new Vector2(235.27f, 65.49f);
            CameraMovement.maxPosition = new Vector2(289.68f, 84.95f);
        }


    }
    public static void changeBGS(AudioClip music, AudioSource source)
    {
        source.Stop();
        source.clip = music;
        source.Play();

    }
    public static void changeBGM(AudioClip music, AudioSource source)
    {
        source.Stop();
        source.clip = music;
        source.Play();

    }
    public void SetStats()
    {
        attackValue.text = PlayerMovements.attack.ToString();
        defValue.text = PlayerMovements.defence.ToString();
        agilityValue.text = PlayerMovements.agility.ToString();
        SpValue.text = PlayerMovements.Sp.ToString();
        HpValue.text = PlayerMovements.hp.ToString();

        attackBonus.text = "+(" + (PlayerMovements.BonusAttack + petAtkBonus).ToString() + ")";
        defBonus.text = "+(" + (PlayerMovements.BonusDefence + petDefBonus).ToString() + ")";
        agilityBonus.text = "+(" + (PlayerMovements.BonusAgility + petAgiBonus).ToString() + ")";
        SpBonus.text = "+(" + (PlayerMovements.BonusSp + petSpBonus).ToString() + ")";
        HpBonus.text = "+(" + (PlayerMovements.BonusHp + petHpBonus).ToString() + ")";

        BattlePower = (int)(PlayerMovements.attack * 4 + PlayerMovements.defence / 2 + PlayerMovements.agility / 2 + PlayerMovements.hp / 2 + PlayerMovements.Sp * 2);
        battlePowerText.text = BattlePower.ToString() + " BP.";

        if (PlayerPrefs.GetInt("BattlePower") != (int)GameController.BattlePower && !gearExist)
        {
            equipAudio.Play();
            gainedBpText.GainedValue = (int)GameController.BattlePower - PlayerPrefs.GetInt("BattlePower");

            try
            {
                var gainedTxt = Instantiate(gainedBp, new Vector3(-194.8f, 30f, 0f), Quaternion.identity) as GameObject;
                gainedTxt.transform.SetParent(GameObject.FindGameObjectWithTag("inventory").transform, false);
                gainedTxt.transform.localScale = new Vector3(0.75f, 0.75f, 1f);
            }
            catch (NullReferenceException e)
            {
                try
                {
                    var gainedTxt = Instantiate(gainedBp, new Vector3(-2.838074f, 8.945099f, 0f), Quaternion.identity) as GameObject;
                    gainedTxt.transform.SetParent(GameObject.FindGameObjectWithTag("lapidary").transform, false);
                    gainedTxt.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
                    Debug.Log(e);
                }
                catch (NullReferenceException e1)
                {
                    try
                    {
                        if (statsPanel.activeSelf)
                        {
                            var gainedTxt = Instantiate(gainedBp, new Vector3(70f, -26f, 0f), Quaternion.identity) as GameObject;
                            gainedTxt.transform.SetParent(GameObject.FindGameObjectWithTag("eggShop").transform, false);
                            gainedTxt.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
                            Debug.Log(e1);
                        }
                        else
                        {
                            var gainedTxt = Instantiate(gainedBp, new Vector3(-120f, 0f, 0f), Quaternion.identity) as GameObject;
                            gainedTxt.transform.SetParent(GameObject.FindGameObjectWithTag("eggShop").transform, false);
                            gainedTxt.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
                            Debug.Log(e1);
                        }

                    }
                    catch (NullReferenceException e2)
                    {
                        Debug.Log(e2);
                    }
                }
            }
            PlayerPrefs.SetInt("BattlePower", (int)GameController.BattlePower);

        }
        else if (PlayerPrefs.GetInt("BattlePower") != (int)GameController.BattlePower && gearExist)
        {
            equipAudio.Play();
            gearExist = false;
        }

    }
    IEnumerator removeCock()
    {
        yield return new WaitForSeconds(2f);
        cockAudio.SetActive(false);
    }
    public void checkForCockSound()
    {
        if (time.hour == 6)
        {
            cockAudio.SetActive(true);
            StartCoroutine(removeCock());
        }
    }

 

}
