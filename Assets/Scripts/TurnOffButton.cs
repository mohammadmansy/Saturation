using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffButton : MonoBehaviour
{
    public GameObject Monitor;
    public GameObject Temp;
    public GameObject Power;
    public Renderer ButtonOff;
    public TurnOnButton instance;
    private void OnMouseUpAsButton()
    {
        if (Monitor.activeInHierarchy == true)
        {

            Monitor.SetActive(false);
            Temp.SetActive(false);
            Power.SetActive(false);

            ButtonOff.material.color = Color.red;

            if (instance.ButtonON.material.color == Color.green)
            {
                instance.ButtonON.material.color = Color.white;
            }

            GameManager.IsMonitorON = false;
            GameManager.Instance.TempText.text = "25";
            GameManager.Instance.TempText2.text = "25";



        }

    }

}
