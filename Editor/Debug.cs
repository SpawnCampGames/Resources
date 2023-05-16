using UnityEngine;
//SpawnCampGames.com

public static class Debug
{
    // base debug
    public static void Log(string msg)
    {
        UnityEngine.Debug.Log($"<color=white>{msg}</color>");
    }

    // extended debugs
    public static void Underlined(string msg)
    {
        UnityEngine.Debug.Log(msg + "\n----------------------------");
    }

    public static void Error(string msg)
    {
        UnityEngine.Debug.Log($"<color=red>! {msg} !</color>");
    }

    public static void Warning(string msg)
    {
        UnityEngine.Debug.Log($"<color=yellow>* {msg} *</color>");
    }

    public static void Red(string msg)
    {
        UnityEngine.Debug.Log($"<color=red>{msg}</color>");
    }

    public static void Orange(string msg)
    {
        UnityEngine.Debug.Log($"<color=orange>{msg}</color>");
    }

    public static void Yellow(string msg)
    {
        UnityEngine.Debug.Log($"<color=yellow>{msg}</color>");
    }

    public static void Green(string msg)
    {
        UnityEngine.Debug.Log($"<color=lime>{msg}</color>");
    }

    public static void Blue(string msg)
    {
        UnityEngine.Debug.Log($"<color=aqua>{msg}</color>");
    }

    public static void Indigo(string msg)
    {
        UnityEngine.Debug.Log($"<color=magenta>{msg}</color>");
    }

    public static void Violet(string msg)
    {
        UnityEngine.Debug.Log($"<color=purple>{msg}</color>");
    }
}