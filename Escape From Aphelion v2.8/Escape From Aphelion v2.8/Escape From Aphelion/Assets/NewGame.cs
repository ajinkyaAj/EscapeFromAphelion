using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class NewGame : MonoBehaviour {
	public AudioClip[] list;
	private Button b;
	void Start () 
	{
		list = new AudioClip[]{(AudioClip)Resources.Load ("Sounds/menu")};
		 b = this.GetComponent<Button> ();
		b.onClick.AddListener(() => Hello());

	}
	void Update()
	{

	}
	public void Hello()
	{
		//AudioSource.PlayClipAtPoint (list[0], transform.position, setMusicVolume.volume);

		//foreach (GameObject thisSound in GameObject.Find("One shot audio")){
		//GameObject thisSound = GameObject.Find ("One shot audio");

	//	}

		LoadingScreen.show ();
		Application.LoadLevel("SceneWithRotation");
	}
	
	
}
