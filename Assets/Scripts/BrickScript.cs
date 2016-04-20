using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

    public bool hit = false;

    const int MOVE_SPAN = 5;
    const float SPEED = 2f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (hit)
        {
            transform.position = new Vector3(Mathf.PingPong(Time.time, SPEED) * MOVE_SPAN, transform.position.y, 0);
        }
	
	}
}
