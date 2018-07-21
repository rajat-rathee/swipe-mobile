using UnityEngine;
using System.Collections;

public class BallCollideOrange : MonoBehaviour {
	public int scoreadd;
	
	public Animator other;
	public GameObject bound;
	public GameObject green;
	public GameObject blue;
	public GameObject pink;
	
	

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Orange" )
		ScoreChanger.score += scoreadd;
		if (col.gameObject.tag == "Orange" )
		FinalScore.score2 += scoreadd;
		else
		{
			other.GetComponent<Animator>().SetTrigger("GameOver");
			bound.GetComponent<Spawner>().enabled = false;
			pink.GetComponent<Collider2D>().enabled = false;
			blue.GetComponent<Collider2D>().enabled = false;
			green.GetComponent<Collider2D>().enabled = false;
			Spawner.ballsspawned = 0;
		}
		

	}
}
