using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsSaves : MonoBehaviour
{
    public Earning earning;
    public Text workersNY;
    public GameObject newYork;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("Money"))
        {
            Earning.money = PlayerPrefs.GetFloat("Money");
        }
        else
        {
            Earning.money = 0f;
        }
        if (PlayerPrefs.HasKey("WorkerLevel"))
        {
            earning.buttonLevel = PlayerPrefs.GetInt("WorkerLevel");
        }
    }

    private void Update()
    {
        
    }

}
