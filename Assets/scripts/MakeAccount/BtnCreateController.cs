using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnCreateController : MonoBehaviour
{
    NewAccountDirector director;

    void Start()
    {
        director = GameObject.Find("MakeAccountDirector").GetComponent<NewAccountDirector>();
    }

    public void OnBtnCreate_Clicked()
    {
        director.CreateAccount();
        SceneManager.LoadScene("SNS_account");
    }
}
