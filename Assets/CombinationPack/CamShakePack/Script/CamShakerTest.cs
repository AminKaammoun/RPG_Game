using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShakerTest : MonoBehaviour
{
    [Header("OnClick")]
    public float intensity_cli = .1f;
    public float duration_cli = .5f;

    [Header("OnImpact")]
    public float intensity_imp = .1f;
    public float duration_imp = .1f;
    
    
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CamShaker._instance.Shake(duration_cli, intensity_cli);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        CamShaker._instance.Shake(duration_imp, intensity_imp);
    }
}
