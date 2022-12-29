using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int weapon = 1;
    public float rotSpeed;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireForce = 20f;
    private float timeBtwShots;
	public float startTimeBtwShots;

    public void Fire()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
		Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		firePoint.rotation = Quaternion.Slerp(firePoint.rotation, rotation, rotSpeed * Time.deltaTime);

        if (weapon == 1)
        {
            if(Input.GetMouseButtonDown(0)){
			    GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                //bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
		    }

		    if(Input.GetMouseButton(0)){

			    if(timeBtwShots <= 0)
			    {
				    GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                    //bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
				    timeBtwShots = startTimeBtwShots;
			    }
			    else
			    {
			    	timeBtwShots -= Time.deltaTime;
			    }
	    	} 
        }
    }
}
