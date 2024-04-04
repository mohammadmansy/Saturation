using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffButton : MonoBehaviour
{
    public GameObject Monitor;
    private void OnMouseUpAsButton()
    {
        if (Monitor.activeInHierarchy == true)
        {
            //GameManager.IsMonitorON = false;

            Monitor.SetActive(false);
            GetComponent<Renderer>().material.color = Color.red;
        }

    }

}
