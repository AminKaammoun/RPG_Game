using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corn : MonoBehaviour
{
    private float timeToGrow = 60f;
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    public GameObject waterSign;
    public GameObject harvestSign;
    private bool isWatered = false;
    public GameObject Ekey;
    private GameObject player;

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
            }
            else
            {
                timeToGrow -= Time.deltaTime;
            }
            if (timeToGrow < 45 && timeToGrow >= 30)
            {
                spriteRenderer.sprite = sprites[1];
            }
            else if (timeToGrow < 30 && timeToGrow >= 15)
            {
                spriteRenderer.sprite = sprites[2];
            }
            else if (timeToGrow < 15 && timeToGrow > 0)
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
