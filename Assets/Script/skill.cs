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
    public GameObject Skill3Button;
    public GameObject Skill4Button;
    public GameObject Skill5Button;

    public Sprite[] skills;

    public Text skillTitle;
    public Text skillDescription;

    public GameObject alert;
    public GameObject alert1;

    private int currentskill;
    public GameObject effect;

    public GameObject slot;
    public GameObject notEnoughText;
    public GameObject skillPanel;

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
            Skill3Button.SetActive(true);
            skillSelectImage[0].sprite = skills[1];
        }
        else
        {
            Skill3.SetActive(false);
            Skill3Button.SetActive(false);
            skillSelectImage[0].sprite = skills[0];
        }

        if (GameController.skill2Level >= 10)
        {
            Skill4.SetActive(true);
            Skill4Button.SetActive(true);
            skillSelectImage[1].sprite = skills[3];
        }
        else
        {
            Skill4.SetActive(false);
            Skill4Button.SetActive(false);
            skillSelectImage[1].sprite = skills[2];
        }

        if (GameController.skill3Level >= 10 && GameController.skill4Level >= 10)
        {
            Skill5.SetActive(true);
            Skill5Button.SetActive(true);
            skillSelectImage[2].sprite = skills[5];
        }
        else
        {
            Skill5.SetActive(false);
            Skill5Button.SetActive(false);
            skillSelectImage[2].sprite = skills[4];
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
        skillDescription.text = "Attack all enemies on a straight Line using a spinning giant rock, growing rate 100%.";
    }

    public void skill3()
    {
        DescriptionImage.sprite = skillImages[2];
        skillTitle.text = "Cursed chains";
        skillDescription.text = "Take out the soul of 5 enemies, growing rate 120%.";
    }

    public void skill4()
    {
        DescriptionImage.sprite = skillImages[3];
        skillTitle.text = "Charge Attack";
        skillDescription.text = "Attack and track closest 5 enemies, growing rate 120%.";
    }

    public void skill5()
    {
        DescriptionImage.sprite = skillImages[4];
        skillTitle.text = "Holy hand";
        skillDescription.text = "Attack all enemies in range with lightning strikes, growing rate 150%.";
    }

    public void skill1Plus()
    {
        if (GameController.skillPoint > 0)
        {
            Vector3 add = new Vector3(-slot.transform.position.x, -slot.transform.position.y, transform.position.z);
            var Effect = Instantiate(effect, slot.transform.position + add, Quaternion.identity) as GameObject;
            Effect.transform.SetParent(slot.transform, false);
            Destroy(Effect, 1f);
            GameController.skill1Level++;
            GameController.skillPoint--;
        }
    }
    public void skill2Plus()
    {

        if (GameController.skillPoint > 0)
        {
            Vector3 add = new Vector3(-slot.transform.position.x, -slot.transform.position.y, transform.position.z);
            var Effect = Instantiate(effect, slot.transform.position + add, Quaternion.identity) as GameObject;
            Effect.transform.SetParent(slot.transform, false);
            Destroy(Effect, 1f);
            GameController.skill2Level++;
            GameController.skillPoint--;
        }

    }

    public void skill3Plus()
    {
        if (GameController.skillPoint > 0)
        {
            Vector3 add = new Vector3(-slot.transform.position.x, -slot.transform.position.y, transform.position.z);
            var Effect = Instantiate(effect, slot.transform.position + add, Quaternion.identity) as GameObject;
            Effect.transform.SetParent(slot.transform, false);
            Destroy(Effect, 1f);
            GameController.skill3Level++;
            GameController.skillPoint--;
        }
    }

    public void skill4Plus()
    {
        if (GameController.skillPoint > 0)
        {
            Vector3 add = new Vector3(-slot.transform.position.x, -slot.transform.position.y, transform.position.z);
            var Effect = Instantiate(effect, slot.transform.position + add, Quaternion.identity) as GameObject;
            Effect.transform.SetParent(slot.transform, false);
            Destroy(Effect, 1f);
            GameController.skill4Level++;
            GameController.skillPoint--;
        }
    }
    public void skill5Plus()
    {
        if (GameController.skillPoint > 0)
        {
            Vector3 add = new Vector3(-slot.transform.position.x, -slot.transform.position.y, transform.position.z);
            var Effect = Instantiate(effect, slot.transform.position + add, Quaternion.identity) as GameObject;
            Effect.transform.SetParent(slot.transform, false);
            Destroy(Effect, 1f);
            GameController.skill5Level++;
            GameController.skillPoint--;
        }
    }

    public void skill1Minus()
    {
        if (GameController.skill1Level > 1)
        {
            currentskill = 1;
            alert.SetActive(true);
        }
    }
    public void skill2Minus()
    {
        if (GameController.skill2Level > 1)
        {
            currentskill = 2;
            alert.SetActive(true);
        }
    }

    public void skill3Minus()
    {
        if (GameController.skill3Level > 1)
        {
            currentskill = 3;
            alert.SetActive(true);
        }
    }

    public void skill4Minus()
    {
        if (GameController.skill4Level > 1)
        {
            currentskill = 4;
            alert.SetActive(true);
        }
    }
    public void skill5Minus()
    {

        if (GameController.skill5Level > 1)
        {
            currentskill = 5;
            alert.SetActive(true);
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
        skillDescription.text = "Attack all enemies on a straight Line using a spinning giant rock, growing rate 100%.";
    }
    public void SelectSkill3()
    {
        GameController.currentSkill = 2;
        selectAudio.Play();
        DescriptionImage.sprite = skillImages[2];
        skillTitle.text = "Cursed chains";
        skillDescription.text = "Take out the soul of 5 enemies, growing rate 120%.";
    }
    public void SelectSkill4()
    {
        GameController.currentSkill = 3;
        selectAudio.Play();
        DescriptionImage.sprite = skillImages[3];
        skillTitle.text = "Charge Attack";
        skillDescription.text = "Attack and track closest 5 enemies, growing rate 120%.";
    }
    public void SelectSkill5()
    {
        GameController.currentSkill = 4;
        selectAudio.Play();
        DescriptionImage.sprite = skillImages[4];
        skillTitle.text = "Holy hand";
        skillDescription.text = "Attack all enemies in range with lightning strikes, growing rate 150%.";
    }

    public void closeAlert()
    {
        alert.SetActive(false);
        alert1.SetActive(false);
    }
    public void comfirmAlert()
    {
        if (GameController.diamonds > 99)
        {
            switch (currentskill)
            {
                case 1:
                    GameController.skill1Level--;
                    GameController.diamonds -= 10;
                    break;
                case 2:
                    GameController.skill2Level--;
                    GameController.diamonds -= 10;
                    break;
                case 3:
                    GameController.skill3Level--;
                    GameController.diamonds -= 10;
                    break;
                case 4:
                    GameController.skill4Level--;
                    GameController.diamonds -= 10;
                    break;
                case 5:
                    GameController.skill5Level--;
                    GameController.diamonds -= 10;
                    break;
            }
            GameController.skillPoint++;
            alert.SetActive(false);
        }
        else
        {
            var forgedTxt = Instantiate(notEnoughText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(skillPanel.transform, false);
            Destroy(forgedTxt, 0.5f);
        }
    }
    public void reset()
    {
        alert1.SetActive(true);
    }
    public void comfirmReset()
    {
        if (GameController.diamonds > 99)
        {
            alert1.SetActive(false);
            GameController.diamonds -= 100;
            GameController.skillPoint += GameController.skill1Level + GameController.skill2Level + GameController.skill3Level + GameController.skill4Level + GameController.skill5Level - 5;
            GameController.skill1Level = 1;
            GameController.skill2Level = 1;
            GameController.skill3Level = 1;
            GameController.skill4Level = 1;
            GameController.skill5Level = 1;
        }
        else
        {
            var forgedTxt = Instantiate(notEnoughText, new Vector3(5.2f, -166.8f, 0f), Quaternion.identity) as GameObject;
            forgedTxt.transform.SetParent(skillPanel.transform, false);
            Destroy(forgedTxt, 0.5f);
        }
    }
}
