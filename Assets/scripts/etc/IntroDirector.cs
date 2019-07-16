using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroDirector : MonoBehaviour {
	Text info;

	void Start () {
		info = GameObject.Find("Info").GetComponent<Text>();
		StartCoroutine("PlayGame", 15.0f);
	}

	IEnumerator PlayGame(float sec)
	{
		float t = 0;
		while (t<sec)
		{
			yield return new WaitForSeconds(1.0f);
			t += 1;
			info.text = (sec-t) + "초 후 게임이 시작됩니다...";
		}

		SceneManager.LoadScene("GameScene");

	}
}
