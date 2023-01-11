using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("Copyright");
        }
    }
}
