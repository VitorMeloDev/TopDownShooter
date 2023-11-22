using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : Bullet
{
    void Update()
    {
        Move();
    }

    public override void Move()
    {
        //transform.Translate(new Vector2(0, vel * Time.deltaTime));
        myRB.velocity = transform.up * vel;
    }
}
