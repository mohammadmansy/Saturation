using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class TemperatureManager : MonoBehaviour
{
    // GameManager variables
    public float currentTemp = 25f;
    public float n = 1f; // You can adjust this value as needed
    public Animator BoillingAnime;
    public Image TempBarImage;

    // Update interval
    public float updateInterval = 1f; // in seconds

    // Delta temperature calculation
    private float CalculateDeltaTemp()
    {
        return (150 * n) / 8.368f;
    }

    // Update temperature every second
    public IEnumerator UpdateTemperature()
    {
        while (GameManager.IsSwitchOpen)
        {
            // Calculate delta temperature
            float deltaTemp = CalculateDeltaTemp();

            // Update current temperature
            currentTemp += Mathf.Round( deltaTemp*Time.deltaTime);
            GameManager.Instance.TempText.text = currentTemp.ToString();
            GameManager.Instance.TempText2.text = currentTemp.ToString();
            TempBarImage.fillAmount = currentTemp / 200f;

            // Output current temperature
            Debug.Log("Current Temperature: " + currentTemp);
            Debug.Log(GameManager.IsSwitchOpen);
            if (currentTemp >=100) 
            {
                       GameManager.IsBoil = true;
                       BoillingAnime.SetTrigger("Boiling");

            }
            yield return new WaitForSeconds(updateInterval);
        }
    }

    private void Start()
    {
        // Start updating temperature
        //StartCoroutine(UpdateTemperature());
    }
}
