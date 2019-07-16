using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class arbeitmenu : MonoBehaviour
{

	public void startarbeit()
	{
		SceneManager.LoadScene("ArbeitScene");
	}
}
