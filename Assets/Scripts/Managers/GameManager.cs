using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    }

    // Update is called once per frame
    void Update()
    {

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
        Time.timeScale = 0;
    }
}
