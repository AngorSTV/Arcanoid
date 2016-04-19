using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject brick;
    public GameObject ball;
    private Rigidbody rbBita;

    // Use this for initialization
    public void Start () {
        Screen.SetResolution(600, 900, false, 60);
        GameObject[] bits = GameObject.FindGameObjectsWithTag("Player");
        GameObject bita = bits[0];
        rbBita = bita.GetComponent<Rigidbody>();
        fillTheFild();
        setBall();
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
        
        Instantiate(ball, new Vector3(rbBita.position.x,-11.98f,0), Quaternion.identity);
        
    }
}
