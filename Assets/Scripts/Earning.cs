using UnityEngine;
using UnityEngine.UI;

public class Earning : MonoBehaviour
{
    public Text currency;

    public Text costText;

    public UpgradeButton incomeLevel;

    public int buttonLevel;

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
        if (PlayerPrefs.HasKey("WorkerLevel"))
        {
            buttonLevel = PlayerPrefs.GetInt("WorkerLevel");
        }
        else
        {
            buttonLevel = 0;
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
        PlayerPrefs.SetInt("WorkerLevel", buttonLevel);
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
        if (money >= 1000000000)
        {
            currency.text = (money * 0.000000001f).ToString("C2") + "B";

            if (money >= 1000000000000)
            { 
                currency.text = (money * 0.000000000001f).ToString("C2") + "T";

                if (money >= 1000000000000000)
                {
                    currency.text = (money * 0.000000000000001f).ToString("C2") + "Qa";

                    if (money >= 1000000000000000000)
                    {
                        currency.text = (money * 0.000000000000000001f).ToString("C2") + "Qi";
                    }
                }
            }
        }
    }
    
}
