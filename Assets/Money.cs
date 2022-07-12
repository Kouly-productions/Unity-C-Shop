using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public int money = 0;
    public Text currentMoneyShow;
    // Start is called before the first frame update
    void Start()
    {
        currentMoneyShow.text = money.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
