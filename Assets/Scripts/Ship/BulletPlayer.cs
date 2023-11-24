using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : Bullet
{
    void FixedUpdate()
    {
        Move();
    }

    public override void Move()
    {
        myRB.velocity = transform.up * vel;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<HealthEnemy>().LifeDecrement();
            Instantiate(explosion,transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }

        if(other.gameObject.CompareTag("Bullet"))
        {   
            Instantiate(explosion,transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }

        if(other.gameObject.CompareTag("Rock"))
        {
            Instantiate(explosion,transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
