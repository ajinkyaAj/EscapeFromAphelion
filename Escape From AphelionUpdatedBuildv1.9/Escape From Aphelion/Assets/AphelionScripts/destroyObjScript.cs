using UnityEngine;
using System.Collections;

public class destroyObjScript : MonoBehaviour {
	
	//bool destroy = true;
	public GameObject gameObj;
	public int floorcount = 0;
	public GameObject[] floorRemove = new GameObject[45];
	public int hitcount = 0;
	
	public static bool hashit = false;
	public int prevcount = 0;
	
	public static int[] powerups = new int[5];
	//public int powerup1count = 0;
	//public int powerup2count = 0;
	//public int powerup3count = 0;
	//public int powerup4count = 0;
	//public int powerup5count = 0;


	public static int highscore = 0;
	
	
	public static int slowcount = 0;
	public static bool isSlowed = false;
	public static int fastcount = 0;
	public static bool isFast = false;

	public GameObject Explosion;

	
	void OnTriggerEnter(Collider other) 
	{
		bool dest = true;
		//floorRemove = selectSpace.floor;
		//destroy = true;
		if (gameObject.name == "Destroy Object") {
			Destroy (other.gameObject);
			
			moveBoxScript.score -= 10;
			
		}
		//if ((gameObject.name == "Falling Box") && (other.gameObject.name == "vincent")) {
		
		//Application.LoadLevel ("GameOver");
		
		//	}
		
		
		
		
		if (gameObject.name == "bomb") {
			//	gameObject.collider.isTrigger = false;
			//   gameObject.renderer.enabled = false;
			
			
			int powerupnum = Random.Range (1, 11);
			
			
			if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [0]) {
				moveBoxScript.score += 10;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp1";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
					
				}
				
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [1]) {
				moveBoxScript.score += 20;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp2";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [2]) {
				moveBoxScript.score += 30;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp3";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [3]) {
				moveBoxScript.score += 40;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp4";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [4]) {
				moveBoxScript.score += 50;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp5";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [5]) {
				dest = false;
			}
			
			if (dest) {
				if(!Explosion)
				{
					Explosion = GameObject.FindGameObjectWithTag("Explode");
				}
				Instantiate (Explosion,other.gameObject.transform.position,new Quaternion());
				Destroy (other.gameObject);

				
			}
			Destroy (gameObject);
			selectSpace.placedB = false;
			
		}  else if (other.gameObject.name == "Vincent") {
			
			
			
			if (gameObject.name == "PowerUp1") {
				
				powerups [0]++;
				//powerup1count++;
				Destroy (gameObject);
				
				//Debug.Log("0 " + powerups[0]);
				
				
			} else if (gameObject.name == "PowerUp2") {
				
				powerups [1]++;
				//powerup2count++;
				Destroy (gameObject);
				
				//Debug.Log("1 " + powerups[1]);
				
			} else if (gameObject.name == "PowerUp3") {
				
				//powerups [2]++;
				//powerup3count++;
				Destroy (gameObject);
				
				//Debug.Log("2 " + powerups[2]);
				
				
				
				
				
				moveBoxScript.countrotate = 500;
				
				slowcount = 0;
				
				isSlowed = true;
				
				
				
				
				
				
				
			} else if (gameObject.name == "PowerUp4") {
				
				//powerups [3]++;
				//powerup4count++;
				Destroy (gameObject);
				
				//Debug.Log("3 " + powerups[3]);
				
				Controller3DExample.movespeed = 3.0f;
				
				fastcount = 0;
				
				isFast = true;
				
				
				
				
				
				
				
			} else if (gameObject.name == "PowerUp5") {
				
				powerups [4]++;
				//powerup5count++;
				Destroy (gameObject);
				
				
				//Debug.Log("4 " + powerups[4]);
				
				
			}

			
			
			
			
			
			
			
			
			
			
			
		} else if (gameObject.name == "colbomb") {
			
			
			
			
			
			int powerupnum = Random.Range (1, 11);
			
			
			if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [0]) {
				moveBoxScript.score += 10;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp1";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
					
				}
				
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [1]) {
				moveBoxScript.score += 20;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp2";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [2]) {
				moveBoxScript.score += 30;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp3";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [3]) {
				moveBoxScript.score += 40;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp4";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [4]) {
				moveBoxScript.score += 50;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp5";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [5]) {
				//dest = false;
				moveBoxScript.score += 100;
			}
			
			//if (dest) {

				Explosion = GameObject.FindGameObjectWithTag("Explode");

			Instantiate (Explosion,other.gameObject.transform.position,new Quaternion());
			Destroy (other.gameObject);
			
			//}
			Destroy (gameObject);
			powerUpScript.cbomb = false;
			
			
			
			
			
			
			
			
			
			
		}
		
		
		else if (gameObject.name == "rowbomb") {
			
			
			
			
			
			int powerupnum = Random.Range (1, 11);
			
			
			if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [0]) {
				moveBoxScript.score += 10;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp1";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
					
				}
				
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [1]) {
				moveBoxScript.score += 20;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp2";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [2]) {
				moveBoxScript.score += 30;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp3";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [3]) {
				moveBoxScript.score += 40;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp4";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [4]) {
				moveBoxScript.score += 50;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp5";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [5]) {
				//dest = false;
				moveBoxScript.score += 100;
			}
			
			//if (dest) {
			if(!Explosion)
			{
				Explosion = GameObject.FindGameObjectWithTag("Explode");
			}
			Instantiate (Explosion,other.gameObject.transform.position,new Quaternion());
			Destroy (other.gameObject);
			
			//}
			Destroy (gameObject);
			powerUpScript.rbomb = false;
			
			
			
			
			
			
			
			
			
			
		}
		
		
		
		
		else if (gameObject.name == "largeBomb") {
			
			
			
			
			
			int powerupnum = Random.Range (1, 11);
			
			
			if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [0]) {
				moveBoxScript.score += 10;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp1";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
					
				}
				
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [1]) {
				moveBoxScript.score += 20;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp2";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [2]) {
				moveBoxScript.score += 30;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp3";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [3]) {
				moveBoxScript.score += 40;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp4";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [4]) {
				moveBoxScript.score += 50;
				if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.name = "PowerUp5";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [5]) {
				//dest = false;
				moveBoxScript.score += 100;
			}
			
			//if (dest) {

			if(!Explosion)
			{
				Explosion = GameObject.FindGameObjectWithTag("Explode");
			}
			Instantiate (Explosion,other.gameObject.transform.position,new Quaternion());
			Destroy (other.gameObject);
			
			//}
			Destroy (gameObject);
			powerUpScript.lbomb = false;
			
			
			
			
			
			
			
			
			
			
		}
		
		
		
		
		
		
		
		else if (other.gameObject.name == "newCube") {
			hitcount++;
			if ((floorcount < 45) && (hitcount == 5)) {
				floorRemove [floorcount].rigidbody.isKinematic = false;
				floorRemove [floorcount + 1].rigidbody.isKinematic = false;
				floorRemove [floorcount + 2].rigidbody.isKinematic = false;
				floorRemove [floorcount + 3].rigidbody.isKinematic = false;
				floorRemove [floorcount + 4].rigidbody.isKinematic = false;
				floorRemove [floorcount].rigidbody.useGravity = true;
				floorRemove [floorcount + 1].rigidbody.useGravity = true;
				floorRemove [floorcount + 2].rigidbody.useGravity = true;
				floorRemove [floorcount + 3].rigidbody.useGravity = true;
				floorRemove [floorcount + 4].rigidbody.useGravity = true;
				floorcount += 5;
				
				hitcount = 0;
				
				
				moveBoxScript.score -= 50;
				
				
			}
			
		}
		
		
		
	}
	// Use this for initialization
	void Start () {
		//gameObj = gameObject;
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if ((hashit)&&((prevcount+5)<=(floorcount))) {
			hashit = false;
			GameObject destroybox = GameObject.Find ("Destroy Object");
			Vector3 currentPosition = destroybox.transform.position;
			Vector3 newPosition = currentPosition;
			newPosition.z += 0.806f;
			destroybox.transform.position = newPosition;
			
			
			prevcount = floorcount;
			
			
			
		}

		if (GameObject.Find ("Vincent") == null) {
						powerUpScript.rbomb = false;
						powerUpScript.lbomb = false;
						powerUpScript.cbomb = false;
						Application.LoadLevel ("GameOver");
						if (moveBoxScript.score > highscore) {
				
								highscore = moveBoxScript.score;
				
						}
						moveBoxScript.score = 0;
				} else {

						GameObject Vinc = GameObject.Find ("Vincent");

						foreach (GameObject cubeCheck in GameObject.FindGameObjectsWithTag("Box")) {
								//if(cubeCheck.transform.position == Vinc.transform.position){
								if (cubeCheck.name == "newCube") {
										if ((cubeCheck.transform.position.x + .4f > Vinc.transform.position.x) && (cubeCheck.transform.position.z + .4f > Vinc.transform.position.z) && (cubeCheck.transform.position.x - .4f < Vinc.transform.position.x) && (cubeCheck.transform.position.z - .4f < Vinc.transform.position.z)) {
												Destroy (Vinc);

										}
			
								}
								//}


						}

				}


		
		
		
		

		
		
		
		
		slowcount++;
		if((slowcount > 1000)&&(isSlowed)){
			
			isSlowed = false;
			moveBoxScript.countrotate = 200;
			
			
		}
		
		fastcount++;
		if((fastcount > 1000)&&(isFast)){
			
			isFast = false;
			Controller3DExample.movespeed = 1.5f;
			
			
		}
		
		
	}
	
}

