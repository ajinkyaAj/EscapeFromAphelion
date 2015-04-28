using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TouchButtonLogic : MonoBehaviour {

	private GameObject destroyBox;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update()
	{
		Button b = this.GetComponent<Button> ();
		b.onClick.AddListener(() => Hello());
		destroyBox = GameObject.FindGameObjectWithTag("Destroy");
	}

	public void Hello()
	{
		Debug.Log ("Hello Deactive");
		destroyBox.GetComponent<destroyObjScript>().enabled = false;
	}
}