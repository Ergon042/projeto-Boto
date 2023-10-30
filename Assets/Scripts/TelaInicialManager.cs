using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicialManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelTelaInicial;
    [SerializeField] private GameObject painelCredito;

    public void jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void AbrirCreditos()
    {
        painelTelaInicial.SetActive(true);
        painelCredito.SetActive(true);
    }

    public void FecharCreditos()
    {
        painelCredito.SetActive(false);
        painelTelaInicial.SetActive(true);
    }

    public void SairJogo()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
}
