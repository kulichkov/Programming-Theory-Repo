using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleMenuUIHandler : MonoBehaviour
{
    [SerializeField]
    Button startButton;

    void Start()
    {
        SetStartButton(false);
    }

    public void PlayerNameDidChange(string playerName)
    {
        SetStartButton(playerName.Length >= 3);
    }

    public void PlayerNameDidEndChanging(string playerName)
    {
        MainManager.Instance.SetPlayerName(playerName);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Game started");
    }

    private void SetStartButton(bool enabled)
    {
        startButton.gameObject.SetActive(enabled);
    }

}
