using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public Text upgradeLevel;

    public Text incomeLevel;

    public Text costText;

    float cost = 100;

    int upgradeButtonLevel;

    float costMulti = 1.15f;

    public float incomeAmount = 1;

    float incomeMulti = 1.1f;

    public float money;

    void Update()
    {
        upgradeLevel.text = upgradeButtonLevel.ToString();
        incomeLevel.text = ( "x" + incomeAmount.ToString("F0"));
        costText.text = cost.ToString("C0");
        money = Earning.money;
    }

    public void UpgradeClicking()
    {
        if (Earning.money >= cost)
        {
            Earning.money -= cost;
            upgradeButtonLevel += 1;
            cost = cost * costMulti;
            incomeAmount = incomeAmount * incomeMulti;
        }
    }
}
