using UnityEngine;
using System.Collections;

public class NewResetPoint : MonoBehaviour {

	void OnTriggerEnter(Collider theCollider) {
		CarDriver theCarDriver = theCollider.gameObject.transform.parent.gameObject.GetComponent<CarDriver> ();

		if(theCarDriver != null) {
			theCarDriver.RespawnPosition.position = this.transform.position;
		}
	}
}
