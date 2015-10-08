using UnityEngine;
using System.Collections;

public class goUp : MonoBehaviour 
{


	public Vector3 forceUp = new Vector3();

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		//GameObject this;
		Rigidbody rb = this.GetComponent<Rigidbody>();

		if (Input.GetKeyDown ("space")) 
		{
			rb.AddForce (forceUp);
		}

		//float movehorizontal = Input.getAxis ("Horizontal") * playerSpeed;
		//rb.AddForce (Vector3.up);
	}
}
