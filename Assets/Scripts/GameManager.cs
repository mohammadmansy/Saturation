using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    public static bool IsMonitorON=false;
    public static bool IsUpperValveOpen = false, IsLowerValveOpen = false ,IsSwitchOpen = false;
    public static bool HeaterUp = false, HeaterDown = false ,IsBoil;
    public static Material m;
    public TextMeshPro HeaterPowerText ,HeaterPowerText2 ,TempText , TempText2;
    public static float n ,currentPower, currentTemp, TempAmbient = 25f, DeltaTemp;

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
