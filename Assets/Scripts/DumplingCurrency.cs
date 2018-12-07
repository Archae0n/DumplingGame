using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DumplingCurrency : MonoBehaviour
{
    public static float dumplingCurrency;

    public Text dumplingCurrencyText;
    public Text dumplingCurrencyText2;

    void Update()
    {
        dumplingCurrencyText.text = dumplingCurrency.ToString();
        dumplingCurrencyText2.text = dumplingCurrency.ToString();
    }
    //This is so that the money that the player earn can exchange this for dumpling currency
    //which they will use to upgrade their dumplings to earn more money.
    //Will at least four button. That way they don't need to click on one button for just one dumpling
    // if they have too much money already
    public void DumplingCurrency1()
    {
        if (Earning.money >= 1000)
        {
            Earning.money -= 1000;
            dumplingCurrency += 1;
        }
    }

    public void DumplingCurrency10()
    {
        if (Earning.money >= 10000)
        {
            Earning.money -= 10000;
            dumplingCurrency += 1;
        }
    }

    public void DumplingCurrency100()
    {
        if (Earning.money >= 100000)
        {
            Earning.money -= 100000;
            dumplingCurrency += 1;
        }
    }

    public void DumplingCurrency1000()
    {
        if (Earning.money >= 1000000)
        {
            Earning.money -= 1000000;
            dumplingCurrency += 1000;
        }
    }
}
