using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour

{
    public GameObject bulletPrefab;
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
        bulletRigidBody.AddForce(direction * force);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
    }
}
