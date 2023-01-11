using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffee : MonoBehaviour
{
    private GameObject Player;
    private Rigidbody2D rigid;
    public float Speed = 50f;
    Vector3 target;
    // Start is called before the first frame update
    public GameObject coffeeText;

    GameManager gameManager;


    void Start()
    {
        Player = GameObject.Find("Player");
        gameManager = GameObject.Find("GameManager").gameObject.GetComponent<GameManager>();
        target = Player.transform.position;
        rigid = GetComponent<Rigidbody2D>();
        rigid.AddForce((target - this.transform.position) * Speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Walls")
        {
            Destroy(this.gameObject);
        }

        if (collision.tag == "Player")
        {
            gameManager.HearingCoffee();
            Instantiate(coffeeText, transform.position, Quaternion.identity);
            GameManager.DrinkCoffee();
            Destroy(this.gameObject);
        }
    }


}
