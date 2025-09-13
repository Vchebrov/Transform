using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCube : MonoBehaviour
{

    [SerializeField] private float _movingSpeed = 2f;
    [SerializeField] private float _rotatingSpeed = 50f;
    [SerializeField] private float _enlargingSpeed = 0.1f;

    void Update()
    {
        transform.Translate(Vector3.forward * _movingSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotatingSpeed * Time.deltaTime);
        transform.localScale += Vector3.one * _enlargingSpeed * Time.deltaTime;
    }
}
