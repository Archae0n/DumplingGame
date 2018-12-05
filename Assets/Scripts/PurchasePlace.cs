using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchasePlace : MonoBehaviour
{
    public int cost;

    public GameObject unlock;

    //to make the player purchase different places
    public void Africa()
    {
        cost = 25000;

        if (Earning.money >= cost)
        {
            Earning.money -= cost;
            unlock.SetActive(true);
            Destroy(gameObject);
        }

    }

    public void France()
    {
        cost = 1000000;

        if (Earning.money >= cost)
        {
            Earning.money -= cost;
            unlock.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void Tokyo()
    {
        cost = 500000000;

        if (Earning.money >= cost)
        {
            Earning.money -= cost;
            unlock.SetActive(true);
            Destroy(gameObject);
        }
    }

}
