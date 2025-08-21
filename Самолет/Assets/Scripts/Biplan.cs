using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biplan : MonoBehaviour
{
    public int Health;
    public CoinCounter CoinCounter;
    
    private void OnTriggerEnter(Collider other)
    {
        Bomb bomb = other.gameObject.GetComponent<Bomb>();
        if (bomb)
        {
            Health -= 1;
            if (Health <= 0)
            {
                Destroy(gameObject);
            }
            bomb.Die();
        }
        
        Coin coin = other.gameObject.GetComponent<Coin>();
        if (coin)
        { 
            coin.Die();
            CoinCounter.AddCoin();
        }
    }
}
