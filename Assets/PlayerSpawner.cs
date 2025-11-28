using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform rigRoot;

    void Start()
    {
        if (spawnPoint != null && rigRoot != null)
        {
            rigRoot.position = spawnPoint.position;
            rigRoot.rotation = spawnPoint.rotation;
        }
    }
}

