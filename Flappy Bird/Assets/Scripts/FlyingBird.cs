using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBird : MonoBehaviour
{
    public float velocity = 2.5f;
    public Rigidbody2D rb;

    private void Start()
    {
        Debug.Log("Your high score is: " + PlayerPrefs.GetInt("highscore"));
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }
}
