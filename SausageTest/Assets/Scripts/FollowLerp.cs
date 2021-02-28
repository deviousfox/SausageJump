
using UnityEngine;

public class FollowLerp : MonoBehaviour
{
    [SerializeField]  private Transform target;
    [Range(0.1f,20f)][SerializeField] private float followSpeed = 3f;
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, followSpeed * Time.deltaTime);
    }
}
