using UnityEngine;
using UnityEngine.SceneManager;

public class MainManager : MonoBehaviour
{
    public MainManager Instance { get; private set; }

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
        Debug.Log("Game started");
    }
}
