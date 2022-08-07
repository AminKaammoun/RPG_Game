using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class damageText : MonoBehaviour
{
    public GameObject textMesh;
    public static int num;

    // Start is called before the first frame update
    private void Update()
    {
        if (num == 0)
        {
            float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
            float damage = attack * (100 / (100 + Enemy.defence));
            textMesh.GetComponent<TextMesh>().text = ((int)damage).ToString();
        }
        else if (num == 1)
        {
            float attack = PlayerMovements.attack + (PlayerMovements.agility / 2) + (PlayerMovements.Sp / 2);
            float damage = attack * (100 / (100 + Worm.defence));
            textMesh.GetComponent<TextMesh>().text = ((int)damage).ToString();
        }
    }
}
