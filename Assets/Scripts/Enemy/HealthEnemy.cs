using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : Health
{
    public override void LifeDecrement()
    {
        if(GameManager.instance.gameOver){return;}

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
        lifeTxt.text = life.ToString();

        if(life <= 0){ Dead();}
    }

    public override void Dead()
    {
        Instantiate(bigExplosion, transform.position, Quaternion.identity);
        GameManager.instance.AddPoints(1);
        Destroy(this.gameObject);
    }
}
