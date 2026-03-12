using UnityEngine;
using UnityEngine.InputSystem;

public class magnuseffect : MonoBehaviour
{
    public float kickForce;
    public float spineAmount;
    public float magnusStrength = 0.5f;

    Rigidbody rb;
    bool isShot = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            rb.AddForce(Vector3.forward * kickForce, ForceMode.Impulse);

            rb.AddTorque(Vector3.up * spineAmount);

            isShot = true;
        }
    }

    private void FixedUpdate()
    {
        if (!isShot) return;
        
        Vector3 velocity = rb.linearVelocity;
        Vector3 spin = rb.angularVelocity;

        Vector3 manusForce = magnusStrength * Vector3.Cross(spin, velocity);

        rb.AddForce(manusForce);
    }
}
