using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vitoria : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private string resetar;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Menu()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(resetar);
    }
}
