using UnityEngine;

[CreateAssetMenu(fileName = "WaveConfig", menuName = "New WaveConfig")]
public class WaveCongSO : ScriptableObject
{
    [SerializeField] Transform pathPrefab;
    [SerializeField] float enemyMoveSpeed = 5f;

    public Transform GetStartingWaypoint()
    {
        return pathPrefab.GetChild(0);
    }

    public float GetEnemyMoveSpeed()
    {
        return enemyMoveSpeed;
    }

    public Transform[] GetWaypoints()
    {
        Transform[] waypoints = new Transform[pathPrefab.childCount];

        for (int i = 0; i < pathPrefab.childCount; i++)
        {
            waypoints[i] = pathPrefab.GetChild(i);
        }

        waypoints[0] = pathPrefab.GetChild(0);        
        waypoints[1] = pathPrefab.GetChild(1);
        // etc...

        return waypoints;
    }
}
