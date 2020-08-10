using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tvboxcreate : MonoBehaviour {

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
		
//		if(other.gameObject.tag == "armbig"){
//
//			gameObject.transform.Translate (new Vector3 (0, 0, 50));
//
//
//		}

		if(other.gameObject.tag == "bigpush"){

			//gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position,new Vector3(0,0,500f),Time.deltaTime * smooth);
			tvrb.AddForce(transform.forward * smooth ,ForceMode.Force);
		}



	}

	void OnTriggerExit(Collider other){

//		if(other.gameObject.tag == "armbig"){
//
//			box.SetActive (true);
//			gameObject.transform.Translate (new Vector3 (0, 0, -50));
//
//
//		}


		if(other.gameObject.tag == "bigbox"){


			box.SetActive (true);
			//tvrb.AddForce(transform.forward * -smooth ,ForceMode.Force);
		}




	}
}
