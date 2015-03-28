using UnityEngine;
using System.Collections;

public class ColliderTest : MonoBehaviour
{

	void OnTriggerExit()
	{
		Debug.Log ("Collided!!");
		Destroy	(GameObject.FindGameObjectWithTag("Box"));
	}
		
	/*void OnCollisionStay(Collision collisionInfo)
	{
		Debug.Log(gameObject.name + " and " + collisionInfo.collider.name + " are still colliding");
	}
		
	void OnCollisionExit(Collision collisionInfo)
	{
		Debug.Log(gameObject.name + " and " + collisionInfo.collider.name + " are no longer colliding");
	}*/

}