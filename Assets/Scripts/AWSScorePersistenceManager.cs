using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class AWSScorePersistenceManager : IScorePersistenceManager
{
    public string ReadPlayerName()
    {
        throw new System.NotImplementedException();
    }

    public int ReadScore(string userName)
    {
        Debug.Log("Reading en AWS");
        return 0;
    }

    public void StorePlayerName(string userName)
    {
        throw new System.NotImplementedException();
    }

    public void StoreScore(string userName, int score)
    {
        Debug.Log("Storing en AWS");
    }

}
