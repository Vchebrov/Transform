using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlageCapsule : MonoBehaviour
{
    [SerializeField] private float _enlargingSpeed = 0.1f;

    private void Update()
    {
        transform.localScale += Vector3.one * _enlargingSpeed * Time.deltaTime;        
    }
}
