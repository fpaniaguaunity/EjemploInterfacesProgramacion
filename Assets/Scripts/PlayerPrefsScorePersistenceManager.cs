using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerPrefsScorePersistenceManager : IScorePersistenceManager
{
    private static string PLAYER_NAME_KEY = "PlayerName";

    public string ReadPlayerName()
    {
        return PlayerPrefs.GetString(PLAYER_NAME_KEY, null);
    }

    public int ReadScore(string userName)
    {
        return PlayerPrefs.GetInt(userName, 0);
    }

    public void StorePlayerName(string userName)
    {
        PlayerPrefs.SetString(PLAYER_NAME_KEY, userName);
        PlayerPrefs.Save();
    }

    public void StoreScore(string userName, int score)
    {
        PlayerPrefs.SetInt(userName, score);
        PlayerPrefs.Save();
    }
}
