using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GameManager.IsSwitchOpen)
        {
            GameManager.HeaterUp = true;
            GameManager.n += 0.1f;

            if (GameManager.n > 1.1)
            {
                GameManager.n = 1;
                return;
            }

            RotateObject.Instance.RotateOn();

        }
    }
    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }


}
