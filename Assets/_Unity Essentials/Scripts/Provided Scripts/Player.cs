using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        RotationController();
        MovementController();
    }

    private void MovementController()
    {
        float vertical = Input.GetAxis("Vertical");
        if (vertical != 0)
        {
            Vector3 movement = transform.forward * vertical * speed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + movement); ;
        }
    }

    private void RotationController()
    {
        float horinzontal = Input.GetAxis("Horizontal");
        if (horinzontal != 0)
        {
            float turn = horinzontal * rotationSpeed ;
            Quaternion quaternion = Quaternion.Euler(0, horinzontal, 0);
            rb.MoveRotation(rb.rotation * quaternion);
        }
    }
}
