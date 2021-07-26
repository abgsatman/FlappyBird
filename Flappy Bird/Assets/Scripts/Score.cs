using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    public GameObject gameOver;
    public GameObject restart;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "checkpoint")
        {
            Debug.Log("Score!!");
            score++;
            scoreText.text = score.ToString();
        }
    }
    
    void OnCollisionEnter2D(Collision2D coll)
    {

        if(coll.gameObject.tag == "pipe")
        {
            Debug.Log("game over!");

            //when the game is over!
            CheckHighScore();

            gameOver.SetActive(true);
            restart.SetActive(true);

            Time.timeScale = 0;
        }
    }

    public void Restart()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene("SampleScene");
    }

    public void CheckHighScore()
    {
        if(PlayerPrefs.GetInt("highscore") < score)
        {
            //new high record!
            PlayerPrefs.SetInt("highscore", score);
        }
    }
}
