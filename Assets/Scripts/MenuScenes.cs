using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButtonOn()
    {
        SceneManager.LoadScene("GameManager");
    }

    public void ExitButtonOn()
    {
        Application.Quit();
    }

    public void TutorButtonOn()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
