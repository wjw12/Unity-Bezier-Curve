using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillation : MonoBehaviour {

    public float amplitude;
    public float phase_deg;
    public float period;

    float w, phase;
    Vector3 pos;

	// Use this for initialization
	void Start () {
        w = 2f * Mathf.PI / period;
        phase = phase_deg / 180f * Mathf.PI;
        pos = transform.position;
        pos.y = amplitude * Mathf.Sin(phase);
        transform.position = pos;
	}
	
	// Update is called once per frame
	void Update () {
        pos.y = amplitude * Mathf.Sin(w * Time.realtimeSinceStartup + phase);
        transform.position = pos;
    }
}
