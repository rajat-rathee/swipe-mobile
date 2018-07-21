using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class slider2 : MonoBehaviour {
	public GameObject[] sprites;

private Vector2 fp; // first finger position
    private Vector2 lp; // last finger position
    private float angle;
    private float swipeDistanceX; 
    private float swipeDistanceY;
    List<GameObject> zones;

    void Start()
{
	GameObject BlueZone = GameObject.Find("Blue Zone");
	GameObject GreenZone = GameObject.Find("Green Zone");
	GameObject OrangeZone = GameObject.Find("Orange Zone");
	GameObject PinkZone = GameObject.Find("Pink Zone");
	zones = new List<GameObject>();
	zones.Add(BlueZone);
	zones.Add(GreenZone);
	zones.Add(OrangeZone);
	zones.Add(PinkZone);
	
}	


void Update () {
 
foreach(Touch touch in Input.touches) //codeforswipe
{
  if (touch.phase == TouchPhase.Began)
{
  fp = touch.position;
  lp = touch.position;
}
if (touch.phase == TouchPhase.Moved )
{
  lp = touch.position;
  swipeDistanceX = Mathf.Abs((lp.x-fp.x));
  swipeDistanceY = Mathf.Abs((lp.y-fp.y));
}
if(touch.phase == TouchPhase.Ended)
{
  angle = Mathf.Atan2((lp.x-fp.x),(lp.y-fp.y))*57.2957795f;
 
  if(angle > 60 && angle < 120 && swipeDistanceX > 40 ) //whenthereisaswiperight
  {
    
    Vector3 tempPosition = zones[0].transform.position;
    for (int i=0;i<zones.Count; i++){
    if(i == (zones.Count-1)){zones[i].transform.position = tempPosition;}
    else {zones[i].transform.position = zones[(i+1)%zones.Count].transform.position;}
  }
}
 
if(angle < -60 && angle > -120 && swipeDistanceX > 40) //whenthereisaswipeleft
{
  
  Vector3 tempPosition = zones[(zones.Count-1)].transform.position;
  for (int i=(zones.Count-1);i>=0; i--){
    
    if(i == (0)){zones[i].transform.position = tempPosition;}
    else {zones[i].transform.position = zones[(i+(zones.Count-1))%zones.Count].transform.position;}
  }
}
}
 
}
}
}