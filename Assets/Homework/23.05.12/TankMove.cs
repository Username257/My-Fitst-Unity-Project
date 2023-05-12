using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class TankMove : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 moveDir;
    public float movePower;
    public float rotateSpeed;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        Move();
        
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up * -rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
    

    public void Move()
    {
        transform.Translate(moveDir * movePower * Time.deltaTime);
    }
    public void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }
}
