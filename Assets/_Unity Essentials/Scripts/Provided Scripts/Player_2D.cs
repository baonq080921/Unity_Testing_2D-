using UnityEngine;

public class Player_2D : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 movement; // Stores the direction of player movement
    [SerializeField] bool canMoveDiagonally = true; // Controls whether the player can move diagonally
    public bool isMovingHorizontally = true; // Tracks if the player is moving horizontally
    public bool isMovingVertically = false; // Tracks if the player is moving vertically

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;

    }

    private void Update()
    {
        MovementController();
        Debug.Log("canMoveDiagonally = " + canMoveDiagonally);


    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }

    private void MovementController()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");


        // Create a movement vector based on input
        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized * moveSpeed * Time.fixedDeltaTime;
        //Debug.Log($"Movement Vector: {movement}");
        if (canMoveDiagonally)
        {
            // Set movement direction based on input
            movement = new Vector2(horizontalInput, verticalInput);
            // Optionally rotate the player based on movement direction
            RotatePlayer(horizontalInput, verticalInput);
        }

        //else
        //{
        //    // Determine the priority of movement based on input
        //    if (horizontalInput != 0)
        //    {
        //        isMovingHorizontally = true;
        //    }
        //    else if (verticalInput != 0)
        //    {
        //        isMovingHorizontally = false;
        //    }

        //    // Set movement direction and optionally rotate the player
        //    if (isMovingHorizontally)
        //    {
        //        movement = new Vector2(horizontalInput, 0);
        //        RotatePlayer(horizontalInput, 0);
        //    }
        //    else
        //    {
        //        movement = new Vector2(0, verticalInput);
        //        RotatePlayer(0, verticalInput);
        //    }
        //}
    }


    void RotatePlayer(float x, float y)
    {
        // If there is no input, do not rotate the player
        if (x == 0 && y == 0) return;

        // Calculate the rotation angle based on input direction
        float angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
        // Apply the rotation to the player
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
