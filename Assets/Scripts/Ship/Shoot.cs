using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public Transform[] bulletsOut;
    public GameObject bullet;
    bool canShoot = true;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1") && canShoot)
        {
            FrontalShoot();
        }

        if(Input.GetButton("Fire2") && canShoot)
        {
            TripleShoot();
        }
    }

    public void FrontalShoot()
    {
        canShoot = false;
        Instantiate(bullet, bulletsOut[0].position, bulletsOut[0].rotation);
        StartCoroutine(NoShoot(0.6f));
    }

    public void TripleShoot()
    {
        canShoot = false;
        Instantiate(bullet, bulletsOut[0].position, bulletsOut[0].rotation);
        Instantiate(bullet, bulletsOut[1].position, bulletsOut[1].rotation);
        Instantiate(bullet, bulletsOut[2].position, bulletsOut[2].rotation);
        StartCoroutine(NoShoot(1f));
    }

    private IEnumerator NoShoot(float time)
    {
        yield return new WaitForSeconds(time);
        canShoot = true;
    }
}
