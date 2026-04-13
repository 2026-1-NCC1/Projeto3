using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Clicou em Jogar");
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void QuitGame()
    {
        Debug.Log("Saiu do jogo");
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}