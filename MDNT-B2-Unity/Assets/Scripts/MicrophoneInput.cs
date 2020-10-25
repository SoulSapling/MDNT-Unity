using UnityEngine;
using System.Collections;


public class MicrophoneInput : MonoBehaviour {
	//public AudioSource audio;
	public GameObject btn_record;
	private AudioSource aud;

	void Start(){
		GetComponent<AudioSource> ().loop = true;
	}

	public void StartMicrophone () {
		//GetComponent<AudioSource>().clip =  Microphone.Start("RODECaster Pro Multichannel", true, 5, 44100);
        GetComponent<AudioSource>().clip = Microphone.Start("Built-in Microphone", true, 5, 44100);
        GetComponent<AudioSource> ().loop = true;
	}

	public void StopMicrophone () {
		//Microphone.End("RODECaster Pro Multichannel");
        Microphone.End("Built-in Microphone");
        //Stops the recording of the device	
    }
	public void playRecord () {
		GetComponent<AudioSource>().Play();//Stops the audio
		GetComponent<AudioSource> ().loop = true;

	}
	public void stopRecord () {
		GetComponent<AudioSource>().Stop ();

		
	}


}