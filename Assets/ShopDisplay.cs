using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShopDisplay : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AudioSource pay;
    public ShopItems shopItems;
    private Money moneys;

    private int mon;

    public Text titleText;
    public Text tescriptionText;

    public Image artworkImage;

    public Text priceText;
    private bool hasEntered = false;


    public GameObject gameobjectDiscBox;
    void Start()
    {
        titleText.text = shopItems.title;
        tescriptionText.text = "";

        artworkImage.sprite = shopItems.artwork;

        priceText.text = shopItems.price.ToString();
    }

    private void Update()
    {
        if (hasEntered == true && Input.GetMouseButton(0))
        {
        }
    }
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        hasEntered = true;
        tescriptionText.text = shopItems.description;
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        hasEntered = false;
        tescriptionText.text = "";
    }
    public void purchase()
    {
        if (mon < shopItems.price)
        {
           pay.Play();
        }
    }
}
