using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public Vector3 translation;
    public float speed;
    private void FixedUpdate()
    {
        Vector3 newPosition = player.position + translation;
        Vector3 targetPosition = Vector3.Lerp(transform.position, newPosition, Time.fixedDeltaTime * speed);
        transform.position = targetPosition;
    }
}
