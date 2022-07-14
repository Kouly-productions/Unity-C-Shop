using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inputcoin : MonoBehaviour
{
    public ShopManagerScript shop;
    public TMP_InputField coinInput;
    public GameObject plane;
    int value;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Shop.coins is : " + shop.coins);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void confirmMoney()
    {
    }

}
