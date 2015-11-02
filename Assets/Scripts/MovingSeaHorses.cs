using UnityEngine;
using System.Collections;

public class MovingSeaHorses : MonoBehaviour {

	float rotateSpeed =0.25f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//gameObject.transform.forward (Vector3.forward * forwardSpeed);
		gameObject.transform.Rotate (Vector3.up * -rotateSpeed);

	}
}
