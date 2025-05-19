using InterfaceDefine;
using UnityEngine;

public class LobbyController : MonoBehaviour, IUI
{
    public void Initialize()
    {

    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
