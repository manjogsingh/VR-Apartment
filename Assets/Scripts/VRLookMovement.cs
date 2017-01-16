using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookMovement : MonoBehaviour {

    public Transform vrCamera;
    public float toogleAngle = 30.0f;
    public float speed = 3.0f;
    public bool moveForward;
    CharacterController cc;
	// Use this for initialization
	void Start () {
        cc = GetComponent<CharacterController>();
        //cc.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (vrCamera.eulerAngles.x >= toogleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
        }
        else {
            moveForward= false;
        }

        if (moveForward) {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
        }
	}
}
