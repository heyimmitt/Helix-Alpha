using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject target;
    // public float distance = 5f;
    public Vector3 offset;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }
        transform.position = new Vector3(transform.position.x + offset.x, transform.position.y, target.transform.position.z + offset.z);
    }
}
