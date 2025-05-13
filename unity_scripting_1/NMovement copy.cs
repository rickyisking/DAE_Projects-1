using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 5f;

    void Awake()
    {
        // This runs first, even if the GameObject is disabled
        rb = GetComponent<Rigidbody>();
        Debug.Log("Rigidbody assigned in Awake");
    }

    void Start()
    {
        // This runs after Awake, only if the GameObject is active
        Debug.Log("PlayerMovement is ready!");
    }

    void Update()
    {
        // Handles player input every frame
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0f, moveZ) * moveSpeed;
        rb.velocity = new Vector3(move.x, rb.velocity.y, move.z);
    }
}

