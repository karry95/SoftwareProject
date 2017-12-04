using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour {

	public Transform gunTransform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(OVRInput.Get(OVRInput.Button.PrimaryHandTrigger)){
			RaycastGun ();
	}
}

	private void RaycastGun(){

		RaycastHit hit;
		if(Physics.Raycast(gunTransform.position, gunTransform.forward, out hit)){
			if(hit.collider.gameObject.CompareTag("Capsule")){
				Destroy(hit.collider.gameObject);
			}
		}
	}
}
