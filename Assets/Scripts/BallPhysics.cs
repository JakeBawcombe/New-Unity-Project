using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    public float thrust = 1.0f; //How far the ball gets yeeted
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Gets Rigidbody from Unity
    }

    void FixedUpdate()
    {
        //rb.AddForce(transform.forward * thrust);
    }
}