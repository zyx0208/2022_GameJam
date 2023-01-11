using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkSpawner : MonoBehaviour
{
    public GameObject Coffee;
    public GameObject Milk;
    public Transform Player;
    public float SpawnTime = 2f;
    private float Timer;
    private int drinkType = 0;

    void Start()
    {
        Timer = SpawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer >= 0)
        {
            Timer -= Time.deltaTime;
        }
        else
        {
            drinkType = Random.Range(0, 2);
            int rand = Random.Range(0, 4);
            Timer = SpawnTime;
            if (drinkType == 0)
            {
               
                
                if (rand == 0) //위쪽 소환
                {
                    Instantiate(Milk, new Vector3(Player.position.x + Random.Range(-10f, 10f), Player.position.y + 10f, 0f), Quaternion.identity);
                }
                else if (rand == 1) //왼쪽 소환
                {
                    Instantiate(Milk, new Vector3(Player.position.x - 10f, Player.position.y + Random.Range(-10f, 10f), 0f), Quaternion.identity);
                }
                else if (rand == 2) //오른쪽 소환
                {
                    Instantiate(Milk, new Vector3(Player.position.x + 10f, Player.position.y + Random.Range(-10f, 10f), 0f), Quaternion.identity);
                }
                else //아래쪽 소환
                {
                    Instantiate(Milk, new Vector3(Player.position.x + Random.Range(-10f, 10f), Player.position.y - 10f, 0f), Quaternion.identity);
                }
            }
            else if(drinkType == 1)
            {
                if (rand == 0) //위쪽 소환
                {
                    Instantiate(Coffee, new Vector3(Player.position.x + Random.Range(-10f, 10f), Player.position.y + 10f, 0f), Quaternion.identity);
                }
                else if (rand == 1) //왼쪽 소환
                {
                    Instantiate(Coffee, new Vector3(Player.position.x - 10f, Player.position.y + Random.Range(-10f, 10f), 0f), Quaternion.identity);
                }
                else if (rand == 2) //오른쪽 소환
                {
                    Instantiate(Coffee, new Vector3(Player.position.x + 10f, Player.position.y + Random.Range(-10f, 10f), 0f), Quaternion.identity);
                }
                else //아래쪽 소환
                {
                    Instantiate(Coffee, new Vector3(Player.position.x + Random.Range(-10f, 10f), Player.position.y - 10f, 0f), Quaternion.identity);
                }
            }
            
        }
    }
}
