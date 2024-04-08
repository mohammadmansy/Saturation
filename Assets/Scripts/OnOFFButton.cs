using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOFFButton : MonoBehaviour
{
    public GameObject Monitor;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void OnButtonPressed()
    {
        if (Monitor.activeInHierarchy == true)
        {
            Monitor.SetActive(false);
        }
        else
            Monitor.SetActive(true);
    }
    //private void OnMouseEnter()
    //{
    //    GetComponent<Renderer>().material.color = Color.green;
    //}
    private void OnMouseUpAsButton()
    {
        if (Monitor.activeInHierarchy == false)
        {
            Monitor.SetActive(true);
            GetComponent<Renderer>().material.color = Color.green;

        }
        else
        {
            Monitor.SetActive(false);
            GetComponent<Renderer>().material.color = Color.red;
        }


    }


    //private void OnMouseExit()
    //{
    //    GetComponent<Renderer>().material.color = Color.white;
    //}
}
