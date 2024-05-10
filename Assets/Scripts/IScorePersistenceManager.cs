using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IScorePersistenceManager 
{
    public void StoreScore(string userName, int score);
    public int ReadScore(string userName);
    public void StorePlayerName(string userName);
    public string ReadPlayerName();
}
