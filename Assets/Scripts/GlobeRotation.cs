using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void rotate() {
        transform.GetComponentInChildren<Animator>().Play("Rotation");
    }
}
