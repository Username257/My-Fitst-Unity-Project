using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityTransform : MonoBehaviour
{
    /************************************************************************
	 * 트랜스폼 (Transform)
	 * 
	 * 게임오브젝트의 위치, 회전, 크기를 저장하는 컴포넌트
	 * 게임오브젝트의 부모-자식 상태를 저장하는 컴포넌트
	 * 게임오브젝트는 반드시 하나의 트랜스폼 컴포넌트를 가지고 있으며 추가 & 제거할 수 없음
	 ************************************************************************/
    private void Start()
    {
		TranslateMove();
    }
    private void TranslateMove()
	{

		transform.position = new Vector3(10, 10, 10);
		transform.localScale = new Vector3(3, 3, 3);
		
	}
    // <트랜스폼 부모-자식 상태>
    // 트랜스폼은 부모 트랜스폼을 가질 수 있음
    // 부모 트랜스폼이 있는 경우 부모 트랜스폼의 위치, 회전, 크기 변경이 같이 적용됨
    // 이를 이용하여 계층적 구조를 정의하는데 유용함 (ex. 팔이 움직이면, 손가락도 같이 움직임)
    // 하이어라키 창 상에서 드래그 & 드롭을 통해 부모-자식 상태를 변경할 수 있음

	private void TransformParent()
	{
        GameObject newGameObject = new GameObject() { name = "NewGameObject" };
		transform.parent = newGameObject.transform;
        // 부모를 기준으로한 트랜스폼
        // transform.localPosition	: 부모트랜스폼이 있는 경우 부모를 기준으로 한 위치
        // transform.localRotation	: 부모트랜스폼이 있는 경우 부모를 기준으로 한 회전
        // transform.localScale		: 부모트랜스폼이 있는 경우 부모를 기준으로 한 크기

        // 부모 해제
        transform.parent = null; // 부모 트랜스폼이 없는 모든 게임 오브젝트는 월드를 기준

        // 월드를 기준으로한 트랜스폼
        // transform.localPosition == transform.position	: 부모트랜스폼이 없는 경우 월드를 기준으로 한 위치
        // transform.localRotation == transform.rotation	: 부모트랜스폼이 없는 경우 월드를 기준으로 한 회전
        // transform.localScale		
    }
}
