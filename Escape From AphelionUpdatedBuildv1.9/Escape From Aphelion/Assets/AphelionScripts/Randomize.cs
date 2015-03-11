using UnityEngine;
using System.Collections;

public class Randomize : MonoBehaviour {

	public GameObject newCube;

	public Material[] materials = new Material[6];

	public static Material[] materials1 = new Material[6];

	//public float counter = 0;

	public int[] col = new int[15];

	public int colcount = 0;

	public int rotcount = 0;
//	public bool first = true;


	// Use this for initialization
	void Start () {
		materials1[0]= materials[0];
		materials1[1]= materials[1];
		materials1[2]= materials[2];
		materials1[3]= materials[3];
		materials1[4]= materials[4];
		materials1[5]= materials[5];

		
	}
	
	// Update is called once per frame
	void Update () {

		bool ShouldCreateNewRow = moveBoxScript.ShouldCreateNewRow;
		
		if(ShouldCreateNewRow){
			
			rotcount++;
		}
		if (!ShouldCreateNewRow) {
			
			rotcount = 0;
		}
		
		if ((ShouldCreateNewRow)&&(rotcount == 1))
		{
			//first = false;

		//if(Input.GetKey (KeyCode.D)) {
			//justRotated = false;

			int numBlocks = 5;
			
			int[] blocks = new int[numBlocks];


			
			
			
			
			//foreach(row in higher structure){
			//foreach (Transform pCube in rowx){
			// do whatever you want with this bullet
			//}
			//}
			
			int emptycount = 0;
			for( int i = 0 ; i < numBlocks; i++ ){
				//Random rnd = new Random();
				blocks[i] = Random.Range (1,10);//rnd.Next(1, 6);
				if(blocks[i] > 6){

					emptycount++;
					if(emptycount > 2){

						blocks[i] = Random.Range (1,7);
					}

				}
			}
			
			
			///Debug.Log("dgklfjgvjkfhv ");
			
			
			//when assigning material
			//Rigidbody clone;
			//clone = Instantiate (go1, new Vector3(0,0,0), this.transform.rotation) as Rigidbody;
			//Instantiate(Resources.Load<Object>("pCube1"));
			

			int count1 =0;
			int count2 =0;
			int count3 =0;
			int count4 =0;
			int count5 =0;
			int count6 =0;
			int currow;
			int[] recent2 = new int[2];
			int rcount = 0;
			int colcheck;



			for(int i = 0; i < numBlocks; i++){
				//if(i == 0){



				if(blocks[i]<=6){
				//transform.position = Vector3(0, 1, 0);
				
				//}
				//Debug.Log("i " + blocks[i]);
				currow = colcount%5;
				if(currow != colcount){
					recent2[rcount] = col[currow];
					rcount++;
				}
				if((currow+5) != colcount){
					recent2[rcount] = col[currow+5];
					rcount++;
				}
				if((currow+10) != colcount){
					recent2[rcount] = col[currow+10];
					rcount++;
				}
				rcount = 0;



				if(recent2[0] == recent2[1]){

					colcheck = recent2[0];
				}
				else{
					colcheck = 7;
				}


				Rigidbody rb = GetComponent<Rigidbody>();
				
				//GameObject newC = GameObject.CreatePrimitive(PrimitiveType.Cube);
				//newC.AddComponent<Rigidbody>(gameObject.rigidbody);
				
				GameObject newC = (GameObject)Instantiate(Resources.Load("cube"));

				newC.tag = "Box";


				//GameObject newC = GameObject.CreatePrimitive(PrimitiveType.Cube);
				
				//newC.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);

				if(i == 0){
					newC.name = "newCube";
					newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
				}
				else if(i == 1){
					newC.name = "newCube";
					newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
				}
				else if(i == 2){
					newC.name = "newCube";
					newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
				}
				else if(i == 3){
					newC.name = "newCube";
					newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
				}
				else{
					newC.name = "newCube";
					newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
				}

				//newC.AddComponent<Rigidbody>();






				if(blocks[i] == 1){
					//Debug.Log("i " + blocks[i]);
					
					if((count1 < 2)&&(colcheck != 0)){
						newC.renderer.material = materials[0];
						col[colcount] = 0;

						count1++;
					}
					else if((count2 < 2)&&(colcheck != 1)){
						newC.renderer.material = materials[1];
						col[colcount] = 1;
						
						count2++;
					}
					else if((count3 < 2)&&(colcheck != 2)){
						newC.renderer.material = materials[2];
						col[colcount] = 2;
						
						count3++;
					}
					else if((count4 < 2)&&(colcheck != 3)){
						newC.renderer.material = materials[3];
						col[colcount] = 3;
						
						count4++;
					}
					else if((count5 < 2)&&(colcheck != 4)){
						newC.renderer.material = materials[4];
						col[colcount] = 4;
						
						count5++;
					}
					else if((count6 < 2)&&(colcheck != 5)){
						newC.renderer.material = materials[5];
						col[colcount] = 5;
						
						count6++;

					}

					//clone = Instantiate (go1) as Rigidbody;
					
				}
				else if(blocks[i] == 2){
					//clone = Instantiate (go2) as Rigidbody;
					if((count2 < 2)&&(colcheck != 1)){
						newC.renderer.material = materials[1];
						col[colcount] = 1;
						
						count2++;
					}
					else if((count3 < 2)&&(colcheck != 2)){
						newC.renderer.material = materials[2];
						col[colcount] = 2;

						count3++;
					}
					else if((count4 < 2)&&(colcheck != 3)){
						newC.renderer.material = materials[3];
						col[colcount] = 3;

						count4++;
					}
					else if((count5 < 2)&&(colcheck != 4)){
						newC.renderer.material = materials[4];
						col[colcount] = 4;

						count5++;
					}
					else if((count6 < 2)&&(colcheck != 5)){
						newC.renderer.material = materials[5];
						col[colcount] = 5;

						count6++;
						
					}
					else if((count1 < 2)&&(colcheck != 0)){
						newC.renderer.material = materials[0];
						col[colcount] = 0;
						
						count1++;
					}

				}
				
				else if(blocks[i] == 3)
				{
					//clone = Instantiate (go3) as Rigidbody;
					if((count3 < 2)&&(colcheck != 2)){
						newC.renderer.material = materials[2];
						col[colcount] = 2;
						
						count3++;
					}
					else if((count4 < 2)&&(colcheck != 3)){
						newC.renderer.material = materials[3];
						col[colcount] = 3;
						
						count4++;
					}
					else if((count5 < 2)&&(colcheck != 4)){
						newC.renderer.material = materials[4];
						col[colcount] = 4;
						
						count5++;
					}
					else if((count6 < 2)&&(colcheck != 5)){
						newC.renderer.material = materials[5];
						col[colcount] = 5;
						
						count6++;
						
					}
					else if((count1 < 2)&&(colcheck != 0)){
						newC.renderer.material = materials[0];
						col[colcount] = 0;
						
						count1++;
					}
					else if((count2 < 2)&&(colcheck != 1)){
						newC.renderer.material = materials[1];
						col[colcount] = 1;
						
						count2++;
					}


				}
				else if(blocks[i] == 4)
				{
					//clone = Instantiate (go4) as Rigidbody;
					if((count4 < 2)&&(colcheck != 3)){
						newC.renderer.material = materials[3];
						col[colcount] = 3;
						
						count4++;
					}
					else if((count5 < 2)&&(colcheck != 4)){
						newC.renderer.material = materials[4];
						col[colcount] = 4;
						
						count5++;
					}
					else if((count6 < 2)&&(colcheck != 5)){
						newC.renderer.material = materials[5];
						col[colcount] = 5;
						
						count6++;
						
					}
					else if((count1 < 2)&&(colcheck != 0)){
						newC.renderer.material = materials[0];
						col[colcount] = 0;
						
						count1++;
					}
					else if((count2 < 2)&&(colcheck != 1)){
						newC.renderer.material = materials[1];
						col[colcount] = 1;
						
						count2++;
					}
					else if((count3 < 2)&&(colcheck != 2)){
						newC.renderer.material = materials[2];
						col[colcount] = 2;
						
						count3++;
					}

					
				}
				else if(blocks[i] == 5){
					//clone = Instantiate (go5) as Rigidbody;
					if((count5 < 2)&&(colcheck != 4)){
						newC.renderer.material = materials[4];
						col[colcount] = 4;
						
						count5++;
					}
					else if((count6 < 2)&&(colcheck != 5)){
						newC.renderer.material = materials[5];
						col[colcount] = 5;
						
						count6++;
						
					}
					else if((count1 < 2)&&(colcheck != 0)){
						newC.renderer.material = materials[0];
						col[colcount] = 0;
						
						count1++;
					}
					else if((count2 < 2)&&(colcheck != 1)){
						newC.renderer.material = materials[1];
						col[colcount] = 1;
						
						count2++;
					}
					else if((count3 < 2)&&(colcheck != 2)){
						newC.renderer.material = materials[2];
						col[colcount] = 2;
						
						count3++;
					}
					else if((count4 < 2)&&(colcheck != 3)){
						newC.renderer.material = materials[3];
						col[colcount] = 3;
						
						count4++;
					}

				}
				else{
					if((count6 < 2)&&(colcheck != 5)){
						newC.renderer.material = materials[5];
						col[colcount] = 5;
						
						count6++;
						
					}
					else if((count1 < 2)&&(colcheck != 0)){
						newC.renderer.material = materials[0];
						col[colcount] = 0;
						
						count1++;
					}
					else if((count2 < 2)&&(colcheck != 1)){
						newC.renderer.material = materials[1];
						col[colcount] = 1;
						
						count2++;
					}
					else if((count3 < 2)&&(colcheck != 2)){
						newC.renderer.material = materials[2];
						col[colcount] = 2;
						
						count3++;
					}
					else if((count4 < 2)&&(colcheck != 3)){
						newC.renderer.material = materials[3];
						col[colcount] = 3;
						
						count4++;
					}
					else if((count5 < 2)&&(colcheck != 4)){
						newC.renderer.material = materials[4];
						col[colcount] = 4;
						
						count5++;
					}

				}
				

				//newC.AddComponent("moveBoxScript");
				//GameObject.Find("pCube5").renderer.material = block5;
				}
				else{
					col[colcount] = 7;

				}
				colcount++;
				if(colcount == 15){
					colcount = 0;
				}
				
			}

			//counter-=0.75f;


						//newCube = Instantiate (GameObject.Find ("pCube1"), transform.position + transform.up, transform.transform.rotation) as GameObject;
			//GameObject newC = new GameObject("newCube1");








				}



	}
}
