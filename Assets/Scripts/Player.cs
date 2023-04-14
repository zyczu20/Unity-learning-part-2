using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10f;
    void Start()
    {

    }

    private void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        //transform.Translate(new Vector3(horizontalMovement, 0, verticalMovement));
        rb.AddForce(new Vector3(horizontalMovement, 0, verticalMovement) * speed);
    }
}
