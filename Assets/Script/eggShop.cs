using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eggShop : MonoBehaviour
{

    public GameObject effect;
    public GameObject slot;
    public GameObject slot2;
    public GameObject slot3;
    public Animator egg1SwitchAnim;
    public Animator egg2SwitchAnim;
    public Animator egg3SwitchAnim;

    public GameObject[] useButton;
    public GameObject[] feedButton;

    public InventoryObject inventory;
    public ItemObject RedEgg;
    public ItemObject BlueEgg;
    public ItemObject YellowEgg;
    public ItemObject BlackEgg;
    public ItemObject GreenEgg;
    public ItemObject BrownEgg;

    ItemObject[] usedEggs = new ItemObject[3];

    public Image[] eggImage = new Image[3];
    public Sprite[] eggSprite = new Sprite[6];

    private int[] nestLevel = new int[3] ;

    public GameObject[] counter = new GameObject[3];

    public Text nest1LevelText;
    public Text nest2LevelText;
    public Text nest3LevelText;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
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
        for (int i =0; i < usedEggs.Length; i++)
        {
            if(usedEggs[i] == null)
            {
                eggImage[i].sprite = eggSprite[0];
                usedEggs[i] = RedEgg;
                nestLevel[i]++;
                counter[i].SetActive(true);
                feedButton[i].SetActive(true);

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
                eggImage[i].sprite = eggSprite[1];
                usedEggs[i] = BlueEgg;
                nestLevel[i]++;
                counter[i].SetActive(true);
                feedButton[i].SetActive(true);
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
                eggImage[i].sprite = eggSprite[2];
                usedEggs[i] = YellowEgg;
                nestLevel[i]++;
                counter[i].SetActive(true);
                feedButton[i].SetActive(true);
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
                eggImage[i].sprite = eggSprite[3];
                usedEggs[i] = BlackEgg;
                nestLevel[i]++;
                counter[i].SetActive(true);
                feedButton[i].SetActive(true);
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
                eggImage[i].sprite = eggSprite[4];
                usedEggs[i] = GreenEgg;
                nestLevel[i]++;
                counter[i].SetActive(true);
                feedButton[i].SetActive(true);
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
                eggImage[i].sprite = eggSprite[5];
                usedEggs[i] = BrownEgg;
                nestLevel[i]++;
                counter[i].SetActive(true);
                feedButton[i].SetActive(true);
                break;
            }
        }
    }
    public void EggFeed()
    {
        Vector3 add = new Vector3(-slot.transform.position.x, -slot.transform.position.y, transform.position.z);
        var Effect = Instantiate(effect, slot.transform.position + add, Quaternion.identity) as GameObject;
        Effect.transform.SetParent(slot.transform, false);
        Destroy(Effect, 1f);
        egg1SwitchAnim.SetBool("Press", true);
        StartCoroutine(backSwitch());
    }

    public void EggFeed2()
    {
        Vector3 add = new Vector3(-slot2.transform.position.x, -slot2.transform.position.y, transform.position.z);
        var Effect = Instantiate(effect, slot2.transform.position + add, Quaternion.identity) as GameObject;
        Effect.transform.SetParent(slot2.transform, false);
        Destroy(Effect, 1f);
        egg2SwitchAnim.SetBool("Press", true);
        StartCoroutine(backSwitch());
    }

    public void EggFeed3()
    {
        Vector3 add = new Vector3(-slot3.transform.position.x, -slot3.transform.position.y, transform.position.z);
        var Effect = Instantiate(effect, slot3.transform.position + add, Quaternion.identity) as GameObject;
        Effect.transform.SetParent(slot3.transform, false);
        Destroy(Effect, 1f);
        egg3SwitchAnim.SetBool("Press", true);
        StartCoroutine(backSwitch());
    }


    IEnumerator backSwitch()
    {
        yield return new WaitForSeconds(0.5f);
        egg1SwitchAnim.SetBool("Press", false);
        egg2SwitchAnim.SetBool("Press", false);
        egg3SwitchAnim.SetBool("Press", false);
    }
}
