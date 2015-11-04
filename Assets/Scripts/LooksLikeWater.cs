using UnityEngine;
using System.Collections;

public class LooksLikeWater : MonoBehaviour {

    Color underWaterColor;
    bool isUnderwater;


	// Use this for initialization
	void Start ()
    {
        underWaterColor = new Color(0.22f, 0.65f, 0.77f, 0.5f);
	}
	
	// Update is called once per frame
	void Update ()
    {
        isUnderwater = true;
	}
    void setUnderWater ()
    {
        RenderSettings.fogColor = underWaterColor;
        RenderSettings.fogDensity = 0.03f;
    }
}
