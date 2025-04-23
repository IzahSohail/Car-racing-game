using TMPro;
using UnityEngine;

public class LapManager : MonoBehaviour
{
    public int lapCount = 0;
    public TMP_Text lapText;

    public void CheckLapTrigger(Collider other)
    {
        if (other.CompareTag("LapTrigger"))
        {
            lapCount++;
            lapText.text = "Lap Count: " + lapCount;
            Debug.Log("Lap updated to " + lapCount);
        }
    }
}
