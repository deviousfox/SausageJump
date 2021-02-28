
using UnityEngine;

public class ChunkComponent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MapGeneration.Instance.InstanceChunk();
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
