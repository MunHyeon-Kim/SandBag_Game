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
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
             counter ++;
}

        if (Input.GetKeyDown(KeyCode.S))
        {
             counter++;
        }

        countText.text = "Á¡¼ö : " + counter;
    }
}
