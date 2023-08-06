using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackSmoke : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (this.gameObject.name.Contains("dash"))
        {
            Destroy(this.gameObject, 0.5f);
        }
        else
        {
            Destroy(this.gameObject,0.25f);
        }
        
    }


}
