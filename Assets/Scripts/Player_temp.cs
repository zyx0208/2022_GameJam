using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_temp : MonoBehaviour
{
    Rigidbody2D rid2D;
    // Start is called before the first frame update
    void Start()
    {
        rid2D = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.Translate(new Vector3(0, 10, 0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.Translate(new Vector3(-10, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.transform.Translate(new Vector3(0, -10, 0));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.Translate(new Vector3(10, 0, 0));
        }
    }
}
