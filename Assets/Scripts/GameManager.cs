using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<GameManager>(true);
            return _instance;
        }
    }
    public static bool IsMonitorON;
    public static Material m;


    void Start()
    {
        
    }

    void Update()
    {
        
    }
   public void TurnMonitorOff()
   {
        m.color = Color.green;
        Debug.Log("Hello from gamem Manager");
   }






}
