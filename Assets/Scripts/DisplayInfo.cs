using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayInfo : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinText;
    int dcoins=0;
    // Start is called before the first frame update
    void Start()
    {
        dcoins = GameManager.gameInstance.dCoins();
        if (dcoins == 0)
            dcoins = 0;
        else
        {
            coinText.text = "" + dcoins;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
