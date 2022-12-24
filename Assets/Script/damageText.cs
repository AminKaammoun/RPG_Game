using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class damageText : MonoBehaviour
{
    public GameObject textMesh;
    public static int num;


    // Start is called before the first frame update
    void Start()
    {

        Destroy(this.gameObject, 0.5f);
    }
    private void Update()
    {
        if (num == -5)
        {
            float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
            float damage = attack * (100 / (100 + Enemy.defence));
            damage = damage * 1.5f;
            damage = damage + (GameController.skill5Level * 1.5f);
            textMesh.GetComponent<TextMeshPro>().text = "-" + ((int)damage).ToString();
        }
        if (num == -4)
        {
            float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
            float damage = attack * (100 / (100 + Enemy.defence));
            damage = damage * 1.2f;
            damage = damage + (GameController.skill4Level * 1.2f);
            textMesh.GetComponent<TextMeshPro>().text = "-" + ((int)damage).ToString();
        }
        if (num == -3)
        {
            float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
            float damage = attack * (100 / (100 + Enemy.defence));
            damage = damage * 1.2f;
            damage = damage + (GameController.skill3Level * 1.2f);
            textMesh.GetComponent<TextMeshPro>().text = "-" + ((int)damage).ToString();
        }

        if (num == -2)
        {
            float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
            float damage = attack * (100 / (100 + Enemy.defence));
            damage = damage + (GameController.skill2Level);
            textMesh.GetComponent<TextMeshPro>().text = "-" + ((int)damage).ToString();
        }

        if (num == -1)
        {
            float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
            float damage = attack * (100 / (100 + Enemy.defence));
            damage = damage + (GameController.skill1Level);
            textMesh.GetComponent<TextMeshPro>().text = "-" + ((int)damage).ToString();
        }

        else if (num == 0)
        {
            float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
            float damage = attack * (100 / (100 + Enemy.defence));
            textMesh.GetComponent<TextMeshPro>().text = "-" + ((int)damage).ToString();
        }
        else if (num == 1)
        {
            float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
            float damage = attack * (100 / (100 + Worm.defence));
            textMesh.GetComponent<TextMeshPro>().text = "-" + ((int)damage).ToString();
        }
        else if (num == 2)
        {
            float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
            float damage = attack * (100 / (100 + Cyclop.defence));
            textMesh.GetComponent<TextMeshPro>().text = "-" + ((int)damage).ToString();
        }
        else if (num == 3)
        {
            float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
            float damage = attack * (100 / (100 + Worm.defence));
            textMesh.GetComponent<TextMeshPro>().text = "-" + ((int)damage).ToString();
        }
        else if (num == 4)
        {
            float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
            float damage = attack * (100 / (100 + Cyclop.defence));
            textMesh.GetComponent<TextMeshPro>().text = "-" + ((int)damage).ToString();
        }
        else if (num == 5)
        {
            float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
            float damage = attack * (100 / (100 + lizard.defence));
            textMesh.GetComponent<TextMeshPro>().text = "-" + ((int)damage).ToString();
        }
        else if (num == 6)
        {
            float attack = PlayerMovements.Sp * 5 + (PlayerMovements.agility / 2) + (PlayerMovements.attack / 2);
            float damage = attack * (100 / (100 + lizard.defence));
            textMesh.GetComponent<TextMeshPro>().text = "-" + ((int)damage).ToString();
        }
    }
}
