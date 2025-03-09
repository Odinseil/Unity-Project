using UnityEngine;

public class wall : MonoBehaviour
{
    public float coordonnesX;
    public float coordonnesY;
    public float coordonnesZ;


    void Start()
    {
        Vector3 position = transform.position;

        Debug.Log("position du mur " + gameObject.name +  " au début: " + position);

        transform.position = new Vector3(position.x + coordonnesX, position.y + coordonnesY, position.z + coordonnesZ);
        Vector3 positionEnd = transform.position;

        Debug.Log("position du mur " + gameObject.name + " a la fin : " + positionEnd);
    }
    void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
        collision.gameObject.SetActive(false);
    }
}
