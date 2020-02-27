using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenBar : MonoBehaviour
{
    Image oxygenbar;
    public float maxOxygen = 100f;
    public static float oxygen;

    void Awake()
    {
        oxygenbar = GetComponent<Image>();
        oxygen = maxOxygen;
    }

    void Update()
    {
        if (oxygenbar != null)
        {
            oxygenbar.fillAmount = oxygen / maxOxygen;
        }

       
    }

}
