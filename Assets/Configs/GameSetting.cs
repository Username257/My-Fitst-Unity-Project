using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameSetting
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Init()
    {           
        //������ �����ϱ� �� �ʿ��� ������
        if (GameManager.Instance == null)
        {
            GameObject gameManager = new GameObject() { name = "GameManager" };
            gameManager.AddComponent<GameManager>();
        }
    }    
}
