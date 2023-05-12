using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 moveDir;

    [SerializeField]
    private float movePower;
    [SerializeField]
    private float jumpPower;
    [SerializeField]
    private float rotateSpeed;

    public void Awake()
    {
        //rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        //Move();
        //Rotate();
        LookAt();
    }
    public void Move()
    {
        //rb.AddForce(moveDir * movePower, ForceMode.Force);
        //transform.position += moveDir  * Time.deltaTime;
        // x : 1 -> x : 1/s
        // 위치를 프레임마다 더해주는 방식에서
        // 시간을 곱해줌으로써 음 자연스럽게 움직임
        //transform.Translate(moveDir * movePower * Time.deltaTime);
        //보고 있는 방향

        transform.Translate(moveDir * movePower * Time.deltaTime, Space.World);
        //월드방향

        
    }
    public void Rotate()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }

    public void LookAt()
    {
        transform.LookAt(new Vector3(0, 0, 0));
    }
    
	
    private void Rotation()
    {
        transform.rotation = Quaternion.identity;
        transform.rotation = Quaternion.Euler(0, 90, 0);
        
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
    public void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
        Debug.Log(moveDir);
    }
    public void OnJump(InputValue value)
    {
        Jump();
    }
}
