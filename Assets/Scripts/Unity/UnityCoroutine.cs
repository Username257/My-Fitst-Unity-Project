using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityCoroutine : MonoBehaviour
{
    /************************************************************************
	 * 코루틴 (Coroutine)
	 * 
	 * 작업을 다수의 프레임에 분산할 수 있는 비동기식(안보고잇을때 알아서하고있는) 작업
	 * 반복가능한 작업을 분산하여 진행하며, 실행을 일시정지하고 중단한 부분부터 다시시작할 수 있음
	 * 단, 코루틴은 스레드가 아니며 코루틴의 작업은 여전히 메인 스레드에서 실행
	 ************************************************************************/

    private Coroutine routine;
    private void Start()
    {
        // <코루틴 진행>
        // 반복가능한 작업을 StartCorouine을 통해 실행
        routine = StartCoroutine(SubRoutine());
    }


	IEnumerator SubRoutine()
	{
		//yield return new WaitForSeconds(3f);
		//Debug.Log("로그찍기");
		for (int i = 0; i < 10; i++)
		{
			Debug.Log($"{i}초 지남");
			yield return new WaitForSeconds(1f);
		} 
	}

    // <코루틴 종료>
    // StopCoroutine을 통해 진행 중인 코루틴 종료
    // StopAllCoroutine을 통해 진행 중인 모든 코루틴 종료
    // 반복가능한 작업이 모두 완료되었을 경우 자동 종료
    // 코루틴을 진행시킨 스크립트가 비활성화된 경우 자동 종료

    private void CoroutineStop()
    {
        StopCoroutine(routine);     // 지정한 코루틴 종료
        StopAllCoroutines();        // 스크립트 내의 모든 코루틴 종료
    }
    // <코루틴 시간 지연>
    // 코루틴은 시간 지연을 정의하여 반복가능한 작업의 진행 타이밍을 지정할 수 있음
    IEnumerator CoroutineWait()
    {
        yield return new WaitForSeconds(1);     // n초간 시간지연
        
        yield return null;                      // 시간지연 없음
    }
}


