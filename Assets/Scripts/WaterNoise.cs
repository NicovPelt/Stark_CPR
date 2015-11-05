using UnityEngine;
using System.Collections;

public class WaterNoise : MonoBehaviour {
	public int pixWidth;
	public int pixHeight;
	public float xOrg;
	public float yOrg;
	public float scale = 1.0F;
	private Texture2D noiseTex;
	private Color[] pix;
	// private Renderer rend;

	void Start() {
		// rend = GetComponent<Renderer>();
		noiseTex = new Texture2D(pixWidth, pixHeight);
		pix = new Color[noiseTex.width * noiseTex.height];
		// rend.material.mainTexture = noiseTex;
	}
	void CalcNoise() {
		float y = 0.0F;
		while (y < noiseTex.height) {
			float x = 0.0F;
			while (x < noiseTex.width) {
				float xCoord = xOrg + x / noiseTex.width * scale;
				float yCoord = yOrg + y / noiseTex.height * scale;
				float sample = Mathf.PerlinNoise(xCoord, yCoord);
				Color c = new Color(sample, sample, sample);
				int index = (int) (y * noiseTex.width + x);
				pix[index] = c;
				x++;
			}
			y++;
		}
		noiseTex.SetPixels(pix);
		noiseTex.Apply();
	}
	void Update() {
		xOrg += 0.01f;
		yOrg += 0.01f;
		CalcNoise();
	}
}