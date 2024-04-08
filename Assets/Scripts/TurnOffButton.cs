using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffButton : MonoBehaviour
{
    public GameObject Monitor;
    public GameObject Temp;
    public GameObject Power;

    private void OnMouseUpAsButton()
    {
        if (Monitor.activeInHierarchy == true)
        {

            Monitor.SetActive(false);
            Temp.SetActive(false);
            Power.SetActive(false);

            GetComponent<Renderer>().material.color = Color.red;
            GameManager.IsMonitorON = false;
            GameManager.Instance.TempText.text = "25";
            GameManager.Instance.TempText2.text = "25";



        }

    }

}
