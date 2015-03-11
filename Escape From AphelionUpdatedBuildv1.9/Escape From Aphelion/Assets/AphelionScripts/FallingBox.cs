using UnityEngine;
using System.Collections;

public class FallingBox : MonoBehaviour {



	void OnTriggerEnter(Collider other) 
	{

		destroyObjScript.hashit = true;
		Destroy (other.gameObject);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	



	}
}
