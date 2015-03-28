using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class deactiveDown : MonoBehaviour {
	
	private GameObject destroyBox;
	// Use this for initialization
	void Start () {
		Button b = this.GetComponent<Button> ();
		b.onClick.AddListener(() => Hello());
		//b.onClick.Invoke(() => Hello());
		destroyBox = GameObject.FindGameObjectWithTag("Player");
		
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}
	
	public void Hello()
	{
		Debug.Log ("Hello DeActivated");
		destroyBox.GetComponent<selectSpace>().deactivateBomb();
	}
}