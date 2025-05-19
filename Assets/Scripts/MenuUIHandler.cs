using UnityEngine;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
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

    private void SetStartButton(bool enabled)
    {
        startButton.gameObject.SetActive(enabled);
    }

}
