using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Mathematics;
using UnityEngine;

public abstract class Health : MonoBehaviour
{
    public int life;
    public GameObject bigExplosion;
    public Sprite[] spritesShip;
    public SpriteRenderer srShip;

    public abstract void LifeDecrement();
    public abstract void Dead();
}
