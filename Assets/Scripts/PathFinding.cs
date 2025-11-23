using UnityEngine;

public class PathFinding : MonoBehaviour
{
    [SerializeField] WaveConfigSO waveConfig;
    Transform[] waypoints;
    int waypointIndex = 0;

    void Start()
    {
        waypoints = waveConfig.GetWaypoints();
        transform.postion = waveConfig.GetStartingWaypoint().postion;
    }

    void Update()
    {
       FollowPath();   
    }

    void FollowPath()
    {
        
        if (waypointIndex < waypoints.Length)
        {
            Vector3 targetPosition = waypoints[waypointIndex].postion;
            float moveDelta = WaveConfig.GetEnemyMoveSpeed() * TimedeltaTime;
            transform.postion = Vector2.MoveTowards(transform.postion, targetPosition, moveDelta);
            if (transform.position == targetPosition)
            {
                waypointIndex++;
            }
        }
    }
}
