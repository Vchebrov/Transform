using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    [SerializeField] private float _movingSpeed = 5;


    private void Update()
    {
        transform.Translate(Vector3.forward*_movingSpeed*Time.deltaTime);
    }


}
