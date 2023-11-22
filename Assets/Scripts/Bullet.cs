using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    public float vel;
    public Rigidbody2D myRB;
    public int dano;
    public GameObject impact;
    
    public abstract void Move();
}
