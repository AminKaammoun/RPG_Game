using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skill : MonoBehaviour
{
    public Image DescriptionImage;
    public Image currentSkillImage;

    public Image[] skillSelectImage;

    public Sprite[] skillImages;

    public Text skill1Level;
    public Text skill2Level;
    public Text skill3Level;
    public Text skill4Level;
    public Text skill5Level;
    public Text skillPoints;

    public AudioSource selectAudio;

    public GameObject Skill3;
    public GameObject Skill4;
    public GameObject Skill5;

    public Sprite[] skills;

    public Text skillTitle;
    public Text skillDescription;

    void Update()
    {
        skill1Level.text = GameController.skill1Level.ToString();
        skill2Level.text = GameController.skill2Level.ToString();
        skill3Level.text = GameController.skill3Level.ToString();
        skill4Level.text = GameController.skill4Level.ToString();
        skill5Level.text = GameController.skill5Level.ToString();
        skillPoints.text = GameController.skillPoint.ToString();

        switch (GameController.currentSkill)
        {
            case 0:
                currentSkillImage.sprite = skillImages[0];

                break;
            case 1:
                currentSkillImage.sprite = skillImages[1];

                break;
            case 2:
                currentSkillImage.sprite = skillImages[2];

                break;
            case 3:
                currentSkillImage.sprite = skillImages[3];

                break;
            case 4:
                currentSkillImage.sprite = skillImages[4];

                break;

        }

        if (GameController.skill1Level >= 10)
        {
            Skill3.SetActive(true);
            skillSelectImage[0].sprite = skills[1];
        }

        if (GameController.skill2Level >= 10)
        {
            Skill4.SetActive(true);
            skillSelectImage[1].sprite = skills[3];
        }

        if (GameController.skill3Level >= 10 && GameController.skill4Level >= 10)
        {
            Skill5.SetActive(true);
            skillSelectImage[2].sprite = skills[5];
        }
    }

    public void skill1()
    {
        DescriptionImage.sprite = skillImages[0];
        skillTitle.text = "Crush Wave";
        skillDescription.text = "Attack all enemies on a straight Line using a magical wave, growing rate 100%.";
    }

    public void skill2()
    {
        DescriptionImage.sprite = skillImages[1];
        skillTitle.text = "Mountain Seal";
        skillDescription.text = "Attack all enemies using a spinning giant rock, growing rate 100%.";
    }

    public void skill3()
    {
        DescriptionImage.sprite = skillImages[2];
        skillTitle.text = "Cursed chains";
        skillDescription.text = "growing rate 120%.";
    }

    public void skill4()
    {
        DescriptionImage.sprite = skillImages[3];
        skillTitle.text = "Charge Attack";
        skillDescription.text = "growing rate 120%.";
    }

    public void skill5()
    {
        DescriptionImage.sprite = skillImages[4];
        skillTitle.text = "Holy hand";
        skillDescription.text = "growing rate 150%.";
    }

    public void skill1Plus()
    {
        if (GameController.skillPoint > 0)
        {
            GameController.skill1Level++;
            GameController.skillPoint--;
        }
    }
    public void skill2Plus()
    {
        if (GameController.skillPoint > 0)
        {
            if (GameController.skillPoint > 0)
            {
                GameController.skill2Level++;
                GameController.skillPoint--;
            }
        }
    }

    public void skill3Plus()
    {
        if (GameController.skillPoint > 0)
        {
            GameController.skill3Level++;
            GameController.skillPoint--;
        }
    }

    public void skill4Plus()
    {
        if (GameController.skillPoint > 0)
        {
            GameController.skill4Level++;
            GameController.skillPoint--;
        }
    }
    public void skill5Plus()
    {
        if (GameController.skillPoint > 0)
        {
            GameController.skill5Level++;
            GameController.skillPoint--;
        }
    }

    public void SelectSkill1()
    {
        GameController.currentSkill = 0;
        selectAudio.Play();
        DescriptionImage.sprite = skillImages[0];
        skillTitle.text = "Crush Wave";
        skillDescription.text = "Attack all enemies on a straight Line using a magical wave, growing rate 100%.";
    }
    public void SelectSkill2()
    {
        GameController.currentSkill = 1;
        selectAudio.Play();
        DescriptionImage.sprite = skillImages[1];
        skillTitle.text = "Mountain Seal";
        skillDescription.text = "Attack all enemies using a spinning giant rock, growing rate 100%.";
    }
    public void SelectSkill3()
    {
        GameController.currentSkill = 2;
        selectAudio.Play();
        DescriptionImage.sprite = skillImages[2];
        skillTitle.text = "Cursed chains";
        skillDescription.text = "growing rate 120%.";
    }
    public void SelectSkill4()
    {
        GameController.currentSkill = 3;
        selectAudio.Play();
        DescriptionImage.sprite = skillImages[3];
        skillTitle.text = "Charge Attack";
        skillDescription.text = "growing rate 120%.";
    }
    public void SelectSkill5()
    {
        GameController.currentSkill = 4;
        selectAudio.Play();
        DescriptionImage.sprite = skillImages[4];
        skillTitle.text = "Holy hand";
        skillDescription.text = "growing rate 150%.";
    }
}
