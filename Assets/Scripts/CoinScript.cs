using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    [SerializeField] int coinAmount;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            GameManager.gameInstance.Display(coinAmount);
            Destroy(gameObject);
        }

    }
}
