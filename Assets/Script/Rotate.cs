using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Rotate: MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 1;

    private void Update()
    {
        transform.Rotate(Vector3.up * _rotateSpeed*_rotateSpeed);
    }
}
