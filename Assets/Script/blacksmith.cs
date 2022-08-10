using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class blacksmith : MonoBehaviour
{
    public Image image;
    public Image craft1;
    public Image craft2;
    public Sprite[] sprites;
    public Sprite[] firstItem;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sword()
    {
        image.sprite = sprites[0];
        craft1.sprite = firstItem[0];
        craft2.sprite = firstItem[1];
    }
    public void Def()
    {
        image.sprite = sprites[1];
        craft1.sprite = firstItem[1];
        craft2.sprite = firstItem[4];
    }
    public void Helmet()
    {
        image.sprite = sprites[2];
        craft1.sprite = firstItem[2];
        craft2.sprite = firstItem[0];
    }
    public void Belt()
    {
        image.sprite = sprites[3];
        craft1.sprite = firstItem[3];
        craft2.sprite = firstItem[2];
    }
    public void Ring()
    {
        image.sprite = sprites[4];
        craft1.sprite = firstItem[4];
        craft2.sprite = firstItem[3];
    }
   
}
