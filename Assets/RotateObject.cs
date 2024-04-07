using System.Collections;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    static public RotateObject Instance;
    public GameObject objectRotate;
    public float rotateSpeed = 50f;
    public bool rotateStatus = false;

    public Coroutine rotationCoroutine;
    public Coroutine TempCoroCoroutine;
    //public Animator BoillingAnime;
    public TemperatureManager temperatureManager;
    //public float n = 0f; // Initial value of n

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    // Rotate object function
    public void RotateOn()
    {
        if ( GameManager.IsSwitchOpen && GameManager.IsUpperValveOpen)
        {
            temperatureManager.StartCoroutine(temperatureManager.UpdateTemperature());

        }
            rotationCoroutine = StartCoroutine(RotateObjectCoroutine(36f * GameManager.n)); // Multiply target rotation by n
            GameManager.currentPower = Mathf.RoundToInt(3000 * GameManager.n); 
            GameManager.Instance.HeaterPowerText.text = GameManager.currentPower.ToString();
            GameManager.Instance.HeaterPowerText2.text = GameManager.currentPower.ToString();
    }

    public void RotateOff()
    {

            //TempCoroCoroutine = StartCoroutine(ChangeTempCoroutine());
            rotationCoroutine = StartCoroutine(RotateObjectCoroutine(-36f * GameManager.n)); // Multiply target rotation by n
            GameManager.currentPower = Mathf.RoundToInt(3000 * GameManager.n); // Adjust currentPower based on n
            GameManager.Instance.HeaterPowerText.text = GameManager.currentPower.ToString();
            GameManager.Instance.HeaterPowerText2.text = GameManager.currentPower.ToString();
    }

    IEnumerator RotateObjectCoroutine(float targetRotation)
    {
        float currentRotation = 0f;
        Vector3 rotationDirection = (targetRotation >= 0) ? Vector3.left : Vector3.right;

        while (currentRotation < Mathf.Abs(targetRotation))
        {
            objectRotate.transform.Rotate(rotationDirection, rotateSpeed * Time.deltaTime);
            currentRotation += Mathf.Abs(rotateSpeed * Time.deltaTime);

            yield return null;
        }
    }
    //IEnumerator ChangeTempCoroutine(float temp)
    //{
    //    // float baseTemperatureChangeRate = 150f;
    //    // float exponent = 8.368f;
    //    //float maxTemperature = 100f;
    //    //float initialTemp = 25f;

    //    float deltaT = temp * Time.deltaTime;
    //    //GameManager.currentTemp = initialTemp + deltaT;

    //    //while (GameManager.currentTemp < maxTemperature)
    //    //{
    //    //    GameManager.currentTemp += deltaT;
    //    //    GameManager.currentTemp = Mathf.Min(GameManager.currentTemp, maxTemperature);
    //    //    if (GameManager.currentTemp >= 100 && GameManager.IsUpperValveOpen && GameManager.IsLowerValveOpen)
    //    //    {
    //    //        GameManager.IsBoil = true;
    //    //        BoillingAnime.SetTrigger("Boiling");
    //    //        if (Input.GetKeyDown(KeyCode.Space))
    //    //        {
    //    //            GameManager.IsBoil = false;
    //    //            BoillingAnime.SetTrigger("NonBoilling");
    //    //            Debug.Log("kakakakaka");
    //    //        }

    //    //    }

    //    //    //GameManager.currentTemp = Mathf.Round(GameManager.currentTemp);
    //    //    GameManager.Instance.TempText.text = GameManager.currentTemp.ToString();
    //    //    GameManager.Instance.TempText2.text = GameManager.currentTemp.ToString();
    //    yield return null;
    //    //}


    //}
    //public float StoreTemp() 
    //{
    //    GameManager.currentTemp = GameManager.TempAmbient;
    //    GameManager.DeltaTemp = (150 * GameManager.n) / 8.368f;
    //    GameManager.currentTemp += GameManager.DeltaTemp; 
    //    Debug.Log((GameManager.currentTemp));
    //    StartCoroutine(ChangeTempCoroutine(GameManager.currentTemp));
    //    return GameManager.currentTemp;
    //}

}



