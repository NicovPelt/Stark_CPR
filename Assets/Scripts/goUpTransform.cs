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
        PositionChange();

		tempTime += Time.deltaTime;
		if (Input.GetKeyDown ("space"))
		{

			if (tempTime >= bpmMin)
			{
				transform.position = lowV;
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                
			}
			else if (tempTime <= bpmMax)
			{
				transform.position = highV;
                gameObject.GetComponent<Renderer>().material.color = Color.red;

			}
			else
			{
				transform.position = (new Vector3 (0.0f, 0.0f, 0.0f));
                gameObject.GetComponent<Renderer>().material.color = Color.green;
			}
			tempTime = 0.0f;
		}


	}

    void PositionChange ()
    {

    }
}
