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
   
    private float currentTime;
    private float startTime = 10f;
    public static bool dashed = false;

    public Text dashTimer;

    public static PlayerMap currentMap;

    
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
}
