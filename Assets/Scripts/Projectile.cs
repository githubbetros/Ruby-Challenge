using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    public void Launch (Vector2 direction, float force)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
