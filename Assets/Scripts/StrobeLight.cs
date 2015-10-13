
using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Light))]

public class StrobeLight : MonoBehaviour {
	
	public float time = .6f; //time between on and off
	
	// Use this for initialization
	void Start () {
		StartCoroutine("Flicker");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator Flicker(){
		while(true){
			GetComponent<Light>().enabled = false;
			yield return new WaitForSeconds(time);
			GetComponent<Light>().enabled = true;
			yield return new WaitForSeconds(time);
		}
	}
}
