using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseButton : MonoBehaviour
{
    
	public void Buy1_99()
    {
        Purchase.Instance.Buy1_99();
    }

    public void Buy14_99()
    {
        Purchase.Instance.Buy14_99();
    }

    public void Buy49_99()
    {
        Purchase.Instance.Buy49_99();
    }

    public void Buy79_99()
    {
        Purchase.Instance.Buy79_99();
    }

    public void Buy144_99()
    {
        Purchase.Instance.Buy144_99();
    }

    public void Buy299_99()
    {
        Purchase.Instance.Buy299_99();
    }
    
}
