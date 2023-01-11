using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLife : MonoBehaviour
{
    private float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        time = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time < 0f)
        {
            Destroy(gameObject);
        }
    }
}
