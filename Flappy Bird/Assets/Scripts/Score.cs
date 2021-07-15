using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "checkpoint")
        {
            Debug.Log("Score!!");
            score++;
            scoreText.text = score.ToString();
        }
    }
}
