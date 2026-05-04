using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoesl;
    public void Jogar()
    {
       SceneManager.LoadScene(nomeDoLevelDeJogo);

    }
    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoesl.SetActive(true);

    }
    public void FecharOpcoes()

    {
        painelOpcoesl.SetActive(false);
        painelMenuInicial.SetActive(true);
    }
    public void SairJogo()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }

}
