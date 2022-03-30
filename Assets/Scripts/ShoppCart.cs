using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShoppCart : MonoBehaviour
{
    [Header("Texts")]
    [SerializeField] private TextMeshProUGUI itemPriceText;
    [SerializeField] private TextMeshProUGUI itemNameText;
    [Header("Values ")]
    [SerializeField] private int itemPrice;
    [SerializeField] private int itemLevelMax =5;
    [SerializeField] private int itemLevel;

    public enum ShoppCarts
    {
        placeHolder,
        strongerOars

    }

    public ShoppCarts items;
    // Start is called before the first frame update
    void Awake()
    {
        UpdateItemUI();
    }

    public GameObject newDisplay;
    public GameObject oldDisplay;
    public void BuyItems()
    {
        if(GameManager.gameInstance.ReturnCurrent()>= itemPrice)
        {

            GameManager.gameInstance.Display(-itemPrice);

            gameObject.SetActive(false);
            newDisplay.SetActive(true);
            oldDisplay.SetActive(false);
        }

         else if( GameManager.gameInstance.ReturnCurrent()<=itemPrice)
        {


            GameManager.gameInstance.noMoney.SetActive(true);
           

            
        }

    }
    private void UpdateItemUI()
    {

        itemLevel = PlayerPrefs.GetInt(items.ToString());
        itemNameText.text = "Lv " + itemLevel;
        itemPriceText.text = " Price " + itemPrice;

        if(itemLevel == itemLevelMax)
        {
            itemNameText.text = "Max Lv" + "Boat";
            itemPriceText.text = "0";
        }

    }
}
