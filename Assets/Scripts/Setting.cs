using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{

    public GameObject settingScreen;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void SettingScreen()
    {
        settingScreen.SetActive(true);
    }

    public void ExitSetting()
    {
        settingScreen.SetActive(false);
    }
}
