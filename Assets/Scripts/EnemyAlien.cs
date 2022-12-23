using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAlien : MonoBehaviour
{
    public float timer;
    float startTime =3;
    public float direction = 1;
    Rigidbody2D enemyRigidBody;
    // Start is called before the first frame update
    void Start()
    {
    timer = startTime;
    enemyRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    // Stores enemy postion in a Vector 2 variable
        Vector2 enemyPos = enemyRigidBody.position;
        enemyPos.x = enemyPos.x + Time.deltaTime * 1 * direction;
        enemyRigidBody.MovePosition(enemyPos);
    }
    void Update()
    {
    //  timer -= Time.deltaTime;

    // if (timer < 0)
    //  {
    //  direction = -direction
    //  timer = startTime 
    //  enemyRigidBody.MovePosition(enemyPos);
     }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        direction = -direction;
    }
}
