using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  
using System.Collections;          

public class GameTimer : MonoBehaviour
{
    public Text timerText;
    public float timeRemaining = 360; 

    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
            StartCoroutine(RestartAfterDelay(5)); 
        }
    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private IEnumerator RestartAfterDelay(float delay)
    {
       
        Time.timeScale = 0;
        timerText.text = "Time's up! Restarting...";

       
        yield return new WaitForSecondsRealtime(delay);

       
        Time.timeScale = 1;
        SceneManager.LoadScene("07-Prototype3");
    }
}
