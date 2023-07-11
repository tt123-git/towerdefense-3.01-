using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseButton : MonoBehaviour
{
    public PauseMenu pauseMenu;

    private void Start()
    {
        // ボタンをクリックした時に呼び出すメソッドを登録
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        // PauseMenuを表示する
        pauseMenu.Toggle();
    }
}
