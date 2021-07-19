using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter2 : MonoBehaviour
{

    public static int counter;
    public Text countText;



    void Start()
    {
        Managers.Input.KeyAction -= OnKeyBoard;
        Managers.Input.KeyAction += OnKeyBoard;
    }


    void OnKeyBoard()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            counter++;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            counter++;
        }

        countText.text = "Á¡¼ö : " + counter;
    }
}