using UnityEngine;

public class RotationComponent : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;

    private void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);
    }
}
