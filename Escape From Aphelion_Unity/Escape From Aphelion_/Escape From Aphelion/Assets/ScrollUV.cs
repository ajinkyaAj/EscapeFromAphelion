using UnityEngine;
using System.Collections;

public class ScrollUV : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update (){
			MeshRenderer mr = GetComponent<MeshRenderer>();
			Material mat = mr.material;
			Vector2 offset = mat.mainTextureOffset;
			offset.x += Time.deltaTime / 10.0f;
			offset.y += Time.deltaTime / 10.0f;
			mat.mainTextureOffset = offset;
		}
}

