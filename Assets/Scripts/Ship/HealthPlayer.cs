using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Mathematics;
using UnityEngine;

public class HealthPlayer : Health
{
    public override void LifeDecrement()
    {
        if(GameManager.instance.gameOver){return;}

        life--;
        switch (life)
        {
            case 0:
                srShip.sprite = spritesShip[3];
            break;

            case 1:
                srShip.sprite = spritesShip[2];
            break;

            case 2:
                srShip.sprite = spritesShip[1];
            break;
        }
        lifeTxt.text = life.ToString();
        if(life <= 0){ Dead();}
    }

    public override void Dead()
    {
        Instantiate(bigExplosion, transform.position, Quaternion.identity);
        GameManager.instance.GameOver();
    }
}
