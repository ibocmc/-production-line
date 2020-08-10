using UnityEngine;
using System.Collections;

public class tvspawn : MonoBehaviour {




	public bool workOn;
	public GameObject bigtv;
	public Vector3 bigtvspawnValues;
	public int bigtvCount;
	public float bigtvspawnWait;
	public float bigtvstartWait;
	public float bigtvwaveWait;

	public GameObject smalltv;
	public Vector3 smalltvspawnValues;
	public int smalltvCount;
	public float smalltvspawnWait;
	public float smalltvstartWait;
	public float smalltvwaveWait;

	//public GameObject Enemy;
	//public Vector3 eSpawnValues;
	//public int enemyCount;


	//public GUIText scoreText;
	//private int score;





	// Use this for initialization
	void Start () {



		bigtv.GetComponent<Rigidbody> ().useGravity = false;
		smalltv.GetComponent<Rigidbody> ().useGravity = false;
		workOn = false;




		//score = 0;
		//UpdateScore();
		StartCoroutine (SpawnWaves());
		StartCoroutine (SpawnWaves1());
	}

	void Update () {






		//scoreText.text = "Score:" + score;

		if (Input.GetKey (KeyCode.S)) {
			workOn = true;
		} else if (Input.GetKey (KeyCode.F)) {

			workOn = false;

		}

		//		Work ();


	}





	IEnumerator SpawnWaves(){

		yield return new WaitForSeconds(bigtvstartWait);

		while(true)
		{

			for (int i=0; i<bigtvCount; i++){

				Vector3 spawnPosition = new Vector3(Random.Range(-bigtvspawnValues.x,bigtvspawnValues.x), bigtvspawnValues.y, bigtvspawnValues.z);
				//Vector3 espawnPosition = new Vector3(eSpawnValues.x,eSpawnValues.y,eSpawnValues.z);

				Quaternion spawnRotation = Quaternion.identity;
				//Quaternion espawnRotation = Quaternion.identity;
				if(workOn){
				Instantiate(bigtv,spawnPosition,spawnRotation);

				}
				//Instantiate(Enemy,espawnPosition,espawnRotation);
				yield return new WaitForSeconds(bigtvspawnWait);

			}
			yield return  new WaitForSeconds(bigtvwaveWait);
		}

	}


	IEnumerator SpawnWaves1(){

		yield return new WaitForSeconds(smalltvstartWait);

		while(true)
		{

			for (int i=0; i<smalltvCount; i++){

				Vector3 spawnPosition = new Vector3(Random.Range(-smalltvspawnValues.x,smalltvspawnValues.x), smalltvspawnValues.y, smalltvspawnValues.z);
				//Vector3 espawnPosition = new Vector3(eSpawnValues.x,eSpawnValues.y,eSpawnValues.z);

				Quaternion spawnRotation = Quaternion.identity;
				//Quaternion espawnRotation = Quaternion.identity;
				if(workOn){
				Instantiate(smalltv,spawnPosition,spawnRotation);
				}
				//Instantiate(Enemy,espawnPosition,espawnRotation);
				yield return new WaitForSeconds(smalltvspawnWait);

			}
			yield return  new WaitForSeconds(smalltvwaveWait);
		}

	}



	public void AddScore(int newScoreValue){


		//score += newScoreValue;
		//UpdateScore();

	}

	// Update is called once per frame

//		public void Work(){
//
//		if (workOn) {
//			StartCoroutine (SpawnWaves ());
//			StartCoroutine (SpawnWaves1 ());
//		} else if (workOn = false){
//
//			StopCoroutine (SpawnWaves ());
//			StopCoroutine (SpawnWaves1 ());
//
//		}
	

//	}
	


//	void OnTriggerEnter(Collider other){
//
//		if (other.gameObject.tag == "Finish") {
//
//			Destroy (gameObject);
//
//
//		} 
//
//	}


}
