using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eggShop : MonoBehaviour
{
    /* egg add to dic
     * 0 : name / 1 : level / 2 : xp / 3 : MaxXpNeeded / 4 : stars / 5 : BaseAtk / 6 : BaseDef / 7 : BaseSp / 8 : BaseAgi / 9 : BaseHp / 10: stats points /11 : BonusAtk / 12 : BonusDef / 13 : BonusSp / 14 : BonusAgi / 15 : BonusHp
    */
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

    // stats 

    public Image[] petsImage;
    public static Dictionary<int, string[]> usedPetList = new Dictionary<int, string[]>();
    public static Dictionary<int, string[]> savedUsedPetList = new Dictionary<int, string[]>();
    public static int usedPetListIndex = 0;
    public Image[] usedPetsImage;
    public GameObject[] useButtons;

    private int Atk2starsPet = 5;
    private int Atk3starsPet = 7;
    private int Atk4starsPet = 10;
    private int Atk5starsPet = 20;

    private int Def2starsPet = 5;
    private int Def3starsPet = 7;
    private int Def4starsPet = 10;
    private int Def5starsPet = 20;

    private int Sp2starsPet = 3;
    private int Sp3starsPet = 5;
    private int Sp4starsPet = 7;
    private int Sp5starsPet = 10;

    private int Agi2starsPet = 3;
    private int Agi3starsPet = 5;
    private int Agi4starsPet = 7;
    private int Agi5starsPet = 10;

    private int Hp2starsPet = 10;
    private int Hp3starsPet = 15;
    private int Hp4starsPet = 20;
    private int Hp5starsPet = 30;

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
 

    void Start()
    {
        //savedUsedPetList.Clear();
        //usedPetList.Clear();
        //GameController.petList.Clear();
        //pets

        FoodBar.SetMaxFood(int.Parse(GameController.petList[index][3]));
        FoodBar.SetFood(int.Parse(GameController.petList[index][2]));
     
        if (GameController.petList.Count > 0) {
            for (int i = 1; i <= GameController.petList.Count; i++)
            {
                useButtons[i-1].SetActive(true);
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

                }
            }
        }

        if (savedUsedPetList[1][0] != null && savedUsedPetList[2][0] == null && savedUsedPetList[3][0] == null)
        {
            usedPetList.Add(1, savedUsedPetList[1]);


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
        }
        else if (savedUsedPetList[1][0] != null && savedUsedPetList[2][0] != null && savedUsedPetList[3][0] == null)
        {
            usedPetList.Add(1, savedUsedPetList[1]);
            usedPetList.Add(2, savedUsedPetList[2]);

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
        }
        else if (savedUsedPetList[1][0] != null && savedUsedPetList[2][0] != null && savedUsedPetList[3][0] != null)
        {
            usedPetList.Add(1, savedUsedPetList[1]);
            usedPetList.Add(2, savedUsedPetList[2]);
            usedPetList.Add(3, savedUsedPetList[3]);

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
        }

        //usedPetList.Add(2, savedUsedPetList[2]);
        //usedPetList.Add(3, savedUsedPetList[3]);
        /* break;
     case 2:
         usedPetList.Add(1, eggShop.savedUsedPetList[1]);
         usedPetList.Add(2, eggShop.savedUsedPetList[2]);
         break;
     case 3:
         usedPetList.Add(1, eggShop.savedUsedPetList[1]);
         usedPetList.Add(2, eggShop.savedUsedPetList[2]);
         usedPetList.Add(3, eggShop.savedUsedPetList[3]);
         break;*/

        foreach (KeyValuePair<int, string[]> kvp in usedPetList)
            Debug.Log("Key = " + kvp.Key +" " + "value = "+ kvp.Value[5]);

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
            statsPanel.SetActive(true);

            petCount.text = index + "/" + GameController.petList.Count;
            petName.text = GameController.petList[index][0];
            petLevel.text = GameController.petList[index][1];
            FoodXpCounter.text = GameController.petList[index][2] + "/" + GameController.petList[index][3];
            BaseAtkText.text = GameController.petList[index][5].ToString() + "/10";
            BaseDefText.text = GameController.petList[index][6].ToString() + "/10";
            BaseSpText.text = GameController.petList[index][7].ToString() + "/10";
            BaseAgiText.text = GameController.petList[index][8].ToString() + "/10";
            BaseHpText.text = GameController.petList[index][9].ToString() + "/10";
            points.text = "stats points : " + GameController.petList[index][10].ToString();

            switch (usedPetList.Count)
            {
                case 0:
                    GameController.petAtkBonus = 0;
                    GameController.petDefBonus = 0;
                    GameController.petSpBonus = 0;
                    GameController.petAgiBonus = 0;
                    GameController.petHpBonus = 0;
                    break;
                case 1:

                    switch (usedPetList[1][4])
                    {
                        case "2":
                            GameController.pet1AtkBonus = int.Parse(usedPetList[1][5]) * Atk2starsPet + int.Parse(usedPetList[1][11]) * Atk2starsPet;
                            GameController.pet1DefBonus = int.Parse(usedPetList[1][6]) * Def2starsPet + int.Parse(usedPetList[1][12]) * Def2starsPet;
                            GameController.pet1SpBonus = int.Parse(usedPetList[1][7]) * Sp2starsPet + int.Parse(usedPetList[1][13]) * Sp2starsPet;
                            GameController.pet1AgiBonus = int.Parse(usedPetList[1][8]) * Agi2starsPet + int.Parse(usedPetList[1][14]) * Agi2starsPet;
                            GameController.pet1HpBonus = int.Parse(usedPetList[1][9]) * Hp2starsPet + int.Parse(usedPetList[1][15]) * Hp2starsPet;
                            break;
                        case "3":
                            GameController.pet1AtkBonus = int.Parse(usedPetList[1][5]) * Atk3starsPet + int.Parse(usedPetList[1][11]) * Atk3starsPet;
                            GameController.pet1DefBonus = int.Parse(usedPetList[1][6]) * Def3starsPet + int.Parse(usedPetList[1][12]) * Def3starsPet;
                            GameController.pet1SpBonus = int.Parse(usedPetList[1][7]) * Sp3starsPet + int.Parse(usedPetList[1][13]) * Sp3starsPet;
                            GameController.pet1AgiBonus = int.Parse(usedPetList[1][8]) * Agi3starsPet + int.Parse(usedPetList[1][14]) * Agi3starsPet;
                            GameController.pet1HpBonus = int.Parse(usedPetList[1][9]) * Hp3starsPet + int.Parse(usedPetList[1][15]) * Hp3starsPet;
                            break;
                        case "4":
                            GameController.pet1AtkBonus = int.Parse(usedPetList[1][5]) * Atk4starsPet + int.Parse(usedPetList[1][11]) * Atk4starsPet;
                            GameController.pet1DefBonus = int.Parse(usedPetList[1][6]) * Def4starsPet + int.Parse(usedPetList[1][12]) * Def4starsPet;
                            GameController.pet1SpBonus = int.Parse(usedPetList[1][7]) * Sp4starsPet + int.Parse(usedPetList[1][13]) * Sp4starsPet;
                            GameController.pet1AgiBonus = int.Parse(usedPetList[1][8]) * Agi4starsPet + int.Parse(usedPetList[1][14]) * Agi4starsPet;
                            GameController.pet1HpBonus = int.Parse(usedPetList[1][9]) * Hp4starsPet + int.Parse(usedPetList[1][15]) * Hp4starsPet;
                            break;
                        case "5":
                            GameController.pet1AtkBonus = int.Parse(usedPetList[1][5]) * Atk5starsPet + int.Parse(usedPetList[1][11]) * Atk5starsPet;
                            GameController.pet1DefBonus = int.Parse(usedPetList[1][6]) * Def5starsPet + int.Parse(usedPetList[1][12]) * Def5starsPet;
                            GameController.pet1SpBonus = int.Parse(usedPetList[1][7]) * Sp5starsPet + int.Parse(usedPetList[1][13]) * Sp5starsPet;
                            GameController.pet1AgiBonus = int.Parse(usedPetList[1][8]) * Agi5starsPet + int.Parse(usedPetList[1][14]) * Agi5starsPet;
                            GameController.pet1HpBonus = int.Parse(usedPetList[1][9]) * Hp5starsPet + int.Parse(usedPetList[1][15]) * Hp5starsPet;
                            break;

                    }

                    break;

                case 2:

                    switch (usedPetList[1][4])
                    {
                        case "2":
                            GameController.pet1AtkBonus = int.Parse(usedPetList[1][5]) * Atk2starsPet + int.Parse(usedPetList[1][11]) * Atk2starsPet;
                            GameController.pet1DefBonus = int.Parse(usedPetList[1][6]) * Def2starsPet + int.Parse(usedPetList[1][12]) * Def2starsPet;
                            GameController.pet1SpBonus = int.Parse(usedPetList[1][7]) * Sp2starsPet + int.Parse(usedPetList[1][13]) * Sp2starsPet;
                            GameController.pet1AgiBonus = int.Parse(usedPetList[1][8]) * Agi2starsPet + int.Parse(usedPetList[1][14]) * Agi2starsPet;
                            GameController.pet1HpBonus = int.Parse(usedPetList[1][9]) * Hp2starsPet + int.Parse(usedPetList[1][15]) * Hp2starsPet;
                            break;
                        case "3":
                            GameController.pet1AtkBonus = int.Parse(usedPetList[1][5]) * Atk3starsPet + int.Parse(usedPetList[1][11]) * Atk3starsPet;
                            GameController.pet1DefBonus = int.Parse(usedPetList[1][6]) * Def3starsPet + int.Parse(usedPetList[1][12]) * Def3starsPet;
                            GameController.pet1SpBonus = int.Parse(usedPetList[1][7]) * Sp3starsPet + int.Parse(usedPetList[1][13]) * Sp3starsPet;
                            GameController.pet1AgiBonus = int.Parse(usedPetList[1][8]) * Agi3starsPet + int.Parse(usedPetList[1][14]) * Agi3starsPet;
                            GameController.pet1HpBonus = int.Parse(usedPetList[1][9]) * Hp3starsPet + int.Parse(usedPetList[1][15]) * Hp3starsPet;
                            break;
                        case "4":
                            GameController.pet1AtkBonus = int.Parse(usedPetList[1][5]) * Atk4starsPet + int.Parse(usedPetList[1][11]) * Atk4starsPet;
                            GameController.pet1DefBonus = int.Parse(usedPetList[1][6]) * Def4starsPet + int.Parse(usedPetList[1][12]) * Def4starsPet;
                            GameController.pet1SpBonus = int.Parse(usedPetList[1][7]) * Sp4starsPet + int.Parse(usedPetList[1][13]) * Sp4starsPet;
                            GameController.pet1AgiBonus = int.Parse(usedPetList[1][8]) * Agi4starsPet + int.Parse(usedPetList[1][14]) * Agi4starsPet;
                            GameController.pet1HpBonus = int.Parse(usedPetList[1][9]) * Hp4starsPet + int.Parse(usedPetList[1][15]) * Hp4starsPet;
                            break;
                        case "5":
                            GameController.pet1AtkBonus = int.Parse(usedPetList[1][5]) * Atk5starsPet + int.Parse(usedPetList[1][11]) * Atk5starsPet;
                            GameController.pet1DefBonus = int.Parse(usedPetList[1][6]) * Def5starsPet + int.Parse(usedPetList[1][12]) * Def5starsPet;
                            GameController.pet1SpBonus = int.Parse(usedPetList[1][7]) * Sp5starsPet + int.Parse(usedPetList[1][13]) * Sp5starsPet;
                            GameController.pet1AgiBonus = int.Parse(usedPetList[1][8]) * Agi5starsPet + int.Parse(usedPetList[1][14]) * Agi5starsPet;
                            GameController.pet1HpBonus = int.Parse(usedPetList[1][9]) * Hp5starsPet + int.Parse(usedPetList[1][15]) * Hp5starsPet;
                            break;

                    }


                    switch (usedPetList[2][4])
                    {
                        case "2":
                            GameController.pet2AtkBonus = int.Parse(usedPetList[2][5]) * Atk2starsPet + int.Parse(usedPetList[2][11]) * Atk2starsPet;
                            GameController.pet2DefBonus = int.Parse(usedPetList[2][6]) * Def2starsPet + int.Parse(usedPetList[2][12]) * Def2starsPet;
                            GameController.pet2SpBonus = int.Parse(usedPetList[2][7]) * Sp2starsPet + int.Parse(usedPetList[2][13]) * Sp2starsPet;
                            GameController.pet2AgiBonus = int.Parse(usedPetList[2][8]) * Agi2starsPet + int.Parse(usedPetList[2][14]) * Agi2starsPet;
                            GameController.pet2HpBonus = int.Parse(usedPetList[2][9]) * Hp2starsPet + int.Parse(usedPetList[2][15]) * Hp2starsPet;
                            break;
                        case "3":
                            GameController.pet2AtkBonus = int.Parse(usedPetList[2][5]) * Atk3starsPet + int.Parse(usedPetList[2][11]) * Atk3starsPet;
                            GameController.pet2DefBonus = int.Parse(usedPetList[2][6]) * Def3starsPet + int.Parse(usedPetList[2][12]) * Def3starsPet;
                            GameController.pet2SpBonus = int.Parse(usedPetList[2][7]) * Sp3starsPet + int.Parse(usedPetList[2][13]) * Sp3starsPet;
                            GameController.pet2AgiBonus = int.Parse(usedPetList[2][8]) * Agi3starsPet + int.Parse(usedPetList[2][14]) * Agi3starsPet;
                            GameController.pet2HpBonus = int.Parse(usedPetList[2][9]) * Hp3starsPet + int.Parse(usedPetList[2][15]) * Hp3starsPet;
                            break;
                        case "4":
                            GameController.pet2AtkBonus = int.Parse(usedPetList[2][5]) * Atk4starsPet + int.Parse(usedPetList[2][11]) * Atk4starsPet;
                            GameController.pet2DefBonus = int.Parse(usedPetList[2][6]) * Def4starsPet + int.Parse(usedPetList[2][12]) * Def4starsPet;
                            GameController.pet2SpBonus = int.Parse(usedPetList[2][7]) * Sp4starsPet + int.Parse(usedPetList[2][13]) * Sp4starsPet;
                            GameController.pet2AgiBonus = int.Parse(usedPetList[2][8]) * Agi4starsPet + int.Parse(usedPetList[2][14]) * Agi4starsPet;
                            GameController.pet2HpBonus = int.Parse(usedPetList[2][9]) * Hp4starsPet + int.Parse(usedPetList[2][15]) * Hp4starsPet;
                            break;
                        case "5":
                            GameController.pet2AtkBonus = int.Parse(usedPetList[2][5]) * Atk5starsPet + int.Parse(usedPetList[2][11]) * Atk5starsPet;
                            GameController.pet2DefBonus = int.Parse(usedPetList[2][6]) * Def5starsPet + int.Parse(usedPetList[2][12]) * Def5starsPet;
                            GameController.pet2SpBonus = int.Parse(usedPetList[2][7]) * Sp5starsPet + int.Parse(usedPetList[2][13]) * Sp5starsPet;
                            GameController.pet2AgiBonus = int.Parse(usedPetList[2][8]) * Agi5starsPet + int.Parse(usedPetList[2][14]) * Agi5starsPet;
                            GameController.pet2HpBonus = int.Parse(usedPetList[2][9]) * Hp5starsPet + int.Parse(usedPetList[2][15]) * Hp5starsPet;
                            break;

                    }
                    break;

                case 3:

                    switch (usedPetList[1][4])
                    {
                        case "2":
                            GameController.pet1AtkBonus = int.Parse(usedPetList[1][5]) * Atk2starsPet + int.Parse(usedPetList[1][11]) * Atk2starsPet;
                            GameController.pet1DefBonus = int.Parse(usedPetList[1][6]) * Def2starsPet + int.Parse(usedPetList[1][12]) * Def2starsPet;
                            GameController.pet1SpBonus = int.Parse(usedPetList[1][7]) * Sp2starsPet + int.Parse(usedPetList[1][13]) * Sp2starsPet;
                            GameController.pet1AgiBonus = int.Parse(usedPetList[1][8]) * Agi2starsPet + int.Parse(usedPetList[1][14]) * Agi2starsPet;
                            GameController.pet1HpBonus = int.Parse(usedPetList[1][9]) * Hp2starsPet + int.Parse(usedPetList[1][15]) * Hp2starsPet;
                            break;
                        case "3":
                            GameController.pet1AtkBonus = int.Parse(usedPetList[1][5]) * Atk3starsPet + int.Parse(usedPetList[1][11]) * Atk3starsPet;
                            GameController.pet1DefBonus = int.Parse(usedPetList[1][6]) * Def3starsPet + int.Parse(usedPetList[1][12]) * Def3starsPet;
                            GameController.pet1SpBonus = int.Parse(usedPetList[1][7]) * Sp3starsPet + int.Parse(usedPetList[1][13]) * Sp3starsPet;
                            GameController.pet1AgiBonus = int.Parse(usedPetList[1][8]) * Agi3starsPet + int.Parse(usedPetList[1][14]) * Agi3starsPet;
                            GameController.pet1HpBonus = int.Parse(usedPetList[1][9]) * Hp3starsPet + int.Parse(usedPetList[1][15]) * Hp3starsPet;
                            break;
                        case "4":
                            GameController.pet1AtkBonus = int.Parse(usedPetList[1][5]) * Atk4starsPet + int.Parse(usedPetList[1][11]) * Atk4starsPet;
                            GameController.pet1DefBonus = int.Parse(usedPetList[1][6]) * Def4starsPet + int.Parse(usedPetList[1][12]) * Def4starsPet;
                            GameController.pet1SpBonus = int.Parse(usedPetList[1][7]) * Sp4starsPet + int.Parse(usedPetList[1][13]) * Sp4starsPet;
                            GameController.pet1AgiBonus = int.Parse(usedPetList[1][8]) * Agi4starsPet + int.Parse(usedPetList[1][14]) * Agi4starsPet;
                            GameController.pet1HpBonus = int.Parse(usedPetList[1][9]) * Hp4starsPet + int.Parse(usedPetList[1][15]) * Hp4starsPet;
                            break;
                        case "5":
                            GameController.pet1AtkBonus = int.Parse(usedPetList[1][5]) * Atk5starsPet + int.Parse(usedPetList[1][11]) * Atk5starsPet;
                            GameController.pet1DefBonus = int.Parse(usedPetList[1][6]) * Def5starsPet + int.Parse(usedPetList[1][12]) * Def5starsPet;
                            GameController.pet1SpBonus = int.Parse(usedPetList[1][7]) * Sp5starsPet + int.Parse(usedPetList[1][13]) * Sp5starsPet;
                            GameController.pet1AgiBonus = int.Parse(usedPetList[1][8]) * Agi5starsPet + int.Parse(usedPetList[1][14]) * Agi5starsPet;
                            GameController.pet1HpBonus = int.Parse(usedPetList[1][9]) * Hp5starsPet + int.Parse(usedPetList[1][15]) * Hp5starsPet;
                            break;
                    }


                    switch (usedPetList[2][4])
                    {
                        case "2":
                            GameController.pet2AtkBonus = int.Parse(usedPetList[2][5]) * Atk2starsPet + int.Parse(usedPetList[2][11]) * Atk2starsPet;
                            GameController.pet2DefBonus = int.Parse(usedPetList[2][6]) * Def2starsPet + int.Parse(usedPetList[2][12]) * Def2starsPet;
                            GameController.pet2SpBonus = int.Parse(usedPetList[2][7]) * Sp2starsPet + int.Parse(usedPetList[2][13]) * Sp2starsPet;
                            GameController.pet2AgiBonus = int.Parse(usedPetList[2][8]) * Agi2starsPet + int.Parse(usedPetList[2][14]) * Agi2starsPet;
                            GameController.pet2HpBonus = int.Parse(usedPetList[2][9]) * Hp2starsPet + int.Parse(usedPetList[2][15]) * Hp2starsPet;
                            break;
                        case "3":
                            GameController.pet2AtkBonus = int.Parse(usedPetList[2][5]) * Atk3starsPet + int.Parse(usedPetList[2][11]) * Atk3starsPet;
                            GameController.pet2DefBonus = int.Parse(usedPetList[2][6]) * Def3starsPet + int.Parse(usedPetList[2][12]) * Def3starsPet;
                            GameController.pet2SpBonus = int.Parse(usedPetList[2][7]) * Sp3starsPet + int.Parse(usedPetList[2][13]) * Sp3starsPet;
                            GameController.pet2AgiBonus = int.Parse(usedPetList[2][8]) * Agi3starsPet + int.Parse(usedPetList[2][14]) * Agi3starsPet;
                            GameController.pet2HpBonus = int.Parse(usedPetList[2][9]) * Hp3starsPet + int.Parse(usedPetList[2][15]) * Hp3starsPet;
                            break;
                        case "4":
                            GameController.pet2AtkBonus = int.Parse(usedPetList[2][5]) * Atk4starsPet + int.Parse(usedPetList[2][11]) * Atk4starsPet;
                            GameController.pet2DefBonus = int.Parse(usedPetList[2][6]) * Def4starsPet + int.Parse(usedPetList[2][12]) * Def4starsPet;
                            GameController.pet2SpBonus = int.Parse(usedPetList[2][7]) * Sp4starsPet + int.Parse(usedPetList[2][13]) * Sp4starsPet;
                            GameController.pet2AgiBonus = int.Parse(usedPetList[2][8]) * Agi4starsPet + int.Parse(usedPetList[2][14]) * Agi4starsPet;
                            GameController.pet2HpBonus = int.Parse(usedPetList[2][9]) * Hp4starsPet + int.Parse(usedPetList[2][15]) * Hp4starsPet;
                            break;
                        case "5":
                            GameController.pet2AtkBonus = int.Parse(usedPetList[2][5]) * Atk5starsPet + int.Parse(usedPetList[2][11]) * Atk5starsPet;
                            GameController.pet2DefBonus = int.Parse(usedPetList[2][6]) * Def5starsPet + int.Parse(usedPetList[2][12]) * Def5starsPet;
                            GameController.pet2SpBonus = int.Parse(usedPetList[2][7]) * Sp5starsPet + int.Parse(usedPetList[2][13]) * Sp5starsPet;
                            GameController.pet2AgiBonus = int.Parse(usedPetList[2][8]) * Agi5starsPet + int.Parse(usedPetList[2][14]) * Agi5starsPet;
                            GameController.pet2HpBonus = int.Parse(usedPetList[2][9]) * Hp5starsPet + int.Parse(usedPetList[2][15]) * Hp5starsPet;
                            break;
                    }
                    switch (usedPetList[3][4])
                    {

                        case "2":
                            GameController.pet3AtkBonus = int.Parse(usedPetList[3][5]) * Atk2starsPet + int.Parse(usedPetList[3][11]) * Atk2starsPet;
                            GameController.pet3DefBonus = int.Parse(usedPetList[3][6]) * Def2starsPet + int.Parse(usedPetList[3][12]) * Def2starsPet;
                            GameController.pet3SpBonus = int.Parse(usedPetList[3][7]) * Sp2starsPet + int.Parse(usedPetList[3][13]) * Sp2starsPet;
                            GameController.pet3AgiBonus = int.Parse(usedPetList[3][8]) * Agi2starsPet + int.Parse(usedPetList[3][14]) * Agi2starsPet;
                            GameController.pet3HpBonus = int.Parse(usedPetList[3][9]) * Hp2starsPet + int.Parse(usedPetList[3][15]) * Hp2starsPet;
                            break;
                        case "3":
                            GameController.pet3AtkBonus = int.Parse(usedPetList[3][5]) * Atk3starsPet + int.Parse(usedPetList[3][11]) * Atk3starsPet;
                            GameController.pet3DefBonus = int.Parse(usedPetList[3][6]) * Def3starsPet + int.Parse(usedPetList[3][12]) * Def3starsPet;
                            GameController.pet3SpBonus = int.Parse(usedPetList[3][7]) * Sp3starsPet + int.Parse(usedPetList[3][13]) * Sp3starsPet;
                            GameController.pet3AgiBonus = int.Parse(usedPetList[3][8]) * Agi3starsPet + int.Parse(usedPetList[3][14]) * Agi3starsPet;
                            GameController.pet3HpBonus = int.Parse(usedPetList[3][9]) * Hp3starsPet + int.Parse(usedPetList[3][15]) * Hp3starsPet;

                            break;
                        case "4":
                            GameController.pet3AtkBonus = int.Parse(usedPetList[3][5]) * Atk4starsPet + int.Parse(usedPetList[3][11]) * Atk4starsPet;
                            GameController.pet3DefBonus = int.Parse(usedPetList[3][6]) * Def4starsPet + int.Parse(usedPetList[3][12]) * Def4starsPet;
                            GameController.pet3SpBonus = int.Parse(usedPetList[3][7]) * Sp4starsPet + int.Parse(usedPetList[3][13]) * Sp4starsPet;
                            GameController.pet3AgiBonus = int.Parse(usedPetList[3][8]) * Agi4starsPet + int.Parse(usedPetList[3][14]) * Agi4starsPet;
                            GameController.pet3HpBonus = int.Parse(usedPetList[3][9]) * Hp4starsPet + int.Parse(usedPetList[3][15]) * Hp4starsPet;

                            break;
                        case "5":
                            GameController.pet3AtkBonus = int.Parse(usedPetList[3][5]) * Atk5starsPet + int.Parse(usedPetList[3][11]) * Atk5starsPet;
                            GameController.pet3DefBonus = int.Parse(usedPetList[3][6]) * Def5starsPet + int.Parse(usedPetList[3][12]) * Def5starsPet;
                            GameController.pet3SpBonus = int.Parse(usedPetList[3][7]) * Sp5starsPet + int.Parse(usedPetList[3][13]) * Sp5starsPet;
                            GameController.pet3AgiBonus = int.Parse(usedPetList[3][8]) * Agi5starsPet + int.Parse(usedPetList[3][14]) * Agi5starsPet;
                            GameController.pet3HpBonus = int.Parse(usedPetList[3][9]) * Hp5starsPet + int.Parse(usedPetList[3][15]) * Hp5starsPet;
                            break;

                    }
                    break;
            }
            
            GameController.petAtkBonus = GameController.pet1AtkBonus + GameController.pet2AtkBonus + GameController.pet3AtkBonus;
            GameController.petDefBonus = GameController.pet1DefBonus + GameController.pet2DefBonus + GameController.pet3DefBonus;
            GameController.petSpBonus = GameController.pet1SpBonus + GameController.pet2SpBonus + GameController.pet3SpBonus;
            GameController.petAgiBonus = GameController.pet1AgiBonus + GameController.pet2AgiBonus + GameController.pet3AgiBonus;
            GameController.petHpBonus = GameController.pet1HpBonus + GameController.pet2HpBonus + GameController.pet3HpBonus;
          
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
                    petImage.sprite = Pets[0];
                    break;
                case "Claws":
                    petImage.sprite = Pets[1];
                    break;
                case "Golem":
                    petImage.sprite = Pets[2];
                    break;
                case "Snow Wolf":
                    petImage.sprite = Pets[3];
                    break;
                case "Buzz":
                    petImage.sprite = Pets[4];
                    break;
                case "Night Wolf":
                    petImage.sprite = Pets[5];
                    break;
                case "Rumryss":
                    petImage.sprite = Pets[6];
                    break;
                case "Wyvernldle":
                    petImage.sprite = Pets[7];
                    break;
                case "Dread Biter":
                    petImage.sprite = Pets[8];
                    break;
                case "One Eye":
                    petImage.sprite = Pets[9];
                    break;
            }
        }
        else
        {
            foodLevels.SetActive(false);
            feedUIButton.SetActive(false);
            equipUIButton.SetActive(false);
            statsPanel.SetActive(false);
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
            if(eggsNumber == requiredEggs[0])
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
        eggsPanel.SetActive(true);
        petsPanel.SetActive(false);
        statPanel.SetActive(false);
    }

    public void statsButton()
    {
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

                            GameController.petList.Add(++petListIndex, new string[] { "Jack-O-Lantern", "1", "0", "10", "4", "5", "6", "3", "2", "4", "0", "0", "0", "0", "0", "0" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[0];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
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
                            GameController.petList.Add(++petListIndex, new string[] { "Claws", "1", "0", "10", "2", "2", "1", "3", "1", "2", "0", "0", "0", "0", "0", "0" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[1];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
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
                            GameController.petList.Add(++petListIndex, new string[] { "Golem", "1", "0", "10", "3", "3", "2", "4", "2", "4", "0", "0", "0", "0", "0", "0" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[2];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
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
                            GameController.petList.Add(++petListIndex, new string[] { "Snow Wolf", "1", "0", "10", "3", "4", "2", "3", "2", "1", "0", "0", "0", "0", "0", "0" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[3];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
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
                            GameController.petList.Add(++petListIndex, new string[] { "Buzz", "1", "0", "10", "2", "1", "2", "1", "3", "3", "0", "0", "0", "0", "0", "0" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[4];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
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
                            GameController.petList.Add(++petListIndex, new string[] { "Buzz", "1", "0", "10", "2", "1", "2", "1", "3", "3", "0", "0", "0", "0", "0", "0" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[4];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
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
                            GameController.petList.Add(++petListIndex, new string[] { "Night Wolf", "1", "0", "10", "3", "4", "2", "3", "1", "5", "0", "0", "0", "0", "0", "0" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[5];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
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
                            GameController.petList.Add(++petListIndex, new string[] { "Night Wolf", "1", "0", "10", "3", "4", "2", "3", "1", "5", "0", "0", "0", "0", "0", "0" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[5];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
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
                            GameController.petList.Add(++petListIndex, new string[] { "Rumryss", "1", "0", "10", "2", "1", "2", "3", "3", "1", "0", "0", "0", "0", "0", "0" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[6];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
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
                            GameController.petList.Add(++petListIndex, new string[] { "Wyvernldle", "1", "0", "10", "4", "5", "4", "3", "4", "4", "0", "0", "0", "0", "0", "0" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[7];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
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
                            GameController.petList.Add(++petListIndex, new string[] { "Dread Biter", "1", "0", "10", "4", "6", "2", "3", "4", "5", "0", "0", "0", "0", "0", "0" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[8];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
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
                            GameController.petList.Add(++petListIndex, new string[] { "One Eye", "1", "0", "10", "3", "3", "2", "4", "1", "5", "0", "0", "0", "0", "0", "0" });
                            petsImage[GameController.petList.Count - 1].sprite = Pets[9];
                            useButtons[GameController.petList.Count - 1].SetActive(true);
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
        if (meatNumber >= 10)
        {
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
                GameController.petList[index][1] = level.ToString();
            }
            else
            {
                GameController.petList[index][2] = a.ToString();
                eatSound.Play();
                FoodBar.SetFood(a);
            }
        }
        else{
            var forgedTxt = Instantiate(notEnoughRawMeatText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(petsPanel.transform, false);
            forgedTxt.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
            Destroy(forgedTxt, 0.5f);
        }
    }

    public void EquipButton()
    {
        GameObject pet = GameObject.FindGameObjectWithTag("pet");
        Destroy(pet);
        switch (GameController.petList[index][0])
        {
            case "Jack-O-Lantern":
                Instantiate(animals[0], player.transform.position, Quaternion.identity);
                GameController.petName = "pumpkin";
                break;

            case "Claws":
                Instantiate(animals[3], player.transform.position, Quaternion.identity);
                GameController.petName = "crab";
                break;

            case "Golem":
                Instantiate(animals[6], player.transform.position, Quaternion.identity);
                GameController.petName = "golem";
                break;

            case "Snow Wolf":
                Instantiate(animals[9], player.transform.position, Quaternion.identity);
                GameController.petName = "snow wolf";
                break;

            case "Buzz":
                Instantiate(animals[12], player.transform.position, Quaternion.identity);
                GameController.petName = "bee";
                break;

            case "Night Wolf":
                Instantiate(animals[15], player.transform.position, Quaternion.identity);
                GameController.petName = "night wolf";
                break;

            case "Rumryss":
                Instantiate(animals[18], player.transform.position, Quaternion.identity);
                GameController.petName = "snake";
                break;

            case "Wyvernldle":
                Instantiate(animals[21], player.transform.position, Quaternion.identity);
                GameController.petName = "dragon";
                break;

            case "Dread Biter":
                Instantiate(animals[24], player.transform.position, Quaternion.identity);
                GameController.petName = "worm";
                break;

            case "One Eye":
                Instantiate(animals[27], player.transform.position, Quaternion.identity);
                GameController.petName = "eye ball";
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
            for(int i = 1; i<= usedPetList.Count; i++)
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
}
