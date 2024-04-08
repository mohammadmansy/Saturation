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
    public TemperatureManager temperatureManager;

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void RotateOn()
    {
        if ( GameManager.IsSwitchOpen && GameManager.IsUpperValveOpen)
        {
            temperatureManager.StartCoroutine(temperatureManager.UpdateTemperature());

        }
            rotationCoroutine = StartCoroutine(RotateObjectCoroutine(36f * GameManager.n)); 
            GameManager.currentPower = Mathf.RoundToInt(3000 * GameManager.n); 
            GameManager.Instance.HeaterPowerText.text = GameManager.currentPower.ToString();
            GameManager.Instance.HeaterPowerText2.text = GameManager.currentPower.ToString();
    }

    public void RotateOff()
    {
        if (GameManager.IsSwitchOpen && GameManager.IsUpperValveOpen)
        {
            temperatureManager.StartCoroutine(temperatureManager.UpdateTemperature());

        }

        rotationCoroutine = StartCoroutine(RotateObjectCoroutine(-36f * GameManager.n)); 
            GameManager.currentPower = Mathf.RoundToInt(3000 * GameManager.n); 
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

}



