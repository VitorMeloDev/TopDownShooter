using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : Health
{
    void Update()
    {
        
    }

    public override void LifeDecrement()
    {
        life--;
        switch (life)
        {
            case 0:
                srShip.sprite = spritesShip[2];
            break;

            case 1:
                srShip.sprite = spritesShip[1];
            break;
        }

        if(life <= 0){ Dead();}
    }

    public override void Dead()
    {
        Instantiate(bigExplosion, transform.position, Quaternion.identity);
    }
}
