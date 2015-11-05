using UnityEngine;
using System.Collections;

public class playerIsKill : MonoBehaviour {

	public GameObject player;
	int deadScore = 0; 


	public GameObject life1;
	public GameObject life2;
	public GameObject life3;
	public GameObject dead1;
	public GameObject dead2;

	void Start () 
	{
//		Sprite life1 = Resources.Load <Sprite> ("biervis");
//		Sprite life2 = Resources.Load <Sprite> ("biervis");
//		Sprite life3 = Resources.Load <Sprite> ("biervis");

	}

	void OnTriggerEnter (Collider other)
	{
		deadScore++;

		if (deadScore == 1) 
		{
			dead1.SetActive(true);
			Debug.Log ("dedded once");

		}
		if (deadScore == 2) 
		{
			dead2.SetActive(true);
			Debug.Log ("dedded twice");


		}
		if (deadScore == 3) 
		{

			Debug.Log ("dedded final");
			Destroy (player);
			Application.LoadLevel ("Level1");

		}
	

	}


	void Update () 
	{
	
	}





}
