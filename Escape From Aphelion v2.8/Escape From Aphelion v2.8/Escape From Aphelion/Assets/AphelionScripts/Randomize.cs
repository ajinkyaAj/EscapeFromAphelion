using UnityEngine;
using System.Collections;

public class Randomize : MonoBehaviour {

	public GameObject newCube;

	public Material[] materials = new Material[6];

	public static Material[] materials1 = new Material[6];

	//public float counter = 0;

	public int[] col = new int[15];
	
	public static int[] shipPartFound = new int[19];

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

		for(int i = 0; i < 19; i++){
			string theName = "shipPart" + (i+1);
			shipPartFound[i] = PlayerPrefs.GetInt(theName);

			//Debug.Log (shipPartFound[i]);
		}
		if (shipPartFound [0] == 1) {

			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart1"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece1";
			newC.transform.position = GameObject.Find("polySurface31").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));
			GameObject.Find("polySurface31").GetComponent<MeshRenderer>().enabled = true;

		}
		if (shipPartFound [1] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart2"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece2";
			newC.transform.position = GameObject.Find("polySurface32").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));
			GameObject.Find("polySurface32").GetComponent<MeshRenderer>().enabled = true;
			
		}
		if (shipPartFound [2] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart3"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece3";
			newC.transform.position = GameObject.Find("polySurface33").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));
			GameObject.Find("polySurface33").GetComponent<MeshRenderer>().enabled = true;
			
		}
		if (shipPartFound [3] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart4"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece4";
			newC.transform.position = GameObject.Find("polySurface34").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));
			GameObject.Find("polySurface34").GetComponent<MeshRenderer>().enabled = true;
			
		}
		if (shipPartFound [4] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart5"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece5";
			newC.transform.position = GameObject.Find("polySurface35").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));
			GameObject.Find("polySurface35").GetComponent<MeshRenderer>().enabled = true;
		}
		if (shipPartFound [5] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart6"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece6";
			newC.transform.position = GameObject.Find("polySurface36").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));
			GameObject.Find("polySurface36").GetComponent<MeshRenderer>().enabled = true;
			
		}
		if (shipPartFound [6] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart7"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece7";
			newC.transform.position = GameObject.Find("polySurface37").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));
			GameObject.Find("polySurface37").GetComponent<MeshRenderer>().enabled = true;
			
		}
		if (shipPartFound [7] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart8"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece8";
			newC.transform.position = GameObject.Find("polySurface38").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));
			GameObject.Find("polySurface38").GetComponent<MeshRenderer>().enabled = true;

		}
		if (shipPartFound [8] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart9"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece9";
			newC.transform.position = GameObject.Find("polySurface39").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));
			GameObject.Find("polySurface39").GetComponent<MeshRenderer>().enabled = true;
	
		}
		if (shipPartFound [9] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart10"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece10";
			newC.transform.position = GameObject.Find("polySurface40").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));			
			GameObject.Find("polySurface40").GetComponent<MeshRenderer>().enabled = true;
			
		}
		if (shipPartFound [10] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart11"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece11";
			newC.transform.position = GameObject.Find("polySurface41").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));
			GameObject.Find("polySurface41").GetComponent<MeshRenderer>().enabled = true;
			
		}
		if (shipPartFound [11] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart12"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece12";
			newC.transform.position = GameObject.Find("polySurface42").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));	
			GameObject.Find("polySurface42").GetComponent<MeshRenderer>().enabled = true;
			
		}
		if (shipPartFound [12] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart13"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece13";
			newC.transform.position = GameObject.Find("polySurface43").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));
			GameObject.Find("polySurface43").GetComponent<MeshRenderer>().enabled = true;

		}
		if (shipPartFound [13] == 1) {
			
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart14"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece14";
			newC.transform.position = GameObject.Find("polySurface44").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));		
			GameObject.Find("polySurface44").GetComponent<MeshRenderer>().enabled = true;
		}
		if (shipPartFound [14] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart15"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece15";
			newC.transform.position = GameObject.Find("polySurface45").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));			
			GameObject.Find("polySurface45").GetComponent<MeshRenderer>().enabled = true;
			
		}
		if (shipPartFound [15] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart16"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece16";
			newC.transform.position = GameObject.Find("polySurface46").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));		
			GameObject.Find("polySurface46").GetComponent<MeshRenderer>().enabled = true;
			
		}
		if (shipPartFound [16] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart17"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece17";
			newC.transform.position = GameObject.Find("polySurface47").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));
			GameObject.Find("polySurface47").GetComponent<MeshRenderer>().enabled = true;
			
		}
		if (shipPartFound [17] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart18"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece18";
			newC.transform.position = GameObject.Find("polySurface48").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));	
			GameObject.Find("polySurface48").GetComponent<MeshRenderer>().enabled = true;
			
		}
		if (shipPartFound [18] == 1) {
			GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart19"));
			newC.transform.localScale = new Vector3(20,20,20);
			newC.name = "shipPiece19";
			newC.transform.position = GameObject.Find("polySurface49").transform.position;
			Destroy (newC.GetComponent("moveBoxScript"));
			GameObject.Find("polySurface49").GetComponent<MeshRenderer>().enabled = true;			
			
		}

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
					int partNum = Random.Range (1,400);
					if((partNum == 25)&&(shipPartFound [0] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart1"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);

						if(i == 0){
							newC.name = "shipPart1";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart1";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart1";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart1";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart1";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 26)&&(shipPartFound [1] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart2"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);
					
						if(i == 0){
							newC.name = "shipPart2";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart2";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart2";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart2";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart2";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 27)&&(shipPartFound [2] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart3"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);

						if(i == 0){
							newC.name = "shipPart3";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart3";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart3";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart3";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart3";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 28)&&(shipPartFound [3] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart4"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);
					
						if(i == 0){
							newC.name = "shipPart4";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart4";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart4";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart4";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart4";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 29)&&(shipPartFound [4] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart5"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);
					
						if(i == 0){
							newC.name = "shipPart5";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart5";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart5";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart5";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart5";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 30)&&(shipPartFound [5] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart6"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);
					
						if(i == 0){
							newC.name = "shipPart6";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart6";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart6";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart6";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart6";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 31)&&(shipPartFound [6] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart7"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);

						if(i == 0){
							newC.name = "shipPart7";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart7";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart7";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart7";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart7";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 32)&&(shipPartFound [7] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart8"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);
					
						if(i == 0){
							newC.name = "shipPart8";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart8";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart8";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart8";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart8";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 33)&&(shipPartFound [8] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart9"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);
					
						if(i == 0){
							newC.name = "shipPart9";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart9";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart9";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart9";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart9";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}else if((partNum == 34)&&(shipPartFound [9] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart10"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);
				
						if(i == 0){
							newC.name = "shipPart10";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart10";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart10";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart10";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart10";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 35)&&(shipPartFound [10] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart11"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);

						if(i == 0){
							newC.name = "shipPart11";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart11";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart11";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart11";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart11";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 36)&&(shipPartFound [11] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart12"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);

						if(i == 0){
							newC.name = "shipPart12";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart12";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart12";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart12";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart12";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 37)&&(shipPartFound [12] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart13"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);

						if(i == 0){
							newC.name = "shipPart13";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart13";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart13";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart13";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart13";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 38)&&(shipPartFound [13] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart14"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);

						if(i == 0){
							newC.name = "shipPart14";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart14";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart14";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart14";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart14";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 39)&&(shipPartFound [14] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart15"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);

						if(i == 0){
							newC.name = "shipPart15";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart15";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart15";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart15";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart15";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 40)&&(shipPartFound [15] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart16"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);

						if(i == 0){
							newC.name = "shipPart16";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart16";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart16";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart16";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart16";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 41)&&(shipPartFound [16] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart17"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);
					
						if(i == 0){
							newC.name = "shipPart17";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart17";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart17";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart17";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart17";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 42)&&(shipPartFound [17] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart18"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);
					
						if(i == 0){
							newC.name = "shipPart18";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart18";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart18";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart18";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart18";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 43)&&(shipPartFound [18] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart19"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);

						if(i == 0){
							newC.name = "shipPart19";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart19";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart19";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart19";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart19";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}

					/*
					else if((partNum == 44)&&(shipPartFound [19] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart20"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);
					
						if(i == 0){
							newC.name = "shipPart20";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart20";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart20";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart20";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart20";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 45)&&(shipPartFound [20] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart21"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);
					
						if(i == 0){
							newC.name = "shipPart21";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart21";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart21";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart21";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart21";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 46)&&(shipPartFound [21] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart22"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);

						if(i == 0){
							newC.name = "shipPart22";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart22";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart22";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart22";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart22";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 47)&&(shipPartFound [22] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart23"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);
					
						if(i == 0){
							newC.name = "shipPart23";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart23";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart23";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart23";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart23";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 48)&&(shipPartFound [23] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart24"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);

						if(i == 0){
							newC.name = "shipPart24";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart24";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart24";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart24";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart24";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					else if((partNum == 49)&&(shipPartFound [24] == 0)){
						GameObject newC = (GameObject)Instantiate(Resources.Load("shipPart25"));
						newC.tag = "Box";
						newC.transform.localScale = new Vector3(20,20,20);
					
						if(i == 0){
							newC.name = "shipPart25";
							newC.transform.position = new Vector3(-1.53f, 0.65f, 1.51f);
						}
						else if(i == 1){
							newC.name = "shipPart25";
							newC.transform.position = new Vector3(-0.72f, 0.65f, 1.51f);
						}
						else if(i == 2){
							newC.name = "shipPart25";
							newC.transform.position = new Vector3(0.08f, 0.65f, 1.51f);
						}
						else if(i == 3){
							newC.name = "shipPart25";
							newC.transform.position = new Vector3(0.89f, 0.65f, 1.51f);
						}
						else{
							newC.name = "shipPart25";
							newC.transform.position = new Vector3(1.69f, 0.65f, 1.51f);
						}
					}
					*/


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
