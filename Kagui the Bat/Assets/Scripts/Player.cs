using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        // Assign rigidbody class to variable
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame (Example: Timers, Detection of inputs etc.)
    void Update()
    {
        // Basic movement of player sprite in vertical directions
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }

    // Update is called once per physics frame (Example: Rigidbody manipulations etc.)
    private void FixedUpdate()
    {
        // Linear velocity calculation of rigidbody in units per second
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
