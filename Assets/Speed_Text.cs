using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Speed_Text : MonoBehaviour
{
    public TMP_Text myText;

    // Update is called once per frame
    public void textUpdate(float value)
    {
        myText.SetText("Acceleration: " + value.ToString("n2"));
        
    }
}
