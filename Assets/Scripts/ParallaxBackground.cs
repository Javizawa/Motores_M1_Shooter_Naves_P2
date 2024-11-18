using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public float parallaxSpeed = 0.5f; // Controla la velocidad de parallax

    private Transform camTransform;
    private Vector3 lastCamPosition;

    void Start()
    {
        camTransform = Camera.main.transform;
        lastCamPosition = camTransform.position;
    }

    void Update()
    {
        Vector3 deltaMovement = camTransform.position - lastCamPosition;
        transform.position += new Vector3(deltaMovement.x * parallaxSpeed, deltaMovement.y * parallaxSpeed, 0);
        lastCamPosition = camTransform.position;
    }
}