using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAnimation : MonoBehaviour
{
    public static event Action<float> OnFillAmountChanged;
    //public GameObject Valve;
    public Animator Anime;
    private float currentFillAmount = 0;
    private void OnMouseUpAsButton()
    {
        //GetComponent<Animator>().gameObject.SetActive(true);
        //Valve.SetActive(true);
        //if (Anime.SetBool=true )
        if(CompareTag("Upper Valve"))
        {
            if (!GameManager.IsUpperValveOpen)
            {
                Anime.SetBool("TurnOnAndOff", true);
                //Anime.SetBool("TurnOn", false);
                //else
                //  Anime.SetBool("TurnOff", true);

                //ChangeFillAmount(currentFillAmount);
                GameManager.IsUpperValveOpen = true;
            }
            else
            {
                Anime.SetBool("TurnOnAndOff", true);
                //Anime.SetBool("TurnOn", false);
                //else
                //  Anime.SetBool("TurnOff", true);

                Debug.Log("HiDown");
                //ChangeFillAmount(currentFillAmount);
                GameManager.IsUpperValveOpen = false;
            }

        }
        if (CompareTag("Lower Valve"))
        {
            if (!GameManager.IsLowerValveOpen)
            {
                Anime.SetBool("TurnOnAndOff", true);
                GameManager.IsLowerValveOpen = true;
            }
            else
            {
                Anime.SetBool("TurnOnAndOff", true);
                GameManager.IsLowerValveOpen = false;
            }
        }
        if (CompareTag("Switch"))
        {
            if (!GameManager.IsSwitchOpen)
            {

                Anime.SetBool("SwitchOnAndOff", true);
                GameManager.IsSwitchOpen = true;
            }
            else
            {
                Anime.SetBool("SwitchOnAndOff", true);
                GameManager.IsSwitchOpen = false;
            }

        }




    }
    public void ChangeFillAmount(float _amount)
    {
        currentFillAmount -= _amount;
        OnFillAmountChanged(currentFillAmount);
    }
}
