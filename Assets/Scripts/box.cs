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
        wallNord.GetComponent<Renderer>().enabled = false;
        wallOuest.GetComponent<Renderer>().enabled = false;
        wallEst.GetComponent<Renderer>().enabled = false;
        wallSud.GetComponent<Renderer>().enabled = false;
        floor.GetComponent<Renderer>().enabled = false;
        estActif = false;
    }

    void OnMouseDown()
    {
        if (!estActif)
        {
            wallNord.GetComponent<Renderer>().enabled = true;
            wallOuest.GetComponent<Renderer>().enabled = true;
            wallEst.GetComponent<Renderer>().enabled = true;
            wallSud.GetComponent<Renderer>().enabled = true;
            floor.GetComponent<Renderer>().enabled = true;
            estActif = true;
        }
        else if (estActif)
        {
            wallNord.GetComponent<Renderer>().enabled = false;
            wallOuest.GetComponent<Renderer>().enabled = false;
            wallEst.GetComponent<Renderer>().enabled = false;
            wallSud.GetComponent<Renderer>().enabled = false;
            floor.GetComponent<Renderer>().enabled = false;
            estActif = false;
        }

    }
}
