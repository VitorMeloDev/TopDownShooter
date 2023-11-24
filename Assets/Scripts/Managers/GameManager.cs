using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool gameOver;
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private Text pointsTxt;
    private int points;
    private float sessionTime;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        gameOver = false;
        sessionTime = (float)PlayerPrefs.GetInt("GameSession") * 60;
    }

    // Update is called once per frame
    void Update()
    {
        sessionTime -= Time.deltaTime;
        if(sessionTime <= 0) {GameOver();}
    }

    public void AddPoints(int add)
    {
        points += add;
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverMenu.SetActive(true);
        pointsTxt.text = "SCORE: " + points.ToString();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
