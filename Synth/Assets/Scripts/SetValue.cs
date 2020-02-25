using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetValue : MonoBehaviour {

	public string parameter;
	public string mixparam;
	public float calcvar;
	public AudioMixer mixer;
	public Text text;

	void Start () 
	{
	}
	

	public void SetParamVal(float val)
	{


		if (mixparam == "") 
		{
			mixer.SetFloat (parameter, val);

		} 
		else 
		{
			mixer.SetFloat (parameter, val);
			mixer.SetFloat (mixparam, (float)((val-calcvar)*-1)+calcvar);


		}
		text.text = parameter + ": " + val;
	}


}
