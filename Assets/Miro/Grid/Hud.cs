using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hud : MonoBehaviour
{
    public string towerType;

    public Money money;

    public GameObject generatorPic;
    public GameObject basicTowerPic;
    public GameObject tankTowerPic;
    public GameObject sniperTowerPic;

    public TextMeshProUGUI generatorMoneyText;
    public TextMeshProUGUI basicMoneyText;
    public TextMeshProUGUI tankMoneyText;
    public TextMeshProUGUI sniperMoneyText;

    public GameObject generatorTooltip;
    public GameObject basicTooltip;
    public GameObject sniperTooltip;
    public GameObject tankTooltip;

    private void Start()
    {
        money = GameObject.Find("Money").GetComponent<Money>();

        generatorMoneyText.text = money.generatorCost.ToString();
        basicMoneyText.text = money.basicCost.ToString();
        tankMoneyText.text = money.tankCost.ToString();
        sniperMoneyText.text = money.sniperCost.ToString();

        generatorTooltip.GetComponentInChildren<TMP_Text>().text = generatorMoneyText.text;
        basicTooltip.GetComponentInChildren<TMP_Text>().text = basicMoneyText.text;
        tankTooltip.GetComponentInChildren<TMP_Text>().text = tankMoneyText.text;
        sniperTooltip.GetComponentInChildren<TMP_Text>().text = sniperMoneyText.text;
    }

    public void BringOutTowerImage()
    {
        if (towerType == "Generator" && money.money>=money.generatorCost)
        {
            money.money -= money.generatorCost;
            Instantiate(generatorPic, Input.mousePosition, new Quaternion(0, 0, 0, 0), GameObject.FindGameObjectWithTag("Canvas").transform);
        }
        else if(towerType == "Basic Tower" && money.money>= money.basicCost)
        {
            money.money -= money.basicCost;
            Instantiate(basicTowerPic, Input.mousePosition, new Quaternion(0, 0, 0, 0), GameObject.FindGameObjectWithTag("Canvas").transform);
        }
        else if(towerType == "Tank Tower" && money.money>= money.tankCost)
        {
            money.money -= money.tankCost;
            Instantiate(tankTowerPic, Input.mousePosition, new Quaternion(0, 0, 0, 0), GameObject.FindGameObjectWithTag("Canvas").transform);
        }
        else if(towerType=="Sniper Tower" && money.money>= money.sniperCost)
        {
            money.money -= money.sniperCost;
            Instantiate(sniperTowerPic, Input.mousePosition, new Quaternion(0, 0, 0, 0), GameObject.FindGameObjectWithTag("Canvas").transform);
        }
    }
}
