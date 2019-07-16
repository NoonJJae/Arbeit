using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_btn : MonoBehaviour {
	public void startintro()
	{
		SceneManager.LoadScene("IntroScene");
	}
}
