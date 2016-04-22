using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour
{

    // Use this for initialization
    public float speed;
    public float tilt;
    public float xMin;
    public float xMax;
    private Rigidbody rb;
    private float carrentY;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        carrentY = rb.position.y;

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        //для мобильных устройств
        Touch[] touches = Input.touches;
        foreach (Touch touch in touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                if (touch.position.x > 0)
                    moveHorizontal = 1;
                if (touch.position.x < 0)
                    moveHorizontal = -1;
            }
        }

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        rb.velocity = movement * speed;
        rb.position = new Vector3(Mathf.Clamp(rb.position.x, xMin, xMax), carrentY, 0.0f);
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }
}
