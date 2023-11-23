using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Mathematics;
using UnityEngine;

public class HealthPlayer : Health
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            LifeDecrement();
        }
    }

    public override void LifeDecrement()
    {
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

        if(life <= 0){ Dead();}
    }

    public override void Dead()
    {
        Instantiate(bigExplosion, transform.position, Quaternion.identity);
        GameManager.instance.GameOver();
    }
}
