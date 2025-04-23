using UnityEngine;
using UnityStandardAssets.Utility;

public class AICarFollow : MonoBehaviour
{
    public WaypointCircuit circuit;
    public float speed = 80f;
    public float turnSpeed = 30f;
    private int currentWaypointIndex = 0;
    private Transform[] waypoints;

    void Start()
    {
        waypoints = new Transform[circuit.Waypoints.Length];
        for (int i = 0; i < circuit.Waypoints.Length; i++)
        {
            waypoints[i] = circuit.Waypoints[i];
        }
    }

    void Update()
    {
        if (waypoints.Length == 0) return;

        Transform target = waypoints[currentWaypointIndex];
        Vector3 direction = target.position - transform.position;
        Vector3 moveDir = direction.normalized;

        // Move the AI car
        transform.position += moveDir * speed * Time.deltaTime;

        // Rotate toward the target waypoint
        Quaternion toRotation = Quaternion.LookRotation(moveDir);
        transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, turnSpeed * Time.deltaTime);

        // Switch to next waypoint if close
        if (direction.magnitude < 3f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }
}
