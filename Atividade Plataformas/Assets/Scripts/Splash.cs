using UnityEngine;

public class Splash : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("GoToManiMenu",2f);
    }

    // Update is called once per frame
    void GoToManiMenu()
    {
        GameManager.Instance.LoadScene("MainMenu");
    }
}
