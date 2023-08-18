using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenGrape : MonoBehaviour
{
    private float timeToGrow = 60f;
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[0];
    }

    // Update is called once per frame
    void Update()
    {

        if (timeToGrow < 0)
        {
            spriteRenderer.sprite = sprites[4];
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
}
