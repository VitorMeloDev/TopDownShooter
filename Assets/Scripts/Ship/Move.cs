using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 3.0f;
    public float xLimits;
    public float yLimits;
    private Rigidbody2D rb;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        rb.velocity = transform.up * moveSpeed;
        transform.Rotate(Vector3.forward * -horizontal * rotationSpeed);
        
        Vector2 LimitedPosition = rb.position;
        LimitedPosition.x = Mathf.Clamp(LimitedPosition.x, -xLimits, xLimits);
        LimitedPosition.y = Mathf.Clamp(LimitedPosition.y, -yLimits, yLimits);
        rb.position = LimitedPosition;
    }
}
