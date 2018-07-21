using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawner2 : MonoBehaviour {
	 public GameObject[] sprites;
public float spawnFrequency = 1;

public Transform SpawnPoint2;
List<GameObject> balls;
float spawnTimer = 0;
void Start()
{
  balls = new List<GameObject>();
}
void Update()
{
     spawnTimer += Time.deltaTime;
     if (spawnTimer >= spawnFrequency)
     {
           SpawnSprite();
           spawnTimer = 0;
     }
}
void SpawnSprite()
{
      int random = Random.Range (0, 4);
     GameObject s = Instantiate (sprites[random], SpawnPoint2.position, SpawnPoint2.rotation) as GameObject;

}
}