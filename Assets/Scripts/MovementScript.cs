using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float forwardForce = 500f;
    [SerializeField] float sidewaysForce = 20f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Game is running...");
        Cursor.lockState = CursorLockMode.Locked; 
        Cursor.visible = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
