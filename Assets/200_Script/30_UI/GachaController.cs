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
            Log.Message(LogCategory.Gacha, "단차를 시작합니다.");
        });

        MultyGachaButton.SetButtonAction(() =>
        {
            Log.Message(LogCategory.Gacha, "10연차를 시작합니다.");
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
        // 현재 오픈되어 있는 가챠를 DataManager로부터 가져옴
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

            // 만을 OpenGachaList 에 넣는다!
            OpenGachaList.Add(data);
        }
    }

    private GachaErrorFlag IsOpenGacha(GachaData data)
    {
        // 1. 오픈되어 있는 가챠
        if (data.IsOpen == false)
        {
            return GachaErrorFlag.Close;
        }

        // 2. 시작 날짜를 넘긴 가챠
        if (data.StartTime > DateTime.Now)
        {
            return GachaErrorFlag.StartDateError;
        }

        // 3. 종료 날짜를 넘기지 않은 가챠
        if (data.EndTime < DateTime.Now)
        {
            return GachaErrorFlag.EndDateError;
        }

        return GachaErrorFlag.Possible;
    }

    private void SetGachaAction()
    {
        // 1. 이게 유효한 가챠인지 확인?
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
