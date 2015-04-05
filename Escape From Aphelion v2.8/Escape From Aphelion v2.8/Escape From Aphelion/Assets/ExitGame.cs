using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ExitGame : MonoBehaviour {
	
	private Button b;
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
		Application.Quit();
	}
	
	
}
