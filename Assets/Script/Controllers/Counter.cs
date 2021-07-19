using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.A))
        {
             counter ++;
}

        if (Input.GetKeyDown(KeyCode.S))
        {
             counter ++;
        }

        countText.text = "Á¡¼ö : " + counter;
    }
}
