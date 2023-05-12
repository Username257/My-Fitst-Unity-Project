using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallMove : MonoBehaviour
{
    public Rigidbody rb;
    public float moveForce;
    public float jumpForce;
    public Vector3 moveDir;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        Move();
        
    }
    public void Move()
    {
        rb.AddForce(moveDir * moveForce);
    }
    public void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
        
    }
    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    public void OnJump(InputValue value)
    {
        Jump();
    }
}
