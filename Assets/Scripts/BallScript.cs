using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {
  
    private Rigidbody rb;
    private int counter;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        float speed = Random.Range(3, 4);
        float direct = Random.Range(-2, 2);
        rb.AddForce(new Vector3(direct,speed,0), ForceMode.VelocityChange);
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
            counter = 0;
            
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
            
            //ускоряемся от удара об стены
            rb.velocity = rb.velocity * 1.02f;
            counter++;
            // при горизонтальном зависании шара между двух стен доворачиваем его к серху
            if (counter > 4)
            {
                counter = 0;
                rb.AddForce(new Vector3(0, 4, 0), ForceMode.VelocityChange);
                rb.velocity = rb.velocity * 0.7f;
            }
        }


    }

    }
