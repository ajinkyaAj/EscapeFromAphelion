using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class setting : MonoBehaviour {
	
	private Button b;
	private GameObject go;
	Canvas canvas01;

	void Start () 
	{
		b = this.GetComponent<Button> ();
		b.onClick.AddListener(() => Hello());

	}
	void Update()
	{
		
	}
	public void Hello()
	{
		go = GameObject.Find ("setting_canvas");
		canvas01 = go.GetComponent<Canvas>();
		canvas01.enabled = !canvas01.enabled;
	}
	
	
}
