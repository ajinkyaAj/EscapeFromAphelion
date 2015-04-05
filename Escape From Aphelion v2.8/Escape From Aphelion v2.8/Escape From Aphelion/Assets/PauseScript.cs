using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour {

	private Button b;
	// Use this for initialization
	void Start () {
		b = this.GetComponent<Button> ();
		b.onClick.AddListener(() => Hello());
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Hello()
	{
		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
	}
}
