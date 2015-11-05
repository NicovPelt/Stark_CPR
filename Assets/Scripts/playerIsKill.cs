using UnityEngine;
using System.Collections;

public class playerIsKill : MonoBehaviour {

	public GameObject player;
	int deadScore = 0; 

	
	void Start () 
	{

	}

	void OnTriggerEnter (Collider other)
	{
		if (deadScore < 3) 
		{
			Debug.Log ("Dedded");
			deadScore++;
		}
		if (deadScore == 3)
		{
		Destroy (player);
		Application.LoadLevel ("Level1");
		}

	}


	void Update () 
	{
	
	}





}
