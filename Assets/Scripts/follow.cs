using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject target;
    // public float distance = 5f;
    public Vector3 offset;
    private GameObject obj;
    void Start()
    {
        obj = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }
        obj.transform.position = new Vector3(obj.transform.position.x + offset.x, obj.transform.position.y, target.transform.position.z + offset.z);
    }
}
