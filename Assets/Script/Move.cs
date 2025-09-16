using UnityEngine;

public class Move: MonoBehaviour
{
    [SerializeField] private float _movingSpeed = 5;
    
    private void Update()
    {
        transform.Translate(Vector3.forward*(_movingSpeed*Time.deltaTime));
    }
}
