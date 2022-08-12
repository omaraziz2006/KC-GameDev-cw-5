using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    Rigidbody2D rp;
    float pi;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rp = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        move();
    }
    void move()
    {
        pi = Input.GetAxis("Horizontal");
        rp.velocity = new Vector2(pi * speed, 0); 
    }
}
