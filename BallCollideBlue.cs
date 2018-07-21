using UnityEngine;
using System.Collections;

public class BallCollideBlue : MonoBehaviour {
	public int scoreadd;
	public Animator other;
	public GameObject bound;
	public GameObject green;
	public GameObject pink;
	public GameObject orange;
	

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Blue" )
		ScoreChanger.score += scoreadd;
		if (col.gameObject.tag == "Blue" )
		FinalScore.score2 += scoreadd;
		else
		{
			other.GetComponent<Animator>().SetTrigger("GameOver");
			bound.GetComponent<Spawner>().enabled = false;
			pink.GetComponent<Collider2D>().enabled = false;
			green.GetComponent<Collider2D>().enabled = false;
			orange.GetComponent<Collider2D>().enabled = false;
			Spawner.ballsspawned = 0;

		}

	}
}
