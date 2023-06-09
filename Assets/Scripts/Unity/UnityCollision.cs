using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCollision : MonoBehaviour
{
    /************************************************************************
	 * 충돌체
	 * 
	 * 물리적 충돌을 위해 게임오브젝트의 모양을 정의
	 * 게임오브젝트의 표현인 메시와 똑같을 필요는 없음
	 * 충돌체가 충돌상황에 있을 경우 유니티 충돌 메시지를 받아 상황을 확인
	 ************************************************************************/

    // <유니티 충돌 메시지>
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
