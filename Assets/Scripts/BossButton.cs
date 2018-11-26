using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BossButton : MonoBehaviour
{
    public enum State {Reward, Waiting, Nothing};

    public Text waitTime;

    public Text timertext;

    public State bossState = State.Nothing;

    public float reward = 5;

    public Earning earning;

    public UpgradeButton incomeLevel;

    public int timer;

    public int maxTimer = 3;

    void Update()
    {
        timertext.text = timer.ToString();
    }


    public void BossClicking ()
    {

        if(bossState == State.Nothing)
        {
            bossState = State.Waiting;
            Waiting();
        }
    }

    void Waiting()
    {
        if (bossState == State.Waiting)
        {
            StartCoroutine("LoseTime");
        }
    }

    void Reward()
    {

        if(bossState == State.Reward)
        {
            float bonus = reward * incomeLevel.incomeAmount;
            earning.money += bonus;
            timer = maxTimer;
            bossState = State.Nothing;
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timer --;
            if (timer == 0)
            {
                StopCoroutine("LoseTime");
                bossState = State.Reward;
                Reward();
            }
        }
        
    }
}
