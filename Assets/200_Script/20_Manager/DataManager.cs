using System;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public void Initialize() // Start 에서 실행이 된다
    {

    }

    #region Gem

    public int CashGem { get; private set; } // 이걸로만 할 수 있는 가챠도 존재
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
        // 1-1. 무료 보석 부터 사용
        if (amount <= FreeGem)
        {
            UseFreeGem(amount);
            return;
        }

        // 1-2. 무료 보석을 전부 사용
        amount -= FreeGem;
        UseFreeGem(FreeGem);

        // 2. 사용해야할 보석 만큼 유료 보석 사용
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
