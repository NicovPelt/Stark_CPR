using UnityEngine;
using System.Collections;

public class ObjectsMoveToPlayer : MonoBehaviour {

	public int correctOF16 = 12;
	private int score = 0;
	private int correctB = 0;
	private int incorrectB = 0;
	private float lastTime = 0.0f;

	// Use this for initialization
	void Start () 
	{
		if ((incorrectB + correctB >= 16) && ((Time.time - lastTime) >= 9.142f ) || ((Time.time - lastTime >= 9.142f)))
		{

			lastTime = Time.time;
			Debug.Log("Music change");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
