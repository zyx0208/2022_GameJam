using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    new public Rigidbody2D rigidbody2D;
    public Sprite[] sprites;
    public SpriteRenderer spriteRenderer;

    [SerializeField]
    private float swipeTime;
    [SerializeField]
    private float swipeDistance;
    [SerializeField]
    private float playerDashSpeed;
    [SerializeField]
    private float playerMoveSpeed;
    //private float clickTime;
    private bool isSwipe;
    private Vector3 pointPosition;      // 터치 지점
    private Vector3 startSwipePoint;    // 스와이프 시작 지점
    private Vector3 endSwipePoint;      // 스와이프 끝 지점
    private Vector3 direction;

    private void Start()
    {
        //spriteRenderer.sprite = sprites[1];
    }

    private void Update()
    {
        //Sprite Switch
        if (GameManager.maturity < 30)
        {
            spriteRenderer.sprite = sprites[2];
        }

        else if(GameManager.maturity < 70)
        {
            spriteRenderer.sprite = sprites[1];
        }

        else if (GameManager.maturity <= 100)
        {
            spriteRenderer.sprite = sprites[0];
        }

        //Moving
        #region
        if (Input.GetMouseButtonDown(0))
        {
            startSwipePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButtonUp(0))
        {
            endSwipePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            direction = new Vector2(Mathf.Clamp(startSwipePoint.x - endSwipePoint.x, -10f, 10f),
                                    Mathf.Clamp(startSwipePoint.y - endSwipePoint.y, -10f, 10f));

            rigidbody2D.velocity = direction * playerDashSpeed;
        }

        if (Input.GetMouseButtonDown(1))
        {
            pointPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            rigidbody2D.velocity = (pointPosition - transform.position) * playerMoveSpeed;
        }
        #endregion
    }
}
