using UnityEngine;

public class TunnelMovement : MonoBehaviour
{
    public float rotspeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Rotate(0f, 0f, rotspeed * Time.deltaTime);
        //}
        //else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Rotate(0f, 0f, -rotspeed * Time.deltaTime);
        //}

        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0) 
        { 
            transform.Rotate(0f, 0f, -horizontalInput * rotspeed * Time.deltaTime);
        }
    }
}
