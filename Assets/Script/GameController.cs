using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public enum PlayerMap
{
    Village,
    forrest,
    beach,
    forrestDungeon,
    forrestDungeon2,
    forrestDungeon3,
    forrestDungeon4,
    forrestDungeon2nd,
    forrestDungeon2nd1,
    forrestDungeon2nd2,
    beachDun,
    beachDun1,
    beachDun2,
    beachDun3


}

public class GameController : MonoBehaviour
{
    public Text levelText;

    public InventoryObject Inv;

    public float TimeBtwLeafSpawn;
    public float StartTime = 0.25f;

    public GameObject inventory;
    public GameObject[] leafSpawner;
    public GameObject alert;
    public GameObject[] panel;
    public GameObject leaf;
    public GameObject dashUi;
    public GameObject player;
    public GameObject loadingPanel;
    public GameObject tpPanel;
    public GameObject Dun1Panel;
    public GameObject Dun2Panel;
    public GameObject PotionShopPanel;
    public GameObject theVillage;
    public GameObject theForrest;
    public GameObject theBeach;
    public GameObject cockAudio;

    public AudioSource audioSource;
    public AudioSource musicSource;
    public AudioClip forestAudio;
    public AudioClip forestNightAudio;
    public AudioClip villageSound;
    public AudioClip villageMusic;
    public AudioClip forestMusic;
    public AudioClip dunMusic;
    public AudioSource chestAudio;
    public AudioClip beachMusic;
    public AudioClip beachAudio;
    

    public GameObject forestDoor1;
    public GameObject forestDoor2;
    public GameObject forestDoor3;

    public static bool silverKeyDoorReset = false;
    public static bool goldKeyDoorReset = false;

    public static LevelSystem level;
    public XpBar xpBar;

    private float currentTime;
    private float startTime = 5f;
    public static bool dashed = false;
    public static bool wantTp = false;

    public Text dashTimer;
    public Text loading;
    public Text lvl;
    public Text XP;
    public Text coinText;
    public Text coinTextPotionShop;

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

    public static PlayerMap currentMap;

    private float startLoadingTime = 0.35f;
    public float TimeBtwLoading;

    public static int coins;
    public static bool showAlert = false;
    public static bool returnDunMusic = false;
   

    private string attackGear;
    private string defGear;
    private string beltGear;
    private string helmetGear;
    private string ringGear;


    // Start is called before the first frame update
    void Start()
    {
        attackGear = PlayerPrefs.GetString("AttackGear");
        defGear = PlayerPrefs.GetString("DefGear");
        beltGear = PlayerPrefs.GetString("BeltGear");
        helmetGear = PlayerPrefs.GetString("HelmetGear");
        ringGear = PlayerPrefs.GetString("RingGear");

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

                PlayerMovements.BonusAttack = 50;
                PlayerMovements.BonusDefence = PlayerMovements.BonusDefence + 25;
                PlayerMovements.BonusAgility = PlayerMovements.BonusAgility + 15;
                PlayerMovements.BonusSp = PlayerMovements.BonusSp + 10;
                PlayerMovements.BonusHp = PlayerMovements.BonusHp + 25;
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
        }

        //PlayerPrefs.SetInt("coins", 0);
        coins = PlayerPrefs.GetInt("coins");
        //PlayerPrefs.SetInt("XP", 0);
        //PlayerPrefs.SetInt("LEVEL", 1);
        level = new LevelSystem(PlayerPrefs.GetInt("LEVEL"), OnLevelUp);
        level.experience = PlayerPrefs.GetInt("XP");
        currentTime = startTime;
        leafSpawner = GameObject.FindGameObjectsWithTag("LeafSpawner");
        currentMap = PlayerMap.forrest;

    }

    // Update is called once per frame
    void Update()
    {

        checkForCockSound();
        SetStats();
        Hp.text = PlayerMovements.health.ToString() + "/" + (100 + (PlayerPrefs.GetInt("LEVEL") * 10) + PlayerMovements.BonusHp).ToString();
        resetForestDoors();
        coinTextPotionShop.text = coins.ToString();
        if (coins > PlayerPrefs.GetInt("coins"))
        {
            PlayerPrefs.SetInt("coins", coins);

        }

        coinText.text = coins.ToString();

        updateLevelStats();
        checkIfCanDash();
        ControlLoadingPageIfExist();
        if (wantTp)
        {
            tpPanel.SetActive(true);
        }

        panel = GameObject.FindGameObjectsWithTag("panel");
        InventoryControl();
        checkCurrentMap();

        if (returnDunMusic)
        {
            changeBGM(dunMusic, musicSource);
            returnDunMusic = false;
        }
        if (chest.playChestAudio)
        {
            chestAudio.Play();
            chest.playChestAudio = false;
        }
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
            forestDoor2.SetActive(true);
            forestDoor3.SetActive(true);
            goldKeyDoorReset = false;
        }
    }
    public void closeInventory()
    {
        Inventory.description = "";
        inventory.SetActive(false);
        Inv.save();
        PlayerMovements.invIsOpen = false;
        foreach (GameObject r in panel)
        {
            r.SetActive(false);
        }

    }
    public void closeAlertButton()
    {
        alert.SetActive(false);
        showAlert = false;
    }

    public void closeTpPanel()
    {
        tpPanel.SetActive(false);
        wantTp = false;
    }

    public void closeDun1Pnanel()
    {
        Dun1Panel.SetActive(false);
    }
    public void closeDun2Panel()
    {
        Dun2Panel.SetActive(false);
    }
    public void VillageTpButton()
    {
        changeBGM(villageMusic, musicSource);
        changeBGS(villageSound, audioSource);
        musicSource.loop = true;
        tpPanel.SetActive(false);
        wantTp = false;
        player.transform.position = new Vector3(21.36f, 0.56f, 0f);
        currentMap = PlayerMap.Village;
        loadingPanel.SetActive(true);
        StartCoroutine(removeLoadingPanel());
    }
    public void ForrestTpButton()
    {
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
        currentMap = PlayerMap.forrest;
        loadingPanel.SetActive(true);
        StartCoroutine(removeLoadingPanel());
    }
    public void BeachTpButton()
    {
        changeBGM(beachMusic, musicSource);
        changeBGS(beachAudio, audioSource);
        musicSource.loop = false;
        tpPanel.SetActive(false);
        wantTp = false;
        player.transform.position = new Vector3(68.16f, 129.6f, 0f);
        currentMap = PlayerMap.beach;
        loadingPanel.SetActive(true);
        StartCoroutine(removeLoadingPanel());
    }

    public void potionShop()
    {
        PotionShopPanel.SetActive(true);
    }
    public void closePanels()
    {
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


    public void updateLevelStats()
    {
        lvl.text = "Lv. " + level.currentLevel;

        if (level.experience > PlayerPrefs.GetInt("XP"))
        {
            PlayerPrefs.SetInt("XP", level.experience);
        }

        if (level.currentLevel > PlayerPrefs.GetInt("LEVEL"))
        {
            PlayerPrefs.SetInt("LEVEL", level.currentLevel);
        }
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
            if (currentTime >= 0)
            {
                currentTime -= 1 * Time.deltaTime;
                PlayerMovements.canDash = false;
            }
            else
            {
                currentTime = startTime;
                dashed = false;
                PlayerMovements.canDash = true;
                dashUi.SetActive(false);
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

            CameraMovement.maxPosition = new Vector2(159.63f, 30f);
            CameraMovement.minPosition = new Vector2(56.74f, -2f);

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

            CameraMovement.maxPosition = new Vector2(100f, 46.32f);
            CameraMovement.minPosition = new Vector2(0f, 45.36f);
        }
        else if (currentMap == PlayerMap.forrestDungeon2)
        {
            CameraMovement.maxPosition = new Vector2(200f, 59.73f);
            CameraMovement.minPosition = new Vector2(0f, 58.55f);
        }
        else if (currentMap == PlayerMap.forrestDungeon3)
        {
            CameraMovement.maxPosition = new Vector2(200f, 72.56f);
            CameraMovement.minPosition = new Vector2(0f, 71.64f);
        }
        else if (currentMap == PlayerMap.forrestDungeon4)
        {
            CameraMovement.maxPosition = new Vector2(200f, 72.56f);
            CameraMovement.minPosition = new Vector2(0f, 71.64f);
        }
        else if (currentMap == PlayerMap.Village)
        {
            CameraMovement.maxPosition = new Vector2(12.31f, 2.2f);
            CameraMovement.minPosition = new Vector2(-29.19f, -0.12f);


        }
        else if (currentMap == PlayerMap.forrestDungeon2nd)
        {
            CameraMovement.maxPosition = new Vector2(167.38f, 56.29f);
            CameraMovement.minPosition = new Vector2(140f, 55.41f);
        }
        else if (currentMap == PlayerMap.forrestDungeon2nd1)
        {
            CameraMovement.maxPosition = new Vector2(167.38f, 69.41f);
            CameraMovement.minPosition = new Vector2(140f, 68.32f);
        }
        else if (currentMap == PlayerMap.forrestDungeon2nd2)
        {
            CameraMovement.maxPosition = new Vector2(167.38f, 82.42f);
            CameraMovement.minPosition = new Vector2(140f, 81.24f);
        }
        else if (currentMap == PlayerMap.beach)
        {
            CameraMovement.minPosition = new Vector2(76.55f, 100f);
            CameraMovement.maxPosition = new Vector2(160f, 146.94f);
        }
        else if (currentMap == PlayerMap.beachDun)
        {
            CameraMovement.minPosition = new Vector2(94f, 172.13f);
            CameraMovement.maxPosition = new Vector2(117.22f, 173.57f);
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
            CameraMovement.minPosition = new Vector2(78.14f, 210.04f);
            CameraMovement.maxPosition = new Vector2(117.71f, 211.46f);
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


        attackBonus.text = "+(" + PlayerMovements.BonusAttack.ToString() + ")";
        defBonus.text = "+(" + PlayerMovements.BonusDefence.ToString() + ")";
        agilityBonus.text = "+(" + PlayerMovements.BonusAgility.ToString() + ")";
        SpBonus.text = "+(" + PlayerMovements.BonusSp.ToString() + ")";
        HpBonus.text = "+(" + PlayerMovements.BonusHp.ToString() + ")";
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
