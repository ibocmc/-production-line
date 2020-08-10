using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machine2_work : MonoBehaviour {

	public GameObject kol1;
	public GameObject kol2;

	public Transform newpos;
	public float smooth;

	public GameObject machineSmall;

	//public GameObject box;

	//	public Animator animkol1;
	//
	//	public Animator animkol2;

	//	bool kol1active;
	//	bool kol2active;

	//	private Quaternion targetRot1;
	//	private Quaternion targetRot2;
	//public GameObject findchild2;

	// Use this for initialization
	void Start () {

		//		targetRot1 = kol1.transform.rotation;
		//		targetRot2 = kol2.transform.rotation;
		//		kol1active = false;
		//		kol2active = false;

		//box.SetActive (false);

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay(Collider other){

		if(other.gameObject.tag == "tvsmall"){


			//			targetRot1 *= Quaternion.AngleAxis (45,Vector3.up); 
			//			targetRot2 *= Quaternion.AngleAxis (45,Vector3.up); 


			//			animkol1.SetBool ("kol1active", true);
			//			animkol2.SetBool ("kol2active", true);


			//machineSmall.transform.Translate (new Vector3 (-120, 0, 0));

			machineSmall.transform.position = Vector3.MoveTowards (machineSmall.transform.position,newpos.transform.position,Time.deltaTime * smooth);


//			kol1.transform.Rotate(new Vector3 (0, 0, -45f));
		//kol2.transform.Rotate(new Vector3 (0, 0, -90));
		//	box.SetActive (true);

		}
		//		kol1.transform.rotation = Quaternion.Lerp (kol1.transform.rotation, targetRot1,10 *Time.deltaTime); 
		//		kol2.transform.rotation = Quaternion.Lerp (kol2.transform.rotation, targetRot2,10 *Time.deltaTime); 

	}


	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "tvsmall") {

			kol2.transform.Rotate(new Vector3 (0, 0, -90));

		}

	}

	void OnTriggerExit(Collider other){

		if(other.gameObject.tag == "tvsmall"){

//			kol1.transform.Rotate(new Vector3 (0, 0, 45f));
			kol2.transform.Rotate(new Vector3 (0, 0, 90));
//
//			//box.SetActive(false);
//
			machineSmall.transform.Translate (new Vector3 (150, 0, 0));





		}


	}


}
