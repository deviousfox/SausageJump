
using UnityEngine;

public class CamInput : MonoBehaviour
{
    private static Camera cam;
    private void Start() => cam = Camera.main;

    public static Vector3 MousePosition(Vector3 mousePos)
    {
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(mousePos);
        if (Physics.Raycast(ray, out hit))
        {
            return hit.point;
        }
        return Vector3.zero;
    }
}
