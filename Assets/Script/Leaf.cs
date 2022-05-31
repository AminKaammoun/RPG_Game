using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : MonoBehaviour
{
    public float speed = 1f;
    Vector2 up_left = Vector2.down + Vector2.right;
    private SpriteRenderer leaf;
    public float existTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        leaf = GetComponent<SpriteRenderer>();
        Color c = leaf.material.color;
        c.a = 0f;
        StartCoroutine(FadeIn());
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(up_left * speed * Time.deltaTime);
       if(existTime > 0)
        {
            existTime -= Time.deltaTime;
        }
        else
        {
            existTime = 3f;
            StartCoroutine(FadeOut());
        }
       
    }

IEnumerator FadeIn()
    {
        for (float f = 0.05f; f<= 1; f+= 0.05f)
        {
            Color c = leaf.material.color;
            c.a = f;
            leaf.material.color = c;
            yield return new WaitForSeconds(0.05f);
           
        }
    }

    IEnumerator FadeOut()
    {
        for (float f = 1f; f >= -0.05; f -= 0.05f)
        {
            Color c = leaf.material.color;
            c.a = f;
            leaf.material.color = c;
            yield return new WaitForSeconds(0.05f);
            
        }
        Destroy(gameObject);
    }
}
