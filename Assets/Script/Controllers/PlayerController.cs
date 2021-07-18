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

        // ��ư �Է� ����ȭ 
        // ������ �߰����� : �����⸦ ������ �ɶ� �����⸦ ������ ������ 3�ʰ� ����. 100ȸ�� �Ѿ�� �ȶ߰Ե� 

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
