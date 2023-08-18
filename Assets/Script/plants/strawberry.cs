using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strawberry : MonoBehaviour
{
    private float timeToGrow = 90f;
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
        if (timeToGrow < 67.5 && timeToGrow >= 45)
        {
            spriteRenderer.sprite = sprites[1];
        }
        else if (timeToGrow < 45 && timeToGrow >= 22.5)
        {
            spriteRenderer.sprite = sprites[2];
        }
        else if (timeToGrow < 22.5 && timeToGrow > 0)
        {
            spriteRenderer.sprite = sprites[3];
        }


    }
}
