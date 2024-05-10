using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            print("Pulso espacio");
            ScorePersistenceManagerFactory.GetInstance().StoreScore("nombre",10);
        }
    }
}
