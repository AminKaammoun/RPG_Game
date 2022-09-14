using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability3Potion : MonoBehaviour
{
    public static bool isPlaced;

    public GameObject BigHealth;
    public GameObject SmallHealth;
    public GameObject BigShield;
    public GameObject SmallShield;
    public GameObject BigSpeed;
    public GameObject SmallSpeed;

    // Start is called before the first frame update
    void Start()
    {

        Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
        switch (GameController.ability3)
        {
            case "Big Heal Potion (potionObject)":
                var atk1gear = Instantiate(BigHealth, transform.position + add, Quaternion.identity) as GameObject;
                atk1gear.transform.SetParent(GameObject.FindGameObjectWithTag("ability3").transform, false);
                break;
            case "Small Health Potion (potionObject)":
                var atk10gear = Instantiate(SmallHealth, transform.position + add, Quaternion.identity) as GameObject;
                atk10gear.transform.SetParent(GameObject.FindGameObjectWithTag("ability3").transform, false);
                break;
            case "Big sheild Potion (potionObject)":
                var bigShield = Instantiate(BigShield, transform.position + add, Quaternion.identity) as GameObject;
                bigShield.transform.SetParent(GameObject.FindGameObjectWithTag("ability3").transform, false);
                break;
            case "Small Shield Potion (potionObject)":
                var smallShield = Instantiate(SmallShield, transform.position + add, Quaternion.identity) as GameObject;
                smallShield.transform.SetParent(GameObject.FindGameObjectWithTag("ability3").transform, false);
                break;
            case "Big Speed Potion (potionObject)":
                var bigSpeed = Instantiate(BigSpeed, transform.position + add, Quaternion.identity) as GameObject;
                bigSpeed.transform.SetParent(GameObject.FindGameObjectWithTag("ability3").transform, false);
                break;
            case "Small Speed Potion (potionObject)":
                var smallSpeed = Instantiate(SmallSpeed, transform.position + add, Quaternion.identity) as GameObject;
                smallSpeed.transform.SetParent(GameObject.FindGameObjectWithTag("ability3").transform, false);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaced)
        {
            isPlaced = false;
            Vector3 add = new Vector3(-transform.position.x, -transform.position.y, 0f);
            switch (GameController.ability3)
            {
                case "Big Heal Potion (potionObject)":
                    var atk1gear = Instantiate(BigHealth, transform.position + add, Quaternion.identity) as GameObject;
                    atk1gear.transform.SetParent(GameObject.FindGameObjectWithTag("ability3").transform, false);
                    break;
                case "Small Health Potion (potionObject)":
                    var atk10gear = Instantiate(SmallHealth, transform.position + add, Quaternion.identity) as GameObject;
                    atk10gear.transform.SetParent(GameObject.FindGameObjectWithTag("ability3").transform, false);
                    break;
                case "Big sheild Potion (potionObject)":
                    var bigShield = Instantiate(BigShield, transform.position + add, Quaternion.identity) as GameObject;
                    bigShield.transform.SetParent(GameObject.FindGameObjectWithTag("ability3").transform, false);
                    break;
                case "Small Shield Potion (potionObject)":
                    var smallShield = Instantiate(SmallShield, transform.position + add, Quaternion.identity) as GameObject;
                    smallShield.transform.SetParent(GameObject.FindGameObjectWithTag("ability3").transform, false);
                    break;
                case "Big Speed Potion (potionObject)":
                    var bigSpeed = Instantiate(BigSpeed, transform.position + add, Quaternion.identity) as GameObject;
                    bigSpeed.transform.SetParent(GameObject.FindGameObjectWithTag("ability3").transform, false);
                    break;
                case "Small Speed Potion (potionObject)":
                    var smallSpeed = Instantiate(SmallSpeed, transform.position + add, Quaternion.identity) as GameObject;
                    smallSpeed.transform.SetParent(GameObject.FindGameObjectWithTag("ability3").transform, false);
                    break;
            }
        }
    }
}