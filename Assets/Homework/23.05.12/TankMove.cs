using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class TankMove : MonoBehaviour
{
    public Rigidbody rb;

    public float movePower;
    public float rotateSpeed;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private float repeatTime = 1f;

    public AudioSource audio;
    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        /*
         * 위 아래로 움직이고 좌우방향키로 회전하는 걸 구현하고 싶었습니다.
         */
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(0, 0, 1 * Time.deltaTime * movePower);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(0, 0, -1 * Time.deltaTime * movePower);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up * -rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
    
    public void OnFire(InputValue value)
    {
        
    }

    private Coroutine bulletRoutine;
    IEnumerator BulletMakeRoutine()
    {
        while(true)
        {
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
            audio.Play();
            yield return new WaitForSeconds(repeatTime);
        }
    }

    private void OnRepeatFire(InputValue value)
    {
        if (value.isPressed)
        {
            bulletRoutine = StartCoroutine(BulletMakeRoutine());
        }
        else
        {
            StopCoroutine(bulletRoutine);
        }
    }
}
