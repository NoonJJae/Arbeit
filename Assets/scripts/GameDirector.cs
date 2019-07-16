using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    internal static int gamemoney = 0;
    internal static int earnlv=1;
    internal static int earnup = 50;
    static Text txt_money;
    GameObject txt_money_obj;
    Text txt_effect;
    internal static int main_earn=1;

    // Start is called before the first frame update
    void Start()
    {
        txt_money_obj = GameObject.Find("txt_money");
        txt_money = txt_money_obj.GetComponent<Text>();
        txt_money.text = "돈: " + gamemoney;
        txt_effect = GameObject.Find("txt_effect").GetComponent<Text>();
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        txt_money_obj = GameObject.Find("txt_money");
        txt_money = txt_money_obj.GetComponent<Text>();
        //DontDestroyOnLoad(txt_money_obj);
    }

    void Update()
    {
        if (txt_money!=null)
            txt_money.text = "돈: " + gamemoney;
    }

    internal static void SetEarn(int earn)
    {
        main_earn = earn;
    }

    private void IncreaseMoney()
    {
        gamemoney += main_earn;

        // 텍스트 효과
        if (txt_effect==null)
        {
            txt_effect = GameObject.Find("txt_effect").GetComponent<Text>();
        }
        txt_effect.SendMessage("DoEffect", (object)main_earn);
    }

    
}
