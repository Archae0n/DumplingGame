using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchasePlace : MonoBehaviour
{
    int africaCost = 25000;
    int franceCost = 1000000;
    int tokyoCost = 500000000;

    public GameObject unlock;

    //to make the player purchase different places
    public void Africa()
    {

        if (Earning.money >= africaCost)
        {
            Earning.money -= africaCost;
            unlock.SetActive(true);
            Destroy(gameObject);
        }

    }

    public void France()
    {

        if (Earning.money >= franceCost)
        {
            Earning.money -= franceCost;
            unlock.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void Tokyo()
    {

        if (Earning.money >= tokyoCost)
        {
            Earning.money -= tokyoCost;
            unlock.SetActive(true);
            Destroy(gameObject);
        }
    }

}
