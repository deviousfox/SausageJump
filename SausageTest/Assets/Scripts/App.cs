using Cinemachine;
using UnityEngine;

public class App : MonoBehaviour
{
    [SerializeField] PlayerSpawner spawner;
    [SerializeField] FollowLerp playerFollower;
    [SerializeField] CinemachineVirtualCamera vCam;
    /// <summary>
    ///  Start game without set player skin;
    /// </summary>
    public void StartGame()
    {
        Transform player = spawner.InstantiatePlayer();
        playerFollower.SetTarget(player);
        vCam.LookAt = player;
    }
    /// <summary>
    /// Start game with set player skin
    /// </summary>
    /// <param name="index">player skin index</param>
    public void StartGame(int index)
    {
        Transform player = spawner.InstantiatePlayer(index);
        playerFollower.SetTarget(player);
        vCam.LookAt = player;
    }
}
