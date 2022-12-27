using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class ADReward : MonoBehaviour
{

    public void OnEnable() =>YandexGame.CloseVideoEvent += Rewarded;
    public void OnDisable() =>YandexGame.CloseVideoEvent += Rewarded;
    void Rewarded (int id)
    {
    if(id == 1 )Debug.Log("пользователь получил награду");
    else Debug.Log("пользователь  ne получил награду");
    }
    public void OpenAD()
    {
        YandexGame.RewVideoShow(Random.Range(0,2));
    }

}
