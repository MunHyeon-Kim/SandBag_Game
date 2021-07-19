using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{

    public static float _Timer = (float)60.0;
    public Text countText;



    void Start()
    {
        countText.text = " " + _Timer;
    }


    void Update()
    {
        if (_Timer >= 0)
        {
            _Timer -= Time.deltaTime;
            int _Timer2 = (int)_Timer;
            countText.text = " " + _Timer2;
        }
        else {
            EventManager eventManager = new EventManager();
            eventManager.GameEnding();
        }


    }
}
