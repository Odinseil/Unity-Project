using UnityEngine;

public class wall : MonoBehaviour
{
    public float x;
    public float y;
    public float z;


    void Start()
    {
        Vector3 position = transform.position;
        transform.position = new Vector3(position.x + x, position.y +y, position.z + z);
    }
    void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
        collision.gameObject.SetActive(false);
    }
}
