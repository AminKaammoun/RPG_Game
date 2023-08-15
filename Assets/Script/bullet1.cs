using UnityEngine;

public class bullet1 : MonoBehaviour
{
    private Transform target;
    private float speed = 4f;
    private bool faceLeft = true;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        Destroy(gameObject,10f);
    }

    // Update is called once per frame
    void Update()
    {
        checkDirection();
        if (target != null)
        {
            // Calculate the direction from the bullet to the target.
            Vector3 direction = (target.position - transform.position).normalized;

            // Move the bullet in the calculated direction.
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }

    void checkDirection()
    {
        if (target.position.x < transform.position.x && faceLeft)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
            faceLeft = false;
        }
        else if (target.position.x > transform.position.x && !faceLeft)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
            faceLeft = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ultSlash"))
        {
            Destroy(gameObject);
        }
    }
}