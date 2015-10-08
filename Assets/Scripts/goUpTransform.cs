using UnityEngine;
using System.Collections;

public class goUpTransform : MonoBehaviour {

	public float bpm = 0.6f;
	public float bpmMax = 0.4f;
	public float bpmMin = 0.8f;
	public Vector3 lowV;
	public Vector3 highV;


	float tempTime = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		tempTime += Time.deltaTime;
		if (Input.GetKeyDown ("space"))
		{

			if (tempTime >= bpmMin)
			{
				transform.position = lowV;
				//dynamic cubeColor = gameObject.GetComponent<Shader>();


			}
			else if (tempTime <= bpmMax)
			{
				transform.position = highV;
			}
			else
			{
				transform.position = (new Vector3 (0.0f, 0.0f, 0.0f));
			}
			tempTime = 0.0f;
		}


	}
}
