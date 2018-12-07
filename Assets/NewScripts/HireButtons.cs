using UnityEngine;
using UnityEngine.UI;

public class HireButtons : MonoBehaviour
{
    public Text newYorkWorkerLevelText;
    UpgradeButton incomeLevel;
    float newYorkCost;
    float newYorkCostMultiplier = 1.15f;
    int newYorkWorkerLevel;

    void Update()
    {
        float bonus = newYorkWorkerLevel * incomeLevel.incomeAmount;
        newYorkWorkerLevelText.text = newYorkWorkerLevel.ToString();
    }

    public void NYWorkerLevel()
    {
        if (Earning.money >= newYorkCost)
        {
            Earning.money -= newYorkCost;
            newYorkWorkerLevel += 1;
            newYorkCost = newYorkCost * newYorkCostMultiplier;
        }
    }
}
public class AfricaHireButton : MonoBehaviour
{
    public Text africaWorkerLevelText;
    UpgradeButton incomeLevel;
    float africaCost;
    float africaCostMultiplier = 1.15f;
    int africaWorkerLevel;

    void Update()
    {
        float bonus = africaWorkerLevel * incomeLevel.incomeAmount;
        africaWorkerLevelText.text = africaWorkerLevel.ToString();
    }

    public void AfricaWorkerLevel()
    {
        if (Earning.money >= africaCost)
        {
            Earning.money -= africaCost;
            africaWorkerLevel += 1;
            africaCost = africaCost * africaCostMultiplier;
        }

    }
}
public class FranceHireButton : MonoBehaviour
{
    public Text franceWorkerLevelText;
    UpgradeButton incomeLevel;
    float franceCost;
    float franceCostMultiplier = 1.15f;
    int franceWorkerLevel;

    void Update()
    {
        float bonus = franceWorkerLevel * incomeLevel.incomeAmount;
        franceWorkerLevelText.text = franceWorkerLevel.ToString();
    }

    public void FranceWorkerLevel()
    {
        if (Earning.money >= franceCost)
        {
            Earning.money -= franceCost;
            franceWorkerLevel += 1;
            franceCost = franceCost * franceCostMultiplier;
        }
    }
}
public class TokyoHireButton : MonoBehaviour
{
    public Text tokyoWorkerLevelText;
    UpgradeButton incomeLevel;
    float tokyoCost;
    float tokyoCostMultiplier = 1.15f;
    int tokyoWorkerLevel;

    void Update()
    {
        float bonus = tokyoWorkerLevel * incomeLevel.incomeAmount;
        tokyoWorkerLevelText.text = tokyoWorkerLevel.ToString();
    }

    public void TokyoWorkerLeevl()
    {
        if (Earning.money >= tokyoCost)
        {
            Earning.money -= tokyoCost;
            tokyoWorkerLevel += 1;
            tokyoCost = tokyoCost * tokyoCostMultiplier;
        }
    }
}
