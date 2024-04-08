using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAnimation : MonoBehaviour
{
    public static event Action<float> OnFillAmountChanged;
    public Animator Anime;
    private float currentFillAmount = 0;
    private void OnMouseUpAsButton()
    {
        if(CompareTag("Upper Valve"))
        {
            if (!GameManager.IsUpperValveOpen)
            {
                Anime.SetBool("TurnOnAndOff", true);
                GameManager.IsUpperValveOpen = true;
            }
            else
            {
                Anime.SetBool("TurnOnAndOff", true);
                Debug.Log("HiDown");
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
