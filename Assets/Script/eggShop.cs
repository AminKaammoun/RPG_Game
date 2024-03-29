using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class eggShop : MonoBehaviour
{
    /* egg add to dic
     * 0 : name / 1 : level / 2 : xp / 3 : MaxXpNeeded / 4 : stars / 5 : BaseAtk / 6 : BaseDef / 7 : BaseSp / 8 : BaseAgi / 9 : BaseHp / 10: stats points /11 : BonusAtk / 12 : BonusDef / 13 : BonusSp / 14 : BonusAgi / 15 : BonusHp / 16 : Element
    */
    // 0 - fire / 1 - ice / 2 - earth / 3- lighting / 4 - forest / 5 - night
    //egg
    public GameObject effect;
    public GameObject slot;
    public GameObject slot2;
    public GameObject slot3;
    public Animator egg1SwitchAnim;
    public Animator egg2SwitchAnim;
    public Animator egg3SwitchAnim;

    public GameObject[] useButton;
    public GameObject[] feedButton;
    public GameObject[] birthButton;

    public InventoryObject inventory;
    public InventoryObject meatInventory;
    public ItemObject RedEgg;
    public ItemObject BlueEgg;
    public ItemObject YellowEgg;
    public ItemObject BlackEgg;
    public ItemObject GreenEgg;
    public ItemObject BrownEgg;
    public ItemObject RedDragonEgg;
    public ItemObject eggs;
    public ItemObject meat;

    public static ItemObject[] usedEggs = new ItemObject[3];
    public static int[] eggType = new int[3];

    public Image[] eggImage = new Image[3];
    public Sprite empty;
    public Sprite[] eggSprite = new Sprite[6];

    public static int[] nestLevel = new int[3];

    public GameObject[] counter = new GameObject[3];

    public Text nest1LevelText;
    public Text nest2LevelText;
    public Text nest3LevelText;
    public Text[] CounterText;

    public static int eggsNumber;
    public static int[] requiredEggs = new int[3];

    public GameObject eggsPanel;
    public GameObject petsPanel;
    public GameObject statPanel;
    public GameObject birthPanel;

    public GameObject[] eggUI;

    public AudioSource clickSound;
    public AudioSource upgradeSound;
    public AudioSource eggCrackSound;
    public AudioSource eggOpen;

    public Sprite[] Pets;
    public Sprite grownWorm;
    public Image animalSpawnPos;
    public static int index = 1;


    //pet

    public Text petName;
    public Text petLevel;
    public Image petImage;
    public Text petCount;
    public Text FoodXpCounter;
    public Text meatNumberText;

    bool check = false;

    public GameObject foodLevels;
    public GameObject feedUIButton;
    public GameObject equipUIButton;
    public GameObject unequipUIButton;

    public foodBar FoodBar;
    public GameObject[] animals = new GameObject[30];

    public GameObject player;
    public GameObject levelUpEffect;
    public GameObject statsPanel;
    public GameObject grade2Stars;
    public GameObject grade3Stars;
    public GameObject grade4Stars;
    public GameObject grade5Stars;

    public AudioSource levelUpSound;
    public AudioSource eatSound;

    private int meatNumber;

    public Text BaseAtkText;
    public Text BaseDefText;
    public Text BaseSpText;
    public Text BaseAgiText;
    public Text BaseHpText;
    public Text points;

    public Text BonusAtkText;
    public Text BonusDefText;
    public Text BonusSpText;
    public Text BonusAgiText;
    public Text BonusHpText;

    public GameObject BonusAtk;
    public GameObject BonusDef;
    public GameObject BonusSp;
    public GameObject BonusAgi;
    public GameObject BonusHp;

    public AtkBar atkbar;
    public DefBar defbar;
    public SpBar spbar;
    public AgiBar agibar;
    public hpBar Hpbar;

    public GameObject petPanelEffect;
    public TextMeshProUGUI PetBattlePowerText;
    private int BattlePower;
    public GameObject bp;
    public GameObject usedMeatText;
    public GameObject Smoke;
    public Sprite[] elements;
    public Image elementSlot;

    public AudioSource usePetAudio;

    // stats 

    public Image[] petsImage;
    public static Dictionary<int, string[]> usedPetList = new Dictionary<int, string[]>();
    public static Dictionary<int, string[]> savedUsedPetList = new Dictionary<int, string[]>();
    public static int usedPetListIndex = 0;
    public Image[] usedPetsImage;
    public GameObject[] useButtons;

    public static int Atk2starsPet = 5;
    public static int Atk3starsPet = 7;
    public static int Atk4starsPet = 10;
    public static int Atk5starsPet = 20;

    public static int Def2starsPet = 5;
    public static int Def3starsPet = 7;
    public static int Def4starsPet = 10;
    public static int Def5starsPet = 20;

    public static int Sp2starsPet = 3;
    public static int Sp3starsPet = 5;
    public static int Sp4starsPet = 7;
    public static int Sp5starsPet = 10;

    public static int Agi2starsPet = 3;
    public static int Agi3starsPet = 5;
    public static int Agi4starsPet = 7;
    public static int Agi5starsPet = 10;

    public static int Hp2starsPet = 10;
    public static int Hp3starsPet = 15;
    public static int Hp4starsPet = 20;
    public static int Hp5starsPet = 30;

    public Text petAtkBonusText;
    public Text petDefBonusText;
    public Text petAgiBonusText;
    public Text petSpBonusText;
    public Text petHpBonusText;

    public GameObject[] removeButton;
    public GameObject[] effects;
    public GameObject[] staticEffects;
    public GameObject alert1;
    public GameObject notEnoughText;
    public GameObject notEnoughEggsText;
    public GameObject notEnoughRawMeatText;
    public GameObject alert;

    public int petListIndex;
    private bool firstTime = true;


    //book

    public GameObject book;
    public GameObject animalPanel;
    public GameObject[] page;
    private int BookIndex = 0;
    public AudioSource flipSound;

    public GameObject[] locked;
    void Start()
    {
        //savedUsedPetList.Clear();
        //usedPetList.Clear();
        //GameController.petList.Clear();
        //pets

        locked[0].SetActive(true);
        locked[1].SetActive(true);
        locked[2].SetActive(true);
        locked[3].SetActive(true);
        locked[4].SetActive(true);
        locked[5].SetActive(true);
        locked[6].SetActive(true);
        locked[7].SetActive(true);
        locked[8].SetActive(true);
        locked[9].SetActive(true);
        locked[10].SetActive(true);

        for (int i = 1; i <= GameController.petList.Count; i++)
        {
            switch (GameController.petList[i][0])
            {
                case "Jack-O-Lantern":
                    locked[7].SetActive(false);
                    break;
                case "Claws":
                    locked[0].SetActive(false);
                    break;
                case "Golem":
                    locked[6].SetActive(false);
                    break;
                case "Snow Wolf":
                    locked[3].SetActive(false);
                    break;
                case "Buzz":
                    locked[1].SetActive(false);
                    break;
                case "Night Wolf":
                    locked[4].SetActive(false);
                    break;
                case "Rumryss":
                    locked[2].SetActive(false);
                    break;
                case "Wyvernldle":
                    locked[8].SetActive(false);
                    break;
                case "Dread Biter":
                    locked[9].SetActive(false);
                    break;
                case "One Eye":
                    locked[5].SetActive(false);
                    break;
                case "red dragon":
                    locked[10].SetActive(false);
                    break;

            }
        }


        page[0].SetActive(true);
        page[1].SetActive(true);
        page[2].SetActive(false);
        page[3].SetActive(true);
        page[4].SetActive(false);
        page[5].SetActive(true);
        page[6].SetActive(false);
        page[7].SetActive(true);
        page[8].SetActive(false);
        page[9].SetActive(true);
        page[10].SetActive(false);
        page[11].SetActive(true);

        FoodBar.SetMaxFood(int.Parse(GameController.petList[index][3]));
        FoodBar.SetFood(int.Parse(GameController.petList[index][2]));

        if (GameController.petList.Count > 0)
        {
            for (int i = 1; i <= GameController.petList.Count; i++)
            {
                useButtons[i - 1].SetActive(true);
                switch (GameController.petList[i][0])
                {
                    case "Jack-O-Lantern":
                        petsImage[i - 1].sprite = Pets[0];
                        break;
                    case "Claws":
                        petsImage[i - 1].sprite = Pets[1];
                        break;
                    case "Golem":
                        petsImage[i - 1].sprite = Pets[2];
                        break;
                    case "Snow Wolf":
                        petsImage[i - 1].sprite = Pets[3];
                        break;
                    case "Buzz":
                        petsImage[i - 1].sprite = Pets[4];
                        break;
                    case "Night Wolf":
                        petsImage[i - 1].sprite = Pets[5];
                        break;
                    case "Rumryss":
                        petsImage[i - 1].sprite = Pets[6];
                        break;
                    case "Wyvernldle":
                        petsImage[i - 1].sprite = Pets[7];
                        break;
                    case "Dread Biter":
                        petsImage[i - 1].sprite = Pets[8];
                        break;
                    case "One Eye":
                        petsImage[i - 1].sprite = Pets[9];
                        break;
                    case "red dragon":
                        petsImage[i - 1].sprite = Pets[10];
                        break;

                }
            }
        }

        if (savedUsedPetList[1][0] != null && savedUsedPetList[2][0] == null && savedUsedPetList[3][0] == null)
        {
            if (usedPetList[1][0] == "Jack-O-Lantern")
            {
                usedPetsImage[0].sprite = Pets[0];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Claws")
            {
                usedPetsImage[0].sprite = Pets[1];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Golem")
            {
                usedPetsImage[0].sprite = Pets[2];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Snow Wolf")
            {
                usedPetsImage[0].sprite = Pets[3];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Buzz")
            {
                usedPetsImage[0].sprite = Pets[4];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Night Wolf")
            {
                usedPetsImage[0].sprite = Pets[5];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Rumryss")
            {
                usedPetsImage[0].sprite = Pets[6];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Wyvernldle")
            {
                usedPetsImage[0].sprite = Pets[7];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Dread Biter")
            {
                usedPetsImage[0].sprite = Pets[8];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "One Eye")
            {
                usedPetsImage[0].sprite = Pets[9];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "red dragon")
            {
                usedPetsImage[0].sprite = Pets[10];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
        }
        else if (savedUsedPetList[1][0] != null && savedUsedPetList[2][0] != null && savedUsedPetList[3][0] == null)
        {


            if (usedPetList[1][0] == "Jack-O-Lantern")
            {
                usedPetsImage[0].sprite = Pets[0];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Claws")
            {
                usedPetsImage[0].sprite = Pets[1];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Golem")
            {
                usedPetsImage[0].sprite = Pets[2];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Snow Wolf")
            {
                usedPetsImage[0].sprite = Pets[3];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Buzz")
            {
                usedPetsImage[0].sprite = Pets[4];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Night Wolf")
            {
                usedPetsImage[0].sprite = Pets[5];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Rumryss")
            {
                usedPetsImage[0].sprite = Pets[6];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Wyvernldle")
            {
                usedPetsImage[0].sprite = Pets[7];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Dread Biter")
            {
                usedPetsImage[0].sprite = Pets[8];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "One Eye")
            {
                usedPetsImage[0].sprite = Pets[9];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "red dragon")
            {
                usedPetsImage[0].sprite = Pets[10];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            if (usedPetList[2][0] == "Jack-O-Lantern")
            {
                usedPetsImage[1].sprite = Pets[0];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Claws")
            {
                usedPetsImage[1].sprite = Pets[1];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Golem")
            {
                usedPetsImage[1].sprite = Pets[2];
                removeButton[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Snow Wolf")
            {
                usedPetsImage[1].sprite = Pets[3];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Buzz")
            {
                usedPetsImage[1].sprite = Pets[4];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Night Wolf")
            {
                usedPetsImage[1].sprite = Pets[5];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Rumryss")
            {
                usedPetsImage[1].sprite = Pets[6];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Wyvernldle")
            {
                usedPetsImage[1].sprite = Pets[7];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Dread Biter")
            {
                usedPetsImage[1].sprite = Pets[8];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "One Eye")
            {
                usedPetsImage[1].sprite = Pets[9];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "red dragon")
            {
                usedPetsImage[1].sprite = Pets[10];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
        }
        else if (savedUsedPetList[1][0] != null && savedUsedPetList[2][0] != null && savedUsedPetList[3][0] != null)
        {

            if (usedPetList[1][0] == "Jack-O-Lantern")
            {
                usedPetsImage[0].sprite = Pets[0];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Claws")
            {
                usedPetsImage[0].sprite = Pets[1];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Golem")
            {
                usedPetsImage[0].sprite = Pets[2];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Snow Wolf")
            {
                usedPetsImage[0].sprite = Pets[3];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Buzz")
            {
                usedPetsImage[0].sprite = Pets[4];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Night Wolf")
            {
                usedPetsImage[0].sprite = Pets[5];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Rumryss")
            {
                usedPetsImage[0].sprite = Pets[6];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Wyvernldle")
            {
                usedPetsImage[0].sprite = Pets[7];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "Dread Biter")
            {
                usedPetsImage[0].sprite = Pets[8];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "One Eye")
            {
                usedPetsImage[0].sprite = Pets[9];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            else if (usedPetList[1][0] == "red dragon")
            {
                usedPetsImage[0].sprite = Pets[10];
                removeButton[0].SetActive(true);
                staticEffects[0].SetActive(false);
                effects[0].SetActive(true);
            }
            if (usedPetList[2][0] == "Jack-O-Lantern")
            {
                usedPetsImage[1].sprite = Pets[0];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Claws")
            {
                usedPetsImage[1].sprite = Pets[1];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Golem")
            {
                usedPetsImage[1].sprite = Pets[2];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Snow Wolf")
            {
                usedPetsImage[1].sprite = Pets[3];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Buzz")
            {
                usedPetsImage[1].sprite = Pets[4];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Night Wolf")
            {
                usedPetsImage[1].sprite = Pets[5];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Rumryss")
            {
                usedPetsImage[1].sprite = Pets[6];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Wyvernldle")
            {
                usedPetsImage[1].sprite = Pets[7];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "Dread Biter")
            {
                usedPetsImage[1].sprite = Pets[8];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "One Eye")
            {
                usedPetsImage[1].sprite = Pets[9];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            else if (usedPetList[2][0] == "red dragon")
            {
                usedPetsImage[1].sprite = Pets[10];
                removeButton[1].SetActive(true);
                staticEffects[1].SetActive(false);
                effects[1].SetActive(true);
            }
            if (usedPetList[3][0] == "Jack-O-Lantern")
            {
                usedPetsImage[2].sprite = Pets[0];
                removeButton[2].SetActive(true);
                staticEffects[2].SetActive(false);
                effects[2].SetActive(true);
            }
            else if (usedPetList[3][0] == "Claws")
            {
                usedPetsImage[2].sprite = Pets[1];
                removeButton[2].SetActive(true);
                staticEffects[2].SetActive(false);
                effects[2].SetActive(true);
            }
            else if (usedPetList[3][0] == "Golem")
            {
                usedPetsImage[2].sprite = Pets[2];
                removeButton[2].SetActive(true);
                staticEffects[2].SetActive(false);
                effects[2].SetActive(true);
            }
            else if (usedPetList[3][0] == "Snow Wolf")
            {
                usedPetsImage[2].sprite = Pets[3];
                removeButton[2].SetActive(true);
                staticEffects[2].SetActive(false);
                effects[2].SetActive(true);
            }
            else if (usedPetList[3][0] == "Buzz")
            {
                usedPetsImage[2].sprite = Pets[4];
                removeButton[2].SetActive(true);
                staticEffects[2].SetActive(false);
                effects[2].SetActive(true);
            }
            else if (usedPetList[3][0] == "Night Wolf")
            {
                usedPetsImage[2].sprite = Pets[5];
                removeButton[2].SetActive(true);
                staticEffects[2].SetActive(false);
                effects[2].SetActive(true);
            }
            else if (usedPetList[3][0] == "Rumryss")
            {
                usedPetsImage[2].sprite = Pets[6];
                removeButton[2].SetActive(true);
                staticEffects[2].SetActive(false);
                effects[2].SetActive(true);
            }
            else if (usedPetList[3][0] == "Wyvernldle")
            {
                usedPetsImage[2].sprite = Pets[7];
                removeButton[2].SetActive(true);
                staticEffects[2].SetActive(false);
                effects[2].SetActive(true);
            }
            else if (usedPetList[3][0] == "Dread Biter")
            {
                usedPetsImage[2].sprite = Pets[8];
                removeButton[2].SetActive(true);
                staticEffects[2].SetActive(false);
                effects[2].SetActive(true);
            }
            else if (usedPetList[3][0] == "One Eye")
            {
                usedPetsImage[2].sprite = Pets[9];
                removeButton[2].SetActive(true);
                staticEffects[2].SetActive(false);
                effects[2].SetActive(true);
            }
            else if (usedPetList[3][0] == "red dragon")
            {
                usedPetsImage[2].sprite = Pets[10];
                removeButton[2].SetActive(true);
                staticEffects[2].SetActive(false);
                effects[2].SetActive(true);
            }
        }


        // Nest 1
        if (eggType[0] == 1)
        {
            eggImage[0].sprite = eggSprite[0];
            counter[0].SetActive(true);
            usedEggs[0] = RedEgg;
            if (nestLevel[0] >= 5)
            {
                birthButton[0].SetActive(true);
                feedButton[0].SetActive(false);
            }
            else
            {
                feedButton[0].SetActive(true);
                birthButton[0].SetActive(false);
            }

        }
        else if (eggType[0] == 2)
        {
            eggImage[0].sprite = eggSprite[1];
            counter[0].SetActive(true);
            usedEggs[0] = BlueEgg;
            if (nestLevel[0] >= 5)
            {
                birthButton[0].SetActive(true);
                feedButton[0].SetActive(false);
            }
            else
            {
                feedButton[0].SetActive(true);
                birthButton[0].SetActive(false);
            }
        }
        else if (eggType[0] == 3)
        {
            eggImage[0].sprite = eggSprite[2];
            counter[0].SetActive(true);
            usedEggs[0] = YellowEgg;
            if (nestLevel[0] >= 5)
            {
                birthButton[0].SetActive(true);
                feedButton[0].SetActive(false);
            }
            else
            {
                feedButton[0].SetActive(true);
                birthButton[0].SetActive(false);
            }
        }
        else if (eggType[0] == 4)
        {
            eggImage[0].sprite = eggSprite[3];
            counter[0].SetActive(true);
            usedEggs[0] = BlackEgg;
            if (nestLevel[0] >= 5)
            {
                birthButton[0].SetActive(true);
                feedButton[0].SetActive(false);
            }
            else
            {
                feedButton[0].SetActive(true);
                birthButton[0].SetActive(false);
            }
        }
        else if (eggType[0] == 5)
        {
            eggImage[0].sprite = eggSprite[4];
            counter[0].SetActive(true);
            usedEggs[0] = GreenEgg;
            if (nestLevel[0] >= 5)
            {
                birthButton[0].SetActive(true);
                feedButton[0].SetActive(false);
            }
            else
            {
                feedButton[0].SetActive(true);
                birthButton[0].SetActive(false);
            }
        }
        else if (eggType[0] == 6)
        {
            eggImage[0].sprite = eggSprite[5];
            counter[0].SetActive(true);
            usedEggs[0] = BrownEgg;
            if (nestLevel[0] >= 5)
            {
                birthButton[0].SetActive(true);
                feedButton[0].SetActive(false);
            }
            else
            {
                feedButton[0].SetActive(true);
                birthButton[0].SetActive(false);
            }
        }
        else if (eggType[0] == 7)
        {
            eggImage[0].sprite = eggSprite[6];
            counter[0].SetActive(true);
            usedEggs[0] = BrownEgg;
            if (nestLevel[0] >= 5)
            {
                birthButton[0].SetActive(true);
                feedButton[0].SetActive(false);
            }
            else
            {
                feedButton[0].SetActive(true);
                birthButton[0].SetActive(false);
            }
        }
        else
        {
            eggImage[0].sprite = empty;
            counter[0].SetActive(false);
            birthButton[0].SetActive(false);
            feedButton[0].SetActive(false);
        }

        //Nest 2
        if (eggType[1] == 1)
        {
            eggImage[1].sprite = eggSprite[0];
            counter[1].SetActive(true);
            usedEggs[1] = RedEgg;
            if (nestLevel[1] >= 5)
            {
                birthButton[1].SetActive(true);
                feedButton[1].SetActive(false);
            }
            else
            {
                feedButton[1].SetActive(true);
                birthButton[1].SetActive(false);
            }
        }
        else if (eggType[1] == 2)
        {
            eggImage[1].sprite = eggSprite[1];
            counter[1].SetActive(true);
            usedEggs[1] = BlueEgg;
            if (nestLevel[1] >= 5)
            {
                birthButton[1].SetActive(true);
                feedButton[1].SetActive(false);
            }
            else
            {
                feedButton[1].SetActive(true);
                birthButton[1].SetActive(false);
            }
        }
        else if (eggType[1] == 3)
        {
            eggImage[1].sprite = eggSprite[2];
            counter[1].SetActive(true);
            usedEggs[1] = YellowEgg;
            if (nestLevel[1] >= 5)
            {
                birthButton[1].SetActive(true);
                feedButton[1].SetActive(false);
            }
            else
            {
                feedButton[1].SetActive(true);
                birthButton[1].SetActive(false);
            }
        }
        else if (eggType[1] == 4)
        {
            eggImage[1].sprite = eggSprite[3];
            counter[1].SetActive(true);
            usedEggs[1] = BlackEgg;
            if (nestLevel[1] >= 5)
            {
                birthButton[1].SetActive(true);
                feedButton[1].SetActive(false);
            }
            else
            {
                feedButton[1].SetActive(true);
                birthButton[1].SetActive(false);
            }
        }
        else if (eggType[1] == 5)
        {
            eggImage[1].sprite = eggSprite[4];
            counter[1].SetActive(true);
            usedEggs[1] = GreenEgg;
            if (nestLevel[1] >= 5)
            {
                birthButton[1].SetActive(true);
                feedButton[1].SetActive(false);
            }
            else
            {
                feedButton[1].SetActive(true);
                birthButton[1].SetActive(false);
            }
        }
        else if (eggType[1] == 6)
        {
            eggImage[1].sprite = eggSprite[5];
            counter[1].SetActive(true);
            usedEggs[1] = BrownEgg;
            if (nestLevel[1] >= 5)
            {
                birthButton[1].SetActive(true);
                feedButton[1].SetActive(false);
            }
            else
            {
                feedButton[1].SetActive(true);
                birthButton[1].SetActive(false);
            }
        }
        else
        {
            eggImage[1].sprite = empty;
            counter[1].SetActive(false);
            birthButton[1].SetActive(false);
            feedButton[1].SetActive(false);
        }

        //Nest 3
        if (eggType[2] == 1)
        {
            eggImage[2].sprite = eggSprite[0];
            counter[2].SetActive(true);
            usedEggs[2] = RedEgg;
            if (nestLevel[2] >= 5)
            {
                birthButton[2].SetActive(true);
                feedButton[2].SetActive(false);
            }
            else
            {
                feedButton[2].SetActive(true);
                birthButton[2].SetActive(false);
            }
        }
        else if (eggType[2] == 2)
        {
            eggImage[2].sprite = eggSprite[1];
            counter[2].SetActive(true);
            usedEggs[2] = BlueEgg;
            if (nestLevel[2] >= 5)
            {
                birthButton[2].SetActive(true);
                feedButton[2].SetActive(false);
            }
            else
            {
                feedButton[2].SetActive(true);
                birthButton[2].SetActive(false);
            }
        }
        else if (eggType[2] == 3)
        {
            eggImage[2].sprite = eggSprite[2];
            counter[2].SetActive(true);
            usedEggs[2] = YellowEgg;
            if (nestLevel[2] >= 5)
            {
                birthButton[2].SetActive(true);
                feedButton[2].SetActive(false);
            }
            else
            {
                feedButton[2].SetActive(true);
                birthButton[2].SetActive(false);
            }
        }
        else if (eggType[2] == 4)
        {
            eggImage[2].sprite = eggSprite[3];
            counter[2].SetActive(true);
            usedEggs[2] = BlackEgg;
            if (nestLevel[2] >= 5)
            {
                birthButton[2].SetActive(true);
                feedButton[2].SetActive(false);
            }
            else
            {
                feedButton[2].SetActive(true);
                birthButton[2].SetActive(false);
            }
        }
        else if (eggType[2] == 5)
        {
            eggImage[2].sprite = eggSprite[4];
            counter[2].SetActive(true);
            usedEggs[2] = GreenEgg;
            if (nestLevel[2] >= 5)
            {
                birthButton[2].SetActive(true);
                feedButton[2].SetActive(false);
            }
            else
            {
                feedButton[2].SetActive(true);
                birthButton[2].SetActive(false);
            }
        }
        else if (eggType[2] == 6)
        {
            eggImage[2].sprite = eggSprite[5];
            counter[2].SetActive(true);
            usedEggs[2] = BrownEgg;
            if (nestLevel[2] >= 5)
            {
                birthButton[2].SetActive(true);
                feedButton[2].SetActive(false);
            }
            else
            {
                feedButton[2].SetActive(true);
                birthButton[2].SetActive(false);
            }
        }
        else
        {
            eggImage[2].sprite = empty;
            counter[2].SetActive(false);
            birthButton[2].SetActive(false);
            feedButton[2].SetActive(false);
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (GameController.petList.Count > 0)
        {
            if (GameController.petList[index][0] == "Dread Biter" && int.Parse(GameController.petList[index][1]) >= 5)
            {
                Pets[8] = grownWorm;
            }

            switch (GameController.petList[index][16])
            {
                case "0":
                    elementSlot.sprite = elements[0];
                    break;
                case "1":
                    elementSlot.sprite = elements[1];
                    break;
                case "2":
                    elementSlot.sprite = elements[2];
                    break;
                case "3":
                    elementSlot.sprite = elements[3];
                    break;
                case "4":
                    elementSlot.sprite = elements[4];
                    break;
                case "5":
                    elementSlot.sprite = elements[5];
                    break;
                case "6":
                    elementSlot.sprite = elements[6];
                    break;
            }

            switch (GameController.petList[index][4])
            {
                case "2":
                    BattlePower = (int)1 + ((int.Parse(GameController.petList[index][5]) + int.Parse(GameController.petList[index][11])) * Atk2starsPet * 4 + ((int.Parse(GameController.petList[index][6]) + int.Parse(GameController.petList[index][12])) * Def2starsPet) / 2 + ((int.Parse(GameController.petList[index][7]) + int.Parse(GameController.petList[index][13])) * Sp2starsPet) * 2 + ((int.Parse(GameController.petList[index][8]) + int.Parse(GameController.petList[index][14])) * Agi2starsPet) / 2 + (int.Parse(GameController.petList[index][9]) + int.Parse(GameController.petList[index][15])) * Hp2starsPet / 2);
                    break;
                case "3":
                    BattlePower = (int)1 + ((int.Parse(GameController.petList[index][5]) + int.Parse(GameController.petList[index][11])) * Atk3starsPet * 4 + ((int.Parse(GameController.petList[index][6]) + int.Parse(GameController.petList[index][12])) * Def3starsPet) / 2 + ((int.Parse(GameController.petList[index][7]) + int.Parse(GameController.petList[index][13])) * Sp3starsPet) * 2 + ((int.Parse(GameController.petList[index][8]) + int.Parse(GameController.petList[index][14])) * Agi3starsPet) / 2 + (int.Parse(GameController.petList[index][9]) + int.Parse(GameController.petList[index][15])) * Hp3starsPet / 2);
                    break;
                case "4":
                    BattlePower = (int)1 + ((int.Parse(GameController.petList[index][5]) + int.Parse(GameController.petList[index][11])) * Atk4starsPet * 4 + ((int.Parse(GameController.petList[index][6]) + int.Parse(GameController.petList[index][12])) * Def4starsPet) / 2 + ((int.Parse(GameController.petList[index][7]) + int.Parse(GameController.petList[index][13])) * Sp4starsPet) * 2 + ((int.Parse(GameController.petList[index][8]) + int.Parse(GameController.petList[index][14])) * Agi4starsPet) / 2 + (int.Parse(GameController.petList[index][9]) + int.Parse(GameController.petList[index][15])) * Hp4starsPet / 2);
                    break;
                case "5":
                    BattlePower = (int)1 + ((int.Parse(GameController.petList[index][5]) + int.Parse(GameController.petList[index][11])) * Atk5starsPet * 4 + ((int.Parse(GameController.petList[index][6]) + int.Parse(GameController.petList[index][12])) * Def5starsPet) / 2 + ((int.Parse(GameController.petList[index][7]) + int.Parse(GameController.petList[index][13])) * Sp5starsPet) * 2 + ((int.Parse(GameController.petList[index][8]) + int.Parse(GameController.petList[index][14])) * Agi5starsPet) / 2 + (int.Parse(GameController.petList[index][9]) + int.Parse(GameController.petList[index][15])) * Hp5starsPet / 2);
                    break;
            }
            PetBattlePowerText.text = BattlePower.ToString() + " BP.";
        }
        if (firstTime)
        {
            for (int i = 1; i <= GameController.petList.Count; i++)
            {
                for (int j = 1; j <= usedPetList.Count; j++)
                {
                    if (GameController.petList[i][0] == usedPetList[j][0])
                    {
                        useButtons[i - 1].SetActive(false);
                    }
                }
            }
            firstTime = false;
        }
        petListIndex = GameController.petList.Count;
        usedPetListIndex = usedPetList.Count;
        if (GameController.petList.Count > 0)
        {
            foodLevels.SetActive(true);
            feedUIButton.SetActive(true);
            equipUIButton.SetActive(true);
            unequipUIButton.SetActive(true);
            statsPanel.SetActive(true);
            bp.SetActive(true);

            petCount.text = index + "/" + GameController.petList.Count;
            petName.text = GameController.petList[index][0];
            petLevel.text = GameController.petList[index][1];
            if(int.Parse(GameController.petList[index][1]) == 10)
            {
                FoodXpCounter.text = "MAX!";
            }
            else
            {
                FoodXpCounter.text = GameController.petList[index][2] + "/" + GameController.petList[index][3];
            }
            
            BaseAtkText.text = GameController.petList[index][5].ToString() + "/10";
            BaseDefText.text = GameController.petList[index][6].ToString() + "/10";
            BaseSpText.text = GameController.petList[index][7].ToString() + "/10";
            BaseAgiText.text = GameController.petList[index][8].ToString() + "/10";
            BaseHpText.text = GameController.petList[index][9].ToString() + "/10";
            points.text = "stats points : " + GameController.petList[index][10].ToString();



            petAtkBonusText.text = GameController.petAtkBonus.ToString();
            petDefBonusText.text = GameController.petDefBonus.ToString();
            petSpBonusText.text = GameController.petSpBonus.ToString();
            petAgiBonusText.text = GameController.petAgiBonus.ToString();
            petHpBonusText.text = GameController.petHpBonus.ToString();

            //Debug.Log(GameController.petAtkBonus + " " + GameController.petDefBonus + " " + GameController.petSpBonus + " " + GameController.petAgiBonus + " " + GameController.petHpBonus);
            //Debug.Log(usedPetList.Count);

            if (usedPetsImage[0].sprite == empty && usedPetsImage[1].sprite == empty && usedPetsImage[2].sprite == empty)
            {
                usedPetList.Clear();
            }


            if (int.Parse(GameController.petList[index][11]) > 0)
            {
                BonusAtk.SetActive(true);
                BonusAtkText.text = "+" + GameController.petList[index][11];
            }
            else
            {
                BonusAtk.SetActive(false);
            }

            if (int.Parse(GameController.petList[index][12]) > 0)
            {
                BonusDef.SetActive(true);
                BonusDefText.text = "+" + GameController.petList[index][12];
            }
            else
            {
                BonusDef.SetActive(false);
            }

            if (int.Parse(GameController.petList[index][13]) > 0)
            {
                BonusSp.SetActive(true);
                BonusSpText.text = "+" + GameController.petList[index][13];
            }
            else
            {
                BonusSp.SetActive(false);
            }

            if (int.Parse(GameController.petList[index][14]) > 0)
            {
                BonusAgi.SetActive(true);
                BonusAgiText.text = "+" + GameController.petList[index][14];
            }
            else
            {
                BonusAgi.SetActive(false);
            }

            if (int.Parse(GameController.petList[index][15]) > 0)
            {
                BonusHp.SetActive(true);
                BonusHpText.text = "+" + GameController.petList[index][15];
            }
            else
            {
                BonusHp.SetActive(false);
            }

            atkbar.SetAtk(int.Parse(GameController.petList[index][5]) + int.Parse(GameController.petList[index][11]));
            defbar.SetDef(int.Parse(GameController.petList[index][6]) + int.Parse(GameController.petList[index][12]));
            spbar.SetSp(int.Parse(GameController.petList[index][7]) + int.Parse(GameController.petList[index][13]));
            agibar.SetAgi(int.Parse(GameController.petList[index][8]) + int.Parse(GameController.petList[index][14]));
            Hpbar.SetHp(int.Parse(GameController.petList[index][9]) + int.Parse(GameController.petList[index][15]));


            switch (GameController.petList[index][4])
            {
                case "2":
                    grade2Stars.SetActive(true);
                    grade3Stars.SetActive(false);
                    grade4Stars.SetActive(false);
                    grade5Stars.SetActive(false);
                    break;

                case "3":
                    grade3Stars.SetActive(true);
                    grade2Stars.SetActive(false);
                    grade4Stars.SetActive(false);
                    grade5Stars.SetActive(false);
                    break;

                case "4":
                    grade4Stars.SetActive(true);
                    grade3Stars.SetActive(false);
                    grade2Stars.SetActive(false);
                    grade5Stars.SetActive(false);
                    break;

                case "5":
                    grade5Stars.SetActive(true);
                    grade3Stars.SetActive(false);
                    grade4Stars.SetActive(false);
                    grade2Stars.SetActive(false);
                    break;
            }

            switch (GameController.petList[index][0])
            {
                case "Jack-O-Lantern":
                    if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(false);
                    }else if(int.Parse(GameController.petList[index][1]) >= 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(true);
                    }
                    else
                    {
                        petImage.transform.localScale = new Vector3(1f, 1f, 1f);
                        petPanelEffect.SetActive(false);
                    }
                    petImage.sprite = Pets[0];
                    break;
                case "Claws":
                    if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(false);
                    }
                    else if (int.Parse(GameController.petList[index][1]) >= 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(true);
                    }
                    else
                    {
                        petImage.transform.localScale = new Vector3(1f, 1f, 1f);
                        petPanelEffect.SetActive(false);
                    }
                    petImage.sprite = Pets[1];
                    break;
                case "Golem":
                    if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(false);
                    }
                    else if (int.Parse(GameController.petList[index][1]) >= 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(true);
                    }
                    else
                    {
                        petImage.transform.localScale = new Vector3(1f, 1f, 1f);
                        petPanelEffect.SetActive(false);
                    }
                    petImage.sprite = Pets[2];
                    break;
                case "Snow Wolf":
                    if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(false);
                    }
                    else if (int.Parse(GameController.petList[index][1]) >= 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(true);
                    }
                    else
                    {
                        petImage.transform.localScale = new Vector3(1f, 1f, 1f);
                        petPanelEffect.SetActive(false);
                    }
                    petImage.sprite = Pets[3];
                    break;
                case "Buzz":
                    if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(false);
                    }
                    else if (int.Parse(GameController.petList[index][1]) >= 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(true);
                    }
                    else
                    {
                        petImage.transform.localScale = new Vector3(1f, 1f, 1f);
                        petPanelEffect.SetActive(false);
                    }
                    petImage.sprite = Pets[4];
                    break;
                case "Night Wolf":
                    if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(false);
                    }
                    else if (int.Parse(GameController.petList[index][1]) >= 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(true);
                    }
                    else
                    {
                        petImage.transform.localScale = new Vector3(1f, 1f, 1f);
                        petPanelEffect.SetActive(false);
                    }
                    petImage.sprite = Pets[5];
                    break;
                case "Rumryss":
                    if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(false);
                    }
                    else if (int.Parse(GameController.petList[index][1]) >= 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(true);
                    }
                    else
                    {
                        petImage.transform.localScale = new Vector3(1f, 1f, 1f);
                        petPanelEffect.SetActive(false);
                    }
                    petImage.sprite = Pets[6];
                    break;
                case "Wyvernldle":
                    if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(false);
                    }
                    else if (int.Parse(GameController.petList[index][1]) >= 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(true);
                    }
                    else
                    {
                        petImage.transform.localScale = new Vector3(1f, 1f, 1f);
                        petPanelEffect.SetActive(false);
                    }
                    petImage.sprite = Pets[7];
                    break;
                case "Dread Biter":
                    if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(false);
                    }
                    else if (int.Parse(GameController.petList[index][1]) >= 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(true);
                    }
                    else
                    {
                        petImage.transform.localScale = new Vector3(1f, 1f, 1f);
                        petPanelEffect.SetActive(false);
                    }
                    petImage.sprite = Pets[8];
                    break;
                case "One Eye":
                    if (int.Parse(GameController.petList[index][1]) >= 5)
                        if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                        {
                            petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                            petPanelEffect.SetActive(false);
                        }
                        else if (int.Parse(GameController.petList[index][1]) >= 10)
                        {
                            petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                            petPanelEffect.SetActive(true);
                        }
                        else
                        {
                            petImage.transform.localScale = new Vector3(1f, 1f, 1f);
                            petPanelEffect.SetActive(false);
                        }
                    petImage.sprite = Pets[9];
                    break;
                case "red dragon":
                    if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(false);
                    }
                    else if (int.Parse(GameController.petList[index][1]) >= 10)
                    {
                        petImage.transform.localScale = new Vector3(1.5f, 1.5f, 1);
                        petPanelEffect.SetActive(true);
                    }
                    else
                    {
                        petImage.transform.localScale = new Vector3(1f, 1f, 1f);
                        petPanelEffect.SetActive(false);
                    }
                    petImage.sprite = Pets[10];
                    break;
            }
        }
        else
        {
            foodLevels.SetActive(false);
            feedUIButton.SetActive(false);
            equipUIButton.SetActive(false);
            statsPanel.SetActive(false);
            unequipUIButton.SetActive(false);
        }

        nest1LevelText.text = nestLevel[0].ToString();
        nest2LevelText.text = nestLevel[1].ToString();
        nest3LevelText.text = nestLevel[2].ToString();

        if (checkExist(inventory, RedEgg))
        {
            useButton[0].SetActive(true);
        }
        else
        {
            useButton[0].SetActive(false);
        }

        if (checkExist(inventory, BlueEgg))
        {
            useButton[1].SetActive(true);
        }
        else
        {
            useButton[1].SetActive(false);
        }


        if (checkExist(inventory, YellowEgg))
        {
            useButton[2].SetActive(true);
        }
        else
        {
            useButton[2].SetActive(false);
        }

        if (checkExist(inventory, BlackEgg))
        {
            useButton[3].SetActive(true);
        }
        else
        {
            useButton[3].SetActive(false);
        }

        if (checkExist(inventory, GreenEgg))
        {
            useButton[4].SetActive(true);
        }
        else
        {
            useButton[4].SetActive(false);
        }

        if (checkExist(inventory, BrownEgg))
        {
            useButton[5].SetActive(true);
        }
        else
        {
            useButton[5].SetActive(false);
        }

        if (checkExist(inventory, RedDragonEgg))
        {
            useButton[6].SetActive(true);
        }
        else
        {
            useButton[6].SetActive(false);
        }
        //Debug.Log(usedEggs[0] + " " + usedEggs[1] + " " + usedEggs[2]);
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == eggs)
            {
                eggsNumber = inventory.Container[i].amount;

                break;
            }
        }

        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == meat)
            {
                meatNumber = inventory.Container[i].amount;
                break;
            }
        }
        meatNumberText.text = meatNumber.ToString();

        CounterText[0].text = eggsNumber.ToString() + "/" + requiredEggs[0].ToString();
        CounterText[1].text = eggsNumber.ToString() + "/" + requiredEggs[1].ToString();
        CounterText[2].text = eggsNumber.ToString() + "/" + requiredEggs[2].ToString();

        if (eggsNumber >= requiredEggs[0])
        {
            CounterText[0].color = Color.green;
        }
        else
        {
            CounterText[0].color = Color.white;
        }

        if (eggsNumber >= requiredEggs[1])
        {
            CounterText[1].color = Color.green;
        }
        else
        {
            CounterText[1].color = Color.white;
        }

        if (eggsNumber >= requiredEggs[2])
        {
            CounterText[2].color = Color.green;
        }
        else
        {
            CounterText[2].color = Color.white;
        }

        if (nestLevel[0] >= 5)
        {
            feedButton[0].SetActive(false);
            birthButton[0].SetActive(true);
        }

        if (nestLevel[1] >= 5)
        {
            feedButton[1].SetActive(false);
            birthButton[1].SetActive(true);
        }

        if (nestLevel[2] >= 5)
        {
            feedButton[2].SetActive(false);
            birthButton[2].SetActive(true);
        }
    }

    bool checkExist(InventoryObject inventory, ItemObject item)
    {
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item == item)
            {
                return true;
            }

        }
        return false;
    }

    public void useRed()
    {
        for (int i = 0; i < usedEggs.Length; i++)
        {
            if (usedEggs[i] == null)
            {
                inventory.RemoveItem(RedEgg);
                inventory.save();
                clickSound.Play();
                eggType[i] = 1;
                eggImage[i].sprite = eggSprite[0];
                usedEggs[i] = RedEgg;
                nestLevel[i]++;
                counter[i].SetActive(true);
                feedButton[i].SetActive(true);
                requiredEggs[i] = 1;
                break;
            }
        }
    }

    public void useBlue()
    {
        for (int i = 0; i < usedEggs.Length; i++)
        {
            if (usedEggs[i] == null)
            {
                inventory.RemoveItem(BlueEgg);
                inventory.save();
                clickSound.Play();
                eggType[i] = 2;
                eggImage[i].sprite = eggSprite[1];
                usedEggs[i] = BlueEgg;
                nestLevel[i]++;
                counter[i].SetActive(true);
                feedButton[i].SetActive(true);
                requiredEggs[i] = 1;
                break;
            }
        }
    }

    public void useYellow()
    {
        for (int i = 0; i < usedEggs.Length; i++)
        {
            if (usedEggs[i] == null)
            {
                inventory.RemoveItem(YellowEgg);
                inventory.save();
                clickSound.Play();
                eggType[i] = 3;
                eggImage[i].sprite = eggSprite[2];
                usedEggs[i] = YellowEgg;
                nestLevel[i]++;
                counter[i].SetActive(true);
                feedButton[i].SetActive(true);
                requiredEggs[i] = 1;
                break;
            }
        }
    }

    public void useBlack()
    {
        for (int i = 0; i < usedEggs.Length; i++)
        {
            if (usedEggs[i] == null)
            {
                inventory.RemoveItem(BlackEgg);
                inventory.save();
                clickSound.Play();
                eggType[i] = 4;
                eggImage[i].sprite = eggSprite[3];
                usedEggs[i] = BlackEgg;
                nestLevel[i]++;
                counter[i].SetActive(true);
                feedButton[i].SetActive(true);
                requiredEggs[i] = 1;
                break;
            }
        }
    }

    public void useGreen()
    {
        for (int i = 0; i < usedEggs.Length; i++)
        {
            if (usedEggs[i] == null)
            {
                inventory.RemoveItem(GreenEgg);
                inventory.save();
                clickSound.Play();
                eggType[i] = 5;
                eggImage[i].sprite = eggSprite[4];
                usedEggs[i] = GreenEgg;
                nestLevel[i]++;
                counter[i].SetActive(true);
                feedButton[i].SetActive(true);
                requiredEggs[i] = 1;
                break;
            }
        }
    }

    public void useBrown()
    {
        for (int i = 0; i < usedEggs.Length; i++)
        {
            if (usedEggs[i] == null)
            {
                inventory.RemoveItem(BrownEgg);
                inventory.save();
                clickSound.Play();
                eggType[i] = 6;
                eggImage[i].sprite = eggSprite[5];
                usedEggs[i] = BrownEgg;
                nestLevel[i]++;
                counter[i].SetActive(true);
                feedButton[i].SetActive(true);
                requiredEggs[i] = 1;
                break;
            }
        }
    }

    public void useRedDragon()
    {
        for (int i = 0; i < usedEggs.Length; i++)
        {
            if (usedEggs[i] == null)
            {
                inventory.RemoveItem(RedDragonEgg);
                inventory.save();
                clickSound.Play();
                eggType[i] = 7;
                eggImage[i].sprite = eggSprite[6];
                usedEggs[i] = RedDragonEgg;
                nestLevel[i]++;
                counter[i].SetActive(true);
                feedButton[i].SetActive(true);
                requiredEggs[i] = 1;
                break;
            }
        }
    }
    public void EggFeed()
    {
        if (eggsNumber >= requiredEggs[0])
        {
            for (int i = 0; i < requiredEggs[0]; i++)
            {
                inventory.RemoveItem(eggs);
                meatInventory.RemoveItem(eggs);
                inventory.save();
                meatInventory.save();
            }
            if (eggsNumber == requiredEggs[0])
            {
                eggsNumber = 0;
            }
            upgradeSound.Play();
            nestLevel[0]++;
            requiredEggs[0]++;
            Vector3 add = new Vector3(-slot.transform.position.x, -slot.transform.position.y, transform.position.z);
            var Effect = Instantiate(effect, slot.transform.position + add, Quaternion.identity) as GameObject;
            Effect.transform.SetParent(slot.transform, false);
            Destroy(Effect, 1f);
            egg1SwitchAnim.SetBool("Press", true);
            StartCoroutine(backSwitch());
        }
        else
        {
            var forgedTxt = Instantiate(notEnoughEggsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(eggsPanel.transform, false);
            forgedTxt.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
            Destroy(forgedTxt, 0.5f);
        }
    }

    public void EggFeed2()
    {
        if (eggsNumber >= requiredEggs[1])
        {
            for (int i = 0; i < requiredEggs[1]; i++)
            {
                inventory.RemoveItem(eggs);
                meatInventory.RemoveItem(eggs);
                inventory.save();
                meatInventory.save();
            }
            if (eggsNumber == requiredEggs[1])
            {
                eggsNumber = 0;
            }
            upgradeSound.Play();
            nestLevel[1]++;
            requiredEggs[1]++;
            Vector3 add = new Vector3(-slot2.transform.position.x, -slot2.transform.position.y, transform.position.z);
            var Effect = Instantiate(effect, slot2.transform.position + add, Quaternion.identity) as GameObject;
            Effect.transform.SetParent(slot2.transform, false);
            Destroy(Effect, 1f);
            egg2SwitchAnim.SetBool("Press", true);
            StartCoroutine(backSwitch());
        }
        else
        {
            var forgedTxt = Instantiate(notEnoughEggsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(eggsPanel.transform, false);
            forgedTxt.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
            Destroy(forgedTxt, 0.5f);
        }
    }

    public void EggFeed3()
    {
        if (eggsNumber >= requiredEggs[2])
        {
            for (int i = 0; i < requiredEggs[2]; i++)
            {
                inventory.RemoveItem(eggs);
                meatInventory.RemoveItem(eggs);
                inventory.save();
                meatInventory.save();
            }
            if (eggsNumber == requiredEggs[2])
            {
                eggsNumber = 0;
            }
            upgradeSound.Play();
            nestLevel[2]++;
            requiredEggs[2]++;
            Vector3 add = new Vector3(-slot3.transform.position.x, -slot3.transform.position.y, transform.position.z);
            var Effect = Instantiate(effect, slot3.transform.position + add, Quaternion.identity) as GameObject;
            Effect.transform.SetParent(slot3.transform, false);
            Destroy(Effect, 1f);
            egg3SwitchAnim.SetBool("Press", true);
            StartCoroutine(backSwitch());
        }
        else
        {
            var forgedTxt = Instantiate(notEnoughEggsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(eggsPanel.transform, false);
            forgedTxt.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
            Destroy(forgedTxt, 0.5f);
        }
    }


    IEnumerator backSwitch()
    {
        yield return new WaitForSeconds(0.5f);
        egg1SwitchAnim.SetBool("Press", false);
        egg2SwitchAnim.SetBool("Press", false);
        egg3SwitchAnim.SetBool("Press", false);
    }

    public void BirthEgg1()
    {
        if (eggsNumber >= requiredEggs[0])
        {
            for (int i = 0; i < requiredEggs[0]; i++)
            {
                inventory.RemoveItem(eggs);
                meatInventory.RemoveItem(eggs);
                inventory.save();
                meatInventory.save();
            }
            if (eggsNumber == requiredEggs[0])
            {
                eggsNumber = 0;
            }
            animalSpawnPos.sprite = empty;
            ResetEggNest1();
            birthButton[0].SetActive(false);
            birthPanel.SetActive(true);
            eggCrackSound.Play();
            eggUI[eggType[0] - 1].SetActive(true);
            StartCoroutine(setAniamalSprite(0));
            StartCoroutine(closeBirthPanel());
        }
        else
        {
            var forgedTxt = Instantiate(notEnoughEggsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(eggsPanel.transform, false);
            forgedTxt.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
            Destroy(forgedTxt, 0.5f);
        }
    }

    public void BirthEgg2()
    {
        if (eggsNumber >= requiredEggs[1])
        {
            for (int i = 0; i < requiredEggs[1]; i++)
            {
                inventory.RemoveItem(eggs);
                meatInventory.RemoveItem(eggs);
                inventory.save();
                meatInventory.save();
            }
            if (eggsNumber == requiredEggs[1])
            {
                eggsNumber = 0;
            }
            animalSpawnPos.sprite = empty;
            ResetEggNest2();
            birthButton[1].SetActive(false);
            birthPanel.SetActive(true);
            eggCrackSound.Play();
            eggUI[eggType[1] - 1].SetActive(true);
            StartCoroutine(setAniamalSprite(1));
            StartCoroutine(closeBirthPanel());
        }
        else
        {
            var forgedTxt = Instantiate(notEnoughEggsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(eggsPanel.transform, false);
            forgedTxt.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
            Destroy(forgedTxt, 0.5f);
        }
    }

    public void BirthEgg3()
    {
        if (eggsNumber >= requiredEggs[2])
        {
            for (int i = 0; i < requiredEggs[2]; i++)
            {
                inventory.RemoveItem(eggs);
                meatInventory.RemoveItem(eggs);
                inventory.save();
                meatInventory.save();
            }
            if (eggsNumber == requiredEggs[2])
            {
                eggsNumber = 0;
            }
            animalSpawnPos.sprite = empty;
            ResetEggNest3();
            birthButton[2].SetActive(false);
            birthPanel.SetActive(true);
            eggCrackSound.Play();
            eggUI[eggType[2] - 1].SetActive(true);
            StartCoroutine(setAniamalSprite(2));
            StartCoroutine(closeBirthPanel());
        }
        else
        {
            var forgedTxt = Instantiate(notEnoughEggsText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(eggsPanel.transform, false);
            forgedTxt.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
            Destroy(forgedTxt, 0.5f);
        }
    }

    public void ResetEggNest1()
    {
        eggImage[0].sprite = empty;
        usedEggs[0] = null;
        nestLevel[0] = 0;
        counter[0].SetActive(false);
        feedButton[0].SetActive(false);
        requiredEggs[0] = 0;

    }

    public void ResetEggNest2()
    {
        eggImage[1].sprite = empty;
        usedEggs[1] = null;
        nestLevel[1] = 0;
        counter[1].SetActive(false);
        feedButton[1].SetActive(false);
        requiredEggs[1] = 0;

    }

    public void ResetEggNest3()
    {
        eggImage[2].sprite = empty;
        usedEggs[2] = null;
        nestLevel[2] = 0;
        counter[2].SetActive(false);
        feedButton[2].SetActive(false);
        requiredEggs[2] = 0;

    }


    public void PetsButton()
    {
        animalPanel.SetActive(true);
        book.SetActive(false);
        eggsPanel.SetActive(false);
        petsPanel.SetActive(true);
        statPanel.SetActive(false);
        if (GameController.petList.Count == 1)
        {
            FoodBar.SetMaxFood(int.Parse(GameController.petList[index][3]));
            FoodBar.SetFood(int.Parse(GameController.petList[index][2]));
        }
    }
    public void eggsButton()
    {
        animalPanel.SetActive(true);
        book.SetActive(false);
        eggsPanel.SetActive(true);
        petsPanel.SetActive(false);
        statPanel.SetActive(false);
    }

    public void statsButton()
    {
        animalPanel.SetActive(true);
        book.SetActive(false);
        eggsPanel.SetActive(false);
        petsPanel.SetActive(false);
        statPanel.SetActive(true);
    }

    IEnumerator closeBirthPanel()
    {
        yield return new WaitForSeconds(3f);
        for (int i = 0; i < 6; i++)
        {
            eggUI[i].SetActive(false);
        }
        birthPanel.SetActive(false);

    }

    IEnumerator setAniamalSprite(int i)
    {
        yield return new WaitForSeconds(1.25f);
        eggOpen.Play();
        switch (eggType[i])
        {
            case 1:
                int rand = Random.Range(0, 2);
                switch (rand)
                {
                    case 0:
                        animalSpawnPos.sprite = Pets[0];

                        foreach (KeyValuePair<int, string[]> pet in GameController.petList)
                        {
                            if (pet.Value[0] == "Jack-O-Lantern")
                            {
                                check = true;
                                inventory.AddItem(meat, 40);
                                meatInventory.AddItem(meat, 40);
                                alert.SetActive(true);
                                break;
                            }
                        }
                        if (!check)
                        {

                            GameController.petList.Add(++petListIndex, new string[] { "Jack-O-Lantern", "1", "0", "10", "4", "5", "6", "3", "2", "4", "0", "0", "0", "0", "0", "0","0" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[0];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
                            locked[7].SetActive(false);
                        }
                        check = false;
                        break;
                    case 1:
                        animalSpawnPos.sprite = Pets[1];

                        foreach (KeyValuePair<int, string[]> pet in GameController.petList)
                        {
                            if (pet.Value[0] == "Claws")
                            {
                                check = true;
                                inventory.AddItem(meat, 20);
                                meatInventory.AddItem(meat, 20);
                                alert.SetActive(true);
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++petListIndex, new string[] { "Claws", "1", "0", "10", "2", "2", "1", "3", "1", "2", "0", "0", "0", "0", "0", "0","0" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[1];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
                            locked[0].SetActive(false);
                        }
                        check = false;
                        break;
                }
                inventory.save();
                meatInventory.save();
                break;
            case 2:
                int rand1 = Random.Range(0, 2);
                switch (rand1)
                {
                    case 0:
                        animalSpawnPos.sprite = Pets[2];

                        foreach (KeyValuePair<int, string[]> pet in GameController.petList)
                        {
                            if (pet.Value[0] == "Golem")
                            {
                                check = true;
                                inventory.AddItem(meat, 30);
                                meatInventory.AddItem(meat, 30);
                                alert.SetActive(true);
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++petListIndex, new string[] { "Golem", "1", "0", "10", "3", "3", "2", "4", "2", "4", "0", "0", "0", "0", "0", "0","1" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[2];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
                            locked[6].SetActive(false);
                        }
                        check = false;
                        break;
                    case 1:
                        animalSpawnPos.sprite = Pets[3];
                        foreach (KeyValuePair<int, string[]> pet in GameController.petList)
                        {
                            if (pet.Value[0] == "Snow Wolf")
                            {
                                check = true;
                                inventory.AddItem(meat, 30);
                                meatInventory.AddItem(meat, 30);
                                alert.SetActive(true);
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++petListIndex, new string[] { "Snow Wolf", "1", "0", "10", "3", "4", "2", "3", "2", "1", "0", "0", "0", "0", "0", "0","1" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[3];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
                            locked[3].SetActive(false);
                        }
                        check = false;
                        break;
                }
                inventory.save();
                meatInventory.save();
                break;
            case 3:
                int rand2 = Random.Range(0, 2);
                switch (rand2)
                {
                    case 0:
                        animalSpawnPos.sprite = Pets[4];

                        foreach (KeyValuePair<int, string[]> pet in GameController.petList)
                        {
                            if (pet.Value[0] == "Buzz")
                            {
                                check = true;
                                inventory.AddItem(meat, 20);
                                meatInventory.AddItem(meat, 20);
                                alert.SetActive(true);
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++petListIndex, new string[] { "Buzz", "1", "0", "10", "2", "1", "2", "1", "3", "3", "0", "0", "0", "0", "0", "0","3" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[4];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
                            locked[1].SetActive(false);
                        }
                        check = false;
                        break;
                    case 1:
                        animalSpawnPos.sprite = Pets[4];

                        foreach (KeyValuePair<int, string[]> pet in GameController.petList)
                        {
                            if (pet.Value[0] == "Buzz")
                            {
                                check = true;
                                inventory.AddItem(meat, 20);
                                meatInventory.AddItem(meat, 20);
                                alert.SetActive(true);
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++petListIndex, new string[] { "Buzz", "1", "0", "10", "2", "1", "2", "1", "3", "3", "0", "0", "0", "0", "0", "0","3" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[4];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
                            locked[1].SetActive(false);
                        }
                        check = false;
                        break;
                }
                inventory.save();
                meatInventory.save();
                break;
            case 4:
                int rand3 = Random.Range(0, 2);
                switch (rand3)
                {
                    case 0:
                        animalSpawnPos.sprite = Pets[5];

                        foreach (KeyValuePair<int, string[]> pet in GameController.petList)
                        {
                            if (pet.Value[0] == "Night Wolf")
                            {
                                check = true;
                                inventory.AddItem(meat, 30);
                                meatInventory.AddItem(meat, 30);
                                alert.SetActive(true);
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++petListIndex, new string[] { "Night Wolf", "1", "0", "10", "3", "4", "2", "3", "1", "5", "0", "0", "0", "0", "0", "0","5" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[5];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
                            locked[4].SetActive(false);
                        }
                        check = false;
                        break;
                    case 1:
                        animalSpawnPos.sprite = Pets[5];

                        foreach (KeyValuePair<int, string[]> pet in GameController.petList)
                        {
                            if (pet.Value[0] == "Night Wolf")
                            {
                                check = true;
                                inventory.AddItem(meat, 30);
                                meatInventory.AddItem(meat, 30);
                                alert.SetActive(true);
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++petListIndex, new string[] { "Night Wolf", "1", "0", "10", "3", "4", "2", "3", "1", "5", "0", "0", "0", "0", "0", "0","5" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[5];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
                            locked[4].SetActive(false);
                        }
                        check = false;
                        break;
                }
                inventory.save();
                meatInventory.save();
                break;
            case 5:
                int rand4 = Random.Range(0, 2);
                switch (rand4)
                {
                    case 0:
                        animalSpawnPos.sprite = Pets[6];

                        foreach (KeyValuePair<int, string[]> pet in GameController.petList)
                        {
                            if (pet.Value[0] == "Rumryss")
                            {
                                check = true;
                                inventory.AddItem(meat, 20);
                                meatInventory.AddItem(meat, 20);
                                alert.SetActive(true);
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++petListIndex, new string[] { "Rumryss", "1", "0", "10", "2", "1", "2", "3", "3", "1", "0", "0", "0", "0", "0", "0","4" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[6];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
                            locked[2].SetActive(false);
                        }
                        check = false;
                        break;
                    case 1:
                        animalSpawnPos.sprite = Pets[7];

                        foreach (KeyValuePair<int, string[]> pet in GameController.petList)
                        {
                            if (pet.Value[0] == "Wyvernldle")
                            {
                                check = true;
                                inventory.AddItem(meat, 40);
                                meatInventory.AddItem(meat, 40);
                                alert.SetActive(true);
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++petListIndex, new string[] { "Wyvernldle", "1", "0", "10", "4", "5", "4", "3", "4", "4", "0", "0", "0", "0", "0", "0","4" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[7];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
                            locked[8].SetActive(false);
                        }
                        check = false;
                        break;
                }
                inventory.save();
                meatInventory.save();
                break;
            case 6:
                int rand5 = Random.Range(0, 2);
                switch (rand5)
                {
                    case 0:
                        animalSpawnPos.sprite = Pets[8];

                        foreach (KeyValuePair<int, string[]> pet in GameController.petList)
                        {
                            if (pet.Value[0] == "Dread Biter")
                            {
                                check = true;
                                inventory.AddItem(meat, 40);
                                meatInventory.AddItem(meat, 40);
                                alert.SetActive(true);
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++petListIndex, new string[] { "Dread Biter", "1", "0", "10", "4", "6", "2", "3", "4", "5", "0", "0", "0", "0", "0", "0","2" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[8];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
                            locked[9].SetActive(false);
                        }
                        check = false;
                        break;
                    case 1:
                        animalSpawnPos.sprite = Pets[9];
                        foreach (KeyValuePair<int, string[]> pet in GameController.petList)
                        {
                            if (pet.Value[0] == "One Eye")
                            {
                                check = true;
                                inventory.AddItem(meat, 30);
                                meatInventory.AddItem(meat, 30);
                                alert.SetActive(true);
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++petListIndex, new string[] { "One Eye", "1", "0", "10", "3", "3", "2", "4", "1", "5", "0", "0", "0", "0", "0", "0","2" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[9];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
                            locked[5].SetActive(false);
                        }
                        check = false;
                        break;
                }
                inventory.save();
                meatInventory.save();
                break;

            case 7:
                int rand6 = Random.Range(0, 2);
                switch (rand6)
                {
                    case 0:
                        animalSpawnPos.sprite = Pets[10];

                        foreach (KeyValuePair<int, string[]> pet in GameController.petList)
                        {
                            if (pet.Value[0] == "red dragon")
                            {
                                check = true;
                                inventory.AddItem(meat, 100);
                                meatInventory.AddItem(meat, 100);
                                alert.SetActive(true);
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++petListIndex, new string[] { "red dragon", "1", "0", "10", "5", "6", "7", "4", "6", "7", "0", "0", "0", "0", "0", "0","6" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[10];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
                            locked[10].SetActive(false);
                        }
                        check = false;
                        break;
                    case 1:
                        animalSpawnPos.sprite = Pets[10];
                        foreach (KeyValuePair<int, string[]> pet in GameController.petList)
                        {
                            if (pet.Value[0] == "red dragon")
                            {
                                check = true;
                                inventory.AddItem(meat, 30);
                                meatInventory.AddItem(meat, 30);
                                alert.SetActive(true);
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++petListIndex, new string[] { "red dragon", "1", "0", "10", "5", "6", "7", "4", "6", "7", "0", "0", "0", "0", "0", "0","6" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[10];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
                            locked[10].SetActive(false);
                        }
                        check = false;
                        break;
                }
                inventory.save();
                meatInventory.save();
                break;
        }
        eggType[i] = -1;

    }

    public void previousPetButton()
    {
        clickSound.Play();
        if (index == 1)
        {
            index = GameController.petList.Count;
        }
        else
        {
            index--;

        }
        FoodBar.SetMaxFood(int.Parse(GameController.petList[index][3]));
        FoodBar.SetFood(int.Parse(GameController.petList[index][2]));
    }
    public void nextPetButton()
    {

        clickSound.Play();
        if (index == GameController.petList.Count)
        {
            index = 1;
        }
        else
        {
            index++;

        }
        FoodBar.SetMaxFood(int.Parse(GameController.petList[index][3]));
        FoodBar.SetFood(int.Parse(GameController.petList[index][2]));
    }

    public void FeedButton()
    {
        if (int.Parse(GameController.petList[index][1]) < 10)
        {
            if (meatNumber >= 10)
            {
                var txt = Instantiate(usedMeatText, feedUIButton.transform.position, Quaternion.identity) as GameObject;
                txt.transform.SetParent(GameObject.FindGameObjectWithTag("petPanel").transform, false);
                Destroy(txt, 1f);
                int a = int.Parse(GameController.petList[index][2]);
                a += 10;
                for (int i = 0; i < 10; i++)
                {
                    inventory.RemoveItem(meat);
                    meatInventory.RemoveItem(meat);
                    inventory.save();
                    meatInventory.save();
                }
                if (meatNumber == 10)
                {
                    meatNumber = 0;
                }
                if (a >= int.Parse(GameController.petList[index][3]))
                {

                    int points = int.Parse(GameController.petList[index][10]) + 1;
                    GameController.petList[index][10] = points.ToString();
                    eatSound.Play();
                    GameObject effect = Instantiate(levelUpEffect, petImage.transform.position, Quaternion.identity) as GameObject;
                    effect.transform.SetParent(this.gameObject.transform);
                    levelUpSound.Play();
                    Destroy(effect, 1f);
                  
                    a = 0;
                    int maxFood = int.Parse(GameController.petList[index][3]);
                    maxFood += 10;
                    GameController.petList[index][3] = maxFood.ToString();
                    FoodBar.SetMaxFood(int.Parse(GameController.petList[index][3]));
                    GameController.petList[index][2] = "0";
                    FoodBar.SetFood(int.Parse(GameController.petList[index][2]));
                    int level = int.Parse(GameController.petList[index][1]);
                    level++;
                    if(level == 5 || level == 10)
                    {
                        var smoke = Instantiate(Smoke, feedUIButton.transform.position, Quaternion.identity) as GameObject;
                        smoke.transform.SetParent(GameObject.FindGameObjectWithTag("petPanel").transform, false);
                        Destroy(smoke, 1f);
                        
                    }
                  
                    GameController.petList[index][1] = level.ToString();
                }
                else
                {
                    GameController.petList[index][2] = a.ToString();
                    eatSound.Play();
                    FoodBar.SetFood(a);
                }
            }
            else
            {
                var forgedTxt = Instantiate(notEnoughRawMeatText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
                forgedTxt.transform.SetParent(petsPanel.transform, false);
                forgedTxt.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
                Destroy(forgedTxt, 0.5f);
            }
        }
    }
    public void UnequipPetButton()
    {
        usePetAudio.Play();
        GameObject pet = GameObject.FindGameObjectWithTag("pet");
        GameObject pet1 = GameObject.FindGameObjectWithTag("pumpkin_Pet");
        GameObject pet2 = GameObject.FindGameObjectWithTag("eye_Pet");
        GameObject pet3 = GameObject.FindGameObjectWithTag("crab_Pet");
        GameObject pet4 = GameObject.FindGameObjectWithTag("greenDragon_Pet");
        GameObject pet5 = GameObject.FindGameObjectWithTag("dog_Pet");
        GameObject pet6 = GameObject.FindGameObjectWithTag("snowDog_Pet");
        GameObject pet7 = GameObject.FindGameObjectWithTag("rock_pet");
        GameObject pet8 = GameObject.FindGameObjectWithTag("snake_Pet");
        GameObject pet9 = GameObject.FindGameObjectWithTag("worm_Pet");
        GameObject pet10 = GameObject.FindGameObjectWithTag("bee_Pet");
        GameObject pet11 = GameObject.FindGameObjectWithTag("red_dragon");
        Destroy(pet);
        Destroy(pet1);
        Destroy(pet2);
        Destroy(pet3);
        Destroy(pet4);
        Destroy(pet5);
        Destroy(pet6);
        Destroy(pet7);
        Destroy(pet8);
        Destroy(pet9);
        Destroy(pet10);
        Destroy(pet11);
        this.gameObject.SetActive(false);
    }
    public void EquipButton()
    {
        UnequipPetButton();
        switch (GameController.petList[index][0])
        {
            case "Jack-O-Lantern":
                if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                {
                    Instantiate(animals[1], player.transform.position, Quaternion.identity);
                }
                else if (int.Parse(GameController.petList[index][1]) >= 10)
                {
                    Instantiate(animals[2], player.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(animals[0], player.transform.position, Quaternion.identity);
                }

                GameController.petName = "pumpkin";
                break;

            case "Claws":
                if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                {
                    Instantiate(animals[4], player.transform.position, Quaternion.identity);
                }
                else if (int.Parse(GameController.petList[index][1]) >= 10)
                {
                    Instantiate(animals[5], player.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(animals[3], player.transform.position, Quaternion.identity);
                }

                GameController.petName = "crab";
                break;

            case "Golem":
                if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                {
                    Instantiate(animals[7], player.transform.position, Quaternion.identity);
                }
                else if (int.Parse(GameController.petList[index][1]) >= 10)
                {
                    Instantiate(animals[8], player.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(animals[6], player.transform.position, Quaternion.identity);
                }

                GameController.petName = "golem";
                break;

            case "Snow Wolf":
                if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                {
                    Instantiate(animals[10], player.transform.position, Quaternion.identity);
                }
                else if (int.Parse(GameController.petList[index][1]) >= 10)
                {
                    Instantiate(animals[11], player.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(animals[9], player.transform.position, Quaternion.identity);
                }

                GameController.petName = "snow wolf";
                break;

            case "Buzz":
                if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                {
                    Instantiate(animals[13], player.transform.position, Quaternion.identity);
                }
                else if (int.Parse(GameController.petList[index][1]) >= 10)
                {
                    Instantiate(animals[14], player.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(animals[12], player.transform.position, Quaternion.identity);
                }

                GameController.petName = "bee";
                break;

            case "Night Wolf":
                if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                {
                    Instantiate(animals[16], player.transform.position, Quaternion.identity);
                }
                else if (int.Parse(GameController.petList[index][1]) >= 10)
                {
                    Instantiate(animals[17], player.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(animals[15], player.transform.position, Quaternion.identity);
                }

                GameController.petName = "night wolf";
                break;

            case "Rumryss":
                if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                {
                    Instantiate(animals[19], player.transform.position, Quaternion.identity);
                }
                else if (int.Parse(GameController.petList[index][1]) >= 10)
                {
                    Instantiate(animals[20], player.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(animals[18], player.transform.position, Quaternion.identity);
                }

                GameController.petName = "snake";
                break;

            case "Wyvernldle":
                if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                {
                    Instantiate(animals[22], player.transform.position, Quaternion.identity);
                }
                else if (int.Parse(GameController.petList[index][1]) >= 10)
                {
                    Instantiate(animals[23], player.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(animals[21], player.transform.position, Quaternion.identity);
                }

                GameController.petName = "dragon";
                break;

            case "Dread Biter":
                if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                {
                    Instantiate(animals[25], player.transform.position, Quaternion.identity);
                }
                else if (int.Parse(GameController.petList[index][1]) >= 10)
                {
                    Instantiate(animals[26], player.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(animals[24], player.transform.position, Quaternion.identity);
                }

                GameController.petName = "worm";
                break;

            case "One Eye":
                if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                {
                    Instantiate(animals[28], player.transform.position, Quaternion.identity);
                }
                else if (int.Parse(GameController.petList[index][1]) >= 10)
                {
                    Instantiate(animals[29], player.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(animals[27], player.transform.position, Quaternion.identity);
                }

                GameController.petName = "eye ball";
                break;
            case "red dragon":
                if (int.Parse(GameController.petList[index][1]) >= 5 && int.Parse(GameController.petList[index][1]) < 10)
                {
                    Instantiate(animals[31], player.transform.position, Quaternion.identity);
                }
                else if (int.Parse(GameController.petList[index][1]) >= 10)
                {
                    Instantiate(animals[32], player.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(animals[30], player.transform.position, Quaternion.identity);
                }

                GameController.petName = "red dragon";
                break;
        }
        this.gameObject.SetActive(false);
    }

    public void atkPlusButton()
    {
        if (int.Parse(GameController.petList[index][10]) > 0 && int.Parse(GameController.petList[index][11]) + int.Parse(GameController.petList[index][5]) < 10)
        {
            clickSound.Play();
            int points = int.Parse(GameController.petList[index][10]) - 1;
            GameController.petList[index][10] = points.ToString();

            int bonusAtk = int.Parse(GameController.petList[index][11]) + 1;
            GameController.petList[index][11] = bonusAtk.ToString();
            for (int i = 1; i <= usedPetList.Count; i++)
            {
                if (usedPetList[i][0] == GameController.petList[index][0])
                {
                    usedPetList[i][11] = bonusAtk.ToString();
                }
            }
        }
    }

    public void defPlusButton()
    {
        if (int.Parse(GameController.petList[index][10]) > 0 && int.Parse(GameController.petList[index][12]) + int.Parse(GameController.petList[index][6]) < 10)
        {
            clickSound.Play();
            int points = int.Parse(GameController.petList[index][10]) - 1;
            GameController.petList[index][10] = points.ToString();

            int bonusAtk = int.Parse(GameController.petList[index][12]) + 1;
            GameController.petList[index][12] = bonusAtk.ToString();
            for (int i = 1; i <= usedPetList.Count; i++)
            {
                if (usedPetList[i][0] == GameController.petList[index][0])
                {
                    usedPetList[i][12] = bonusAtk.ToString();
                }
            }
        }
    }

    public void spPlusButton()
    {
        if (int.Parse(GameController.petList[index][10]) > 0 && int.Parse(GameController.petList[index][13]) + int.Parse(GameController.petList[index][7]) < 10)
        {
            clickSound.Play();
            int points = int.Parse(GameController.petList[index][10]) - 1;
            GameController.petList[index][10] = points.ToString();

            int bonusAtk = int.Parse(GameController.petList[index][13]) + 1;
            GameController.petList[index][13] = bonusAtk.ToString();
            for (int i = 1; i <= usedPetList.Count; i++)
            {
                if (usedPetList[i][0] == GameController.petList[index][0])
                {
                    usedPetList[i][13] = bonusAtk.ToString();
                }
            }
        }
    }

    public void agiPlusButton()
    {
        if (int.Parse(GameController.petList[index][10]) > 0 && int.Parse(GameController.petList[index][14]) + int.Parse(GameController.petList[index][8]) < 10)
        {
            clickSound.Play();
            int points = int.Parse(GameController.petList[index][10]) - 1;
            GameController.petList[index][10] = points.ToString();

            int bonusAtk = int.Parse(GameController.petList[index][14]) + 1;
            GameController.petList[index][14] = bonusAtk.ToString();
            for (int i = 1; i <= usedPetList.Count; i++)
            {
                if (usedPetList[i][0] == GameController.petList[index][0])
                {
                    usedPetList[i][14] = bonusAtk.ToString();
                }
            }

        }
    }

    public void hpPlusButton()
    {
        if (int.Parse(GameController.petList[index][10]) > 0 && int.Parse(GameController.petList[index][15]) + int.Parse(GameController.petList[index][9]) < 10)
        {
            clickSound.Play();
            int points = int.Parse(GameController.petList[index][10]) - 1;
            GameController.petList[index][10] = points.ToString();

            int bonusAtk = int.Parse(GameController.petList[index][15]) + 1;
            GameController.petList[index][15] = bonusAtk.ToString();
            for (int i = 1; i <= usedPetList.Count; i++)
            {
                if (usedPetList[i][0] == GameController.petList[index][0])
                {
                    usedPetList[i][15] = bonusAtk.ToString();
                }
            }
        }
    }

    public void usePetButton(int a)
    {
        if (usedPetList.Count < 3)
        {
            effects[usedPetListIndex].SetActive(true);
            staticEffects[usedPetListIndex].SetActive(false);
            clickSound.Play();
            usedPetList.Add(++usedPetListIndex, GameController.petList[a + 1]);
            usedPetsImage[usedPetListIndex - 1].sprite = petsImage[a].sprite;
            useButtons[a].SetActive(false);
            removeButton[usedPetListIndex - 1].SetActive(true);

        }
    }

    public void removePetButton(int a)
    {
        clickSound.Play();
        usedPetListIndex--;
        removeButton[a].SetActive(false);
        effects[a].SetActive(false);
        staticEffects[a].SetActive(true);
        if (usedPetList.Count == 1)
        {
            usedPetList.Remove(1);
        }
        else
        {
            usedPetList.Remove(a + 1);

        }
        Debug.Log(usedPetsImage[a].sprite.name);
        switch (usedPetsImage[a].sprite.name)
        {
            case "pumpking_24":
                for (int i = 0; i < petsImage.Length; i++)
                {
                    if (petsImage[i].sprite.name == "pumpking_24")
                    {
                        useButtons[i].SetActive(true);
                        break;
                    }
                }
                break;
            case "Crab_Idle_4":
                for (int i = 0; i < petsImage.Length; i++)
                {
                    if (petsImage[i].sprite.name == "Crab_Idle_4")
                    {
                        useButtons[i].SetActive(true);
                        break;
                    }
                }
                break;
            case "Golem_IdleB_4":
                for (int i = 0; i < petsImage.Length; i++)
                {
                    if (petsImage[i].sprite.name == "Golem_IdleB_4")
                    {
                        useButtons[i].SetActive(true);
                        break;
                    }
                }
                break;
            case "Canine_White_Idle_4":
                for (int i = 0; i < petsImage.Length; i++)
                {
                    if (petsImage[i].sprite.name == "Canine_White_Idle_4")
                    {
                        useButtons[i].SetActive(true);
                        break;
                    }
                }
                break;
            case "bee_spritesheet_0":
                for (int i = 0; i < petsImage.Length; i++)
                {
                    if (petsImage[i].sprite.name == "bee_spritesheet_0")
                    {
                        useButtons[i].SetActive(true);
                        break;
                    }
                }
                break;
            case "Canine_Black_Idle_4":
                for (int i = 0; i < petsImage.Length; i++)
                {
                    if (petsImage[i].sprite.name == "Canine_Black_Idle_4")
                    {
                        useButtons[i].SetActive(true);
                        break;
                    }
                }
                break;
            case "snake_28":
                for (int i = 0; i < petsImage.Length; i++)
                {
                    if (petsImage[i].sprite.name == "snake_28")
                    {
                        useButtons[i].SetActive(true);
                        break;
                    }
                }
                break;
            case "GreatWyvernIdleSide_0":
                for (int i = 0; i < petsImage.Length; i++)
                {
                    if (petsImage[i].sprite.name == "GreatWyvernIdleSide_0")
                    {
                        useButtons[i].SetActive(true);
                        break;
                    }
                }
                break;
            case "small_worm_37":
                for (int i = 0; i < petsImage.Length; i++)
                {
                    if (petsImage[i].sprite.name == "small_worm_37")
                    {
                        useButtons[i].SetActive(true);
                        break;
                    }
                }
                break;
            case "eyeball_28":
                for (int i = 0; i < petsImage.Length; i++)
                {
                    if (petsImage[i].sprite.name == "eyeball_28")
                    {
                        useButtons[i].SetActive(true);
                        break;
                    }
                }
                break;
            case "reddragonfly_7":
                for (int i = 0; i < petsImage.Length; i++)
                {
                    if (petsImage[i].sprite.name == "reddragonfly_7")
                    {
                        useButtons[i].SetActive(true);
                        break;
                    }
                }
                break;
        }
        usedPetsImage[a].sprite = empty;


        GameController.pet1AtkBonus = 0;
        GameController.pet1DefBonus = 0;
        GameController.pet1SpBonus = 0;
        GameController.pet1AgiBonus = 0;
        GameController.pet1HpBonus = 0;

        GameController.pet2AtkBonus = 0;
        GameController.pet2DefBonus = 0;
        GameController.pet2SpBonus = 0;
        GameController.pet2AgiBonus = 0;
        GameController.pet2HpBonus = 0;

        GameController.pet3AtkBonus = 0;
        GameController.pet3DefBonus = 0;
        GameController.pet3SpBonus = 0;
        GameController.pet3AgiBonus = 0;
        GameController.pet3HpBonus = 0;

        if (usedPetList.Count > 0)
        {
            foreach (KeyValuePair<int, string[]> kvp in usedPetList)
            {
                switch (usedPetList.Count)
                {
                    case 1:
                        switch (kvp.Key)
                        {
                            case 2:
                                string[] value = usedPetList[2];
                                usedPetList.Clear();
                                usedPetList.Add(1, value);
                                usedPetsImage[0].sprite = usedPetsImage[1].sprite;
                                usedPetsImage[1].sprite = empty;
                                removeButton[0].SetActive(true);
                                removeButton[1].SetActive(false);
                                staticEffects[1].SetActive(true);
                                effects[1].SetActive(false);
                                staticEffects[0].SetActive(false);
                                effects[0].SetActive(true);
                                break;

                            case 3:
                                string[] value1 = usedPetList[3];
                                usedPetList.Clear();
                                usedPetList.Add(1, value1);
                                usedPetsImage[0].sprite = usedPetsImage[2].sprite;
                                usedPetsImage[2].sprite = empty;
                                removeButton[0].SetActive(true);
                                removeButton[2].SetActive(false);
                                staticEffects[2].SetActive(true);
                                effects[2].SetActive(false);
                                staticEffects[0].SetActive(false);
                                effects[0].SetActive(true);
                                break;
                        }
                        break;
                    case 2:
                        if (usedPetList.ContainsKey(1) && usedPetList.ContainsKey(3))
                        {
                            string[] value = usedPetList[1];
                            string[] value1 = usedPetList[3];
                            usedPetList.Clear();
                            usedPetList.Add(1, value);
                            usedPetList.Add(2, value1);

                            usedPetsImage[1].sprite = usedPetsImage[2].sprite;
                            usedPetsImage[2].sprite = empty;
                            removeButton[0].SetActive(true);
                            removeButton[1].SetActive(true);
                            removeButton[2].SetActive(false);
                            staticEffects[0].SetActive(false);
                            effects[0].SetActive(true);
                            staticEffects[1].SetActive(false);
                            effects[1].SetActive(true);
                            staticEffects[2].SetActive(true);
                            effects[2].SetActive(false);
                        }
                        else if (usedPetList.ContainsKey(2) && usedPetList.ContainsKey(3))
                        {
                            string[] value = usedPetList[2];
                            string[] value1 = usedPetList[3];
                            usedPetList.Clear();
                            usedPetList.Add(1, value);
                            usedPetList.Add(2, value1);
                            usedPetsImage[0].sprite = usedPetsImage[1].sprite;
                            usedPetsImage[1].sprite = empty;
                            usedPetsImage[1].sprite = usedPetsImage[2].sprite;
                            usedPetsImage[2].sprite = empty;
                            removeButton[0].SetActive(true);
                            removeButton[1].SetActive(true);
                            removeButton[2].SetActive(false);
                            staticEffects[0].SetActive(false);
                            effects[0].SetActive(true);
                            staticEffects[1].SetActive(false);
                            effects[1].SetActive(true);
                            staticEffects[2].SetActive(true);
                            effects[2].SetActive(false);
                        }
                        break;
                }
            }
        }
    }
    public void resetButton()
    {
        alert1.SetActive(true);
    }
    public void ConfirmReset()
    {
        if (GameController.diamonds > 99)
        {
            GameController.diamonds -= 100;
            int atk = int.Parse(GameController.petList[index][11]);
            int def = int.Parse(GameController.petList[index][12]);
            int sp = int.Parse(GameController.petList[index][13]);
            int agi = int.Parse(GameController.petList[index][14]);
            int hp = int.Parse(GameController.petList[index][15]);

            int point = atk + def + sp + agi + hp;
            Debug.Log(point);
            GameController.petList[index][10] = (int.Parse(GameController.petList[index][10]) + point).ToString();
            GameController.petList[index][11] = "0";
            GameController.petList[index][12] = "0";
            GameController.petList[index][13] = "0";
            GameController.petList[index][14] = "0";
            GameController.petList[index][15] = "0";
            alert1.SetActive(false);
        }
        else
        {
            var forgedTxt = Instantiate(notEnoughText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(petsPanel.transform, false);
            forgedTxt.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
            Destroy(forgedTxt, 0.5f);
        }
    }

    public void closeAlert()
    {
        alert1.SetActive(false);
    }
    public void CloseAlert()
    {
        alert.SetActive(false);
    }

    IEnumerator showAlert()
    {
        yield return new WaitForSeconds(3f);
        alert.SetActive(true);
    }

    public void bookButton()
    {
        book.SetActive(true);
        animalPanel.SetActive(false);
    }
    public void bookNextButton()
    {
        if (BookIndex < 5 && BookIndex >= 0)
        {
            flipSound.Play();
            BookIndex++;
            switch (BookIndex)
            {
                case 1:
                    page[0].SetActive(true);
                    page[1].SetActive(false);
                    page[2].SetActive(true);
                    page[3].SetActive(true);
                    page[4].SetActive(false);
                    page[5].SetActive(true);
                    page[6].SetActive(false);
                    page[7].SetActive(true);
                    page[8].SetActive(false);
                    page[9].SetActive(true);
                    page[10].SetActive(false);
                    page[11].SetActive(true);

                    break;
                case 2:
                    page[0].SetActive(true);
                    page[1].SetActive(false);
                    page[2].SetActive(true);
                    page[3].SetActive(false);
                    page[4].SetActive(true);
                    page[5].SetActive(true);
                    page[6].SetActive(false);
                    page[7].SetActive(true);
                    page[8].SetActive(false);
                    page[9].SetActive(true);
                    page[10].SetActive(false);
                    page[11].SetActive(true);
                    break;
                case 3:
                    page[0].SetActive(true);
                    page[1].SetActive(false);
                    page[2].SetActive(true);
                    page[3].SetActive(false);
                    page[4].SetActive(true);
                    page[5].SetActive(false);
                    page[6].SetActive(true);
                    page[7].SetActive(true);
                    page[8].SetActive(false);
                    page[9].SetActive(true);
                    page[10].SetActive(false);
                    page[11].SetActive(true);
                    break;
                case 4:
                    page[0].SetActive(true);
                    page[1].SetActive(false);
                    page[2].SetActive(true);
                    page[3].SetActive(false);
                    page[4].SetActive(true);
                    page[5].SetActive(false);
                    page[6].SetActive(true);
                    page[7].SetActive(false);
                    page[8].SetActive(true);
                    page[9].SetActive(true);
                    page[10].SetActive(false);
                    page[11].SetActive(true);
                    break;
                case 5:
                    page[0].SetActive(true);
                    page[1].SetActive(false);
                    page[2].SetActive(true);
                    page[3].SetActive(false);
                    page[4].SetActive(true);
                    page[5].SetActive(false);
                    page[6].SetActive(true);
                    page[7].SetActive(false);
                    page[8].SetActive(true);
                    page[9].SetActive(false);
                    page[10].SetActive(true);
                    page[11].SetActive(true);
                    break;
            }
        }

    }
    public void bookPreviousButton()
    {
        if (BookIndex <= 5 && BookIndex > 0)
        {
            flipSound.Play();
            BookIndex--;
            switch (BookIndex)
            {
                case 0:
                    page[0].SetActive(true);
                    page[1].SetActive(true);
                    page[2].SetActive(false);
                    page[3].SetActive(true);
                    page[4].SetActive(false);
                    page[5].SetActive(true);
                    page[6].SetActive(false);
                    page[7].SetActive(true);
                    page[8].SetActive(false);
                    page[9].SetActive(true);
                    page[10].SetActive(false);
                    page[11].SetActive(true);
                    break;
                case 1:
                    page[0].SetActive(true);
                    page[1].SetActive(false);
                    page[2].SetActive(true);
                    page[3].SetActive(true);
                    page[4].SetActive(false);
                    page[5].SetActive(true);
                    page[6].SetActive(false);
                    page[7].SetActive(true);
                    page[8].SetActive(false);
                    page[9].SetActive(true);
                    page[10].SetActive(false);
                    page[11].SetActive(true);

                    break;
                case 2:
                    page[0].SetActive(true);
                    page[1].SetActive(false);
                    page[2].SetActive(true);
                    page[3].SetActive(false);
                    page[4].SetActive(true);
                    page[5].SetActive(true);
                    page[6].SetActive(false);
                    page[7].SetActive(true);
                    page[8].SetActive(false);
                    page[9].SetActive(true);
                    page[10].SetActive(false);
                    page[11].SetActive(true);
                    break;
                case 3:
                    page[0].SetActive(true);
                    page[1].SetActive(false);
                    page[2].SetActive(true);
                    page[3].SetActive(false);
                    page[4].SetActive(true);
                    page[5].SetActive(false);
                    page[6].SetActive(true);
                    page[7].SetActive(true);
                    page[8].SetActive(false);
                    page[9].SetActive(true);
                    page[10].SetActive(false);
                    page[11].SetActive(true);
                    break;
                case 4:
                    page[0].SetActive(true);
                    page[1].SetActive(false);
                    page[2].SetActive(true);
                    page[3].SetActive(false);
                    page[4].SetActive(true);
                    page[5].SetActive(false);
                    page[6].SetActive(true);
                    page[7].SetActive(false);
                    page[8].SetActive(true);
                    page[9].SetActive(true);
                    page[10].SetActive(false);
                    page[11].SetActive(true);
                    break;

            }
        }

    }
}
