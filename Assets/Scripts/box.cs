using UnityEngine;
using UnityEngine.UIElements;

public class box : MonoBehaviour
{
    public bool estActif;
    public GameObject wallNord;
    public GameObject wallOuest;
    public GameObject wallEst;
    public GameObject wallSud;
    public GameObject floor;
    void Start()
    {
        wallNord.gameObject.SetActive(false);
        wallOuest.gameObject.SetActive(false);
        wallEst.gameObject.SetActive(false);
        wallSud.gameObject.SetActive(false);
        floor.gameObject.SetActive(false);
        estActif = false;
    }

    void OnMouseDown()
    {
        if (!estActif)
        {
            wallNord.gameObject.SetActive(true);
            wallOuest.gameObject.SetActive(true);
            wallEst.gameObject.SetActive(true);
            wallSud.gameObject.SetActive(true);
            floor.gameObject.SetActive(true);
            estActif = true;
        }
        else if (estActif)
        {
            wallNord.gameObject.SetActive(false);
            wallOuest.gameObject.SetActive(false);
            wallEst.gameObject.SetActive(false);
            wallSud.gameObject.SetActive(false);
            floor.gameObject.SetActive(false);
            estActif = false;
        }

    }
}
