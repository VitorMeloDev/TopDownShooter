using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public abstract class Health : MonoBehaviour
{
    public int life;
    public GameObject bigExplosion;
    public Sprite[] spritesShip;
    public SpriteRenderer srShip;
    public Text lifeTxt;

    public abstract void LifeDecrement();
    public abstract void Dead();
}
