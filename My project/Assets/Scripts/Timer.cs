using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Timer : MonoBehaviour
{
    public string levelToLoad;
    public float timer = 10f;
    private TextMeshProUGUI timerSeconds;
 
    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");
        if (timer <= 0)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
