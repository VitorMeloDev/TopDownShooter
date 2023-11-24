using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float xLimits;
    [SerializeField] private float yLimits;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(GameManager.instance.gameOver){ return;}
        Move();
    }

    void Move()
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
