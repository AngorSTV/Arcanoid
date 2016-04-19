using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {
    public GameObject ball;
    public GameController gc;
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        if (other.gameObject == ball) gc.Start();
    }
}
