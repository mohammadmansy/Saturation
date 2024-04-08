using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillTank : MonoBehaviour
{
    public Transform fillLevel; 
    public float fillSpeed = 0.2f;
    public bool valveOpen = false; 
    public float upperLimit = 1f; 
    public float lowerLimit = 0f; 

    void Update()
    {
        if (GameManager.IsMonitorON)
        {
            if ( GameManager.IsLowerValveOpen)
            {
                fillLevel.localScale += new Vector3(0, 0, fillSpeed * Time.deltaTime);
            }

        }
        else
        {
            if ( GameManager.IsLowerValveOpen)
            {
                fillLevel.localScale -= new Vector3(0, 0, fillSpeed * Time.deltaTime);
            }

        }

        float clampedFillLevel = Mathf.Clamp(fillLevel.localScale.z, lowerLimit, upperLimit);
        fillLevel.localScale = new Vector3(
            fillLevel.localScale.x,
            fillLevel.localScale.y,
            clampedFillLevel
        );
    }

}
