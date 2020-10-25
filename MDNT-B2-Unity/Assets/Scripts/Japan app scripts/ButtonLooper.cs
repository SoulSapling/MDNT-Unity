using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLooper : MonoBehaviour {

	public AudioSource myAudioSource;
	//declare a variable of the data type Game Object AudioSource and call it myAudioSource;


	public void buttonPressed()
	{
		myAudioSource.volume = 1;

	}

	public void buttonReleased()
	{
		myAudioSource.volume = 0;

	}
}
