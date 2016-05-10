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
    private GameObject score;
    private int screenWidth;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        carrentY = rb.position.y;

        GameObject[] gos = GameObject.FindGameObjectsWithTag("Score");
        score = gos[0];
        /*Component[] allComponents;
        allComponents = score.GetComponents<Component>();
        foreach (Component component in allComponents)
        {
            //Debug.Log(component.GetType());
        }*/
        screenWidth = Screen.currentResolution.width;
        Debug.Log(Screen.currentResolution.width);

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        //для мобильных устройств
        Touch[] touches = Input.touches;
        foreach (Touch touch in touches)
        {
            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {
                //score.GetComponent<UnityEngine.UI.Text>().text = "x=" + touch.rawPosition.x.ToString() + " y=" + touch.position.y.ToString();
                if (touch.position.x > screenWidth / 2)
                    moveHorizontal = 1;
                if (touch.position.x < screenWidth / 2)
                    moveHorizontal = -1;
            }
        }

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        
        //score.GetComponent<UnityEngine.UI.Text>().text = moveHorizontal.ToString();
        rb.velocity = movement * speed;
        rb.position = new Vector3(Mathf.Clamp(rb.position.x, xMin, xMax), carrentY, 0.0f);
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }
}
