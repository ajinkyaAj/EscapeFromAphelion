using UnityEngine;
using System.Collections;

public class FallingBox : MonoBehaviour {

	public AudioClip[] list;

	void OnTriggerEnter(Collider other) 
	{

		destroyObjScript.hashit = true;
		Destroy (other.gameObject);
	}
	// Use this for initialization
	void Start () {
		list = new AudioClip[]{(AudioClip)Resources.Load ("Sounds/menu")};
	
		AudioSource.PlayClipAtPoint (list[0], transform.position, setMusicVolume.volume);
	}
	
	// Update is called once per frame
	void Update () {
	



	}
}
