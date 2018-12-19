using UnityEngine;
using System.Collections;

public class BallCollideGreen : MonoBehaviour {
	public int scoreadd;
	public Animator other;
	public GameObject pink;
	public GameObject bound;
	public GameObject blue;
	public GameObject orange;
	

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Green" ) 
		ScoreChanger.score += scoreadd;
		
		if (col.gameObject.tag == "Green" )
		
		FinalScore.score2 += scoreadd;
		else
		{
			other.GetComponent<Animator>().SetTrigger("GameOver");
			bound.GetComponent<Spawner>().enabled = false;
			gameObject.GetComponent<Collider2D>().enabled = false;
			pink.GetComponent<Collider2D>().enabled = false;
			blue.GetComponent<Collider2D>().enabled = false;
			orange.GetComponent<Collider2D>().enabled = false;
			Spawner.ballsspawned = 0;

	}

}
}
