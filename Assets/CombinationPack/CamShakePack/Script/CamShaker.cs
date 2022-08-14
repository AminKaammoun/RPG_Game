using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;


public class CamShaker : MonoBehaviour
{

    /// <summary>
    /// This Script along with it's prefab allows you to easily shake the cam, while maintaining tracking, animation, and other camera movement options.
    /// It does this by using a rendered texture of the scene which is displayed over everything. Instead of moving the cam, the texture is moved.
    /// The primary fuctions are accessed as follows:
    /// CamShaker._instance.Shake(10, 1f);  //This shakes the cam for 10 seconds, with an intensity of 1.
    /// CamShaker._instance.Shake(10,1f,curve1); //This shakes the cam for 10 seconds, with an intensity of 1 at a rate determined by an Animation Curve.
    /// Cam Shaker also comes with some presets which only require a duration. 
    /// </summary>
    public static CamShaker _instance;

    [SerializeField]
    private Camera mainCam, localCam;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            if (_instance!=this)
            {
                Destroy(this);
            }
        }
    }

    private void Start()
    {
        localCam = GetComponent<Camera>();
        localCam.backgroundColor = mainCam.backgroundColor;
    }

    public async void Shake(float _duration, float _intensity)
    {
        //Debug.Log("Start Shaking");
        
        var end = Time.time + _duration;
        while(Time.time < end)
        {
            //Debug.Log("Shaking");
            _instance.gameObject.transform.position = new Vector3(Random.Range(-5,5)* (_intensity/5), Random.Range(-5, 5) * (_intensity / 5), -10)+mainCam.transform.position;
            await Task.Yield();
        }
        _instance.gameObject.transform.position = mainCam.transform.position;
        //Debug.Log("End");
    }



    ///PreSets///
    public void BigShake(float duration)
    {
        Shake(duration, 1f);
    }

    public void NormalShake(float duration)
    {
        Shake(duration, .5f);
    }

    public void SmallShake(float duration)
    {
        Shake(duration, .1f);
    }


    //This allows you to pass in a spesific animation curve so that you can control the exact animation pattern you want the shake intensity to mimic. 
    public async void Shake(float _duration, float _intensity, AnimationCurve curve)
    {
        //Debug.Log("Start Shaking");
        
        var end = Time.time + _duration;
        float t = 0;
        
        while (Time.time < end)
        {
            t += Time.deltaTime;
            //Debug.Log("Shaking");
            _instance.gameObject.transform.position = new Vector3(Random.Range(-5, 5) * (_intensity / 5)*curve.Evaluate(t), Random.Range(-5, 5) * (_intensity / 5)* curve.Evaluate(t), -10) + mainCam.transform.position;
            await Task.Yield();
        }
        _instance.gameObject.transform.position = mainCam.transform.position;
        //Debug.Log("End");
    }
}

