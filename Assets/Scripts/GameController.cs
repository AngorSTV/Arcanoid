using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject brick;
    public GameObject ball;

    public int score;
    private Rigidbody rbBita;

    // Use this for initialization
    public void Start () {
        Screen.SetResolution(600, 900, false, 60);
        GameObject[] bits = GameObject.FindGameObjectsWithTag("Player");
        GameObject bita = bits[0];
        rbBita = bita.GetComponent<Rigidbody>();
        GameObject[] bricks = GameObject.FindGameObjectsWithTag("Brick");
        for(int i=0; i < bricks.Length; i++)
        {
            Destroy (bricks[i]);
        }

        fillTheFild();
        setBall();
    }

    void Update()
    {
        //вывод состояния счёта и колва бит
    }
	
    void fillTheFild ()
    {
        for (int i=-3; i<4; i++)
        {
            for (int k=5; k<10; k++)
            {
                Instantiate(brick, new Vector3 (i*2.6f,k*1.35f,0.0f), Quaternion.identity);
            }
        }
    }

    void setBall()
    {
        
        Instantiate(ball, new Vector3(rbBita.position.x,-11.98f,0), Quaternion.identity);
        
    }
}
