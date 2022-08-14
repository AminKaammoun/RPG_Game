using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;

public class BoomEffect : MonoBehaviour
{
    
    public Material ripplemat;
    public Texture texture;
    private bool rippling;
    private RawImage ri;
    public Vector2 position;
    // Start is called before the first frame update
    void Start()
    {
        rippling = false;
        ri = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ripplemat.GetFloat("TimeStep") < 1&&rippling)
        {
            //Rippling
            ri.material = ripplemat;
            ri.texture = texture;
            ri.color = Vector4.one;
            ripplemat.SetFloat("TimeStep", ripplemat.GetFloat("TimeStep") + (ripplemat.GetFloat("Speed") * Time.deltaTime));
            //Active world position tracking.
            ripplemat.SetVector("FocalPoint", new Vector4((((position.x - transform.position.x) / 18) + 0.5f), (((position.y - transform.position.y) / 10) + 0.5f), 0, 0));
        }
        else
        {
            //End Ripple
            ripplemat.SetFloat("TimeStep", 0);
            rippling = false;
            ripplemat.SetVector("FocalPoint", new Vector4(1, 1));
           
        }
    }

    

    public void SetFocus(Vector2 pos)
    {
        //This first takes the position, and makes it relative to the current position of the texture
        //Then it takes the X and makes it proportional to the width of the cam
        //Then the hight of the cam for Y
        //Finally it gives it the origin offset. As 0.5 0.5 is the center of the texture. 

        ripplemat.SetVector("FocalPoint", new Vector4((((pos.x-transform.position.x) / 18) + 0.5f), (((pos.y - transform.position.y) / 10) + 0.5f), 0, 0));
        
        //This is done in order to make sure the distortion stays in the same relative world space.
        position = pos;
    }

    public void Boom(Vector2 position, float speed = 1, float magnituted = -0.5f, float size = 0.11f)
    {
        rippling = true;
        SetFocus(position);
        ripplemat.SetFloat("Speed", speed);
        ripplemat.SetFloat("Magnification", magnituted);
        ripplemat.SetFloat("Size", size);
    }

    
}
