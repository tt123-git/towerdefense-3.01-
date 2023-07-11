using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 400;

    public static int Lives;
    public int startLives = 20;
    //public Text roundsText;

    public static int Rounds;

    void Start()
    {
        Money = startMoney;
        Lives = startLives;

        Rounds = 0;
    }
    /*Rounds
    void OnEnable()
    {
        roundsText.text = Rounds.ToString();
        Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaaaa");
    }
    */
}
