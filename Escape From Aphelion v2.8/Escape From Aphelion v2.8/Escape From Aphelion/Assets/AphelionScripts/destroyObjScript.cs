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
	
	public static int[] powerups = new int[] {1,1,0,0,1};

	//public int powerup1count = 0;
	//public int powerup2count = 0;
	//public int powerup3count = 0;
	//public int powerup4count = 0;
	//public int powerup5count = 0;


	public static int highscore;//= PlayerPrefs.GetInt("High Score");

	public static float edgeZPos = -5.6f;
	public int dropRate = 2;
	public float dropCounter = 0.0f;
	
	
	public static int slowcount = 0;
	public static bool isSlowed = false;
	public static int fastcount = 0;
	public static bool isFast = false;

	public GameObject Explosion;
	public AudioClip[] list;

	private GameObject particleExplode;
    void Awake()
    {
        highscore = PlayerPrefs.GetInt("High Score");
		list = new AudioClip[]{(AudioClip)Resources.Load("Sounds/DestroySound"),
			(AudioClip)Resources.Load("Sounds/Crush"),
			(AudioClip)Resources.Load("Sounds/BlockFall"),
			(AudioClip)Resources.Load("Sounds/PU")};
    }

	
	void OnTriggerEnter(Collider other) 
	{
		bool dest = true;
		//floorRemove = selectSpace.floor;
		//destroy = true;
		//	AudioSource.PlayClipAtPoint (list[0], transform.position, setMusicVolume.volume);
 		if (gameObject.name == "Destroy Object") {
			Destroy (other.gameObject);
			AudioSource.PlayClipAtPoint (list[2], transform.position, setMusicVolume.volume);
			moveBoxScript.score -= 10;
			
		}
		//if ((gameObject.name == "Falling Box") && (other.gameObject.name == "vincent")) {
		
		//Application.LoadLevel ("GameOver");
		
		//	}
		
		
		
		
		if (gameObject.name == "bomb") {
			//	gameObject.collider.isTrigger = false;
			//   gameObject.renderer.enabled = false;
			AudioSource.PlayClipAtPoint (list[0], transform.position, setMusicVolume.volume);
			


			for(int i = 0; i < 19; i++){
				string theName = "shipPart" + (i+1);
				if(other.gameObject.name == theName){
					Randomize.shipPartFound[i] = 1;
					PlayerPrefs.SetInt(theName, Randomize.shipPartFound[i]);
					PlayerPrefs.Save();
					moveBoxScript.score += 500;
					GameObject newC = (GameObject)Instantiate(Resources.Load(theName));
					newC.transform.localScale = new Vector3(20,20,20);
					string pieceName = "shipPiece" + (i+1);
					newC.name = pieceName;
					string posName = "polySurface" + (i+31);
					newC.transform.position = GameObject.Find(posName).transform.position;
					Destroy (newC.GetComponent("moveBoxScript"));
					GameObject.Find(posName).GetComponent<MeshRenderer>().enabled = true;
				}

			}



			int powerupnum = Random.Range (1, 1001);
			
			
			if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [0]) {
				moveBoxScript.score += 10;
				if(powerupnum % dropRate == 0){//if (powerupnum % 4 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp1";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,true);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
					
				}
				
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [1]) {
				moveBoxScript.score += 20;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);

					powerUp.tag = "powerup";
					powerUp.name = "PowerUp2";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [2]) {
				moveBoxScript.score += 30;
				if(powerupnum % dropRate == 0){//if (powerupnum % 10 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp3";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [3]) {
				moveBoxScript.score += 40;
				if(powerupnum % dropRate == 0){//if (powerupnum % 10 == 0) {

					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp4";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);

					//powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;

					powerUp.renderer.sharedMaterial = Randomize.gMaterial;// To get a glow material
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [4]) {
				moveBoxScript.score += 50;
				if(powerupnum % dropRate == 0){//if (powerupnum % 4 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp5";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [5]) {
				dest = false;
			}





			
			if (dest) {
				if(!Explosion)
				{
					Explosion = GameObject.FindGameObjectWithTag("Explode");
				}
				particleExplode =  (GameObject)Instantiate (Explosion,other.gameObject.transform.position,new Quaternion());
				Destroy (other.gameObject);
				GameObject.Destroy (particleExplode, 1.0f);
				
			}
			Destroy (gameObject);
			selectSpace.placedB = false;
			
		}  else if (other.gameObject.name == "Vincent") {
			
			
			
			if (gameObject.name == "PowerUp1") {
				AudioSource.PlayClipAtPoint (list[3], transform.position, setMusicVolume.volume);
				if(powerups[0] < 3)
					powerups [0]++;
				//powerup1count++;
				Destroy (gameObject);
				
				//Debug.Log("0 " + powerups[0]);
				
				
			} else if (gameObject.name == "PowerUp2") {
				AudioSource.PlayClipAtPoint (list[3], transform.position, setMusicVolume.volume);
				if(powerups[1] < 3)
					powerups [1]++;
				//powerup2count++;
				Destroy (gameObject);
				
				//Debug.Log("1 " + powerups[1]);
				
			} else if (gameObject.name == "PowerUp3") {
				AudioSource.PlayClipAtPoint (list[3], transform.position, setMusicVolume.volume);
				//powerups [2]++;
				//powerup3count++;
				Destroy (gameObject);
				
				//Debug.Log("2 " + powerups[2]);

				
				moveBoxScript.countrotate = 500;
				movePU.countrotate = 500;
				
				slowcount = 0;
				
				isSlowed = true;
				

				
			} else if (gameObject.name == "PowerUp4") {
				AudioSource.PlayClipAtPoint (list[3], transform.position, setMusicVolume.volume);
				//powerups [3]++;
				//powerup4count++;
				Destroy (gameObject);
				
				//Debug.Log("3 " + powerups[3]);
				
				Controller3DExample.movespeed = 3.0f;
				
				fastcount = 0;
				
				isFast = true;
				
		
				
			} else if (gameObject.name == "PowerUp5") {
				AudioSource.PlayClipAtPoint (list[3], transform.position, setMusicVolume.volume);
				if(powerups[4] < 3)
					powerups [4]++;
				//powerup5count++;
				Destroy (gameObject);
				
				
				//Debug.Log("4 " + powerups[4]);
				
				
			}


		} else if (gameObject.name == "colbomb") {



			AudioSource.PlayClipAtPoint (list[0], transform.position, setMusicVolume.volume);

			
			for(int i = 0; i < 19; i++){
				string theName = "shipPart" + (i+1);
				if(other.gameObject.name == theName){
					//Randomize.shipPartFound[i] = 1;
					//PlayerPrefs.SetInt(theName, Randomize.shipPartFound[i]);
					//PlayerPrefs.Save();
					moveBoxScript.score += 500;
					//GameObject newC = (GameObject)Instantiate(Resources.Load(theName));
					//newC.transform.localScale = new Vector3(20,20,20);
					//string pieceName = "shipPiece" + (i+1);
					//newC.name = pieceName;
					//string posName = "polySurface" + (i+31);
					//newC.transform.position = GameObject.Find(posName).transform.position;
					//Destroy (newC.GetComponent("moveBoxScript"));
					//GameObject.Find(posName).GetComponent<MeshRenderer>().enabled = true;
				}
				
			}
			
			
			int powerupnum = Random.Range (1, 1001);
			
			
			if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [0]) {
				moveBoxScript.score += 10;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
 					powerUp.name = "PowerUp1";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
					
				}
				
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [1]) {
				moveBoxScript.score += 20;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp2";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [2]) {
				moveBoxScript.score += 30;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp3";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [3]) {
				moveBoxScript.score += 40;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp4";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					//powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;

					powerUp.renderer.sharedMaterial = Randomize.gMaterial;// To get a glow material
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [4]) {
				moveBoxScript.score += 50;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp5";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [5]) {
				//dest = false;
				moveBoxScript.score += 100;
			}
			
			//if (dest) {

				Explosion = GameObject.FindGameObjectWithTag("Explode");

			particleExplode =  (GameObject)Instantiate (Explosion,other.gameObject.transform.position,new Quaternion());
			Destroy (other.gameObject);
			GameObject.Destroy (particleExplode, 1.0f);

			//}
			Destroy (gameObject);
			powerUpScript.cbomb = false;
			
	
		}
		
		
		else if (gameObject.name == "rowbomb") {

			AudioSource.PlayClipAtPoint (list[0], transform.position, setMusicVolume.volume);

			
			
			for(int i = 0; i < 19; i++){
				string theName = "shipPart" + (i+1);
				if(other.gameObject.name == theName){
					//Randomize.shipPartFound[i] = 1;
					//PlayerPrefs.SetInt(theName, Randomize.shipPartFound[i]);
					//PlayerPrefs.Save();
					moveBoxScript.score += 500;
					//GameObject newC = (GameObject)Instantiate(Resources.Load(theName));
					//newC.transform.localScale = new Vector3(20,20,20);
					//string pieceName = "shipPiece" + (i+1);
					//newC.name = pieceName;
					//string posName = "polySurface" + (i+31);
					//newC.transform.position = GameObject.Find(posName).transform.position;
					//Destroy (newC.GetComponent("moveBoxScript"));
					//GameObject.Find(posName).GetComponent<MeshRenderer>().enabled = true;
				}
				
			}
			
			
			int powerupnum = Random.Range (1, 1001);
			
			
			if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [0]) {
				moveBoxScript.score += 10;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp1";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
										
				}
				
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [1]) {
				moveBoxScript.score += 20;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp2";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [2]) {
				moveBoxScript.score += 30;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp3";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [3]) {
				moveBoxScript.score += 40;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp4";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					//powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;

					powerUp.renderer.sharedMaterial = Randomize.gMaterial;// To get a glow material
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [4]) {
				moveBoxScript.score += 50;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp5";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
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
			particleExplode =  (GameObject)Instantiate (Explosion,other.gameObject.transform.position,new Quaternion());
			Destroy (other.gameObject);
			GameObject.Destroy (particleExplode, 1.0f);
			//}
			Destroy (gameObject);
			powerUpScript.rbomb = false;
	
		}
		
		
		
		
		else if (gameObject.name == "largeBomb") {


			AudioSource.PlayClipAtPoint (list[0], transform.position, setMusicVolume.volume);

			
			
			
			for(int i = 0; i < 19; i++){
				string theName = "shipPart" + (i+1);
				if(other.gameObject.name == theName){
					//Randomize.shipPartFound[i] = 1;
					//PlayerPrefs.SetInt(theName, Randomize.shipPartFound[i]);
					//PlayerPrefs.Save();
					moveBoxScript.score += 500;
					//GameObject newC = (GameObject)Instantiate(Resources.Load(theName));
					//newC.transform.localScale = new Vector3(20,20,20);
					//string pieceName = "shipPiece" + (i+1);
					//newC.name = pieceName;
					//string posName = "polySurface" + (i+31);
					//newC.transform.position = GameObject.Find(posName).transform.position;
					//Destroy (newC.GetComponent("moveBoxScript"));
					//GameObject.Find(posName).GetComponent<MeshRenderer>().enabled = true;
				}
				
			}
			
			int powerupnum = Random.Range (1, 1001);
			
			
			if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [0]) {
				moveBoxScript.score += 10;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp1";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
				}
				
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [1]) {
				moveBoxScript.score += 20;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp2";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [2]) {
				moveBoxScript.score += 30;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp3";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [3]) {
				moveBoxScript.score += 40;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp4";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					//powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;

					powerUp.renderer.sharedMaterial = Randomize.gMaterial;// To get a glow material
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
				}
			} else if (other.gameObject.renderer.sharedMaterial == Randomize.materials1 [4]) {
				moveBoxScript.score += 50;
				if(powerupnum % dropRate == 0){//if (powerupnum % 5 == 0) {
					
					GameObject powerUp = GameObject.CreatePrimitive (PrimitiveType.Sphere);
					powerUp.tag = "powerup";
					powerUp.name = "PowerUp5";
					powerUp.transform.localScale = new Vector3 (0.33f, 0.33f, 0.33f);
					powerUp.transform.position = other.gameObject.transform.position;
					//powerUp.transform.SetParent(other.gameObject.transform,false);
					//powerUp.transform.position =  new Vector3(powerUp.transform.position.x, 0.25f, powerUp.transform.position.z);
					powerUp.renderer.sharedMaterial = other.gameObject.renderer.sharedMaterial;
					//Destroy (powerUp.collider);
					//					powerUp.AddComponent<BoxCollider> ();
					powerUp.collider.isTrigger = true;
					//powerUp.AddComponent<Rigidbody>();
					//powerUp.rigidbody.isKinematic = true;
					powerUp.AddComponent ("destroyObjScript");
					//powerUp.AddComponent ("moveBoxScript");
					powerUp.AddComponent ("movePU");
					
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
			particleExplode =  (GameObject)Instantiate (Explosion,other.gameObject.transform.position,new Quaternion());
			Destroy (other.gameObject);
			GameObject.Destroy (particleExplode, 1.0f);
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

		
		dropCounter++;
		
		if(dropCounter > 500){
			
			dropCounter = 0;
			if(dropRate < 15){
				dropRate++;
				
			}
			
		}
		
		
		if ((hashit)&&((prevcount+5)<=(floorcount))) {
			hashit = false;
			GameObject destroybox = GameObject.Find ("Destroy Object");
			Vector3 currentPosition = destroybox.transform.position;
			Vector3 newPosition = currentPosition;
			newPosition.z += 0.806f;
			destroybox.transform.position = newPosition;
			edgeZPos += 0.806f;
			
			prevcount = floorcount;
			
			
			
		}

		foreach (GameObject thisPower in GameObject.FindGameObjectsWithTag("powerup")) {
			//GameObject thisPower = GameObject.Find (PowerName);
			if(thisPower.transform.position.z < edgeZPos){
				
				Destroy (thisPower);
				
			}
			
		}

		if (GameObject.Find ("Vincent") == null) {
         
						powerUpScript.rbomb = false;
						powerUpScript.lbomb = false;
						powerUpScript.cbomb = false;
                        selectSpace.placedB = false;
			/*for(int i = 0; i < 5; i++){

				powerups[i] = 1;

			}*/
			powerups[0] = powerups[1] = powerups[4] = 1;
			if(isSlowed){
				isSlowed = false;
				moveBoxScript.countrotate = 200;
				movePU.countrotate = 200;

			}
			if(isFast){
				isFast = false;
				Controller3DExample.movespeed = 1.5f;
				
			}
			PauseScript.isPaused = false;
						Application.LoadLevel ("GameOver");
						if (moveBoxScript.score > highscore) {
				
								highscore = moveBoxScript.score;
				
						}
						AddScore ("aaaa", moveBoxScript.score );

						PlayerPrefs.SetInt("High Score", highscore);
						PlayerPrefs.Save();
						
			
						moveBoxScript.score = 0;
				} else {

						GameObject Vinc = GameObject.Find ("Vincent");

						foreach (GameObject cubeCheck in GameObject.FindGameObjectsWithTag("Box")) {

								//if(cubeCheck.transform.position == Vinc.transform.position){
								if (cubeCheck.name == "newCube") 
								{
					//AudioSource.PlayClipAtPoint (list[1], transform.position, setMusicVolume.volume);
									if ((cubeCheck.transform.position.x + .4f > Vinc.transform.position.x) && (cubeCheck.transform.position.z + .4f > Vinc.transform.position.z) && (cubeCheck.transform.position.x - .4f < Vinc.transform.position.x) && (cubeCheck.transform.position.z - .4f < Vinc.transform.position.z)) 
									{
						AudioSource.PlayClipAtPoint (list[1], transform.position, setMusicVolume.volume);

										Destroy (Vinc);
									}
								}
						}
				}


		
		slowcount++;
		if((slowcount > 1000)&&(isSlowed)){
			
			isSlowed = false;
			moveBoxScript.countrotate = 200;
			movePU.countrotate = 200;
			
			
		}
		
		fastcount++;
		if((fastcount > 1000)&&(isFast)){
			
			isFast = false;
			Controller3DExample.movespeed = 1.5f;
			
			
		}
		
		
	}
	public void AddScore(string name,int score){
		int newScore;
		string newName;
		int oldScore;
		string oldName;
		newScore = score;
		newName = name;
		for(int i=0;i<10;i++){
			if(PlayerPrefs.HasKey(i+"Score")){
				if(PlayerPrefs.GetInt(i+"Score")<newScore){
					// new score is higher than the stored score
					oldScore = PlayerPrefs.GetInt(i+"Score");
					oldName = PlayerPrefs.GetString(i+"HScoreName");
					PlayerPrefs.SetInt(i+"Score",newScore);
					PlayerPrefs.SetString(i+"HScoreName",newName);
					newScore = oldScore;
					newName = oldName;
				}
			}else{
				PlayerPrefs.SetInt(i+"Score",newScore);
				PlayerPrefs.SetString(i+"HScoreName",newName);
				newScore = 0;
				newName = "";
			}
		}
	}
	
}

