using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.RotateAround(this.gameObject.transform.position, new Vector3(1, 0, 0), Time.deltaTime);
	}
}
