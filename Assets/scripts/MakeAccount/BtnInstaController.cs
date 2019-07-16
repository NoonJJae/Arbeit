using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnInstaController : MonoBehaviour
{
    NewAccountDirector director;

    void Start()
    {
        director = GameObject.Find("MakeAccountDirector").GetComponent<NewAccountDirector>();
    }

    public void OnBtnInsta_Clicked()
    {
        director.sns = "InstaGram";
    }
}
