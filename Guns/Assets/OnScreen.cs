using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnScreen : MonoBehaviour {

	//private Hv_UnityGuns_AudioLib audioLib;


	public void GunShoot1(){

		Hv_UnityGuns_AudioLib script = GetComponent<Hv_UnityGuns_AudioLib>();

		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Volosc, 0);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Volphasor, 0);

		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Volband, 1);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Band, 500);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Randomband, 130);

		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Vollow, 1);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Lop, 300);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Randomlow, 40);

		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Volhigh, 0.01f);

		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Release, 120);

		script.SendEvent(Hv_UnityGuns_AudioLib.Event.Play);

	}

	public void GunShoot2(){
		Hv_UnityGuns_AudioLib script = GetComponent<Hv_UnityGuns_AudioLib>();

		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Volosc, 0);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Volphasor, 0);

		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Volband, 1);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Band, 600);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Randomband, 250);

		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Vollow, 1);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Lop, 200);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Randomlow, 60);

		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Volhigh, 0.1f);

		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Release, 90);

		script.SendEvent(Hv_UnityGuns_AudioLib.Event.Play);

	}

	public void OscShoot() {
		Hv_UnityGuns_AudioLib script = GetComponent<Hv_UnityGuns_AudioLib> ();

		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Volosc, 0.6f);

		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Volband, 0);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Volhigh, 0);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Vollow, 0);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Volphasor, 0);

		script.SendEvent (Hv_UnityGuns_AudioLib.Event.Play);
	
	
	}

	public void SawShoot() {
		Hv_UnityGuns_AudioLib script = GetComponent<Hv_UnityGuns_AudioLib> ();

		script.SetFloatParameter(Hv_UnityGuns_AudioLib.Parameter.Volphasor, 0.6f);

		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Volband, 0);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Volhigh, 0);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Vollow, 0);
		script.SetFloatParameter (Hv_UnityGuns_AudioLib.Parameter.Volosc, 0);

		script.SendEvent (Hv_UnityGuns_AudioLib.Event.Play);


	}


	// Use this for initialization
	void Start () {

	//	Hv_UnityGuns_AudioLib script = GetComponent<Hv_UnityGuns_AudioLib>();
	//	script.SendEvent(Hv_UnityGuns_AudioLib.Event.Play);

		//GetComponent<Hv_UnityGuns_AudioLib> ();

	//	audioLib.SendEvent (Hv_UnityGuns_AudioLib.Event.Play);

		
	}
	
	// Update is called once per frame
	void Update () {

	//	Hv_UnityGuns_AudioLib script = GetComponent<Hv_UnityGuns_AudioLib>();
	//	script.SendEvent(Hv_UnityGuns_AudioLib.Event.Play);
		//GetComponent<Hv_UnityGuns_AudioLib> ();

		//audioLib.SendEvent (Hv_UnityGuns_AudioLib.Event.Play);


		
	}
}
