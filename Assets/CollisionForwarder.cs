using UnityEngine;

public class CollisionForwarder : MonoBehaviour
{
    public LapManager lapManager;

    void OnTriggerEnter(Collider other)
    {
        if (lapManager != null)
        {
            lapManager.CheckLapTrigger(other);
        }
    }
}
