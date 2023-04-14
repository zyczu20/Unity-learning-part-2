using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce = 100f;
    public float speed = 10f;
    public bool canJump = true;
    void Start()
    {

    }
    private void Update()
    {
        bool jump = Input.GetKeyDown(KeyCode.Space);
        if (jump && canJump)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0));
            canJump = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        canJump = true;
    }

    private void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        //transform.Translate(new Vector3(horizontalMovement, 0, verticalMovement));
        rb.AddForce(new Vector3(horizontalMovement, 0, verticalMovement) * speed);
    }
}
