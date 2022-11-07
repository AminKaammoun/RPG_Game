using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggShop : MonoBehaviour
{

    public GameObject effect;
    public GameObject slot;
    public GameObject slot2;
    public GameObject slot3;
    public Animator egg1SwitchAnim;
    public Animator egg2SwitchAnim;
    public Animator egg3SwitchAnim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void EggFeed()
    {
        Vector3 add = new Vector3(-slot.transform.position.x, -slot.transform.position.y, transform.position.z);
        var Effect = Instantiate(effect, slot.transform.position + add, Quaternion.identity) as GameObject;
        Effect.transform.SetParent(slot.transform, false);
        Destroy(Effect, 1f);
        egg1SwitchAnim.SetBool("Press", true);
        StartCoroutine(backSwitch());
    }

    public void EggFeed2()
    {
        Vector3 add = new Vector3(-slot2.transform.position.x, -slot2.transform.position.y, transform.position.z);
        var Effect = Instantiate(effect, slot2.transform.position + add, Quaternion.identity) as GameObject;
        Effect.transform.SetParent(slot2.transform, false);
        Destroy(Effect, 1f);
        egg2SwitchAnim.SetBool("Press", true);
        StartCoroutine(backSwitch());
    }

    public void EggFeed3()
    {
        Vector3 add = new Vector3(-slot3.transform.position.x, -slot3.transform.position.y, transform.position.z);
        var Effect = Instantiate(effect, slot3.transform.position + add, Quaternion.identity) as GameObject;
        Effect.transform.SetParent(slot3.transform, false);
        Destroy(Effect, 1f);
        egg3SwitchAnim.SetBool("Press", true);
        StartCoroutine(backSwitch());
    }


    IEnumerator backSwitch()
    {
        yield return new WaitForSeconds(0.5f);
        egg1SwitchAnim.SetBool("Press", false);
        egg2SwitchAnim.SetBool("Press", false);
        egg3SwitchAnim.SetBool("Press", false);
    }
}
