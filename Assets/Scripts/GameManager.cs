using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{


    public static GameManager instance;
    public GameObject startMenu;
    int score;
    public Text scoreText;



    private void Awake()
    {
        instance = this;

    }


    // Start is called before the first frame update



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart() {
        startMenu.SetActive(false);
        scoreText.gameObject.SetActive(true);
    }


    public void Restart() {
        SceneManager.LoadScene("GameScenes");
    }


    public void ScoreUp() {
        score++;
        scoreText.text = score.ToString();
    }
}
