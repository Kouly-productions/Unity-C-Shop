using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManagerScript : MonoBehaviour
{
    public int coins;
    public TMP_Text coinUI;
    public ShopItemsSO[] shopItemsSO;
    public GameObject[] shopPanelsGO;
    public ShopTemplate[] shopPanels;
    public Button[] myPurchaseBtns;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < shopItemsSO.Length; i++)
            shopPanelsGO[i].SetActive(true);
        coinUI.text = "Penge: " + coins.ToString();
        LoadPanels();
        CheckPurchasable();
    }

    private void Update()
    {
        
    }

    public void AddCoins()
    {
        coins++;
        coinUI.text = "Penge: " + coins.ToString();
        CheckPurchasable();
    }

    public void CheckPurchasable()
    {
        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            if (coins >= shopItemsSO[i].BaseCost) // If I have enough money
                myPurchaseBtns[i].interactable = true;
            else
                myPurchaseBtns[i].interactable = false;
        }
    }

    public void PurchaseItem(int btnNo)
    {
        if (coins >= shopItemsSO[btnNo].BaseCost)
        {
            coins = coins - shopItemsSO[btnNo].BaseCost;
            coinUI.text = "Penge: " + coins.ToString();
            CheckPurchasable();
        }
    }

    public void LoadPanels()
    {
        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            shopPanels[i].titleTxt.text = shopItemsSO[i].title;
            shopPanels[i].descriptionTxt.text = shopItemsSO[i].description;
            shopPanels[i].costTxt.text = "Coins: " + shopItemsSO[i].BaseCost.ToString();
        }
    }
}
