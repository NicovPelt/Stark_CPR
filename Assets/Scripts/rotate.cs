using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	public float rotationSpeed = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		gameObject.transform.Rotate (Vector3.up * rotationSpeed);
	}
}
