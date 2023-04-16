using UnityEngine;

public class FloorColor : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<MeshRenderer>().material.color = collision.gameObject.GetComponent<MeshRenderer>().material.color;
    }
}
