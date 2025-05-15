using TMPro;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    public Rigidbody playerRb;
    public TMP_Text speedText;

    void Update()
    {
        if (playerRb != null)
        {
            float speed = playerRb.velocity.magnitude * 3.6f; // m/s to km/h
            speedText.text = "Speed: " + speed.ToString("F1") + " km/h";
        }
    }
}
