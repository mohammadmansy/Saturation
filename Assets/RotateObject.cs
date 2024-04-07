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
        TempCoroCoroutine = StartCoroutine(ChangeTempCoroutine());
        rotationCoroutine = StartCoroutine(RotateObjectCoroutine(36f * GameManager.n)); // Multiply target rotation by n
            GameManager.currentPower = Mathf.RoundToInt(3000 * GameManager.n); 
            GameManager.Instance.HeaterPowerText.text = GameManager.currentPower.ToString();
            GameManager.Instance.HeaterPowerText2.text = GameManager.currentPower.ToString();
    }

    public void RotateOff()
    {

        TempCoroCoroutine = StartCoroutine(ChangeTempCoroutine());
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
    IEnumerator ChangeTempCoroutine()
    {
       // Vector3 tempDirection = (targetTemp >= 0) ? Vector3.left : Vector3.right;
        GameManager.DeltaTemp = (150f * GameManager.n) / 8.368f;
        float timeElapsed = 0f;

        //while (GameManager.DeltaTemp < Mathf.Abs(targetTemp))
        //{
            // Calculate deltaTemp for this frame
           // float deltaTempThisFrame = GameManager.DeltaTemp * Time.deltaTime;

        // Add deltaTemp to DeltaTemp
       // GameManager.DeltaTemp += Mathf.RoundToInt(deltaTempThisFrame);

        // Update currentTemp
        GameManager.currentTemp = GameManager.DeltaTemp+GameManager.TempAmbient;
            GameManager.currentTemp = Mathf.Min(GameManager.currentTemp, 100f);
            GameManager.Instance.TempText.text = GameManager.currentTemp.ToString();
            GameManager.Instance.TempText2.text = GameManager.currentTemp.ToString();

            // Update time elapsed
            timeElapsed += Time.deltaTime;

            yield return null;
        }
    }



