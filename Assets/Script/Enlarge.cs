using UnityEngine;

public class Enlarge : MonoBehaviour
{
    [SerializeField] private float _enlargeSpeed = 0.1f;

    private void Update()
    {
        transform.localScale += Vector3.one * _enlargeSpeed * Time.deltaTime;
    }
}
