using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using TMPro;
using System;
using Random = UnityEngine.Random;

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
    forrestMiningArea,
    forrestTreesArea,
    beachDun,
    beachDun1,
    beachDun2,
    beachDun3,
    beachDun4


}

public class GameController : MonoBehaviour
{
    public Text levelText;

    public InventoryObject Inv;

    public float TimeBtwLeafSpawn;
    public float StartTime = 0.25f;

    public Camera mainCamera;

    [SerializeField] private Texture2D NormalCursor;

    public GameObject inventory;
    public GameObject[] leafSpawner;
    public GameObject[] crowSpawner;
    public GameObject alert;
    public GameObject[] panel;
    public GameObject leaf;
    public GameObject crow;
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
    public GameObject BlackSmithPanel;
    public GameObject volume;
    public GameObject ultDirection;
    public GameObject ultSlash;
    public GameObject ultEffect;
    public GameObject thunder;
    public GameObject gainedBp;

    public AudioSource audioSource;
    public AudioSource musicSource;

    public AudioSource chestAudio;
    public AudioSource ultimateSound;

    public AudioClip forestAudio;
    public AudioClip forestNightAudio;
    public AudioClip villageSound;
    public AudioClip villageMusic;
    public AudioClip forestMusic;
    public AudioClip dunMusic;
    public AudioClip beachMusic;
    public AudioClip beachAudio;


    public GameObject forestDoor1;
    public GameObject forestDoor3;

    public static bool silverKeyDoorReset = false;
    public static bool goldKeyDoorReset = false;

    public static LevelSystem level;
    public XpBar xpBar;

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

    public TextMeshProUGUI battlePowerText;

    public static PlayerMap currentMap;

    private float startLoadingTime = 0.35f;
    public float TimeBtwLoading;

    private float TimeBtwCrows;
    private float startCrowTime = 2f;

    public static int coins;
    private int value;
    public static bool showAlert = false;
    public static bool returnDunMusic = false;
    public static bool enemyBeaten = false;
    public static bool ultPressed = false;
    private bool openUltimate = false;
    public static float BattlePower;

    private Vector2 cursorHotspot;

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
        BattlePower = PlayerPrefs.GetInt("BattlePower");
        currentTime = startTime;
        TimeBtwCrows = startCrowTime;
        leafSpawner = GameObject.FindGameObjectsWithTag("LeafSpawner");
        crowSpawner = GameObject.FindGameObjectsWithTag("crowSpawner");
        currentMap = PlayerMap.forrest;

    }

    // Update is called once per frame
    void Update()
    {

        checkForCockSound();
        SetStats();
        Hp.text = PlayerMovements.health.ToString() + "/" + (100 + (PlayerPrefs.GetInt("LEVEL") * 10) + PlayerMovements.BonusHp).ToString();
        resetForestDoors();

        if (coins > PlayerPrefs.GetInt("coins"))
        {
            PlayerPrefs.SetInt("coins", coins);

        }

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
        coinsToolTipText.text = coins.ToString();

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
                openUltimate = true;
                Time.timeScale = 1f;
                Time.fixedDeltaTime = 0.02f;
                Instantiate(ultSlash, player.transform.position, ultDirection.transform.rotation);
                Instantiate(ultEffect, player.transform.position, ultDirection.transform.rotation);
                Instantiate(thunder, player.transform.position, ultDirection.transform.rotation);
            }
            StartCoroutine(backFromSlowMo());
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
    public void closeDun2Panel()
    {
        ArrowSpawn.canShoot = true;
        PlayerMovements.changeCursor = true;
        Dun2Panel.SetActive(false);
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
        currentMap = PlayerMap.beach;
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
        enemyBeaten = false;
        ultPressed = false;
        openUltimate = false;
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

            CameraMovement.maxPosition = new Vector2(196.89f, 20.77f);
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
            CameraMovement.minPosition = new Vector2(-27.64f, -0.12f);


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
            CameraMovement.minPosition = new Vector2(78.23f, 100f);
            CameraMovement.maxPosition = new Vector2(175.6f, 146.94f);

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

        BattlePower = (int)(PlayerMovements.attack * 4 + PlayerMovements.defence / 2 + PlayerMovements.agility / 2 + PlayerMovements.hp / 2 + PlayerMovements.Sp * 2);
        battlePowerText.text = BattlePower.ToString() + " BP.";

        if (PlayerPrefs.GetInt("BattlePower") != (int)GameController.BattlePower)
        {

            gainedBpText.GainedValue = (int)GameController.BattlePower - PlayerPrefs.GetInt("BattlePower");
            var gainedTxt = Instantiate(gainedBp, new Vector3(-194.8f, 30f, 0f), Quaternion.identity) as GameObject;
            try
            {
                gainedTxt.transform.SetParent(GameObject.FindGameObjectWithTag("inventory").transform, false);
            }
            catch (NullReferenceException e)
            {

            }
            PlayerPrefs.SetInt("BattlePower", (int)GameController.BattlePower);

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
