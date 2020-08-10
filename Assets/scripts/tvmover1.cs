using UnityEngine;
using System.Collections;


public class tvmover1 : MonoBehaviour {

	private tvspawn workOn_;
	public Rigidbody tvrb;
	public float speed;

	// Use this for initialization
	void Start () {


		workOn_ = GameObject.FindObjectOfType<tvspawn> ();
		tvrb.GetComponent<Rigidbody>();
		tvrb.velocity = transform.right * speed;

	}

	// Update is called once per frame
	void Update () {

	}


	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "tvdowner") {

//			tvrb.useGravity = true;
//			gameObject.GetComponent<BoxCollider> ().isTrigger = false;
			speed = 100;
			tvrb.velocity = transform.right * speed;
//			tvrb.AddForce (transform.right * 1000 , ForceMode.Force);

			gameObject.transform.Translate (new Vector3 (0, -100f, 0));
		}

			if (other.gameObject.tag == "des") {

			Destroy (gameObject);

			} 







		if (other.gameObject.tag == "smallbox" ) {
			
			speed = 0;
			tvrb.velocity = transform.right * speed;
			workOn_.workOn = false;
//
//
		}

		if(other.gameObject.tag == "alignbig"){


			gameObject.transform.Translate (new Vector3(0,0,-90));

		}
//		



	}


	void OnTriggerExit(Collider other){

		if(other.gameObject.tag == "smallbox"){

			speed = 75;
			tvrb.velocity = transform.right * speed;
			workOn_.workOn = true;
		}


	}


}