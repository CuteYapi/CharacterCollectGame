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
            Log.Error(LogCategory.Gacha, $"{transform.parent.name} ��ư�� �Ҵ���� �ʾҽ��ϴ�!");
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
