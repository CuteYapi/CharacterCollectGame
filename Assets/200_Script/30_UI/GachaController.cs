using UnityEngine;
using InterfaceDefine;
using System.Collections.Generic;
using System;

public class GachaController : MonoBehaviour, IUI
{
    List<GachaData> OpenGachaList = new List<GachaData>();
    GachaData SelectedGacha;

    public ButtonController SingleGachaButton;
    public ButtonController MultyGachaButton;

    public void Initialize()
    {
        SingleGachaButton.SetButtonAction(() =>
        {
            Log.Message(LogCategory.Gacha, "������ �����մϴ�.");
        });

        MultyGachaButton.SetButtonAction(() =>
        {
            Log.Message(LogCategory.Gacha, "10������ �����մϴ�.");
        });
    }

    public void Open()
    {
        SetGachaDataList();
    }

    public void Close()
    {

    }

    private void SetGachaDataList()
    {
        // ���� ���µǾ� �ִ� ��í�� DataManager�κ��� ������
        foreach (GachaData data in Manager.Data.GachaDatas)
        {
            switch (IsOpenGacha(data))
            {
                case GachaErrorFlag.Possible:
                    break;

                case GachaErrorFlag.Close:
                    {
                        continue;
                    }
                case GachaErrorFlag.StartDateError:
                    {
                        continue;
                    }
                case GachaErrorFlag.EndDateError:
                    {
                        continue;
                    }
                case GachaErrorFlag.NotEnoughGem:
                    {
                        continue;
                    }
                case GachaErrorFlag.NotEnoughTicket:
                    {
                        continue;
                    }

                case GachaErrorFlag.None:
                case GachaErrorFlag.Max:
                default:
                    continue;
            }

            // ���� OpenGachaList �� �ִ´�!
            OpenGachaList.Add(data);
        }
    }

    private GachaErrorFlag IsOpenGacha(GachaData data)
    {
        // 1. ���µǾ� �ִ� ��í
        if (data.IsOpen == false)
        {
            return GachaErrorFlag.Close;
        }

        // 2. ���� ��¥�� �ѱ� ��í
        if (data.StartTime > DateTime.Now)
        {
            return GachaErrorFlag.StartDateError;
        }

        // 3. ���� ��¥�� �ѱ��� ���� ��í
        if (data.EndTime < DateTime.Now)
        {
            return GachaErrorFlag.EndDateError;
        }

        return GachaErrorFlag.Possible;
    }

    private void SetGachaAction()
    {
        // 1. �̰� ��ȿ�� ��í���� Ȯ��?
        if (IsOpenGacha(SelectedGacha) != GachaErrorFlag.Possible)
        {
            return;
        }

        switch (SelectedGacha.Type)
        {
            case GachaType.None:
                break;
            case GachaType.SingleGem:
                break;
            case GachaType.MultyGem:
                break;
            case GachaType.SingleTicket:
                break;
            case GachaType.MultyTicket:
                break;
            case GachaType.Max:
                break;
        }
    }
}
