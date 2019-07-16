using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ArbaDirector : MonoBehaviour
{
    Button btn_mainearn; // mainearn  moneyeffect( "+" + mainearn) 
    Button btn_sns; // mini
    Button btn_kizmini; // mini
    Button btn_chinesemini; // mini
    Button btn_insteadarbamini; // mini
    Button btn_parking; // mini

    private void Start()
    {
        btn_mainearn = GameObject.Find("btn_mainearn").GetComponent<Button>();
        btn_sns = GameObject.Find("btn_sns").GetComponent<Button>();
        btn_kizmini = GameObject.Find("btn_kizmini").GetComponent<Button>();
        btn_chinesemini = GameObject.Find("btn_chinesemini").GetComponent<Button>();
        btn_insteadarbamini = GameObject.Find("btn_insteadarbamini").GetComponent<Button>();
        btn_parking = GameObject.Find("btn_parking").GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    void Earning(int earn)
    {
        GameDirector.SetEarn(earn);
    }
}
