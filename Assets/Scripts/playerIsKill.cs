using UnityEngine;
using System.Collections;

public class playerIsKill : MonoBehaviour {

	public GameObject player;
	bool collided;
	
	void Start () 
	{
		//StartCoroutine(StartDatShit());
	}

	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("Dedded");
		Destroy (player);
	
		Application.LoadLevel ("Level1");

	}

//	IEnumerator StartDatShit() 
//	{
//		if (collided = true) {
//			yield return new WaitForSeconds (5);
//			collided = false;
//			Application.LoadLevel ("Level1");
//
//		}
//		else 
//		{
//			yield return new WaitForSeconds (1);
//		}
//
//	}

	
	// Update is called once per frame
	void Update () 
	{
	
	}





}
