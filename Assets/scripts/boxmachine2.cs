using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxmachine2 : MonoBehaviour {

	private tvspawn workOn_;
	private tvmover speed_;

	public GameObject smallboxholder;
	public GameObject box;
	//public GameObject smallboxholder;

	// Use this for initialization
	void Start () {

		//box.SetActive (false);
		tvspawn workOn_ = GameObject.FindObjectOfType<tvspawn> ();
	    speed_ = gameObject.GetComponent<tvmover> ();
//		speed_ = GameObject.FindObjectOfType<tvmover> ();
//		speed_ = 50;
 }

	// Update is called once per frame
	void Update () {

	}


	void OnTriggerEnter(Collider other){

		if(other.gameObject.tag == "tvsmall"){


			//			targetRot1 *= Quaternion.AngleAxis (45,Vector3.up); 
			//			targetRot2 *= Quaternion.AngleAxis (45,Vector3.up); 


			//			animkol1.SetBool ("kol1active", true);
			//			animkol2.SetBool ("kol2active", true);

			//			kol1.transform.Rotate(new Vector3 (0, 0, 45f));
			//			kol2.transform.Rotate(new Vector3 (0, 0, 45f));
			smallboxholder.transform.Translate (new Vector3 (-140f, 0, 0));

			workOn_.workOn = false;

			speed_.speed= 0;







		}
		//		kol1.transform.rotation = Quaternion.Lerp (kol1.transform.rotation, targetRot1,10 *Time.deltaTime); 
		//		kol2.transform.rotation = Quaternion.Lerp (kol2.transform.rotation, targetRot2,10 *Time.deltaTime); 

	}

	void OnTriggerExit(Collider other){

		if(other.gameObject.tag == "tvsmall"){

			//			kol1.transform.Rotate(new Vector3 (0, 0, -45f));
			//			kol2.transform.Rotate(new Vector3 (0, 0, -45f));
			smallboxholder.transform.Translate (new Vector3 (140f, 0, 0));
			box.SetActive (true);

				workOn_.workOn = true;



			speed_.speed= 50;





		}


	}


}
