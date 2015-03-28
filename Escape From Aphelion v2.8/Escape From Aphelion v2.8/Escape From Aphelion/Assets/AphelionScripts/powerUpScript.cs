using UnityEngine;
using System.Collections;

public class powerUpScript : MonoBehaviour {
	
	
	public Material materialRow;
	public Material materialCol;
	public Material materialLarge;
	public static bool cbomb = false;
	public static bool rbomb = false;
	public static bool lbomb = false;
	
	
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	public void rowbomb(){
		
		if(destroyObjScript.powerups[1] > 0){
			if(!rbomb){	
				
				
				
				
				int row = 0;
				
				
				if((GameObject.Find("Vincent").transform.position.z > -5.45f) &&(GameObject.Find("Vincent").transform.position.z <= -4.501f)){
					
					row = 1;
				}
				else if((GameObject.Find("Vincent").transform.position.z > -4.501) &&(GameObject.Find("Vincent").transform.position.z <= -3.695f)){
					
					row = 2;
				}
				else if((GameObject.Find("Vincent").transform.position.z > -3.695f) &&(GameObject.Find("Vincent").transform.position.z <= -2.889f)){
					
					row = 3;
				}
				else if((GameObject.Find("Vincent").transform.position.z > -2.889f) &&(GameObject.Find("Vincent").transform.position.z <= -2.083f)){
					
					row = 4;
				}
				else if((GameObject.Find("Vincent").transform.position.z > -2.083f) &&(GameObject.Find("Vincent").transform.position.z <= -1.277f)){
					
					row = 5;
				}
				else if((GameObject.Find("Vincent").transform.position.z > -1.277f) &&(GameObject.Find("Vincent").transform.position.z <= -0.471f)){
					
					row = 6;
				}
				else if((GameObject.Find("Vincent").transform.position.z > -0.471f) &&(GameObject.Find("Vincent").transform.position.z <= 0.335f)){
					
					row = 7;
				}
				else if((GameObject.Find("Vincent").transform.position.z > 0.335f) &&(GameObject.Find("Vincent").transform.position.z <= 1.141f)){
					
					row = 8;
				}
				
				
				
				else if((GameObject.Find("Vincent").transform.position.z > 1.141f) &&(GameObject.Find("Vincent").transform.position.z <= 1.96f)){
					
					row = 9;
				}
				
				//Debug.Log("row " + row);
				
				rbomb = true;
				destroyObjScript.powerups[1]--;
				GameObject newC = GameObject.CreatePrimitive(PrimitiveType.Plane);
				
				newC.transform.localScale = new Vector3(0.50f, 0.07f, 0.07f);
				newC.name = "rowbomb";
				
				
				if(row == 1){
					
					newC.transform.position = new Vector3(0.119f, 0.25f, -4.904f);
					
				}
				else if(row == 2){
					newC.transform.position = new Vector3(0.119f, 0.25f, -4.098f);
				}
				
				else if(row == 3){
					newC.transform.position = new Vector3(0.119f, 0.25f, -3.292f);
				}
				
				else if(row == 4){
					newC.transform.position = new Vector3(0.119f, 0.25f, -2.486f);
				}
				
				else if(row == 5){
					newC.transform.position = new Vector3(0.119f, 0.25f, -1.68f);
				}
				
				else if(row == 6){
					newC.transform.position = new Vector3(0.119f, 0.25f, -0.874f);
				}
				
				else if(row == 7){
					newC.transform.position = new Vector3(0.119f, 0.25f, -0.068f);
				}
				
				else if(row == 8){
					newC.transform.position = new Vector3(0.119f, 0.25f, 0.738f);
				}
				
				else if(row == 9){
					newC.transform.position = new Vector3(0.119f, 0.25f, 1.544f);
				}
				
				
				
				
				
				
				
				//var boxCollid = (BoxCollider)newC.collider;
				//boxCollid.center = new Vector3(-0.72f, 0.61f, -1.51f);//GameObject.Find("polySurface6").transform.position;//new Vector3(2,3,4);
				//newC.transform.position = GameObject.Find("Vincent").transform.position;//transform.position;//new Vector3(-0.72f, 0.61f, -1.51f);//transform.position;
				//newC.transform.position =  new Vector3(newC.transform.position.x, 0.25f, newC.transform.position.z);
				newC.renderer.material = materialCol;
				newC.AddComponent<BoxCollider>();
				//newC.AddComponent<Rigidbody>();
				newC.collider.isTrigger = true;
				newC.AddComponent("destroyObjScript");
				
			}
		}
		
		
		
		
	}
	
	public void colbomb(){

		if(destroyObjScript.powerups[0] > 0){

		if(!cbomb){
			
			
			int col = 0;
			
			
			if((GameObject.Find("Vincent").transform.position.x > 1.325f) &&(GameObject.Find("Vincent").transform.position.x <= 2.2f)){
				
				col = 1;
				
			}
			else if((GameObject.Find("Vincent").transform.position.x > 0.521f) &&(GameObject.Find("Vincent").transform.position.x <= 1.325f)){
				
				col = 2;
			}
			else if((GameObject.Find("Vincent").transform.position.x > -0.283f) &&(GameObject.Find("Vincent").transform.position.x <= 0.521f)){
				
				col = 3;
			}
			else if((GameObject.Find("Vincent").transform.position.x > -1.087f) &&(GameObject.Find("Vincent").transform.position.x <= -0.283)){
				
				col = 4;
			}
			else if((GameObject.Find("Vincent").transform.position.x > -2.0f) &&(GameObject.Find("Vincent").transform.position.x <= -1.087f)){
				
				col = 5;
			}
			
			//Debug.Log("col " + col);
			
			cbomb = true;
			destroyObjScript.powerups[0]--;
			
			GameObject newC = GameObject.CreatePrimitive(PrimitiveType.Plane);
			
			newC.transform.localScale = new Vector3(0.07f, 0.07f, 0.90f);
			newC.name = "colbomb";
			//var boxCollid = (BoxCollider)newC.collider;
			//boxCollid.center = new Vector3(-0.72f, 0.61f, -1.51f);//GameObject.Find("polySurface6").transform.position;//new Vector3(2,3,4);
			
			if(col == 1){
				newC.transform.position = new Vector3(1.7625f, 0.25f, -1.68f);
			}
			else if(col == 2){
				newC.transform.position = new Vector3(0.923f, 0.25f, -1.68f);
				
			}
			else if(col == 3){
				newC.transform.position = new Vector3(0.119f, 0.25f, -1.68f);
				
			}
			else if(col == 4){
				newC.transform.position = new Vector3(-0.675f, 0.25f, -1.68f);
				
			}
			else if(col == 5){
				newC.transform.position = new Vector3(-1.489f, 0.25f, -1.68f);
				
			}
			
			
			//newC.transform.position = GameObject.Find("Vincent").transform.position;//transform.position;//new Vector3(-0.72f, 0.61f, -1.51f);//transform.position;
			//newC.transform.position =  new Vector3(newC.transform.position.x, 0.25f, newC.transform.position.z);
			newC.renderer.material = materialRow;
			newC.AddComponent<BoxCollider>();
			//newC.AddComponent<Rigidbody>();
			newC.collider.isTrigger = true;
			newC.AddComponent("destroyObjScript");
			
			
		}
		}
	}
	
	public void areabomb(){
		
		if(destroyObjScript.powerups[4] > 0){
			
			if(!lbomb){
				
				lbomb = true;
				
				destroyObjScript.powerups[4]--;
				
				
				
				GameObject newC = GameObject.CreatePrimitive(PrimitiveType.Plane);
				
				newC.transform.localScale = new Vector3(0.25f, 0.07f, 0.25f);
				newC.name = "largeBomb";
				//var boxCollid = (BoxCollider)newC.collider;
				//boxCollid.center = new Vector3(-0.72f, 0.61f, -1.51f);//GameObject.Find("polySurface6").transform.position;//new Vector3(2,3,4);
				newC.transform.position = GameObject.Find("Vincent").transform.position;//transform.position;//new Vector3(-0.72f, 0.61f, -1.51f);//transform.position;
				newC.transform.position =  new Vector3(newC.transform.position.x, 0.25f, newC.transform.position.z);
				newC.renderer.material = materialLarge;
				newC.AddComponent<BoxCollider>();
				//newC.AddComponent<Rigidbody>();
				newC.collider.isTrigger = true;
				newC.AddComponent("destroyObjScript");
				
				
			}
			
		}
		
		
	}
	
	
	// Update is called once per frame
	void Update () {
		
		
		
		//if (Input.GetKey (KeyCode.Alpha1)) {
		//if(destroyObjScript.powerups[0] > 0){
		
		//	}
		
		
		//}
		
		//else if (Input.GetKey (KeyCode.Alpha2)) {
		
		
		
		//}
		
		
		
		
		//else if (Input.GetKey (KeyCode.Alpha3)) {
		
		
		
	}
	
	
	//}
}
