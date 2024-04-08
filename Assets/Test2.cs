using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GameManager.IsSwitchOpen)
        {
            GameManager.HeaterDown = true;
            GameManager.n -= 0.1f;
            if (GameManager.n <= -.1)
            {
                GameManager.n = 0;
                return;
            }
            RotateObject.Instance.RotateOff();

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
