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
            countText.text = " " + _Timer;
        }
        else { 

            //결과화면이동 
        }


    }
}
