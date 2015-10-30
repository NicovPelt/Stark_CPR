using UnityEngine;
using System.Collections;

public class NicosAttempt : MonoBehaviour 
{
    private bool falling = false;
    private bool firstTime = true;
	private float timeLastPress = 0f;
	private MusicControler music;

	private Vector3 PosOnPress = new Vector3(0f,0f,0f);
	private Vector3 targetYPos = new Vector3(0f,0f,0f);
	private float startTime = 0f;
	public float speed = 3f;
    public float Upperlimit = 0.3f;
    public float lowerLimit = -0.3f;
	private float journeyLength = 0f;
   

	// Use this for initialization
	void Start () 
	{
		music = GameObject.Find ("Audio Sources").GetComponent<MusicControler>();

	}
	
	// Update is called once per frame
	void Update () 
	{
		//if (music == null)
			//Debug.Log (GameObject.Find ("Audio Sources"));
			
		if (Input.GetKeyDown ("space")) 
		{
			if(firstTime)
			{
				firstTime = false;
				timeLastPress = Time.time;
			} 
			else 
			{
				startTime = Time.time;
				//float tempTime = Time.time;
				if((startTime - timeLastPress) <= 0.1f)
				{
					//set target pos to 2 
					targetYPos = new Vector3(0f, 2f, 0f);
					//Tween to top in 0.6 sec
				}
				else if ((startTime - timeLastPress) < 1.1f)
				{
					//calc pos between -2 and 2
					//formula: targetpos = ((10/3*2)*tempTime-timeLastPress)+4
					//Debug.Log(startTime);
					//Debug.Log(((-(10f/3f*2f))*(startTime-timeLastPress))+4);
					//Debug.Log(startTime-timeLastPress);
					//targetYPos = new Vector3(0f, ((-(10f/3f*2f))*(startTime-timeLastPress))+4, 0f);
					targetYPos = new Vector3(0f, (-4f*(startTime-timeLastPress)+2.4f), 0f);
					//tween to pos in 0.6 sec
				}
				else 
				{
					//set targetpos to -2
					targetYPos = new Vector3(0f, -2f, 0f);
					//tween to bottom in 0.6 sec
				}
				PosOnPress = transform.position;
				journeyLength = Vector3.Distance(PosOnPress, targetYPos);
				timeLastPress = Time.time;
                uiOutPut();
			}
		}
        if ((Time.time - timeLastPress >= 1.2f) && !(Input.GetKeyDown("space"))  && falling == false)
        {
            falling = true;
            startTime = Time.time;
            targetYPos = new Vector3(0f, -2f, 0f);
            PosOnPress = transform.position;
            journeyLength = Vector3.Distance(PosOnPress, targetYPos);
            Debug.Log(" more then 1.2 sec");
            uiOutPut();
        }
        if (targetYPos.y != -2f)
        {
            falling = false;
        }
        moveToTarget();
    }

	void moveToTarget()
	{
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		//Debug.Log (PosOnPress);
		//Debug.Log (targetYPos);
		//Debug.Log (fracJourney);
		transform.position = Vector3.Lerp(PosOnPress, targetYPos, fracJourney);
	}

	void uiOutPut ()
	{
		if (targetYPos.y > Upperlimit) 
		{
			gameObject.GetComponent<Renderer>().material.color = Color.red;
			GetComponentInChildren<uiActor>().incorrectH++;
            music.wrong();

		} 
		else if (targetYPos.y < lowerLimit) 
		{
			gameObject.GetComponent<Renderer>().material.color = Color.red;
			GetComponentInChildren<uiActor>().missedH++;
			music.wrong();
		} 
		else 
		{
			gameObject.GetComponent<Renderer>().material.color = Color.green;
			GetComponentInChildren<uiActor>().correctH++;
			music.correct();
		}

	}

}


