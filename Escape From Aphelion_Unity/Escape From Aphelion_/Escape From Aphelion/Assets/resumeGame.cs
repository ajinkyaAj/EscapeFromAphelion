using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class resumeGame : MonoBehaviour {

	private Button b;
	
	Image sourceImage;
	private Sprite pauseSprite;

	public AudioClip[] list;
	private GameObject go;
	Canvas canvas01;
	// Use this for initialization
	void Start () {
		b = this.GetComponent<Button> ();
		b.onClick.AddListener(() => Hello());
		pauseSprite = Resources.Load<Sprite> ("pause");
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

		go = GameObject.Find ("setting_canvas");
		canvas01 = go.GetComponent<Canvas>();
		canvas01.enabled = !canvas01.enabled;
		
		Time.timeScale = Time.timeScale == 0 ? 1 : 0;

		AudioSource.PlayClipAtPoint (list[0], transform.position, setMusicVolume.volume);
		GameObject gobject = GameObject.Find ("Pause");
		gobject.GetComponent<Image>().sprite = pauseSprite;
		PauseScript.isPaused = false;
	}
}
