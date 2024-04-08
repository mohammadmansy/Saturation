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
    public Renderer ButtonON;
    public TurnOffButton instance;

    private void OnMouseUpAsButton()
    {
        if (Monitor.activeInHierarchy == false)
        {
            Monitor.SetActive(true);
            Temp.SetActive(true);
            Power.SetActive(true);
            ButtonON.material.color = Color.green;
            if (instance.ButtonOff.material.color == Color.red)
            {
                instance.ButtonOff.material.color = Color.white;

            }

            GameManager.IsMonitorON = true;
            GameManager.Instance.TempText.text = "25";
            GameManager.Instance.TempText2.text = "25";

        }
    }

}


