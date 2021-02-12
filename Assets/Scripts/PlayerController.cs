using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //adjusted numbers based on how the speed ran on my computer
    //I am unsure if it will run faster on others but it ran perfectly for myself.
    private float speed = 20.0f;
    private float turnSpeed = 50.0f;

    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Debug.Log(Time.deltaTime);

        //to advance vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //to turn vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
