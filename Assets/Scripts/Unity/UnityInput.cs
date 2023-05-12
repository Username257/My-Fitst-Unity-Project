using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class UnityInput : MonoBehaviour
{
    /************************************************************************
     * 유니티 입력
     * 
     * 유니티에서 사용자의 명령을 감지할 수 있는 수단
     * 사용자는 외부 장치를 이용하여 게임을 제어할 수 있음
     * 유니티는 다양한 타입의 입력기기(키보드 및 마우스, 조이스틱, 터치스크린 등)를 지원
     ************************************************************************/
    private void Update()
    {
        InputByDevice();
    }

    //<Device>
    // 특정한 장치를 기준으로 입력 감지
    // 특정한 장치의 입력을 감지하기 때문에 여러 플랫폼에서는 불가
    private void InputByDevice()
    {
        //키보드 입력
        if (Input.GetKeyUp(KeyCode.Space))
            Debug.Log("KeyUp");
        if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log("KeyDown");
        if (Input.GetKey(KeyCode.Space))
            Debug.Log("Key Pressing");

        //마우스 입력
        if (Input.GetMouseButton(0))
            Debug.Log("Mouse Left Button Pressing");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("Mouse Left Button Up");
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Mouse Left Button Down");
    }

    //<Input Manager>
    // 여러 장치의 입력을 입력매니저에 이름과 입력을 정의
    // 입력매니저의 이름으로 정의한 입력의 변경사항을 확인
    private void InputByInputManager()
    {
        // 버튼 입력
        // Fire1 : 키보드 (Left Ctrl), 마우스 (Left Button), 조이스틱도 있음
        if (Input.GetButton("Fire1"))
            Debug.Log("Fire1 is pressing");
        if (Input.GetButtonDown("Fire1"))
            Debug.Log("Fire1 is down");
        if (Input.GetButtonUp("Fire1"))
            Debug.Log("Fire1 is up");

        // 축 입력
        // Horizontal(수평) : 키보드(a,d / ←, →), 조이스틱(왼쪽 아날로그스틱 좌우)
        float x = Input.GetAxis("Horizontal");
        // Vertical(수직) : 키보드(w,s / ↑, ↓), 조이스틱(왼쪽 아날로그스틱 상하)
        float y = Input.GetAxis("Vertical");
    }

    // <InputSystem>
    // Unity 2019.1 부터 지원하게 된 입력방식
    // 컴포넌트를 통해 입력의 변경사항을 확인
    // GamePad, JoyStick, Mouse, Keyboard, Pointer, Pen, TouchScreen, XR 기기 등을 지원
    private void InputByInputSystem()
    {
        // InputSystem은 이벤트 방식으로 구현됨
        // Update마다 입력변경사항을 확인하는 방식 대신 변경이 있을 경우 이벤트로 확인
        // 메시지를 통해 받는 방식과 이벤트 함수를 직접 연결하는 방식 등으로 구성
    } 

    // Move 입력에 반응하는 OnMove 메시지 함수
    private void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
    }
}
