using UnityEngine;
using System.Collections;

public class BallCollidePink : MonoBehaviour {
	public int scoreadd;
	public Animator other;
	public GameObject bound;
	public GameObject green;
	public GameObject blue;
	public GameObject orange;
	

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Pink" )
		
		ScoreChanger.score += scoreadd;
		if (col.gameObject.tag == "Pink" )
		
		FinalScore.score2 += scoreadd;
		else
		{
			other.GetComponent<Animator>().SetTrigger("GameOver");
			bound.GetComponent<Spawner>().enabled = false;
			green.GetComponent<Collider2D>().enabled = false;
			blue.GetComponent<Collider2D>().enabled = false;
			orange.GetComponent<Collider2D>().enabled = false;
			Spawner.ballsspawned = 0;


			
		}

	}
}
