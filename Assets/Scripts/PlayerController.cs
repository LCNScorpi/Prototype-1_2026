using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private variables
    private float speed = 20.0f;
    private float turnSpeed = 75.0f;                                                             
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //We get here our player input
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");  

        //We move the vehicle forward
        transform.Translate(Vector3.forward*Time.deltaTime * speed * forwardInput);

        //We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
