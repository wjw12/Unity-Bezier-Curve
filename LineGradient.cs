using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineGradient : MonoBehaviour {
    
    public Gradient GradientSegment;
    public float SegmentLen = 0.2f;
    public float speed = 0.3f;

    Gradient newGradient, GradientBackground;
    float front, back;
    GradientColorKey[] keys;
    int nSegKeys;

    // Use this for initialization
    void Start () {
        GradientBackground = GetComponent<LineRenderer>().colorGradient;
        front = 1f - SegmentLen;
        back = 1f;
        nSegKeys = GradientSegment.colorKeys.Length;
        newGradient = new Gradient();

        keys = new GradientColorKey[2 + nSegKeys];

        keys[0] = GradientBackground.colorKeys[0];
        for (int i = 1; i <= nSegKeys; i++)
        {
            keys[i].color = GradientSegment.colorKeys[i - 1].color;
            keys[i].time = SegmentLen * GradientSegment.colorKeys[i - 1].time + front;
        }

        keys[nSegKeys + 1] = GradientBackground.colorKeys[1];
       
        newGradient.SetKeys(keys, GradientBackground.alphaKeys);

    }
	
	// Update is called once per frame
	void Update () {
        front -= speed * Time.deltaTime;
        back -= speed * Time.deltaTime;
        if (front < 0f) front = 1 + front;
        if (back < 0f) back = 1 + back;

        
        for (int i = 1; i <= nSegKeys; i++)
        {
            keys[i].color = GradientSegment.colorKeys[i - 1].color;
            keys[i].time = SegmentLen * GradientSegment.colorKeys[i - 1].time + front;
            if (keys[i].time > 1f) keys[i].time -= 1f;
        }
        

        newGradient.SetKeys(keys, GradientBackground.alphaKeys);

        GetComponent<LineRenderer>().colorGradient = newGradient;
        //Debug.Log(GetComponent<LineRenderer>().colorGradient.Evaluate(.1f));
    }
}
