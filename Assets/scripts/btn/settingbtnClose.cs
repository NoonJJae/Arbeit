using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingbtnClose : MonoBehaviour {
	GameObject settingpanel;

	// Use this for initialization
	void Start () {
		settingpanel = GameObject.Find("SettingPanel");
		settingpanel.SetActive(true);
	}

	public void SettingbtnClose_Click()
	{
		settingpanel.SetActive(false);
	}
}
