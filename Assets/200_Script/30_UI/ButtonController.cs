using UnityEngine;
using InterfaceDefine;
using UnityEngine.UI;
using System;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour, IUI
{
    public Button button;

    public void Initialize()
    {
        if(button == null)
        {
            Log.Error(LogCategory.Gacha, $"{transform.parent.name} 버튼이 할당되지 않았습니다!");
        }
    }

    public void Open()
    {

    }

    public void Close()
    {

    }

    public void SetButtonAction(UnityAction action)
    {
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(action);
    }
}
