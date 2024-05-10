using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePersistenceManagerFactory
{
    private static IScorePersistenceManager manager = 
        new AWSScorePersistenceManager();
    public static IScorePersistenceManager GetInstance()
    {
        return manager;
    }
}
