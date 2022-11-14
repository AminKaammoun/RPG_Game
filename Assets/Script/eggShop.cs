using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eggShop : MonoBehaviour
{
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
    public ItemObject RedEgg;
    public ItemObject BlueEgg;
    public ItemObject YellowEgg;
    public ItemObject BlackEgg;
    public ItemObject GreenEgg;
    public ItemObject BrownEgg;
    public ItemObject eggs;

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

    bool check = false;

    public GameObject foodLevels;
    public GameObject feedUIButton;

    public foodBar FoodBar;
    void Start()
    {

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
        if (GameController.petList.Count > 0)
        {
            foodLevels.SetActive(true);
            feedUIButton.SetActive(true);

            petCount.text = index + "/" + GameController.petList.Count;
            petName.text = GameController.petList[index][0];
            petLevel.text = GameController.petList[index][1];
            FoodXpCounter.text = GameController.petList[index][2] + "/" + GameController.petList[index][3];

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

    public void EggFeed2()
    {
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

    public void EggFeed3()
    {
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


    IEnumerator backSwitch()
    {
        yield return new WaitForSeconds(0.5f);
        egg1SwitchAnim.SetBool("Press", false);
        egg2SwitchAnim.SetBool("Press", false);
        egg3SwitchAnim.SetBool("Press", false);
    }

    public void BirthEgg1()
    {
        animalSpawnPos.sprite = empty;
        ResetEggNest1();
        birthButton[0].SetActive(false);
        birthPanel.SetActive(true);
        eggCrackSound.Play();
        eggUI[eggType[0] - 1].SetActive(true);
        StartCoroutine(setAniamalSprite(0));
        StartCoroutine(closeBirthPanel());
    }

    public void BirthEgg2()
    {
        animalSpawnPos.sprite = empty;
        ResetEggNest2();
        birthButton[1].SetActive(false);
        birthPanel.SetActive(true);
        eggCrackSound.Play();
        eggUI[eggType[1] - 1].SetActive(true);
        StartCoroutine(setAniamalSprite(1));
        StartCoroutine(closeBirthPanel());
    }

    public void BirthEgg3()
    {
        animalSpawnPos.sprite = empty;
        ResetEggNest3();
        birthButton[2].SetActive(false);
        birthPanel.SetActive(true);
        eggCrackSound.Play();
        eggUI[eggType[2] - 1].SetActive(true);
        StartCoroutine(setAniamalSprite(2));
        StartCoroutine(closeBirthPanel());
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
                            if(pet.Value[0] == "Jack-O-Lantern")
                            {
                                check = true;
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++GameController.numberOfPets, new string[] { "Jack-O-Lantern", "1" , "0" ,"10"});
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
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++GameController.numberOfPets, new string[] { "Claws", "1" ,"0" , "10"});
                        }
                        check = false;
                        break;
                }
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
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++GameController.numberOfPets, new string[] { "Golem", "1" ,"0", "10" });
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
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++GameController.numberOfPets, new string[] { "Snow Wolf", "1" ,"0", "10" });
                        }
                        check = false;
                        break;
                }
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
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++GameController.numberOfPets, new string[] { "Buzz", "1","0", "10" });
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
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++GameController.numberOfPets, new string[] { "Buzz", "1","0", "10" });
                        }
                        check = false;
                        break;
                }
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
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++GameController.numberOfPets, new string[] { "Night Wolf", "1","0", "10" });
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
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++GameController.numberOfPets, new string[] { "Night Wolf", "1" ,"0", "10" });
                        }
                        check = false;
                        break;
                }
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
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++GameController.numberOfPets, new string[] { "Rumryss", "1","0", "10" });
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
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++GameController.numberOfPets, new string[] { "Wyvernldle", "1","0", "10" });
                        }
                        check = false;
                        break;
                }
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
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++GameController.numberOfPets, new string[] { "Dread Biter", "1","0", "10" });
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
                                break;
                            }
                        }
                        if (!check)
                        {
                            GameController.petList.Add(++GameController.numberOfPets, new string[] { "One Eye", "1","0", "10" });
                        }
                        check = false;
                        break;
                }
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
        int a = int.Parse(GameController.petList[index][2]);
        a += 10;
        if (a >= int.Parse(GameController.petList[index][3]))
        {
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
            FoodBar.SetFood(a);
        }
    }
}
