using UnityEngine;
using System.Collections;

public class DestroyBall : MonoBehaviour {

	// Update is called once per frame
	
		void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Zone" )
		Destroy(gameObject);



	}
	
	}

