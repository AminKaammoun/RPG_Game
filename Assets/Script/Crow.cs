using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow : MonoBehaviour
{

    Vector3 direction;
    private float speed = 10f;
    private SpriteRenderer crow;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3f);
        crow = GetComponent<SpriteRenderer>();
        float rand = Random.Range(-1, 2);
        float rand1 = Random.Range(-1, 2);
        while (rand == 0 && rand1 == 0)
        {
            rand = Random.Range(-1, 2);
            rand1 = Random.Range(-1, 2);
        }
        if (rand < 0)
        {
            crow.flipX = true;
        }
        else
        {
            crow.flipX = false;
        }
        direction = new Vector3(rand, rand1, 0f);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(direction * speed * Time.deltaTime);
    }
}
