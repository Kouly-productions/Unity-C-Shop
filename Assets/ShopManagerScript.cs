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

    public TMP_InputField coinInput;
    public GameObject plane;

    [SerializeField]
    private IntSO cashSO;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < shopItemsSO.Length; i++)
            shopPanelsGO[i].SetActive(true);
        coinUI.text = "Penge: " + cashSO.Value.ToString();
        LoadPanels();
        CheckPurchasable();
    }

    private void Update()
    {
        
    }

    public void SetCoins()
    {
        string inputmoney = coinInput.text;
        cashSO.Value = int.Parse(inputmoney);
        //coins = int.Parse(inputmoney);

        coinUI.text = "Penge: " + inputmoney;

        CheckPurchasable();

        plane.SetActive(false);
    }

    public void AddCoins()
    {
        cashSO.Value++;
        coinUI.text = "Penge: " + cashSO.Value.ToString();
        CheckPurchasable();
    }

    public void CheckPurchasable()
    {
        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            if (cashSO.Value >= shopItemsSO[i].BaseCost) // If I have enough money
                myPurchaseBtns[i].interactable = true;
            else
                myPurchaseBtns[i].interactable = false;
        }
    }

    public void PurchaseItem(int btnNo)
    {
        if (cashSO.Value >= shopItemsSO[btnNo].BaseCost)
        {
            cashSO.Value = cashSO.Value - shopItemsSO[btnNo].BaseCost;
            coinUI.text = "Penge: " + cashSO.Value.ToString();
            CheckPurchasable();
        }
    }

    public void LoadPanels()
    {
        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            shopPanels[i].titleTxt.text = shopItemsSO[i].title;
            shopPanels[i].descriptionTxt.text = shopItemsSO[i].description;
            shopPanels[i].costTxt.text = "Pris: " + shopItemsSO[i].BaseCost.ToString();
        }
    }
}
