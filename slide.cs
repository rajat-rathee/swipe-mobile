using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class slide : MonoBehaviour {
	public GameObject[] sprites;

private Vector2 fp; // first finger position
    private Vector2 lp; // last finger position
    private float angle;
    private float swipeDistanceX; 
    private float swipeDistanceY;
    List<GameObject> zones;

    void Start()
{
	GameObject BlueZone = GameObject.Find("BlueZone");
	GameObject GreenZone = GameObject.Find("GreenZone");
	GameObject OrangeZone = GameObject.Find("OrangeZone");
	GameObject PinkZone = GameObject.Find("PinkZone");
	zones = new List<GameObject>();
	zones.Add(BlueZone);
	zones.Add(GreenZone);
	zones.Add(OrangeZone);
	zones.Add(PinkZone);
	Debug.Log(zones.Count);
}	

    
    void Update () {
        foreach(Touch touch in Input.touches)
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
                
                if(angle > 60 && angle < 120 && swipeDistanceX > 40    )
                {
                   Debug.Log("right");
                   for (int i=0;i<zones.Count; i++){
                   	zones[i] = zones[(i-1)%zones.Count];
                   	zones[i].transform.position = new Vector2(i, 0);
                    
                }

                if(angle < -60 && angle > -120 && swipeDistanceX > 40)
                {
                    Debug.Log("left");
                    for (int i=0;i<zones.Count; i++){
                    	zones[i] = zones[(i+1)%zones.Count];
                    	zones[i].transform.position = new Vector2(i, 0);

                    
             
                         }
        }
    }
}

	}
}
}