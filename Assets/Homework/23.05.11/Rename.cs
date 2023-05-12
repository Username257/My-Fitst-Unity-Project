using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rename : MonoBehaviour
{
    public GameObject gameObject;
    public AudioSource audioSource;
    public BoxCollider boxCollider;
    private void Awake() 
    {
        gameObject = gameObject.GetComponent<GameObject>();
        gameObject.name = "Player";
    }
}
