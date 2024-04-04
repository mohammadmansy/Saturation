using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor;
using UnityEngine;

public class TurnOnButton : MonoBehaviour
{
    public GameObject Monitor;
    private void OnMouseUpAsButton()
    {
        if (Monitor.activeInHierarchy == false)
        {
            //GameManager.Instance.TurnMonitorOff();
            //GameManager.IsMonitorON = true;
            Monitor.SetActive(true);
            GetComponent<Renderer>().material.color = Color.green;
        }
    }

}


