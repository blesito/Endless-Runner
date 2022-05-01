using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform groundCheckTransform;
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;
    public float movementSpeed = 10f;
    public SpawnManager spawnManager;
   

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check  if space key is pressed down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }
        horizontalInput =  Input.GetAxis("Horizontal");

        //Constant Movement
        float horizontalMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
        float verticalMovement = movementSpeed;
        transform.Translate(new Vector3(horizontalMovement, 0f, verticalMovement) * Time.deltaTime);    
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }

     private void FixedUpdate()
    {
        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f).Length == 1)
        {
            return;
        }
        if (jumpKeyWasPressed)
        {
             rigidbodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
        
        rigidbodyComponent.velocity = new Vector3(horizontalInput,  rigidbodyComponent.velocity.y, 0);
    }    

    
}
