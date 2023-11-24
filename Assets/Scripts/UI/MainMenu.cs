using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject[] menus;

    [SerializeField] private Text gameSessionTxt;
    [SerializeField] private Text spawnTimeTxt;

    void Awake()
    {
        Save();
    }
    
    public void ActivateDisable(int x)
    {
        foreach (var menu in menus)
        {
            menu.SetActive(false);
        }
        menus[x].SetActive(true);
    }

    public void ChangeGameSessionTime(int x)
    {
        int timeGM = PlayerPrefs.GetInt("GameSession");
        switch (x)
        {
            case -1:
                if(timeGM <= 3 && timeGM > 1){ PlayerPrefs.SetInt("GameSession", timeGM - 1); }
            break;

            case 1:
                if(timeGM >= 1 && timeGM < 3){ PlayerPrefs.SetInt("GameSession", timeGM + 1); }
            break;
        }

        gameSessionTxt.text = PlayerPrefs.GetInt("GameSession").ToString() + " Min";
    }

    public void ChangeSpawnTime(int x)
    {
        int timeGM = PlayerPrefs.GetInt("SpawnTime");
        switch (x)
        {
            case -1:
                if(timeGM > 5) {PlayerPrefs.SetInt("SpawnTime", timeGM - 1);}
            break;

            case 1:
                if(timeGM < 30) {PlayerPrefs.SetInt("SpawnTime", timeGM +1);}
            break;
        }

        spawnTimeTxt.text = PlayerPrefs.GetInt("SpawnTime").ToString() + " Sec";
    }

    void Save()
    {
        if(!PlayerPrefs.HasKey("GameSession"))
        {
            PlayerPrefs.SetInt("GameSession", 2);
            gameSessionTxt.text = PlayerPrefs.GetInt("GameSession").ToString() + " Min";
        }

        if(!PlayerPrefs.HasKey("SpawnTime"))
        {
            PlayerPrefs.SetInt("SpawnTime", 8);
            spawnTimeTxt.text = PlayerPrefs.GetInt("SpawnTime").ToString() + " Sec";
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
