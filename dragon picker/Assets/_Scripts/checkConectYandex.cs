using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using TMPro;

public class checkConectYandex : MonoBehaviour
{
    private void OnEnable() => YandexGame.GetDataEvent += CheckSDK;
    private void OnDisable() => YandexGame.GetDataEvent -= CheckSDK;
    private TextMeshProUGUI scoreBest;
    private TextMeshProUGUI achivtxt;
    // Start is called before the first frame update
    void Start()
    {
        if (YandexGame.SDKEnabled == true)
        {
            CheckSDK();
            if ((YandexGame.savesData.achivMent) == false  )
             {
               Debug.Log("ты ");
               }
        else
              {
             GameObject achivt = GameObject.Find("AchivList");
             achivtxt = achivt.GetComponent<TextMeshProUGUI>();
             achivtxt.text = "ты проиграл";
            
             Debug.Log("ты проиграл");
        
              }
        }
    }

    public void CheckSDK()
    {
       
        if(YandexGame.auth == true)
        {
            Debug.Log("user authorization ok ");
        }
        else
        {
            Debug.Log("user not authorization ");
            YandexGame.AuthDialog();
        }
        GameObject  scoreBO = GameObject.Find("BestScore");
        scoreBest = scoreBO.GetComponent<TextMeshProUGUI>();
        scoreBest.text = "Best Score: " + YandexGame.savesData.bestscore.ToString();
        

    }
}
