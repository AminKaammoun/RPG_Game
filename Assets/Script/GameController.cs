using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PlayerMap
{
    Village,
    forrest,
    forrestDungeon,
    forrestDungeon2,
    forrestDungeon3,
    forrestDungeon4
}

public class GameController : MonoBehaviour
{

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
    public GameObject PotionShopPanel;

    private float currentTime;
    private float startTime = 10f;
    public static bool dashed = false;
    public static bool wantTp = false;
    //public static bool showPotionShop = false;

    public Text dashTimer;
    public Text loading;

    public static PlayerMap currentMap;

    private float startLoadingTime = 0.35f;
    public float TimeBtwLoading;

    public static bool showAlert = false;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        leafSpawner = GameObject.FindGameObjectsWithTag("LeafSpawner");
        currentMap = PlayerMap.forrest;
    }

    // Update is called once per frame
    void Update()
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
        
        if (wantTp)
        {
            tpPanel.SetActive(true);

        }


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

        panel = GameObject.FindGameObjectsWithTag("panel");

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
     
        if (PlayerMovements.isDashButtonDown)
        {
            dashUi.SetActive(true);

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

    public void VillageTpButton()
    {
        tpPanel.SetActive(false);
        wantTp = false;
        player.transform.position = new Vector3(21.36f, 0.56f, 0f);
        currentMap = PlayerMap.Village;
        loadingPanel.SetActive(true);
        StartCoroutine(removeLoadingPanel());
    }
    public void ForrestTpButton()
    {
        tpPanel.SetActive(false);
        wantTp = false;
        player.transform.position = new Vector3(47.66f, 3.1f, 0f);
        currentMap = PlayerMap.forrest;
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
    IEnumerator removeLoadingPanel()
    {
        yield return new WaitForSeconds(1f);
        loading.text = "LOADING";
        loadingPanel.SetActive(false);
    }
}
