using UnityEngine;

public class UI : MonoBehaviour
{
    void Start()
    {
        SetLobbyController();
        SetGachaController();
    }

    public static LobbyController Lobby { get; private set; }
    private void SetLobbyController()
    {
        Lobby = GetComponentInChildren<LobbyController>();
        Lobby.Initialize();
    }

    public static GachaController Gacha { get; private set; }
    private void SetGachaController()
    {
        Gacha = GetComponentInChildren<GachaController>();
        Gacha.Initialize();
    }
}
