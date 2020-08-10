using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tvboxcreate2 : MonoBehaviour {

	public GameObject box;
	public Transform newpos;

	public Rigidbody tvrb;

	public float smooth;

	// Use this for initialization
	void Start () {

		box.SetActive (false);

	}

	// Update is called once per frame
	void Update () {

	}


	void OnTriggerEnter(Collider other){

//		if (other.gameObject.tag == "armsmall") {
//
//			gameObject.transform.Translate (new Vector3 (0, 0, 50));
//
//
//		}


		if(other.gameObject.tag == "smallpush"){

			//gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position,newpos.transform.position,Time.deltaTime * smooth);
			tvrb.AddForce(transform.forward * smooth ,ForceMode.Force);

		}


	}



	void OnTriggerExit(Collider other){

//		if(other.gameObject.tag == "armsmall"){
//
//			box.SetActive (true);
//			gameObject.transform.Translate (new Vector3 (0, 0, -50));
//
//
//		}

		if(other.gameObject.tag == "smallbox"){

			//tvrb.AddForce(transform.forward * -smooth ,ForceMode.Force);
			box.SetActive (true);

		}




	}
}
