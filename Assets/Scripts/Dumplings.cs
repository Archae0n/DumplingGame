using UnityEngine;
using UnityEngine.UI;

public class Dumplings : MonoBehaviour
{

    public GameObject dumplingScreen;

    public BossButton money;

    public BossButton timer;

    public float change;

    //Dealing with the text
    public Text costText;

    public Text upgradedLevelText;

    public Text quickCostText;

    public Text quickLevelText;

    public Text bigCostText;

    public Text bigLevelText;

    public Text queenCostText;

    public Text queenLevelText;

    //dumpling bonuses and cost
    #region cost bonus
    float upgradeBonus = 250;

    float upgradeCost = 500;

    float upgradeTimeChange = 4;

    float quickBonus = 200;

    float quickCost = 1000;

    float quickTimeChange = 2;

    float bigBonus = 750;

    float bigCost = 1500;

    float bigTimeChange = 30;

    float queenBonus = 2500000;

    float queenCost = 5000000;

    float queenTimeChange = 60;
    #endregion

    //setting up a leveling system for the dumplings
    int upgradedLevel;

    int quickLevel;

    int bigLevel;

    int queenLevel;

    float costMulti = 1.75f;

    float bonusUpgrade = 2;

    float timeLowered = 0.9f;

    void Update()
    {
        //costText.text = cost.ToString();
        upgradedLevelText.text = upgradedLevel.ToString();
        quickLevelText.text = quickLevel.ToString();
        bigLevelText.text = bigLevel.ToString();
        quickLevelText.text = quickLevel.ToString();
    }

    public void OpeningDumplingScreen()
    {
        dumplingScreen.SetActive(true);
    }

    public void ExitDumplingScreen()
    {
        dumplingScreen.SetActive(false);
    }


    public void UpgradedDumpling()
    {
        change = upgradeTimeChange;

        if (Earning.money >= upgradeCost)
        {
            Earning.money -= upgradeCost;
            money.reward = upgradeBonus;
            timer.maxTimer = upgradeTimeChange;
            timer.timer = change;
            upgradedLevel += 1;
            upgradeCost = upgradeCost * costMulti;
            upgradeBonus = upgradeBonus * bonusUpgrade;
            upgradeTimeChange = upgradeTimeChange * timeLowered;
        }
        
        if (upgradedLevel >= 10)
        {
            upgradedLevel = 10;
            upgradeCost = 0;
        }

        if (upgradeBonus >= 128000)
        {
            upgradeBonus = 135000;
        }

        if (upgradeTimeChange <= 1.6)
        {
            upgradeTimeChange = 1.5f;
        }
        
        costText.text = upgradeCost.ToString("C0");

    }

    public void QuickDumpling()
    {
        change = quickTimeChange;

        if (Earning.money >= quickCost)
        {
            Earning.money -= quickCost;
            money.reward = quickBonus;
            timer.maxTimer = quickTimeChange;
            timer.timer = change;
            quickLevel += 1;
            quickCost = quickCost * costMulti;
            quickBonus = quickBonus * bonusUpgrade;
            quickTimeChange = quickTimeChange * timeLowered;
        }
        else
        {
            return;
        }
        
        if (quickTimeChange <= 0.8f)
        {
            quickTimeChange = 0.5f;
        }

        if (quickBonus >= 102400)
        {
            quickBonus = 125000;
        }

        if (quickLevel >= 10)
        {
            quickLevel = 10;
            quickCost = 0;
        }
        
        quickCostText.text = quickCost.ToString("C0");

    }

    public void BigDumpling()
    {
        change = bigTimeChange;

        if (Earning.money >= bigCost)
        {
            Earning.money -= bigCost;
            money.reward = bigBonus;
            timer.maxTimer = bigTimeChange;
            timer.timer = change;
            bigLevel += 1;
            bigCost = bigCost * costMulti;
            bigBonus = bigBonus * bonusUpgrade;
            bigTimeChange = bigTimeChange * timeLowered;
        }
        else
        {
            return;
        }
        
        if (bigTimeChange <= 12)
        {
            bigTimeChange = 10;
        }

        if (bigBonus >= 380000)
        {
            bigBonus = 500000;
        }

        if (bigLevel >= 10)
        {
            bigLevel = 10;
            bigCost = 0;
        }
        
        bigCostText.text = bigCost.ToString("C0");
    }

    public void QueenDumpling()
    {
        change = queenTimeChange;

        if (Earning.money >= queenCost)
        {
            Earning.money -= queenCost;
            money.reward = queenBonus;
            timer.maxTimer = queenTimeChange;
            timer.timer = change;
            queenLevel += 1;
            queenCost = queenCost * costMulti;
            queenBonus = queenBonus * bonusUpgrade;
            queenTimeChange = queenTimeChange * timeLowered;
        }
        else
        {
            return;
        }
        
        if (queenTimeChange <= 24)
        {
            queenTimeChange = 20;
        }

        if (queenBonus >= 1270000000)
        {
            queenBonus = 1500000000;
        }

        if (queenLevel >= 10)
        {
            queenLevel = 10;
            queenCost = 0;
        }
        
        queenCostText.text = queenCost.ToString("C0");
    }
}
