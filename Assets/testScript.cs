using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    public Animator BoillingAnime;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseUpAsButton()
    {
        if (GameManager.IsBoil)
            BoillingAnime.SetBool("BoillingAnimation", true);


    }

}
