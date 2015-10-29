using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class goUpTransform : MonoBehaviour
{

	public float bpm = 0.6f;
	public float bpmMax = 0.4f;
	public float bpmMin = 0.8f;
    public float speed;
    public float fallingSpeed;
    public string tempText;

	public Vector3 lowV;
	public Vector3 highV;
    public Vector3 normalV;


    int currentBMP = 0;
	float tempTime = 0.0f;
    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        float dTime = Time.deltaTime;
        tempTime += Time.deltaTime;
        if ((currentBMP == 0) && (tempTime < 0.6f))
        {
            VectorChange();
            PositionSet();
        }
        if ((currentBMP == -1) && (tempTime > 0.6f))
        {
            VectorChange();
            PositionSet();
        }
        if ((currentBMP == 1) && (tempTime < 0.6f))
        {
            VectorChange();
            PositionSet();
        }
        if (Input.GetKeyDown("space"))
        {
            BPMCheck();
            VectorChange();
            PositionSet();   
        }
        else if (tempTime >= 1.2f)
        {
            GetComponentInChildren<uiActor>().missedH++;
            if (transform.localPosition.y > -2.0f)
            {
                transform.Translate(new Vector3(0.0f, -fallingSpeed * dTime , 0.0f));
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
        }
	}

    // IEnumerator 
    // check the BPM and sets the current BMP value
    void BPMCheck()
    {
        if (tempTime >= bpmMin)
        {
            currentBMP = -1;
            
        }
         else if (tempTime <= bpmMax)
        {
            currentBMP = 1;
           
        }
        else
        {
            currentBMP = 0;
            
        }
        tempTime = 0.0f;
    }
    // Determens if the vector needs to be chagned
    void VectorChange ()
    {
        float dTime = Time.deltaTime;
        if (currentBMP == 1)
        {
            if (transform.localPosition.y >= 2.0f)
            {
                highV = new Vector3(0.0f, 0.0f, 0.0f);
            }
            else
            {
                highV = new Vector3(0.0f, speed * dTime , 0.0f);
            }
        }
        if (currentBMP == -1)
        {
                if (transform.localPosition.y <= -2.0f)
                {
                    lowV = new Vector3(0.0f, 0.0f, 0.0f);
                }
                else
                {
                    lowV = new Vector3(0.0f, -speed * dTime, 0.0f);
                }
        }
 
        if(currentBMP == 0)
        {
           if( transform.localPosition.y < 0.0f)
                {
                    normalV = new Vector3(0.0f, speed * dTime, 0.0f);
                }
           if (transform.localPosition.y > 0.0f)
                {
                    normalV = new Vector3(0.0f, -speed * dTime, 0.0f);
                }
           if (transform.localPosition.y > -0.1f && transform.localPosition.y < 0.1f)
                {
                    normalV = new Vector3(0.0f, 0.0f, 0.0f);
                }
        }
    }
    // Set the postion of the object
    void PositionSet()
    {
        if (currentBMP == -1)
        {
            transform.Translate(lowV);
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            GetComponentInChildren<uiActor>().missedH++;
        }
        if (currentBMP == 1)
        {
            transform.Translate(highV);
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            GetComponentInChildren<uiActor>().incorrectH++;
        }
        if (currentBMP == 0)
        {
            transform.Translate(normalV);
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            GetComponentInChildren<uiActor>().correctH++;
        }

    }
}
