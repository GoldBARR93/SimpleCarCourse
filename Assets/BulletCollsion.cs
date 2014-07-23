using UnityEngine;
using System.Collections;

public class BulletCollsion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter(Collision theCollision){
		if (theCollision.gameObject)
			Destroy (gameObject);
	}
	// Update is called once per frame
	void Update () {
	}
}
