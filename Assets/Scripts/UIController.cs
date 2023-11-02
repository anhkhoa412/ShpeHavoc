
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public GameObject menuPanel;
    public GameObject restartPanel;
    public Text score;
    public bool isStart = false;
 
   
    public void Update()
    {
        if (isStart)
        {
            score.text = PlayerManager.instance.score.ToString();
        }
    }
    public void Awake()
    {
        Time.timeScale = 0f;
        instance = this;

        restartPanel.SetActive(false);
    }
    public void OnStart()
    {
        isStart = true;
        Time.timeScale = 1f;
        menuPanel.SetActive(false);
        FindObjectOfType<PlayerManager>().enabled = true;
        FindObjectOfType<SpawnManager>().enabled = false;
    }

    public void GameOver()
    {
        restartPanel.SetActive(true);
        Time.timeScale = 0f;
        isStart = false;
        PlayerManager.instance.score = 0;
       
    }

    public void onRestart()
    {
        SceneManager.LoadScene(0);
    }
}
