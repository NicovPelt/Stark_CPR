using UnityEngine;
using System.Collections;

public class MusicControler : MonoBehaviour {

	private int score = 0;
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
		track1 = transform.FindChild("1 ClickTrack105BPM").GetComponent<AudioSource>();
		track2 = transform.FindChild("2 PianoLow").GetComponent<AudioSource>();
		track3 = transform.FindChild("3 Strings").GetComponent<AudioSource>();
		track4 = transform.FindChild("4 Guitar").GetComponent<AudioSource>();
		track5 = transform.FindChild("5 PianoTop").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (track1On && track1.volume < 1f) {
			track1.volume += 0.0005f;
		} else if (!track1On && track1.volume > 0) {
			track1.volume -= 0.0005f;
		}
		if (track2On && track2.volume < 1f) {
			track2.volume += 0.0005f;
		} else if (!track2On && track2.volume > 0) {
			track2.volume -= 0.0005f;
		}
		if (track3On && track3.volume < 1f) {
			track3.volume += 0.0005f;
		} else if (!track3On && track3.volume > 0) {
			track3.volume -= 0.0005f;
		}
		if (track4On && track4.volume < 1f) {
			track4.volume += 0.0005f;
		} else if (!track4On && track4.volume > 0) {
			track4.volume -= 0.0005f;
		}
		if (track5On && track5.volume < 1f) {
			track5.volume += 0.0005f;
		} else if (!track5On && track5.volume > 0) {
			track5.volume -= 0.0005f;
		}
	}

	public void correct(){
		if (score < 70) {
			score ++;
			if(score == 16)
				track2On = true;
			else if(score == 32)
				track3On = true;
			else if(score == 48)
				track4On = true;
			else if(score == 64)
				track5On = true;
			else if(score == 68)
				track1On = false;
		}
	}

	public void wrong(){
		if (score > 0) {
			score -= 2;
			if(score == 12)
				track2On = false;
			else if(score == 28)
				track3On = false;
			else if(score == 44)
				track4On = false;
			else if(score == 60)
				track5On = false;
			else if(score == 64)
				track1On = true;
		}
	}
}
