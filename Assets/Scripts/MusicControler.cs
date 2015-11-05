using UnityEngine;
using System.Collections;

public class MusicControler : MonoBehaviour {


 	public int correctOF16 = 11;
    private int score = 1;

    private int correctB = 0;
    private int incorrectB = 0;
    private float lastTime = 0.0f;

	private bool track1On = true;
	private bool track2On = false;
	private bool track3On = false;
	private bool track4On = false;
	private bool track5On = false;

	private AudioSource track1;
	private AudioSource track2;
	private AudioSource track3;
	private AudioSource track4;
	private AudioSource track5;

	// Use this for initialization
	void Start () {
		track1 = transform.FindChild("1 105BPM").GetComponent<AudioSource>();
		track2 = transform.FindChild("2 PianoLow").GetComponent<AudioSource>();
		track3 = transform.FindChild("3 Strings").GetComponent<AudioSource>();
		track4 = transform.FindChild("4 Guitar").GetComponent<AudioSource>();
		track5 = transform.FindChild("5 PianoTop").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if ((incorrectB + correctB >= 16) && ((Time.time - lastTime) >= 9.142f ) || ((Time.time - lastTime >= 9.142f)))
        {
            scoreCal();
            lastTime = Time.time;
            Debug.Log("Music change");
        }
        musicControll();
	}

    private void scoreCal()
    {
        if (score >= 7)
        {
            GetComponent<uiActor>().Victory();
        }

        if (correctB >= correctOF16)
        {
            score++;
            if (score <= 6)
            {
                if (score == 2)
                    track2On = true;
                else if (score == 3)
                    track3On = true;
                else if (score == 4)
                    track4On = true;
                else if (score == 5)
                    track5On = true;
                else if (score == 6)
                    track1On = false;
            }
         
        }
        if (incorrectB > 16-correctOF16)
        {
            score =-1;
            if (score >= 0)
            {
                if (score == 1)
                    track2On = false;
                else if (score == 2)
                    track3On = false;
                else if (score == 3)
                    track4On = false;
                else if (score == 4)
                    track5On = false;
                else if (score == 5)
                    track1On = true;

            }
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

    public void musicControll()
    {
        if (track1On && track1.volume < 1f)
        {
            track1.volume += 0.0005f;
        }
        else if (!track1On && track1.volume > 0)
        {
            track1.volume -= 0.0005f;
        }
        if (track2On && track2.volume < 1f)
        {
            track2.volume += 0.005f;
        }
        else if (!track2On && track2.volume > 0)
        {
            track2.volume -= 0.0005f;
        }
        if (track3On && track3.volume < 1f)
        {
            track3.volume += 0.0005f;
        }
        else if (!track3On && track3.volume > 0)
        {
            track3.volume -= 0.0005f;
        }
        if (track4On && track4.volume < 1f)
        {
            track4.volume += 0.0005f;
        }
        else if (!track4On && track4.volume > 0)
        {
            track4.volume -= 0.0005f;
        }
        if (track5On && track5.volume < 1f)
        {
            track5.volume += 0.0005f;
        }
        else if (!track5On && track5.volume > 0)
        {
            track5.volume -= 0.0005f;
        }
    }

}
