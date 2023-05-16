using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    public CinemachineVirtualCamera view1;
    public CinemachineVirtualCamera view3;

    public void Start()
    {
        view3.Priority = 10;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            view1.Priority = 10;
            view3.Priority = 5;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            view1.Priority = 5;
            view3.Priority = 10;
        }
    }
}
