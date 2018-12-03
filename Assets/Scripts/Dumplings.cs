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

    public Text dumplingLevelText;

    //dumpling bonuses and cost
    #region cost bonus
    float upgradeBonus = 20;

    float upgradeCost = 250;

    float upgradeTimeChange = 4;

    float quickBonus = 10;

    float quickCost = 500;

    float quickTimeChange = 2;

    float bigBonus = 100;

    float bigCost = 1000;

    float bigTimeChange = 30;

    float queenBonus = 10000;

    float queenCost = 1000000;

    float queenTimeChange = 60;
    #endregion

    //setting up a leveling system for the dumplings
    int dumplingLevel;

    float costMulti = 1.1f;

    float bonusUpgrade = 2.5f;

    float timeLowered = 0.9f;

    void Update()
    {
        //costText.text = cost.ToString();
        dumplingLevelText.text = dumplingLevel.ToString();
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
            dumplingLevel += 1;
            upgradeCost = upgradeCost * costMulti;
            upgradeBonus = upgradeBonus * bonusUpgrade;
            upgradeTimeChange = upgradeTimeChange * timeLowered;
        }

        if(upgradeTimeChange <= 1)
        {
            upgradeTimeChange = 1;
        }

        if(upgradeBonus >= 100000)
        {
            upgradeBonus = 100000;
        }

        if(dumplingLevel >= 15)
        {
            dumplingLevel = 15;
            upgradeCost = 0;
        }

        costText.text = upgradeCost.ToString();
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
            dumplingLevel += 1;
            quickCost = quickCost * costMulti;
            quickBonus = quickBonus * bonusUpgrade;
            quickTimeChange = quickTimeChange * timeLowered;
        }
        else
        {
            return;
        }

        if (quickTimeChange <= 1)
        {
            quickTimeChange = 1;
        }

        if (quickBonus >= 100000)
        {
            quickBonus = 100000;
        }

        if (dumplingLevel >= 15)
        {
            dumplingLevel = 15;
            quickCost = 0;
        }

        costText.text = quickCost.ToString();

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
            dumplingLevel += 1;
            bigCost = bigCost * costMulti;
            bigBonus = bigBonus * bonusUpgrade;
            bigTimeChange = bigTimeChange * timeLowered;
        }
        else
        {
            return;
        }

        if (bigTimeChange <= 1)
        {
            bigTimeChange = 1;
        }

        if (bigBonus >= 100000)
        {
            bigBonus = 100000;
        }

        if (dumplingLevel >= 15)
        {
            dumplingLevel = 15;
            bigCost = 0;
        }

        costText.text = bigCost.ToString();
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
            dumplingLevel += 1;
            queenCost = queenCost * costMulti;
            queenBonus = queenBonus * bonusUpgrade;
            queenTimeChange = queenTimeChange * timeLowered;
        }
        else
        {
            return;
        }

        if (queenTimeChange <= 1)
        {
            queenTimeChange = 1;
        }

        if (queenBonus >= 100000)
        {
            queenBonus = 100000;
        }

        if (dumplingLevel >= 15)
        {
            dumplingLevel = 15;
            queenCost = 0;
        }

        costText.text = queenCost.ToString();
    }
}
