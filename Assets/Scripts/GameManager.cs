using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Season
{
    Spring, 
    Summer, 
    Autumn,
    Winter
}

public class GameManager : MonoBehaviour
{

    public static Season season = Season.Spring;
    public static float maturity = 50f; //우유를 먹으면 -10, 커피를 먹으면 +10
    public static float time = 0f;
    public static float maxTime = 150f;

    public AudioClip milkSound;
    public AudioClip coffeeSound;

    public AudioSource audioSource;

    public static void DrinkCoffee()
    {
        maturity -= 10;
        
    }

    public static void DrinkMilk()
    {
        maturity += 10;
    }

    public void HearingCoffee()
    {
        audioSource.clip = coffeeSound;
        audioSource.Play();
    }

    public void HearingMilk()
    {
        audioSource.clip = milkSound;
        audioSource.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        maturity = 50f;
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.F1) || maturity <= 0.0f)
        {
            SceneManager.LoadScene("Ending_Old");
        }
        else if (Input.GetKeyDown(KeyCode.F2) || maturity >= 100f)
        {
            SceneManager.LoadScene("Ending_Young");
        }
        else if (Input.GetKeyDown(KeyCode.F3) || time >= maxTime)
        {
            SceneManager.LoadScene("Ending_Fin");
        }

        #region Season Setting
        if (time < (maxTime / 4))
        {
            season = Season.Spring;
        }
        else if(time < (maxTime/2))
        {
            season = Season.Summer;
        }
        else if (time < (maxTime * 3/4))
        {
            season = Season.Autumn;
        }
        else if (time < maxTime)
        {
            season = Season.Winter;
        }
        #endregion
    }
}
