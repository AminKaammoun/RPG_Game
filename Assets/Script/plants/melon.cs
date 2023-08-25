using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melon : MonoBehaviour
{
    private float timeToGrow = 420f;
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    public GameObject waterSign;
    public GameObject harvestSign;
    private bool isWatered = false;
    public GameObject Ekey;
    public GameObject EharvestKey;
    private GameObject player;
    public GameObject fruit;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[0];
        waterSign.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (isWatered)
        {
            waterSign.SetActive(false);
            Ekey.SetActive(false);
            if (timeToGrow < 0)
            {
                spriteRenderer.sprite = sprites[4];
                harvestSign.SetActive(true);
                if (Vector3.Distance(this.gameObject.transform.position, player.transform.position) < 0.75f)
                {
                    EharvestKey.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        int rand = Random.Range(1, 4);
                        PlayerMovements.isHarvesting = true;
                        switch (rand)
                        {
                            case 1:
                                Instantiate(fruit, transform.position, Quaternion.identity);
                                break;

                            case 2:
                                for (int i = 0; i < 2; i++)
                                {
                                    Instantiate(fruit, transform.position, Quaternion.identity);
                                }
                                break;

                            case 3:
                                for (int i = 0; i < 3; i++)
                                {
                                    Instantiate(fruit, transform.position, Quaternion.identity);
                                }
                                break;

                        }

                        Destroy(gameObject);
                    }
                }
                else
                {
                    EharvestKey.SetActive(false);
                }

            }
            else
            {
                timeToGrow -= Time.deltaTime;
            }
            if (timeToGrow < 315 && timeToGrow >= 210)
            {
                spriteRenderer.sprite = sprites[1];
            }
            else if (timeToGrow < 210 && timeToGrow >= 105)
            {
                spriteRenderer.sprite = sprites[2];
            }
            else if (timeToGrow < 105 && timeToGrow > 0)
            {
                spriteRenderer.sprite = sprites[3];
            }
        }
        else
        {
            if (Vector3.Distance(this.gameObject.transform.position, player.transform.position) < 1f)
            {
                Ekey.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    isWatered = true;
                    PlayerMovements.isWatering = true;
                }

            }
            else
            {
                Ekey.SetActive(false);
            }

        }
    }
}

