using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnFbController : MonoBehaviour
{
    NewAccountDirector director;

    void Start()
    {
        director = GameObject.Find("MakeAccountDirector").GetComponent<NewAccountDirector>();
    }

    public void OnBtnFb_Clicked()
    {
        director.sns = "FaceBook";
    }
}
