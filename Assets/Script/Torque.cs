using UnityEngine;

public class Torque : MonoBehaviour
{
    [SerializeField] private float torqueSpeed;

    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.AddTorque(Vector3.right * torqueSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
