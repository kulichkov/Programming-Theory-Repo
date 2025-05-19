using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; } // ENCAPSULATION”

    public string PlayerName;

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetPlayerName(string playerName)
    {
        PlayerName = playerName;
        Debug.Log("PlayerName set to " + PlayerName);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Game started");
    }
}
