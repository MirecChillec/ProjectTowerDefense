using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{
    public int money;
    public int basicCost;
    public int generatorCost;
    public int tankCost;
    public int sniperCost;

    public TextMeshProUGUI mainMoneyText;

    public void Start()
    {
        money = 100;
    }

    private void Update()
    {
        mainMoneyText.text = money.ToString();
    }
}
