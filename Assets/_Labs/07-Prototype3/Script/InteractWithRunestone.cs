using UnityEngine;
using UnityEngine.UI;

public class InteractWithRunestone : MonoBehaviour
{
    public Text RunestonecounterText; 

    private int totalRunestones = 20;
    private int runestonesCollected = 0;

    private void Start()
    {
        UpdateRunestoneCounter();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Runestone"))
        {
            other.gameObject.SetActive(false);
            runestonesCollected++;
            UpdateRunestoneCounter();
            CheckCompletion();
        }
    }

    private void UpdateRunestoneCounter()
    {
        if (RunestonecounterText != null)
        {
            RunestonecounterText.text = "Collected Runestones: " + runestonesCollected + "/" + "20";
        }
    }

    private void CheckCompletion()
    {
        if (runestonesCollected >= totalRunestones)
        {
          
            if (RunestonecounterText != null)
            {
                RunestonecounterText.text = "Well done, hope you had fun!";
            }
        }
    }
}

