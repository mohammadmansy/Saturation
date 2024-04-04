using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAnimation : MonoBehaviour
{
    public GameObject Valve;
    private void OnMouseUpAsButton()
    {
        if (!Valve.activeInHierarchy)
        {
            Valve.SetActive(true);
            Debug.Log("Hi");
        }
    }
}
