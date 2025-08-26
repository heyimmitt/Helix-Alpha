using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{

    public ParticleSystem  ps;
    public GameObject WinScreen;
    public GameObject DeathScreen;
    public TMP_Text scoreMessage;

    public int scoreMultiplier = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WinScreen.SetActive(false);
        DeathScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreMessage.text = "Score: " + ComputeScore();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("KillBlock"))
        {
            DeathScreen.SetActive(true);
            Destroy(this.gameObject);
            ps.Play();

        }
        else if (collision.gameObject.CompareTag("EndBlock"))
        {
            WinScreen.SetActive(true);
            Destroy(this.gameObject);
            ps.Play();
        }
    }

    private int ComputeScore()
    {
        return Mathf.RoundToInt(scoreMultiplier * transform.position.z);
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
