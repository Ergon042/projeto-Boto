using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void SairJogo()
    {
        Application.Quit();
    }
}
