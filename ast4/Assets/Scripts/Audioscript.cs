using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Audioscript : MonoBehaviour {

	public AudioMixer audio;
	float pitch=0.1f;
	float cut = 5000f;

	void Start ()
	{
	
	}

	void Update ()
	{
		if (Input.GetAxis("Horizontal")<0 )
		{
			pitch-=.005f;
			pitch=Mathf.Clamp(pitch,0.01f,1.2f);
			SetPitchLvl(pitch);
		}
		
		if (Input.GetAxis("Horizontal")>0 )
		{
			pitch+=.005f;
			pitch=Mathf.Clamp(pitch,0.01f,1.2f);
			SetPitchLvl(pitch);
		}
		
		if (Input.GetAxis("Vertical")<0 )
		{
			cut-=cut*0.008f;
			cut=Mathf.Clamp(cut,50f,5000f);
			SetFilterLvl(cut);
		
		}
		
		if (Input.GetAxis("Vertical")>0 )
		{
			cut+=cut*0.008f;
			cut=Mathf.Clamp(cut,50f,5000f);
			SetFilterLvl(cut);
		}
	
	}

	public void SetMusicLvl(float vol)
	{
		audio.SetFloat ("Master", vol);
	}

	public void SetPitchLvl(float vol)
	{
		audio.SetFloat ("Pitch", vol);
	}

	public void SetFilterLvl(float vol)
	{
		audio.SetFloat ("Cut", vol);
	}
}
