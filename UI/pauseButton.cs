using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseButton : MonoBehaviour
{
    public PauseMenu pauseMenu;

    private void Start()
    {
        // �{�^�����N���b�N�������ɌĂяo�����\�b�h��o�^
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        // PauseMenu��\������
        pauseMenu.Toggle();
    }
}
