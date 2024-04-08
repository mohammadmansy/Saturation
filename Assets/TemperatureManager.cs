using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class TemperatureManager : MonoBehaviour
{
    public float currentTemp = 25f;
    public float n = .1f; 
    public Animator BoillingAnime;
    public Animator NonBoillingAnime;

    public Image TempBarImage;

    public float updateInterval = 1f;

    private float CalculateDeltaTemp()
    {
        return (150 * n) / 8.368f;
    }

    public IEnumerator UpdateTemperature()
    {
        while (true)
        {
            if (GameManager.IsSwitchOpen)
            {
                float deltaTemp = CalculateDeltaTemp();

                currentTemp += Mathf.Round(deltaTemp * Time.deltaTime);
                GameManager.Instance.TempText.text = currentTemp.ToString();
                GameManager.Instance.TempText2.text = currentTemp.ToString();
                TempBarImage.fillAmount = currentTemp / 200f;

                if (currentTemp >= 100)
                {
                    Debug.Log(GameManager.IsLowerValveOpen);
                    GameManager.IsBoil = true;
                    BoillingAnime.SetBool("IsBoilling", true);
                    if (currentTemp <= 100)
                    {

                        BoillingAnime.SetBool("IsBoilling", true);
                    }
                }
                //if (GameManager.IsLowerValveOpen)
                //{
                //    deltaTemp = 0;
                //    Debug.Log("kkkkk");
                //}

            }
            //else if (GameManager.IsSwitchOpen)
            //{
            //    float deltaTemp = CalculateDeltaTemp();
            //    currentTemp -= Mathf.Round(deltaTemp * Time.deltaTime);
            //    currentTemp = Mathf.Max(currentTemp, 25f); // Ensure temperature doesn't go below 0
            //    GameManager.Instance.TempText.text = currentTemp.ToString();
            //    GameManager.Instance.TempText2.text = currentTemp.ToString();
            //    TempBarImage.fillAmount = currentTemp / 200f;
            //    if (currentTemp < 100)
            //    {
            //        GameManager.IsBoil = false;
            //        //NonBoillingAnime.SetBool("NotBoilling", true);
            //        BoillingAnime.SetBool("IsBoilling", false);

            //    }
            //    else
            //    {
            //        BoillingAnime.SetBool("IsBoilling", true);

            //    }


            //}
            else if (/*!GameManager.IsSwitchOpen||*/GameManager.IsLowerValveOpen)
            {
                Debug.Log(GameManager.IsLowerValveOpen);

                float test = CalculateDeltaTemp();
                currentTemp -= Mathf.Round(test * Time.deltaTime);
                currentTemp = Mathf.Max(currentTemp, 25f); // Ensure temperature doesn't go below 0
                GameManager.Instance.TempText.text = currentTemp.ToString();
                GameManager.Instance.TempText2.text = currentTemp.ToString();
                TempBarImage.fillAmount = currentTemp / 200f;
                if (currentTemp < 100)
                {
                    GameManager.IsBoil = false;
                    BoillingAnime.SetBool("IsBoilling", false);

                }
                else
                {
                    BoillingAnime.SetBool("IsBoilling", true);

                }

            }
            else if (!GameManager.IsSwitchOpen )
            {
                Debug.Log(GameManager.IsLowerValveOpen);

                float test = CalculateDeltaTemp();
                currentTemp -= Mathf.Round(test * Time.deltaTime);
                currentTemp = Mathf.Max(currentTemp, 25f); // Ensure temperature doesn't go below 0
                GameManager.Instance.TempText.text = currentTemp.ToString();
                GameManager.Instance.TempText2.text = currentTemp.ToString();
                TempBarImage.fillAmount = currentTemp / 200f;
                if (currentTemp < 100)
                {
                    GameManager.IsBoil = false;
                    BoillingAnime.SetBool("IsBoilling", false);

                }
                else
                {
                    BoillingAnime.SetBool("IsBoilling", true);

                }

            }

            yield return new WaitForSeconds(updateInterval);

        }

    }

}
