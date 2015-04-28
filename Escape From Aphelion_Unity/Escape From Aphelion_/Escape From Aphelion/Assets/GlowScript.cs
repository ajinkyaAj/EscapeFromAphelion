using UnityEngine;
using System.Collections;
public class GlowScript : MonoBehaviour {
	// Use this for initialization
	public Camera cam;
	//GameObject camera;
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		if(cam){
			Matrix4x4 viewm=cam.cameraToWorldMatrix;
			Debug.Log(viewm);
			renderer.sharedMaterial.SetMatrix("ViewIXf",viewm.inverse);
		}
	}
}