using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject brick;
    public GameObject ball;
    private Rigidbody rbBall;

    // Use this for initialization
    public void Start () {
        //rbBall = ball.GetComponent<Rigidbody>;
        Screen.SetResolution(600, 900, false, 60);
        fillTheFild();
        setBall();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void fillTheFild ()
    {
        for (int i=-4; i<5; i++)
        {
            for (int k=1; k<10; k++)
            {
                Instantiate(brick, new Vector3 (i*2.1f,k*1.1f,0.0f), Quaternion.identity);
            }
        }
    }

    void setBall()
    {
        Instantiate(ball, new Vector3(0,-11.98f,0), Quaternion.identity);
        
    }
}
