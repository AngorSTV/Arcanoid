using UnityEngine;
using System.Collections;

public class BrickScript : MonoBehaviour {
    public float tumble;
    private Rigidbody rb;
    private BoxCollider bc;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        bc = GetComponent<BoxCollider>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Hit( float x, float y)
    {
        bc.isTrigger = true;
        rb.position = new Vector3(rb.position.x, rb.position.y, -1);
        rb.isKinematic = false;
        rb.useGravity = true;
        rb.angularVelocity = Random.insideUnitSphere * tumble;
        rb.AddForce(new Vector3(-x,-y,0), ForceMode.Impulse);




    }
}
