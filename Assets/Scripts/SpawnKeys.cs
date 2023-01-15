using UnityEngine;

public class SpawnKeys : MonoBehaviour
{
    public GameObject keyPrefab;
    public Vector3 spawnArea = new Vector3(20, 0, 20);

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-spawnArea.x / 2, spawnArea.x / 2),
                                                 0,
                                                 Random.Range(-spawnArea.z / 2, spawnArea.z / 2));
            Instantiate(keyPrefab, transform.position + randomPosition, Quaternion.identity);
        }
    }
}
