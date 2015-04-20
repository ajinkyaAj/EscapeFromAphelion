using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class goToMenu : MonoBehaviour {
	public AudioClip[] list;
	private Button b;
	float timer;
	void Start () 
	{

		list = new AudioClip[]{(AudioClip)Resources.Load ("Sounds/menu")};
		b = this.GetComponent<Button> ();
		b.onClick.AddListener (() => Hello ());

		
	}
	void Update()
	{

	}


	public void Hello()
	{
		AudioSource.PlayClipAtPoint (list[0], transform.position, setMusicVolume.volume);
		//foreach (GameObject thisSound in GameObject.Find("One shot audio")){
			//GameObject thisSound = GameObject.Find ("One shot audio");
		DontDestroyOnLoad(list[0]);
		//}

		powerUpScript.rbomb = false;
		powerUpScript.lbomb = false;
		powerUpScript.cbomb = false;
		selectSpace.placedB = false;
	
		if(destroyObjScript.isSlowed){
			destroyObjScript.isSlowed = false;
			moveBoxScript.countrotate = 200;
			
		}
		if(destroyObjScript.isFast){
			destroyObjScript.isFast = false;
			Controller3DExample.movespeed = 1.5f;
			
		}
	



			Time.timeScale = 1;
			PauseScript.isPaused = false;	
			destroyObjScript.powerups = new int[] {1,1,0,0,1};
			LoadingScreen.show ();
			Application.LoadLevel ("MainMenu");
			
	
	}
	
	
}
