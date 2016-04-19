using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public GameController gc;
    private Rigidbody rb;
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
    }

    }
