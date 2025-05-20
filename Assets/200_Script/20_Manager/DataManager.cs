using System;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public void Initialize() // Start ���� ������ �ȴ�
    {

    }

    #region Gem

    public int CashGem { get; private set; } // �̰ɷθ� �� �� �ִ� ��í�� ����
    public int FreeGem { get; private set; }
    public int MinusGem { get; private set; } 
    public int Gem
    {
        get
        {
            return FreeGem + CashGem - MinusGem;
        }
    }
    
    public void UseGem(int amount)
    {
        // 1-1. ���� ���� ���� ���
        if (amount <= FreeGem)
        {
            UseFreeGem(amount);
            return;
        }

        // 1-2. ���� ������ ���� ���
        amount -= FreeGem;
        UseFreeGem(FreeGem);

        // 2. ����ؾ��� ���� ��ŭ ���� ���� ���
        UseCashGem(amount);
    }

    public void AddCashGem(int amount)
    {
        CashGem += amount;
    }

    public void UseCashGem(int amount)
    {
        CashGem -= amount;
    }

    public void AddFreeGem(int amount)
    {
        FreeGem += amount;
    }

    public void UseFreeGem(int amount)
    {
        FreeGem -= amount;
    }

    public void AddMinusGem(int amount)
    {
        MinusGem += amount;
    }

    public void PayOffMinusGem(int amount)
    {
        MinusGem -= amount;
    }

    #endregion

    #region Gold

    public long Gold { get; private set; }

    public void AddGold(int amount)
    {
        Gold += amount;
    }

    public void UseGold(int amount)
    {
        Gold -= amount;
    }

    #endregion

    #region GachaTicket

    public short SingleGachaTicket { get; private set; }
    
    public void AddSingleGachaTicket(short amount)
    {
        SingleGachaTicket += amount;
    }

    public void UseSingleGachaTicket(short amount)
    {
        SingleGachaTicket -= amount;
    }

    public short MultyGachaTicket { get; private set; }

    public void AddMultyGachaTicket(short amount)
    {
        MultyGachaTicket += amount;
    }

    public void UseMultyGachaTicket(short amount)
    {
        MultyGachaTicket -= amount;
    }

    #endregion

    public List<GachaData> GachaDatas = new List<GachaData>();
}
