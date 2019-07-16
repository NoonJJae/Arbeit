using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
     
public class btn_mainearn : MonoBehaviour
{
    Text txt_earnlv;
    Text txt_earntouch;
    Text txt_earnup;

    void Start()
    {
        txt_earnlv = GameObject.Find("txt_earnlv").GetComponent<Text>();
        txt_earnlv.text = GameDirector.earnlv + "";
        txt_earntouch = GameObject.Find("txt_earntouch").GetComponent<Text>();
        txt_earntouch.text = GameDirector.main_earn + "원";
        txt_earnup = GameObject.Find("txt_earnup").GetComponent<Text>();
        txt_earnup.text = GameDirector.earnup + "원";

    }

   //최저시급 레벨업

    public void Earning()
    {
        //GameDirector.SetEarn(earnlv);
    }

    public void EarnLevel()
    {
        switch (GameDirector.earnlv)
        {
            case 1:
                if (GameDirector.gamemoney >= 50)
                {
                    GameDirector.gamemoney -= 50;
                    GameDirector.earnlv++;
                    GameDirector.main_earn = 5;
                    GameDirector.earnup = 500;
                    txt_earnlv.text = GameDirector.earnlv + "";
                    txt_earntouch.text = GameDirector.main_earn + "원";
                    txt_earnup.text = GameDirector.earnup + "원";
                }
                break;
            case 2:
                if (GameDirector.gamemoney >= 500)
                {
                    GameDirector.gamemoney -= 500;
                    GameDirector.earnlv++;
                    GameDirector.main_earn = 10;
                    GameDirector.earnup = 3000;
                    txt_earnlv.text = GameDirector.earnlv + "";
                    txt_earntouch.text = GameDirector.main_earn + "원";
                    txt_earnup.text = GameDirector.earnup + "원";
                }
                break;
            case 3:
                if (GameDirector.gamemoney >= 3000)
                {
                    GameDirector.gamemoney -= 3000;
                    GameDirector.earnlv++;
                    GameDirector.main_earn = 200;
                    GameDirector.earnup = 10000;
                    txt_earnlv.text = GameDirector.earnlv + "";
                    txt_earntouch.text = GameDirector.main_earn + "원";
                    txt_earnup.text = GameDirector.earnup + "원";
                }
                break;
            case 4:
                if (GameDirector.gamemoney >= 10000)
                {
                    GameDirector.gamemoney -= 10000;
                    GameDirector.earnlv++;
                    GameDirector.main_earn = 1000;
                    GameDirector.earnup = 500000;
                    txt_earnlv.text = GameDirector.earnlv + "";
                    txt_earntouch.text = GameDirector.main_earn + "원";
                    txt_earnup.text = GameDirector.earnup + "원";
                }
                break;
            case 5:
                if (GameDirector.gamemoney >= 500000)
                {
                    GameDirector.gamemoney -= 500000;
                    GameDirector.earnlv++;
                    GameDirector.main_earn = 25000;
                    GameDirector.earnup = 7500000;
                    txt_earnlv.text = GameDirector.earnlv + "";
                    txt_earntouch.text = GameDirector.main_earn + "원";
                    txt_earnup.text = GameDirector.earnup + "원";
                }
                break;
            case 6:
                if (GameDirector.gamemoney >= 7500000)
                {
                    GameDirector.gamemoney -= 7500000;
                    GameDirector.earnlv++;
                    GameDirector.main_earn = 400000;
                    GameDirector.earnup = 50000000;
                    txt_earnlv.text = GameDirector.earnlv + "";
                    txt_earntouch.text = GameDirector.main_earn + "원";
                    txt_earnup.text = GameDirector.earnup + "원";
                }
                break;
        }
    }
}
