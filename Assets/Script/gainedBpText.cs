using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gainedBpText : MonoBehaviour
{
    public static int GainedValue;
    public Text GainedValueText;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 1f);
        if (GainedValue > 0)
        {
            GainedValueText.color = Color.green;
            GainedValueText.text = "+" + GainedValue.ToString();
        }
        else if (GainedValue < 0)
        {
            GainedValueText.color = Color.red;
            GainedValueText.text = GainedValue.ToString();
        }
    }


}
