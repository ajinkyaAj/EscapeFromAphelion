using UnityEngine;
using System.Collections;

public class selectSpace : MonoBehaviour {

	public Shader shaderB;

	public Material materialB;
	public static bool placedB = false;
	public GameObject[] floor = new GameObject[45];
	public int cubeNum;
	//public Vector3 cubepos;
	public int curcol = 0;
	public int currow = 0;

	public AudioClip[] list;
	//public int countB = 0;
	// Use this for initialization
	void Start () {
		list = new AudioClip[]{(AudioClip)Resources.Load("Sounds/P"),
			(AudioClip)Resources.Load("Sounds/ACT"),
			(AudioClip)Resources.Load("Sounds/DEA"),
			(AudioClip)Resources.Load("Sounds/PUD2")};
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log("i ");


		if (Input.GetKey (KeyCode.Space)) {

			activateBomb();
		}

		if(Input.GetKey (KeyCode.T)){

			deactivateBomb();

		}
	
	}

	public void activateBomb()
	{
		int row = 0;
		int col = 0;
		//countB++;
		if (!placedB) {
			
						if (!PauseScript.isPaused) {
			
				AudioSource.PlayClipAtPoint (list[1], transform.position, setMusicVolume.volume);
								//cubepos = floor[44].transform.position;
			
			
								if ((GameObject.Find ("Vincent").transform.position.x > 1.325f) && (GameObject.Find ("Vincent").transform.position.x <= 2.2f)) {
				
										col = 1;
								} else if ((GameObject.Find ("Vincent").transform.position.x > 0.521f) && (GameObject.Find ("Vincent").transform.position.x <= 1.325f)) {
				
										col = 2;
								} else if ((GameObject.Find ("Vincent").transform.position.x > -0.283f) && (GameObject.Find ("Vincent").transform.position.x <= 0.521f)) {
				
										col = 3;
								} else if ((GameObject.Find ("Vincent").transform.position.x > -1.087f) && (GameObject.Find ("Vincent").transform.position.x <= -0.283)) {
				
										col = 4;
								} else if ((GameObject.Find ("Vincent").transform.position.x > -2.0f) && (GameObject.Find ("Vincent").transform.position.x <= -1.087f)) {
				
										col = 5;
								}
			
			
			
			
			
			
								if ((GameObject.Find ("Vincent").transform.position.z > -5.45f) && (GameObject.Find ("Vincent").transform.position.z <= -4.501f)) {
				
										row = 1;
								} else if ((GameObject.Find ("Vincent").transform.position.z > -4.501) && (GameObject.Find ("Vincent").transform.position.z <= -3.695f)) {
				
										row = 2;
								} else if ((GameObject.Find ("Vincent").transform.position.z > -3.695f) && (GameObject.Find ("Vincent").transform.position.z <= -2.889f)) {
				
										row = 3;
								} else if ((GameObject.Find ("Vincent").transform.position.z > -2.889f) && (GameObject.Find ("Vincent").transform.position.z <= -2.083f)) {
				
										row = 4;
								} else if ((GameObject.Find ("Vincent").transform.position.z > -2.083f) && (GameObject.Find ("Vincent").transform.position.z <= -1.277f)) {
				
										row = 5;
								} else if ((GameObject.Find ("Vincent").transform.position.z > -1.277f) && (GameObject.Find ("Vincent").transform.position.z <= -0.471f)) {
				
										row = 6;
								} else if ((GameObject.Find ("Vincent").transform.position.z > -0.471f) && (GameObject.Find ("Vincent").transform.position.z <= 0.335f)) {
				
										row = 7;
								} else if ((GameObject.Find ("Vincent").transform.position.z > 0.335f) && (GameObject.Find ("Vincent").transform.position.z <= 1.141f)) {
				
										row = 8;
								} else if ((GameObject.Find ("Vincent").transform.position.z > 1.141f) && (GameObject.Find ("Vincent").transform.position.z <= 1.96f)) {
				
										row = 9;
								}
			
								curcol = col;
								currow = row;
								cubeNum = (5 * (row - 1)) + (col - 1);
								if ((curcol != 0) && (currow != 0)) {
				
										placedB = true;
				
										GameObject newC = GameObject.CreatePrimitive (PrimitiveType.Plane);
										newC.renderer.material.shader = shaderB;
				
										newC.transform.localScale = new Vector3 (0.07f, 0.07f, 0.07f);
										newC.name = "bomb";
										//var boxCollid = (BoxCollider)newC.collider;
										//boxCollid.center = new Vector3(-0.72f, 0.61f, -1.51f);//GameObject.Find("polySurface6").transform.position;//new Vector3(2,3,4);
										newC.transform.position = floor [cubeNum].transform.position;//GameObject.Find("Vincent").transform.position;//transform.position;//new Vector3(-0.72f, 0.61f, -1.51f);//transform.position;
										newC.transform.position = new Vector3 (newC.transform.position.x, 0.25f, newC.transform.position.z);
										newC.renderer.material = materialB;
										newC.AddComponent<BoxCollider> ();
										//newC.AddComponent<Rigidbody>();
										newC.collider.isTrigger = true;
										newC.AddComponent ("destroyObjScript");
				
				
								}
			
						}
				}

	}

	public void deactivateBomb()
	{
		if(placedB) {
			AudioSource.PlayClipAtPoint (list[2], transform.position, setMusicVolume.volume);
			placedB = false;
			GameObject bomb = GameObject.Find ("bomb");
			Destroy(bomb);
			
			
		}

	}
}
