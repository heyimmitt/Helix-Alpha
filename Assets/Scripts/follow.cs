using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject target;
    // public float distance = 5f;
    public Vector3 offset;
    public float yFollowConst = 0.3f;
    private GameObject obj;
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
        obj.transform.position = new Vector3(obj.transform.position.x + offset.x, target.transform.position.y * yFollowConst, target.transform.position.z + offset.z);
    }
}
