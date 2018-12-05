using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DumplingCurrency : MonoBehaviour
{
    public float dumplingCurrency;

    public Text dumplingCurrencyText;
    public Text dumplingCurrencyText2;

    void Update()
    {
        dumplingCurrencyText.text = dumplingCurrency.ToString();
        dumplingCurrencyText2.text = dumplingCurrency.ToString();
    }

    public void DumplingCurrency1()
    {
        if (Earning.money >= 1000)
        {
            Earning.money -= 1000;
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
