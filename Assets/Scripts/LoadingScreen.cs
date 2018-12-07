using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public Slider loadSlider;

    public int loadTimer = 0;

    public int refreshLoadTime = 0;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine("LoseTime");
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            loadTimer++;
            if (loadTimer >= 5)
            {
                StopCoroutine("LoseTime");
                loadTimer = refreshLoadTime;
                StartGame();
            }
        }

    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update ()
    {
        loadSlider.value = loadTimer;
	}
}
