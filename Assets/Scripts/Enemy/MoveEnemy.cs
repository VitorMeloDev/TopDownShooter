using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float moveSpeed;
    public float distanceTarget;
    private GameObject target;
    private Rigidbody2D myRb;
    
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player");
    }
    
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        if(target == null){return;}

        Vector2 direction = (target.transform.position - transform.position).normalized;
        myRb.velocity = direction * moveSpeed;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        myRb.rotation = angle;
        
        distanceTarget = Vector2.Distance(transform.position, target.transform.position);
    }
}
