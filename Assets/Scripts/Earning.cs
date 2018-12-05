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

    float costMultiplier = 1.15f;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("Money"))
        {
            money = PlayerPrefs.GetFloat("Money");
        }
        else
        {
            money = 0f;
        }
    }

    void Update()
    {
        float bonus = buttonLevel * incomeLevel.incomeAmount;
        currency.text = money.ToString("C0");

        costText.text = cost.ToString("C0");

        buttonLevelText.text = buttonLevel.ToString();

        money += Time.deltaTime * bonus;

        MoneyCheck();

        PlayerPrefs.SetFloat("Money", money);
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

    public void MoneyCheck()
    {
        if (money >= 1000)
        {
            currency.text = (money * 0.001f).ToString("C2") + "Tho";

            if (money >= 1000000)
            {
                currency.text = (money * 0.000001f).ToString("C2") + "Mil";

                if (money >= 1000000000)
                {
                    currency.text = (money * 0.000000001f).ToString("C2") + "Bil";

                    if (money >= 1000000000000)
                    {
                        currency.text = (money * 0.000000000001f).ToString("C2") + "Tri";

                        if (money >= 1000000000000000)
                        {
                            currency.text = (money * 0.000000000000001f).ToString("C2") + "Qua";

                            if (money >= 1000000000000000000)
                            {
                                currency.text = (money * 0.000000000000000001f).ToString("C2") + "Qui";
                            }
                        }
                    }
                }
            }
        }
    }
	
}
