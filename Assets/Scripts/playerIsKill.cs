using UnityEngine;
using System.Collections;

public class playerIsKill : MonoBehaviour {



	// Use this for initialization

	public GameObject player;
	
	void Start () 
	{
		StartCoroutine(StartDatShit());
	}

	void OnTriggerEnter (Collider other)
	{

		Debug.Log ("Shrekked");
		StartDatShit ();
		Destroy (player);
	}

	IEnumerator StartDatShit() 
	{

		yield return new WaitForSeconds(5);	
		Application.LoadLevel("Level1");
	}

	
	// Update is called once per frame
	void Update () 
	{
	
	}





}
