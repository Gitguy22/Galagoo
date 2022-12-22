using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour

{
    public GameObject bulletPrefab
    Rigidbody2D bulletRigidBody;
    // Start is called before the first frame update
    void Awake()
    {
        bulletRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Shoot(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force)
    }
     void ShootBullet()
    {
        GameObject bulletObject = Instantiate(bulletPrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);

        Bullet bullet = bulletObject.GetComponent<Bullet>();
        bullet.Shoot(new Vector2(0,1), 300);
    }
     if(Input.GetKeyDown(KeyCode.C))
        {
            ShootBullet();
        }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.GameObject);
    }
}
