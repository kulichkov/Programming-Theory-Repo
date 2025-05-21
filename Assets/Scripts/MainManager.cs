using UnityEngine;

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
        Debug.Log($"Player's name: {PlayerName}");
    }

}
