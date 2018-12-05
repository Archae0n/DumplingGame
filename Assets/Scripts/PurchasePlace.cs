using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchasePlace : MonoBehaviour
{
    public int cost;

    //to make the player purchase different places
	public void Africa()
    {
        cost = 25000;

        if (Earning.money >= cost)
        {
            Earning.money -= cost;
            Destroy(gameObject);
        }
            
    }

}
