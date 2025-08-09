using UnityEngine;

public class Movement : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rb;

    public GameObject tunnel;
    public float rotspeed = 10f;
    public float movementSpeed = 10f;

    private bool gravityInverted = false;

    public float gravityMultiplier = 2f;

    void Start()
    {
        player = this.gameObject;
        rb = this.gameObject.GetComponent<Rigidbody>();

    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            tunnel.transform.Rotate(0f, 0f, rotspeed * Time.deltaTime);
        } else if(Input.GetKey(KeyCode.D)){
            tunnel.transform.Rotate(0f, 0f, -rotspeed * Time.deltaTime);
        }
        
        rb.linearVelocity = new Vector3(rb.linearVelocity.x,rb.linearVelocity.y,movementSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravityInverted = !gravityInverted;
            Physics.gravity = gravityMultiplier * (gravityInverted ? Vector3.up * 9.81f : Vector3.down * 9.81f);

        }
    }

    // This will be called when the player collides with another collider
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("KillBlock"))
        {
            Destroy(player);
        }
    }

}
