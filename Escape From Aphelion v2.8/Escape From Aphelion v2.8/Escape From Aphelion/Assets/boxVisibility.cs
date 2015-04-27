using UnityEngine;
using System.Collections;

public class boxVisibility : MonoBehaviour {

	public static int shipPartFound = 0;
	// Use this for initialization
	void Start () {

		for(int i = 0; i < 19; i++){
			string theName = "shipPart" + (i+1);
			shipPartFound = PlayerPrefs.GetInt(theName);
			if(shipPartFound == 1)
			{
				if(i == 0)
					GameObject.Find("polySurface31").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 1)
					GameObject.Find("polySurface32").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 2)
					GameObject.Find("polySurface33").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 3)
					GameObject.Find("polySurface34").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 4)
					GameObject.Find("polySurface35").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 5)
					GameObject.Find("polySurface36").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 6)
					GameObject.Find("polySurface37").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 7)
					GameObject.Find("polySurface38").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 8)
					GameObject.Find("polySurface39").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 9)
					GameObject.Find("polySurface40").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 10)
					GameObject.Find("polySurface41").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 11)
					GameObject.Find("polySurface42").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 12)
					GameObject.Find("polySurface43").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 13)
					GameObject.Find("polySurface44").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 14)
					GameObject.Find("polySurface45").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 15)
					GameObject.Find("polySurface46").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 16)
					GameObject.Find("polySurface47").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 17)
					GameObject.Find("polySurface48").GetComponent<MeshRenderer>().enabled = true;
				else if(i == 18)
					GameObject.Find("polySurface49").GetComponent<MeshRenderer>().enabled = true;
			}
			if (shipPartFound == 0) {
				if (i == 0)
					GameObject.Find ("polySurface31").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 1)
					GameObject.Find ("polySurface32").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 2)
					GameObject.Find ("polySurface33").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 3)
					GameObject.Find ("polySurface34").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 4)
					GameObject.Find ("polySurface35").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 5)
					GameObject.Find ("polySurface36").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 6)
					GameObject.Find ("polySurface37").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 7)
					GameObject.Find ("polySurface38").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 8)
					GameObject.Find ("polySurface39").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 9)
					GameObject.Find ("polySurface40").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 10)
					GameObject.Find ("polySurface41").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 11)
					GameObject.Find ("polySurface42").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 12)
					GameObject.Find ("polySurface43").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 13)
					GameObject.Find ("polySurface44").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 14)
					GameObject.Find ("polySurface45").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 15)
					GameObject.Find ("polySurface46").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 16)
					GameObject.Find ("polySurface47").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 17)
					GameObject.Find ("polySurface48").GetComponent<MeshRenderer> ().enabled = false;
				else if (i == 18)
					GameObject.Find ("polySurface49").GetComponent<MeshRenderer> ().enabled = false;
			}
					
			//Debug.Log (shipPartFound[i]);
		}
	}


	// Update is called once per frame
	void Update () {

	}
}
