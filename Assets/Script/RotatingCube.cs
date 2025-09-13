using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCube : MonoBehaviour
{
    [SerializeField] private float _rotatingSpeed = 1;

    private void Update()
    {
        transform.Rotate(Vector3.up * _rotatingSpeed*_rotatingSpeed);
    }
}
