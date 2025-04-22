using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    public void StartGame()
    {
        GameManager.Instance.LoadScene("Game");
    }

    
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Complicado");
    }
}
