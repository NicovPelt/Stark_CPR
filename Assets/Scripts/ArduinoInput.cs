using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArduinoInput : MonoBehaviour {

    SerialPort sp = new SerialPort("COM3", 9600);
    private int spReadout = 0;
    private int OldReadout = 0;
    public int spReadInt;

    // Use this for initialization
    void Start () {
        sp.Open();
        sp.ReadTimeout = 1;
    }
	
	// Update is called once per frame
	void Update () {

        if (sp.IsOpen)
            try
            {
                spReadout = sp.ReadByte();
                Debug.Log(spReadout);
            }
            catch
            {
                Debug.Log("Try failed");
            }
        else
            Debug.Log("Sp closed");

        if (spReadout != OldReadout)
        {
            GetComponent<NicosAttempt>().spInput = spReadout;
            OldReadout = spReadout;
        }
        else
        {
            GetComponent<NicosAttempt>().spInput = 0;
        }

    }
}
