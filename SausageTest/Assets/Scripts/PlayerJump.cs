using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [Range(0.1f,2f)][SerializeField]private float jumpMultiplayer = 1;
    [Range(1, 20)] [SerializeField] private float velocityClamp = 10;
    private Camera cam;
    private Vector3 jumpDirection;
    private Vector3 force;
    private Rigidbody rb;
    private Transform thisTransform;
    private bool inJump = true;
    void Start()
    {
        cam = Camera.main;
        thisTransform = transform;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, velocityClamp);
        
        if (Input.GetMouseButton(0))
        {
            if (Time.frameCount %5 == 0)
            {
                jumpDirection = thisTransform.position - CamInput.MousePosition(Input.mousePosition);
            }
        }

        if (Input.GetMouseButtonUp(0) && !inJump)
        {
            force = Vector3.ClampMagnitude(jumpDirection.normalized * jumpDirection.magnitude * jumpMultiplayer, velocityClamp);
            rb.AddForce(force, ForceMode.Impulse);
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
