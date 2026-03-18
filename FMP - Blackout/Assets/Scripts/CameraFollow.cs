using System.Security.Cryptography;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float cameraOffset = 10f;

    [SerializeField] private float smoothTime = 0.25f;

    [SerializeField] private Transform target;

    private Vector3 offset;
    private Vector3 velocity = Vector3.zero;


    private void Awake()
    {
        offset = new Vector3(0f, 0f, -(cameraOffset));
    }


    void Update()
    {
        Vector3 targetPosition = target.position + offset;

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
