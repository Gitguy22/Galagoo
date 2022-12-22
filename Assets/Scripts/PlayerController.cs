using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    public GameObject bulletPrefab;

    
    
    // Start is called before the first frame update
    void Start()
    {
        // Write the code below to get your Rigidbody2D component
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Write the code below to get your Horizontal and Vertical axis
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    
}