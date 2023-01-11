using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending_Young_Text : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject pepe;

    float Timer;
    // Start is called before the first frame update
    void Start()
    {
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        text5.SetActive(false);
        text6.SetActive(false);
        text7.SetActive(false);
        pepe.SetActive(false);
        Timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= 20)
        {
            SceneManager.LoadScene("Main Menu");
        }
        else if (Timer >= 18)
        {
            pepe.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        else if (Timer >= 15)
        {
            pepe.SetActive(true);
            pepe.GetComponent<Rigidbody2D>().velocity = Vector2.right * 3.57f;
        }
        else if (Timer >= 13)
        {
            text7.SetActive(true);
        }
        else if (Timer >= 11)
        {
            text4.SetActive(false);
            text5.SetActive(false);
            text6.SetActive(true);
        }
        else if (Timer >= 9)
        {
            text5.SetActive(true);
        }
        else if (Timer >= 7)
        {
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(true);
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
