using UnityEngine;
using System.Collections;

public class randomCubeSelect : MonoBehaviour {

	public ArrayList nameCube;

	public int size ;

	public GameObject cube;

	string[] NameArray = new string[]{"Name 00", "Name 11", "Name 22", "Name 33"};

	string chosenName;

	int i = 5;
	//var chosenName : String;
	
	void ChooseName() 
	{
		chosenName = NameArray[Random.Range(0, NameArray.Length)];    
		//Debug.Log("chosenName " + chosenName);
	}


	
	// Use this for initialization
	void Start () 
	{
	
		size = 10;


	}
	
	// Update is called once per frame
	void Update () 
	{
		ChooseName();

		for(i=0;i<5;i++)
		{


		}


	}




}
