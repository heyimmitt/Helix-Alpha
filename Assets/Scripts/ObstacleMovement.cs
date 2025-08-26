using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public GameObject tunnel;
    private Vector3 orbitPoint;
    public float orbitSpeed = 10f;
    public Vector3 centre;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MeshRenderer meshRenderer = tunnel.GetComponent<MeshRenderer>();
        centre = meshRenderer.bounds.center;
        orbitPoint = new Vector3(centre.x, centre.y, transform.position.z);
        Vector3 newPos = transform.position;
        newPos.x = centre.x;
        newPos.y = -4;
        transform.position = newPos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(orbitPoint, Vector3.forward, orbitSpeed * Time.deltaTime);
    }
}
