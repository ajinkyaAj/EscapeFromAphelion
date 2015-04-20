using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class settings_mainmenu : MonoBehaviour {
	
	
	private Button b;
	
	Image sourceImage;
	private Sprite pauseSprite;
	private Sprite playSprite;
	public AudioClip[] list;
	private GameObject go;
	Canvas canvas01;
	// Use this for initialization
	void Start () {
		b = this.GetComponent<Button> ();
		b.onClick.AddListener(() => Hello());
		
		
		list = new AudioClip[]{(AudioClip)Resources.Load("Sounds/P"),
			(AudioClip)Resources.Load("Sounds/ACT"),
			(AudioClip)Resources.Load("Sounds/DEA"),
			(AudioClip)Resources.Load("Sounds/PUD2")};
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Hello()
	{
		
		//AudioSource.PlayClipAtPoint (list[0], transform.position, setMusicVolume.volume);
		Button myButtonScript01 = GameObject.Find ("NewGameButton").GetComponent<Button>();
		myButtonScript01.interactable = false;
		Button myButtonScript02 = GameObject.Find ("EndGameButton").GetComponent<Button>();
		myButtonScript02.interactable = false;
		Button myButtonScript03 = GameObject.Find ("Help").GetComponent<Button>();
		myButtonScript03.interactable = false;
		Button myButtonScript04 = GameObject.Find ("Settings").GetComponent<Button>();
		myButtonScript04.interactable = false;

		go = GameObject.Find ("setting_canvas");
		canvas01 = go.GetComponent<Canvas>();
		canvas01.enabled = !canvas01.enabled;
		
	}
}
