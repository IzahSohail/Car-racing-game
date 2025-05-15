using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LapManager : MonoBehaviour
{
    public int lapCount = 0;
    public int maxLaps = 3;
    public TMP_Text lapText;
    public GameObject gameOverPanel;

    private bool raceEnded = false;
    private bool raceStarted = false;
    private bool passedMidpoint = false;

    void Start()
    {
        lapText.text = "Lap: " + lapCount + "/" + maxLaps;
    }

    public void OnTriggerEnter(Collider other)
    {
        // Get named references (optional but not necessary here)
        GameObject detector = GameObject.FindGameObjectWithTag("Player");
        GameObject lapTrigger = GameObject.Find("LapTrigger");
        GameObject MidPointTrigger = GameObject.Find("MidpointTrigger");
        GameObject MidPointTriggerAlt = GameObject.Find("MidpointTriggerAlt");

        Debug.Log("This object: " + gameObject.name);
        Debug.Log("Other object: " + other.name);

        // Log when the CollisionDetector hits LapTrigger
        if (other.gameObject.name == "LapTrigger")
        {
            Debug.Log("Car's CollisionDetector collided with LapTrigger");
        }

        // If car hits a midpoint
        if (other.gameObject.name == "MidpointTrigger" || other.gameObject.name == "MidpointTriggerAlt")
        {
            Debug.Log("Collision detected with: " + other.gameObject.name);
            passedMidpoint = true;
        }

        // If car hits lap trigger after hitting midpoint
        if (other.gameObject.name == "LapTrigger" && passedMidpoint)
        {
            lapCount++;
            passedMidpoint = false;
            Debug.Log("Lap incremented! New lap count: " + lapCount);

            // Optional: update UI if you have a lap text field
            if (lapText != null)
            {
                lapText.text = "Lap: " + lapCount + "/" + maxLaps;
            }

            // Check for race end
            if (lapCount >= maxLaps)
            {
                raceEnded = true;
                Debug.Log("Race Finished!");
                if (gameOverPanel != null) gameOverPanel.SetActive(true);
            }
        }
    }


    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
