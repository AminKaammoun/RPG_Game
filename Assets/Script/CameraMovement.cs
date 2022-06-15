using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform target;
    public float smoothing;
    public static Vector2 maxPosition;
    public static Vector2 minPosition;

    public static bool shake = false;
    public static bool bigShake = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (shake)
        {
            StartCoroutine(Shake(0.05f));
            shake = false;
        }
        if (bigShake)
        {
            StartCoroutine(Shake(0.25f));
            bigShake = false;
        }
        if (transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);

            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);

            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }

    }
    public IEnumerator Shake(float duration)
    {
        Vector3 orignalPosition = transform.position;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            transform.position = orignalPosition + Random.insideUnitSphere;

            yield return null;
        }
        transform.position = orignalPosition;
    }
}
