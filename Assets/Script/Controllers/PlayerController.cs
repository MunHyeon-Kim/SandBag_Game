using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    void Start()
    {
        Managers.Input.KeyAction -= OnKeyBoard;
        Managers.Input.KeyAction += OnKeyBoard;
    }

        // 버튼 입력 최적화 
        // 옥눅의 추가사항 : 발차기를 눌러야 될때 발차기를 누르지 않으면 3초간 멈춤. 100회가 넘어가면 안뜨게둠 

    void OnKeyBoard() {

        if (Input.GetKeyDown(KeyCode.A))
        {
            Animator anim = GetComponent<Animator>();
            anim.Play("kick");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Animator anim = GetComponent<Animator>();
            anim.Play("punch");
        }

        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
