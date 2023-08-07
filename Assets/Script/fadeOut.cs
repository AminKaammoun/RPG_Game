using UnityEngine;

public class fadeOut : MonoBehaviour
{
    public float fadeTime = 1.0f; // Time it takes to fade out in seconds

    private Material material;
    private float alpha = 1.0f;

    private void Start()
    {
        Destroy(gameObject,0.5f);
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            material = renderer.material;
        }
        else
        {
            Debug.LogWarning("FadeOut script requires a Renderer component.");
            enabled = false;
        }
    }

    private void Update()
    {
        // Reduce alpha value over time
        alpha -= Time.deltaTime / fadeTime;
        alpha = Mathf.Clamp01(alpha);

        // Update the material's alpha value
        if (material != null)
        {
            Color color = material.color;
            color.a = alpha;
            material.color = color;
        }

        // Disable the object when fully faded out
        if (alpha <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}