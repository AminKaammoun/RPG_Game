using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraMovement : MonoBehaviour
{

    public Transform target;
    public float smoothing;
    public static Vector2 maxPosition;
    public static Vector2 minPosition;

    public static bool shake = false;
    public static bool bigShake = false;
    public static bool bigbigShake = false;
    public static bool longUltShake = false;
    public static bool SuperLongUltShake = false;
    public static bool longShakeEnemy = false;
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

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
        if (bigbigShake)
        {
            StartCoroutine(Shake(0.5f));
            bigbigShake = false;
        }
        if (longUltShake)
        {
            StartCoroutine(SoftShake(1.5f));
            longUltShake = false;
        }
        if (longShakeEnemy)
        {
            StartCoroutine(SoftShake(2.5f));
            cam.orthographicSize = 1f;
            longShakeEnemy = false;
        }
        if (SuperLongUltShake)
        {
            StartCoroutine(SoftShake(7f));
            SuperLongUltShake = false;
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

    public IEnumerator SoftShake(float duration)
    {
        Vector3 orignalPosition = transform.position;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            transform.position = orignalPosition + Random.insideUnitSphere * 0.05f;

            yield return null;
        }
        transform.position = orignalPosition;
    }
}
