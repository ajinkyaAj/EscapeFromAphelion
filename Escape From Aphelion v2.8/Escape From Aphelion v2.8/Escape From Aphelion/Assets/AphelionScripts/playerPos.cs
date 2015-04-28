using UnityEngine;
using System.Collections;

public class playerPos : MonoBehaviour {
	public Material materialPlayerPos;
	// Use this for initialization
	void Start () {
	
		Vector3 playerPosition = GameObject.Find ("Vincent").transform.position;
		GameObject newC = GameObject.CreatePrimitive(PrimitiveType.Plane);
		
		newC.transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);
		newC.name = "playerPos";
		newC.transform.position = new Vector3(playerPosition.x, 0.25f, playerPosition.z);//new Vector3(0.119f, 0.25f, -4.904f);

		newC.renderer.material = materialPlayerPos;


	}
	
	// Update is called once per frame
	void Update () {

		GameObject pPos = GameObject.Find ("playerPos");

		Vector3 playerPosition = GameObject.Find ("Vincent").transform.position;

		pPos.transform.position = new Vector3(playerPosition.x, 0.25f, playerPosition.z);
	}
}
