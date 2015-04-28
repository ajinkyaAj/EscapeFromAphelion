using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActiveTouchDown : MonoBehaviour {
		
		private GameObject destroyBox;
		// Use this for initialization
		void Start () {
			
			
		}
		
		// Update is called once per frame
		void Update()
		{
			Button b = this.GetComponent<Button> ();
			b.onClick.AddListener(() => Hello());
			destroyBox = GameObject.FindGameObjectWithTag("Player");
		}
		
		public void Hello()
		{
			Debug.Log ("Hello Activated");
			destroyBox.GetComponent<selectSpace>().activateBomb();
		}
	}