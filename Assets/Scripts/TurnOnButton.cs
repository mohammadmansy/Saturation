using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor;
using UnityEngine;

public class TurnOnButton : MonoBehaviour
{
    public GameObject Monitor;
    public GameObject Temp;
    public GameObject Power;

    private void OnMouseUpAsButton()
    {
        if (Monitor.activeInHierarchy == false)
        {
            //GameManager.Instance.TurnMonitorOff();
            //GameManager.IsMonitorON = true;
            Monitor.SetActive(true);
            Temp.SetActive(true);
            Power.SetActive(true);
            GetComponent<Renderer>().material.color = Color.green;
            GameManager.IsMonitorON = true;
            GameManager.Instance.TempText.text = "25";
            GameManager.Instance.TempText2.text = "25";

        }
    }

}


