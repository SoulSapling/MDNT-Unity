using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DancingImage : MonoBehaviour {

	public int detail = 5;
	public float minValue = 1.0f;
	public float amplitude = 0.1f;

	private Vector3 startScale;

	void  Start (){
		startScale = transform.localScale;


	}

	void  Update (){
		float[] info = new float[detail];
		AudioListener.GetOutputData(info, 0); 
		float packagedData = 0.0f;

		for(int x = 0; x < info.Length; x++)
		{
			packagedData += System.Math.Abs(info[x]);   
		}

		transform.localScale = new Vector3((packagedData * amplitude) + startScale.x, (packagedData * amplitude) + startScale.y, minValue);
		// this is line that pumps the transform, you can subsitute "minValue" for "(packagedData * amplitude) + startScale.y" if you want it to move only in x dimension
	}
}