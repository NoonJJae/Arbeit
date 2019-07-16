using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewAccountDirector : MonoBehaviour
{
    public string sns;
    public string name;
    GameObject inputFieldObj;
    InputField inputName;

    void Start()
    {
        inputFieldObj = GameObject.Find("inputname") as GameObject;
        inputName = inputFieldObj.GetComponent<InputField>();
    }

    public void CreateAccount()
    {
        if (sns.Length==0)
        {
            Debug.Log("SNS가 선택되지 않았습니다.");
            return;
        }

        if (inputName.text.Length==0)
        {
            Debug.Log("이름이 입력되지 않았습니다.");
            return;
        }

        name = inputName.text;

        if (PlayerPrefs.HasKey("keySize"))
        {
            PlayerPrefs.SetInt("keySize", 0);
        }

        int keySize = PlayerPrefs.GetInt("keySize");

        string Snskey = (keySize + 1) + "sns";
        string Namekey = (keySize + 1) + "name";

        PlayerPrefs.SetString(Snskey, sns);
        PlayerPrefs.SetString(Namekey, name);
    }
}
