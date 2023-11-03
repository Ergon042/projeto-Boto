using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;

    public void ResetScene()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void SairJogo()
    {
        Application.Quit();
    }
}
