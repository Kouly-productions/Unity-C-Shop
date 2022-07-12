using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shop Item", menuName = "Scriptable Objects/Shop Item", order = 1)]
public class ShopItemsSO : ScriptableObject
{
    public string title;
    public string description;
    public Sprite artwork;
    public int BaseCost;
}
