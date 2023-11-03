using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorSom : MonoBehaviour
{
    public AudioSource fundoMusical, som1, som2, som3, som4, som5, som6;

    public void AtualizarSensibilidade(float value)
    {
        PlayerController.mouseSensitivity = value;
    }

    public void VolumeMusical(float value)
    {
        fundoMusical.volume = value;
        som1.volume = value;
        som2.volume = value;
        som3.volume = value;
        som4.volume = value;
        som5.volume = value;
        som6.volume = value;
    }
}
