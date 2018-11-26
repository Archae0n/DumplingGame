using UnityEngine;
using UnityEngine.UI;

public class Earning : MonoBehaviour
{
    public Text currency;

    public Text costText;

    public UpgradeButton incomeLevel;

    int buttonLevel;

    public static float money;

    public Text buttonLevelText;

    float cost = 10;

    float costMultiplier = 1.3f;

    void Update()
    {
        float bonus = buttonLevel * incomeLevel.incomeAmount;
        currency.text = money.ToString("C0");

        costText.text = cost.ToString("C0");

        buttonLevelText.text = buttonLevel.ToString();

        money += Time.deltaTime * bonus;
    }

    public void ButtonLevel()
    {
        if (money >= cost)
        {
            money -= cost;
            buttonLevel += 1;
            cost = cost * costMultiplier;
        
        }
        
    }
	
}
