using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody player;
    public float speed;
    public float jumpForce;
    public Transform groundCheck;
    public float groundCheckDistance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        bool grounded = Physics.Raycast(groundCheck.position, Vector3.down, groundCheckDistance);

        bool jumping = Input.GetButtonDown("Jump");

        Vector3 move = transform.right * x +transform.forward * z;

        if (jumping && grounded)
        {
            player.AddForce(transform.up * jumpForce, ForceMode.Impulse);

        }

        player.position += move * speed * Time.deltaTime;
    }
}
