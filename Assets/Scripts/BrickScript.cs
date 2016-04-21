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
    public void Hit()
    {
        bc.isTrigger = true;

        rb.isKinematic = false;
        rb.useGravity = true;
        rb.angularVelocity = Random.insideUnitSphere * tumble;




    }
}
