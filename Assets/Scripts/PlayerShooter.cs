using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private float repeatTime = 1f;
   
    [SerializeField] private Animator anim;

    public UnityEvent OnFired;
    public UnityEvent OnRepeatFired;
    public void Fire()
    {
        //anim.SetTrigger("IsTerretMove");
        Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        //GetComponent<AudioSource>().Play();

        GameManager.Data.AddShootCount(1);
        OnFired?.Invoke();
    }
    public void OnFire(InputValue value)
    {
        if (!value.isPressed)
        {
            Fire();
        }
    }
    private Coroutine bulletRoutine;
    IEnumerator BulletMakeRoutine()
    {
        while (true)
        {
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
            GameManager.Data.AddShootCount(1);
            anim.SetTrigger("IsTerretMove");
            OnRepeatFired?.Invoke();
            yield return new WaitForSeconds(repeatTime);
        }
    }

    public void OnRepeatFire(InputValue value)
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
