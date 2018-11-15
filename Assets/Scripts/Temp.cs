using UnityEngine;

public class Temp : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject minion;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
        GameObject go = Instantiate(minion, spawnPoints[i].position, Quaternion.identity);
        }
    }
}
