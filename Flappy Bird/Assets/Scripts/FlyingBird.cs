using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBird : MonoBehaviour
{
    public float velocity = 2.5f;
    public Rigidbody2D rb;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }
}
