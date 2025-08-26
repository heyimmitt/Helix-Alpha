using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rb;

    public GameObject tunnel;
    public float rotspeed = 10f;
    public float movementSpeed = 10f;

    private bool gravityInverted = false;
    public float gravityMultiplier = 2f;

    public GameObject WinScreen;
    public GameObject DeathScreen;

    public TMP_Text scoreMessage;


    public int scoreMultiplier = 1;

    void Start()
    {
        player = this.gameObject;
        rb = this.gameObject.GetComponent<Rigidbody>();


        WinScreen.SetActive(false);
        DeathScreen.SetActive(false);

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            tunnel.transform.Rotate(0f, 0f, rotspeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            tunnel.transform.Rotate(0f, 0f, -rotspeed * Time.deltaTime);
        }

        rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y, movementSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravityInverted = !gravityInverted;
            Physics.gravity = gravityMultiplier * (gravityInverted ? Vector3.up * 9.81f : Vector3.down * 9.81f);

        }

        scoreMessage.text = "Score: " + ComputeScore();
    }

    // This will be called when the player collides with another collider
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("KillBlock"))
        {
            DeathScreen.SetActive(true);
            Destroy(player);
            SceneManager.LoadScene(0);

        }
        else if (collision.gameObject.CompareTag("EndBlock"))
        {
            WinScreen.SetActive(true);
            Destroy(player);
            SceneManager.LoadScene(0);
        }
        else
        {
            return;
        }
    }

    private int ComputeScore()
    {
        return Mathf.RoundToInt(scoreMultiplier * player.transform.position.z);
    }
    

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
