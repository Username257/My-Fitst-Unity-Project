using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCollision : MonoBehaviour
{
    /************************************************************************
	 * �浹ü
	 * 
	 * ������ �浹�� ���� ���ӿ�����Ʈ�� ����� ����
	 * ���ӿ�����Ʈ�� ǥ���� �޽ÿ� �Ȱ��� �ʿ�� ����
	 * �浹ü�� �浹��Ȳ�� ���� ��� ����Ƽ �浹 �޽����� �޾� ��Ȳ�� Ȯ��
	 ************************************************************************/

    // <����Ƽ �浹 �޽���>
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }


}
