using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int Coins;
    public Text CoinsText;

    public void AddCoin()
    {
        Coins += 1;
        CoinsText.text = "Собрали: " + Coins.ToString() + " монет";
    }
}
