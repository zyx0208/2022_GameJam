using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending_Fin : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    float Timer;
    // Start is called before the first frame update
    void Start()
    {
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        Timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= 9)
        {
            SceneManager.LoadScene("Main Menu");
        }
        else if (Timer >= 5)
        {
            text3.SetActive(true);
        }
        else if (Timer >= 3)
        {
            text2.SetActive(true);
        }
        else if (Timer >= 1)
        {
            text1.SetActive(true);
        }
    }
}
