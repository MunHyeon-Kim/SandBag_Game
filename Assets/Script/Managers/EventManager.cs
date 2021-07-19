using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour
{

    public void GameEnding()
    {
        if (Counter.counter > Counter2.counter)
        {
            SceneManager.LoadScene("1pWins");
        }
        else if (Counter.counter < Counter2.counter)
        {
            SceneManager.LoadScene("2pWins");
        }
        else
        {
            Timer._Timer += (float)10.0;
        }

    }
    
}
