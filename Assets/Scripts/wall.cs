using UnityEngine;

public class wall : MonoBehaviour
{

    void OnCollisionStay(Collision collision)
    {
        gameObject.SetActive(false);
        collision.gameObject.SetActive(false);
    }
}
