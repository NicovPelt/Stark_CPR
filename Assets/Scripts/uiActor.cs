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



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        correctHT.text = "Correct Beats: " + correctH;
        incorrectHT.text = "Faulty Beats: " + incorrectH;
        missedHT.text = "Missed Beats: " + missedH;
        
    }
}
