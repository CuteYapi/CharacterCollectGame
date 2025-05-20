#if LOG

using UnityEngine;
using System.Collections.Generic;


public enum LogCategory
{
    None = -1,

    IsLogOn = 0,

    Gacha,

    MainMenu,

    Max,
}



public class LogManager : MonoBehaviour
{
    public List<bool> IsLogCategoryOn = new List<bool>();

    public void Initialize()
    {
        for (int i = 0; i < (int)LogCategory.Max; i++)
        {
            IsLogCategoryOn.Add(false);
            //IsLogCategoryOn[(int)IsLogOn] 의 값은 False
            //IsLogCategoryOn[(int)Gacha] 의 값은 False
        }
    }

}

#endif