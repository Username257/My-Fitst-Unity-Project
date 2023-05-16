using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityCoroutine : MonoBehaviour
{
    /************************************************************************
	 * �ڷ�ƾ (Coroutine)
	 * 
	 * �۾��� �ټ��� �����ӿ� �л��� �� �ִ� �񵿱��(�Ⱥ��������� �˾Ƽ��ϰ��ִ�) �۾�
	 * �ݺ������� �۾��� �л��Ͽ� �����ϸ�, ������ �Ͻ������ϰ� �ߴ��� �κк��� �ٽý����� �� ����
	 * ��, �ڷ�ƾ�� �����尡 �ƴϸ� �ڷ�ƾ�� �۾��� ������ ���� �����忡�� ����
	 ************************************************************************/

    private Coroutine routine;
    private void Start()
    {
        // <�ڷ�ƾ ����>
        // �ݺ������� �۾��� StartCorouine�� ���� ����
        routine = StartCoroutine(SubRoutine());
    }


	IEnumerator SubRoutine()
	{
		//yield return new WaitForSeconds(3f);
		//Debug.Log("�α����");
		for (int i = 0; i < 10; i++)
		{
			Debug.Log($"{i}�� ����");
			yield return new WaitForSeconds(1f);
		} 
	}

    // <�ڷ�ƾ ����>
    // StopCoroutine�� ���� ���� ���� �ڷ�ƾ ����
    // StopAllCoroutine�� ���� ���� ���� ��� �ڷ�ƾ ����
    // �ݺ������� �۾��� ��� �Ϸ�Ǿ��� ��� �ڵ� ����
    // �ڷ�ƾ�� �����Ų ��ũ��Ʈ�� ��Ȱ��ȭ�� ��� �ڵ� ����

    private void CoroutineStop()
    {
        StopCoroutine(routine);     // ������ �ڷ�ƾ ����
        StopAllCoroutines();        // ��ũ��Ʈ ���� ��� �ڷ�ƾ ����
    }
    // <�ڷ�ƾ �ð� ����>
    // �ڷ�ƾ�� �ð� ������ �����Ͽ� �ݺ������� �۾��� ���� Ÿ�̹��� ������ �� ����
    IEnumerator CoroutineWait()
    {
        yield return new WaitForSeconds(1);     // n�ʰ� �ð�����
        
        yield return null;                      // �ð����� ����
    }
}


