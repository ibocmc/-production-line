using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tvdown : MonoBehaviour {

	public GameObject tvbig;
	public GameObject tvsmall;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void OnTriggerEnter(Collider other){

		if(other.gameObject.tag == "tvbig" || other.gameObject.tag == "tvsmall" ){

			tvbig.GetComponent<Rigidbody> ().useGravity = true;
		
		}

	}
}
