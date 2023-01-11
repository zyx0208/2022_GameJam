using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider matureSlider;
    public Slider seasonSlider;
    public Sprite[] backgroundSprites;
    public GameObject audio1;
    public GameObject audio2;
    public GameObject audio3;
    public GameObject audio4;

    private SpriteRenderer backgroundRenderer;

    // Start is called before the first frame update
    void Start()
    {
        backgroundRenderer = GameObject.Find("Background").GetComponent<SpriteRenderer>();
        audio1.SetActive(false);
        audio2.SetActive(false);
        audio3.SetActive(false);
        audio4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Maturity Setting
        #region
        matureSlider.value = GameManager.maturity;
        #endregion

        //Season Setting
        #region
        seasonSlider.value = GameManager.time / GameManager.maxTime;
        if(GameManager.season == Season.Spring)
        {
            backgroundRenderer.sprite = backgroundSprites[(int)Season.Spring];
            audio1.SetActive(true);
        }
        else if(GameManager.season == Season.Summer)
        {
            backgroundRenderer.sprite = backgroundSprites[(int)Season.Summer];
            audio1.SetActive(false);
            audio2.SetActive(true);
        }
        else if (GameManager.season == Season.Autumn)
        {
            backgroundRenderer.sprite = backgroundSprites[(int)Season.Autumn];
            audio2.SetActive(false);
            audio3.SetActive(true);
        }
        else if (GameManager.season == Season.Winter)
        {
            backgroundRenderer.sprite = backgroundSprites[(int)Season.Winter];
            audio3.SetActive(false);
            audio4.SetActive(true);
        }

        #endregion
    }
}
