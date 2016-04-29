using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {
  
    private Rigidbody rb;
    private int score;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        float speed = Random.Range(3, 4);
        float direct = Random.Range(-2, 2);
        rb.AddForce(new Vector3(direct,speed,0), ForceMode.VelocityChange);
        GameObject[] gcs = GameObject.FindGameObjectsWithTag("GameController");
        GameObject gc = gcs[0];
        score = gc.GetComponent<GameController>().score;
    }

    void FixedUpdate()
    {
        rb.position = new Vector3(rb.position.x, rb.position.y, 0.0f);
        if (rb.velocity == Vector3.zero)
        {
            Start();
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Brick")
        {
            col.gameObject.GetComponent<BrickScript>().Hit(rb.velocity.x, rb.velocity.y);
            score++;
            rb.velocity = rb.velocity * 1.05f;

        }
        if (col.gameObject.tag == "Border")
        {
            //доварачиваем угол отражения в сторону движения мяча
            if (rb.velocity.y > 0)
            {
                rb.AddForce(new Vector3(0, 1, 0), ForceMode.VelocityChange);
            }
            else
            {
                rb.AddForce(new Vector3(0, -1, 0), ForceMode.VelocityChange);
            }
        }
    }
}
