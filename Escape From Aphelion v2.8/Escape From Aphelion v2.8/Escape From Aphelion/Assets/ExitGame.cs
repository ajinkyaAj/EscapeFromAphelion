using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ExitGame : MonoBehaviour {
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

		AudioSource.PlayClipAtPoint (list[0], transform.position, setMusicVolume.volume);
		Application.Quit();
	}
	
	
}
