﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BossButton : MonoBehaviour
{
    public enum State {Reward, Waiting, Nothing};

    public Text waitTime;

    public Text timertext;

    public Text rewardText;

    public State bossState = State.Nothing;

    public float reward = 5;

    public UpgradeButton incomeLevel;

    public float timer;

    public float maxTimer = 3;

    public Slider waitTimer;

    void Update()
    {
        timertext.text = timer.ToString("F2");
        rewardText.text = reward.ToString("C0");
        waitTimer.value = timer;
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
            Earning.money += bonus;
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
            if (timer < 0)
            {
                StopCoroutine("LoseTime");
                bossState = State.Reward;
                Reward();
            }
        }
        
    }
}
