using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour {
		
		void OnGUI()
		{
			Button b = this.GetComponent<Button> ();
			b.onClick.AddListener(() => Hello());
		}
		public void Hello()
		{
			Application.Quit();
		}
}
