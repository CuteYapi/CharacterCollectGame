using UnityEngine;

public class UI : MonoBehaviour
{
    void Start()
    {
        SetLobbyController();
    }

    public static LobbyController Lobby { get; private set; }
    private void SetLobbyController()
    {
        Lobby = GetComponent<LobbyController>();
        Lobby.Initialize();
    }
}
