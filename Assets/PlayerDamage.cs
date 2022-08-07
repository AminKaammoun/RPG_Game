using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private Transform Target;
    public GameObject textMesh;
    public static int num;

    Vector3 add = new Vector3(0f, 0.75f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindWithTag("Player").transform;
        Destroy(this.gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position + add;
        if (num == 0)
        {
            float attack = Enemy.attack;
            float damage = attack * (100 / (100 + PlayerMovements.defence));
            textMesh.GetComponent<TextMesh>().text = "-" + ((int)damage).ToString();
        }
        else if (num == 1)
        {
            float attack = Worm.attack;
            float damage = attack * (100 / (100 + PlayerMovements.defence));
            textMesh.GetComponent<TextMesh>().text = "-" + ((int)damage).ToString();
        }
        else if (num == 2)
        {
            float attack = Cyclop.attack;
            float damage = attack * (100 / (100 + PlayerMovements.defence));
            textMesh.GetComponent<TextMesh>().text = "-" + ((int)damage).ToString();
        }

    }

}
