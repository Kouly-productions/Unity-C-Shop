using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shop Item", menuName = "Shop Item")]
public class ShopItems : ScriptableObject
{
    public string description;
    public string title;

    public Sprite artwork;

    public int price;
}

