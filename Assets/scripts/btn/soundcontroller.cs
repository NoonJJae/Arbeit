using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundcontroller : MonoBehaviour {
	GameObject soundon, soundoff;
	AudioSource audio;


	private void Start()
	{
		soundon = GameObject.Find("SoundOn");
		soundoff = GameObject.Find("SoundOff");
		audio = GameObject.Find("Audio").GetComponent<AudioSource>();
	}

	public void OnSoundOn_Click()
	{
		if (!audio.isPlaying) audio.Play();
	}
	public void OnSoundOff_Click()
	{
		if (audio.isPlaying) audio.Pause();
	}
}
