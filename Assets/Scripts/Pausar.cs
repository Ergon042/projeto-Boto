using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausar : MonoBehaviour
{
    public GameObject pausa;
    public static bool pause;

    [SerializeField] private string menu;
    [SerializeField] private GameObject configu;


    // Start is called before the first frame update
    void Start()
    {
        pausa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pausa.SetActive(true);
        Time.timeScale = 0f;
        pause = true;
    }

    public void ResumeGame()
    {
        pausa.SetActive(false);
        Time.timeScale = 1f;
        pause = false;
    }

    public void Voltar()
    {
        ResumeGame();
    }

    public void Config()
    {
        configu.SetActive(true);
    }

    public void SairConfig()
    {
        configu.SetActive(false);
    }

    public void Menu()
    {
        SceneManager.LoadScene(menu);
        ResumeGame();
    }

    public void SairJogo()
    {
        Application.Quit();
    }
}
