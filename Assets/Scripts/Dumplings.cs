using UnityEngine;
using UnityEngine.UI;

public class Dumplings : MonoBehaviour
{

    public GameObject dumplingScreen;

    //public Earning earning;

    public BossButton money;

    public float bonus;

    [System.Serializable]
    public class DumplingsClass
    {
        public string name;
        public GameObject game;
        public int cost;
        public float bonus;
    }

    public DumplingsClass [] dumplings;

    public void OpeningDumplingScreen()
    {
        dumplingScreen.SetActive(true);
    }

    public void ExitDumplingScreen()
    {
        dumplingScreen.SetActive(false);
    }

    public void NormalDumpling()
    {

    }

    public void UpgradedDumpling()
    {
        bonus = 10;

        money.reward = bonus;
    }

    public void QuickDumpling()
    {
        bonus = 5;

        money.reward = bonus;
    }

    public void BigDumpling()
    {
        bonus = 50;

        money.reward = bonus;
    }

    public void QueenDumpling()
    {
        bonus = 200;

        money.reward = bonus;
    }
}
