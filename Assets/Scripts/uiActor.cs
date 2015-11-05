using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class uiActor : MonoBehaviour {
    public int correctH = 0;
	public int incorrectH = 0;
	public int missedH = 0;

    public Text correctHT;
    public Text incorrectHT;
    public Text missedHT;
    public Text Press;

    private float startTime;
    private float Holdtime;
    private int Hold;
    private int i;
    private int o;
    private bool HoldB;
    private bool vicBool = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        correctHT.text = "Correct Beats: " + correctH;
        incorrectHT.text = "Faulty Beats: " + incorrectH;
        missedHT.text = "Missed Beats: " + missedH;

        if ((Time.time - startTime) >= 2.0f)
        {
            Press.text = "";
            startTime = Time.time;
        }
        if (vicBool)
        {
            StartCoroutine(Wait());
            Application.LoadLevel("Level1");
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);      
    }

    public void pressEnable(int i)
    {
        Debug.Log("press call");
        if (i == 1 && HoldB == false)
        {
            Hold = i;
            Holdtime = Time.time;
            Debug.Log(Hold);
            HoldB = true;
        }

        if (i == 2)
        {
            HoldB = false;
        }
        
        if (HoldB == true && Press.text == "" && i == 1 && Hold == 1 && (Time.time - 0.6f) >= Holdtime)
        {
            Press.text = "Press Harder!!!";
            startTime = Time.time;
            HoldB = false;
            Debug.Log("HARDER");
        }
        
    }
    public void Victory()
    {
        vicBool = true;
        Press.text = "VICTORY";        
    }
}
