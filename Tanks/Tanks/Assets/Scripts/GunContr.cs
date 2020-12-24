using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunContr : MonoBehaviour {

    public bool firing;

    public BulletContr bullet;
    public float bulletSpeed;

    public float shootingRate;
    private float shotCounter;

    public Transform firePoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (firing)
        {
            shotCounter -= Time.deltaTime;
            if(shotCounter <= 0)
            {
                shotCounter = shootingRate;
                BulletContr newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation);
                newBullet.speed = bulletSpeed;
            }
        }
        else
        {
            shotCounter = 0;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            firing = true;
        }
        else
        {
            firing = false;
        }


    }
}
