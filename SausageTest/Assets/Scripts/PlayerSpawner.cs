
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private Transform spawnTransform;
    [SerializeField] private GameObject[] playerPrefabs;

    private void Awake()
    {
        if (spawnTransform == null)
        {
            spawnTransform = transform;
        }
    }
    /// <summary>
    /// Instantiate player with skin
    /// </summary>
    /// <param name="playerIndex"> Skin index</param>
    /// <returns> Player transform</returns>
    public Transform InstantiatePlayer(int playerIndex = 0)
    {
        return Instantiate(playerPrefabs[playerIndex], spawnTransform).transform;
    }
    /// <summary>
    /// Instantiate player whith transform and skin
    /// </summary>
    /// <param name="spawnTransform"> Spawn position</param>
    /// <param name="playerIndex"> Skin index </param>
    /// <returns> Player transform</returns>
    public Transform InInstantiatePlayer(Transform spawnTransform,int playerIndex = 0)
    {
        return Instantiate(playerPrefabs[playerIndex], spawnTransform).transform;
    }
}
