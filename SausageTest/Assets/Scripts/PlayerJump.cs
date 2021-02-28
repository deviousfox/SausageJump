using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    //public Transform tr;
    private Camera cam;
    private Vector3 jumpDirection;
    private Transform thisTransform;
    private bool inJump = true;
    void Start()
    {
        cam = Camera.main;
        thisTransform = transform;
    }

    private void Update()
    {
        
        
        if (Input.GetMouseButton(0))
        {
            if (Time.frameCount %5 == 0)
            {
                RaycastHit hit;
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    //tr.position = hit.point;
                    jumpDirection = thisTransform.position - hit.point;
                }
            }
        }

        if (Input.GetMouseButtonUp(0) && !inJump)
        {
            GetComponent<Rigidbody>().AddForce(jumpDirection.normalized * jumpDirection.magnitude *1.5f, ForceMode.Impulse);
            inJump = true;
        }
        if (thisTransform.position.y <0)
        {
            SceneManager.LoadScene(0);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        inJump = false;
    }

}
