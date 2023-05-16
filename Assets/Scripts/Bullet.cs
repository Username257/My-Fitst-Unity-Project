using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float bulletSpeed = 5f;
    [SerializeField] private GameObject explosion;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.velocity = transform.forward * bulletSpeed;
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    /************************************************************************
	 * Ʈ���� �浹ü
	 * 
	 * �ϳ��� �浹ü�� �浹�� ����Ű�� �ʰ� �ٸ� �浹ü�� ������ ���� ���� ����
	 * Ʈ���Ű� ��ħ��Ȳ�� ���� ��� ����Ƽ Ʈ���� �޽����� �޾� ��Ȳ�� Ȯ��
	 ************************************************************************/

    // <����Ƽ Ʈ���� �޽���>
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }
    // <���̾��� �浹 ����>
    // ���ӿ�����Ʈ�� ���̾ Ȱ���Ͽ� �浹ü���� �浹���� ���θ� ���� ����
    // edit -> ProjectSettings -> Physics ���� ���� ����

    // <�浹ü ����>
    // (1) ���� �浹ü (Static Collider)
    // Rigidbody�� ���� �浹ü, �ܺο� ���� �������� ����
    // ����� �������� �ʴ� ����, ������ҿ� �ַ� ���

    // (2) ������ٵ� �浹ü (Rigidbody Collider)
    // Rigidbody�� �ִ� �浹ü, �ܺο� ���� �޾� ������
    // �浹�� �� ������ ������ ����ϴ� ���� �� ���� ���� ���Ǵ� �浹ü�� ���

    // (3) Ű�׸�ƽ �浹ü (Kinematic Collider)
    // Kinematic Rigidbody�� �ִ� �浹ü, �ܺ��� ���� �������� ����
    // ���������� �ܺ� ��ݿ��� �и��� �ʴ� ��ü(�о�� ��ֹ�, �̴��̹� ��)�� �� ���
    // kinematic ���¸� Ȱ��ȭ/��Ȱ��ȭ �Ͽ� ������ ���θ� ������ ��� ���


    // <�浹ü ��ȣ�ۿ� ��Ʈ����>
    // ���ǻ� �����浹ü(SC), ������ٵ��浹ü(RC), Ű�׸�ƽ�浹ü(KC)�� ǥ��
    // ���ǻ� ����Ʈ����(ST), ������ٵ�Ʈ����(RT), Ű�׸�ƽƮ����(KT)�� ǥ��

    // �浹�� �浹 �޽����� ����
    //		SC	RC	KC
    // SC		 O	
    // RC	 O	 O	 O
    // KC		 O	

    // �浹�� Ʈ���� �޽����� ����
    //		SC	RC	KC	ST	RT	KT
    // SC					 O	 O
    // RC				 O	 O	 O
    // KC				 O	 O	 O
    // ST		 O	 O		 O	 O
    // RT	 O	 O	 O	 O	 O	 O
    // KT	 O	 O	 O	 O	 O	 O
}
