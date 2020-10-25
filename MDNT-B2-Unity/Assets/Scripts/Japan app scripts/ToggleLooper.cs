using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLooper : MonoBehaviour {

	//declare a variable of data type Audiosource called myAudioSource;
	public AudioSource myAudioSource;
	//declare a variable of data type boolean and call it isTriggered with a starting value of "false";
	public bool isTriggered = false;
	public UnityEngine.UI.Image myButton;


	public void doTrigger(){

		//if our variable isTriggered is not true and then it becomes true set myAudioSourcevolume to .8;
		if (!isTriggered) {
			isTriggered = true;
			myAudioSource.volume = .8f;
			GetComponent<UnityEngine.UI.Image> ().color = Color.green;

		} else {
			//if our variable isTriggered is false then set volume to 0;
			isTriggered = false;
			myAudioSource.volume = 0;
			GetComponent<UnityEngine.UI.Image> ().color = Color.white;
		}

	}





}
