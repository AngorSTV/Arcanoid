using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {
    public GameObject ball;
    public GameController gc;
    void OnTriggerExit(Collider other)
    {
        
        if (other.tag == "Ball") gc.Start();
        Destroy(other.gameObject);
        
    }
}
