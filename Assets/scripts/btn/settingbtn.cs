using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingbtn : MonoBehaviour {
	GameObject settingpanel;

	// Use this for initialization
	void Start () {
		settingpanel = GameObject.Find("SettingPanel");
		settingpanel.SetActive(false);
	}
	
	public void OnSettingbtn_Click()
	{
		settingpanel.SetActive(true);
	}
}
