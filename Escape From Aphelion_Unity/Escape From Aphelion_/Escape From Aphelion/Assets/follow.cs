using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	public Transform target;
	// Use this for initialization
	void Start () {
		this.transform.position = target.localPosition; 
	
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.position = target.localPosition; 
	}
}
