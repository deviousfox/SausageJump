
using UnityEngine;

public class MapGeneration : MonoBehaviour
{
    [SerializeField] private GameObject[] mapChunks;
    [SerializeField] private Transform startChunkTransform;
    private Transform lastChunkTransform;
    public static MapGeneration Instance;

    private void Start()
    {
        Instance = this;
    }

    private GameObject GetChunk()
    {
        return mapChunks[Random.Range(0, mapChunks.Length)];
    }

    public void InstanceChunk()
    {
        if (lastChunkTransform == null)
            lastChunkTransform = Instantiate(GetChunk(), startChunkTransform.position, Quaternion.identity).transform;
        else
            lastChunkTransform = Instantiate(GetChunk(), lastChunkTransform.position + new Vector3(0, Random.Range(2, 5), 8 + Random.Range(4, 6)), Quaternion.identity).transform;
    }
}
