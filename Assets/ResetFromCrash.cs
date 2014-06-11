using UnityEngine;
using System.Collections;

public class ResetFromCrash : MonoBehaviour {

	void OnCollisionEnter(Collision theCollision){
		CarDriver otherObjectsScript = theCollision.gameObject.GetComponent<CarDriver> ();
	
	if(otherObjectsScript != null)
		otherObjectsScript.Respawn();
	}
}
