using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    [SerializeField] private Transform bulletsOut;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float distanceToShoot;
    private MoveEnemy moveEnemy;
    bool canShoot = true;

    void Start()
    {
        moveEnemy = GetComponent<MoveEnemy>();
    }

    void Update()
    {
        if(moveEnemy.distanceTarget < distanceToShoot && canShoot)
        {
            FrontalShoot();
        }
    }

    public void FrontalShoot()
    {
        canShoot = false;
        Instantiate(bullet, bulletsOut.position, bulletsOut.rotation);
        StartCoroutine(NoShoot(1f));
    }

    private IEnumerator NoShoot(float time)
    {
        yield return new WaitForSeconds(time);
        canShoot = true;
    }
}
