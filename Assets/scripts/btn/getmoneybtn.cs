 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getmoneybtn : MonoBehaviour
{
    GameObject gamedirector;

    void Start()
    {
        gamedirector = GameObject.Find("GameDirector");
    }

    public void GetMoney()
    {
        gamedirector.SendMessage("IncreaseMoney");
    }
}
