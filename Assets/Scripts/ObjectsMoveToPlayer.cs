using UnityEngine;
using System.Collections;

public class ObjectsMoveToPlayer : MonoBehaviour 
{

	public int correctOF16 = 12;
	private int score = 0;
	private int correctB = 0;
	private int incorrectB = 0;
	private float lastTime = 0.0f;

	Vector3 pos1;
	Vector3 pos2;
	Vector3 pos3;
	Vector3 pos4; 
	Vector3 pos5;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if ((incorrectB + correctB >= 16) && ((Time.time - lastTime) >= 9.142f ) || ((Time.time - lastTime >= 9.142f)))
		{

			scoreCal();
			lastTime = Time.time;
			Debug.Log("moved to player");
		}
	}

	private void scoreCal()
	{
		if (correctB >= correctOF16)
		{
			Debug.Log(score);
			score++;
		}
		if (incorrectB > (16-correctOF16))
		{
			score =-1;
		}
		if (score >= 0)
		{
			if (score == 1){
				pos1  = new Vector3 (0.0f, 3.5f, 0.0f);
				Debug.Log ( "Changed pos");
			}
			else if (score == 2)
				pos2 =  new Vector3 (0.0f, 3.25f, 0.0f);
			else if (score == 3)
				pos3 = new Vector3 (0.0f, 3.0f, 0.0f);
			else if (score == 4)
				pos4 = new Vector3 (0.0f, 2.75f, 0.0f);
			else if (score == 5)
				pos5 = new Vector3 (0.0f, 2.5f, 0.0f);
		}
		correctB = 0;
		incorrectB = 0;
	}

	public void correct(){
		correctB++;   
	}
	
	public void wrong(){
		incorrectB++;   
	}
}
