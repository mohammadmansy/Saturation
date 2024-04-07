using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillTank : MonoBehaviour
{
    public Transform fillLevel; // This is a GameObject representing the filling level inside the cylinder
    public float fillSpeed = 0.2f; // Speed at which the cylinder fills/empties
    public bool valveOpen = false; // Track whether the valve is open or closed
    public float upperLimit = 1f; // Upper limit of the fill level
    public float lowerLimit = 0f; 

    void Update()
    {
        if (GameManager.IsMonitorON)
        {
            if (GameManager.IsUpperValveOpen && GameManager.IsLowerValveOpen)
            {
                fillLevel.localScale += new Vector3(0, 0, fillSpeed * Time.deltaTime);
            }

        }
        else
        {
            if (GameManager.IsUpperValveOpen && GameManager.IsLowerValveOpen)
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

    //public void OpenValve()
    //{
    //    valveOpen = true;
        
    //}

    //public void CloseValve()
    //{
    //    valveOpen = false;
    //}
}
