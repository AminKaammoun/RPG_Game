using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skill : MonoBehaviour
{
    public Image DescriptionImage;

    public Sprite[] skillImages;
    public void skill1()
    {
        DescriptionImage.sprite = skillImages[0];
    }

    public void skill2()
    {
        DescriptionImage.sprite = skillImages[1];
    }

    public void skill3()
    {
        DescriptionImage.sprite = skillImages[2];
    }

    public void skill4()
    {
        DescriptionImage.sprite = skillImages[3];
    }

    public void skill5()
    {
        DescriptionImage.sprite = skillImages[4];
    }
}
