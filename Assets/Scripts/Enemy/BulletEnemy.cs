using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : Bullet
{
    void FixedUpdate()
    {
        if(GameManager.instance.gameOver){return;}
        Move();
    }

    public override void Move()
    {
        myRB.velocity = transform.up * vel;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<HealthPlayer>().LifeDecrement();
            Instantiate(explosion,transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }

        if(other.gameObject.CompareTag("Enemy"))
        {
            Instantiate(explosion,transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }

        if(other.gameObject.CompareTag("Rock"))
        {
            Instantiate(explosion,transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}