using UnityEngine;
using System.Collections;

public class movePU : MonoBehaviour {



	public static bool ShouldCreateNewRow = true;
	
	public static bool IsRotate = true;

	public float speed = 100.0f;
	public float smooth = 50000.0f;
	public Vector3 move = new Vector3 (0,0,1);
	
	public static int countrotate = 200;
	
	
	public float count;
	
	
	// Public Variables
	public float rotateSpeed;    // Speed of the rotation of the cubes
	public float rotateDegrees;    // Rotate degrees interval
	
	
	// Private Variables
	private Transform trans; // To Store this gameObject
	private float startRotation;    // To store the startRotation
	private float curRotation;    // Store the currentRotation
	private float angle;
	
	
	Vector3 theAxis = new Vector3 (0.036f,0.134f,1.95f);
	float TheAngle = 360.0f;
	
	public float anglePerUpdate = 1f;
	public float gravity = 9.81f;
	public float pos = 0.1f;
	public float step = 0.005f;
	public float sensitivity = -0.682f;
	public float timerTillNextRotate = 1.0f;
	public float timer;
	
	public static int flag = 0;
	
	
	public static bool ShouldRotate = false;
	//Private Variables
	
	public AudioClip[] list;
	//Variables End

	// Use this for initialization
	void Start () {

		trans = this.transform;                // Store this.transform for optimisation
		startRotation = trans.eulerAngles.z;// Store the current rotation
		curRotation = startRotation;        // Store the cur Rotation
		IsRotate = false;     
		rotateSpeed = 50.0f;
		rotateDegrees = 360.0f;
		count = 0.0f;
		timerTillNextRotate = 1.0f;
		timer = 0.0f;
		
		float halflength = 0.4f;
		
		list = new AudioClip[]{(AudioClip)Resources.Load ("Sounds/DestroySound"),
			(AudioClip)Resources.Load ("Sounds/ROT"),
			(AudioClip)Resources.Load ("Sounds/BlockFall")};
	
	}
	
	// Update is called once per frame
	void Update () {



		if (!PauseScript.isPaused) {

			
			//Rotation Bool  
			//bool ShouldRotate = false;
			count += 1.0f;
			if (count < 46) {
				ShouldRotate = true;
				ShouldCreateNewRow = false;
				
			} else {
				ShouldRotate = false;
			}
			
			
			if (Input.GetKey (KeyCode.K)) {
				ShouldRotate = false;
			}
			
			if (ShouldRotate) {
				
				var initialRotation = Quaternion.identity;
				
				/*float currentAngle = transform.rotation.eulerAngles.x;
			transform.rotation = 
				Quaternion.AngleAxis(currentAngle + (Time.deltaTime*-90.0f) , Vector3.right);*/
				//rigidbody.velocity = Quaternion.AngleAxis(-90.0f, Vector3.right) * rigidbody.velocity;
				
				
				//this.transform.Translate(Vector3.forward * sensitivity * Time.deltaTime ,Space.World);
				
				
				//this.transform.Translate(move * -1 * Time.deltaTime);
				//this.transform.rotation = this.transform.rotation * Quaternion.AngleAxis(anglePerUpdate, this.transform.right * -1 * Time.deltaTime);
				
				timer += Time.deltaTime;
				Vector3 degree = new Vector3 (-2.0f, 0, 0);
				Quaternion startRotation = transform.rotation;
				Quaternion endRotation = transform.rotation * Quaternion.Euler (degree);
				Vector3 currentPosition = transform.position;
				
				Vector3 newPosition = currentPosition - new Vector3 (0.0f, 0.0f, 0.865f * 0.0205f);
				transform.position = Vector3.Lerp (currentPosition, newPosition, 1.0f);
				transform.rotation = Quaternion.Slerp (startRotation, endRotation, 1.0f);
				
			}
			
			
			if (count > countrotate) {
				AudioSource.PlayClipAtPoint (list[1], transform.position, setMusicVolume.volume);
				count = 0.0f;
				ShouldCreateNewRow = true;
				if (Input.GetKey (KeyCode.B)) {
					GameObject newMinor = Instantiate (gameObject, transform.position + transform.up, transform.transform.rotation) as GameObject;
				}
			}
			
		}
	}
	

	

}
