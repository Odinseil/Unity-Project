using UnityEngine;

public class TEST8COLLISION : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        other.gameObject.SetActive(false);
    }
}
