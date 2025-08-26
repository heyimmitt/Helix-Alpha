using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            SceneManager.LoadScene(0);
        }
    }
}