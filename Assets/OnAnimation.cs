using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAnimation : MonoBehaviour
{
    //public GameObject Valve;
    public Animator Anime;
    private void OnMouseUpAsButton()
    {
        //GetComponent<Animator>().gameObject.SetActive(true);
        //Valve.SetActive(true);
        //if (Anime.SetBool=true )
        Anime.SetBool("TurnOn", true);
        //Anime.SetBool("TurnOn", false);
        //else
          //  Anime.SetBool("TurnOff", true);

        Debug.Log("Hi");
    }
}
