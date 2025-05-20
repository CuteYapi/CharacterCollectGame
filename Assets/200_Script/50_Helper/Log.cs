#if LOG

using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public static class Log
{
    [System.Diagnostics.Conditional("LOG")]
    public static void Message(LogCategory type, string message)
    {
        if (Manager.Log.IsLogCategoryOn[(int)LogCategory.IsLogOn] == false)
        {
            return;
        }

        if (Manager.Log.IsLogCategoryOn[(int)type] == false)
        {
            return;
        }

        string typeText = GetTypeText(type);

        Debug.Log(typeText + message);
    }

    [System.Diagnostics.Conditional("LOG")]
    public static void Warning(LogCategory type, string message)
    {
        string typeText = GetTypeText(type);

        Debug.LogWarning(typeText + message);
    }

    [System.Diagnostics.Conditional("LOG")]
    public static void Error(LogCategory type, string message)
    {
        string typeText = GetTypeText(type);

        Debug.LogError(typeText + message);
    }

    private static string GetTypeText(LogCategory type)
    {
        string textColor = string.Empty;
        switch (type)
        {
            case LogCategory.Gacha:
                {
                    return textColor = $"<color=red>[°¡Ã­] </color>";
                }
            case LogCategory.MainMenu:

            case LogCategory.IsLogOn:
            case LogCategory.None:
            case LogCategory.Max:
            default:
                return string.Empty;
        }
    }
}

#endif