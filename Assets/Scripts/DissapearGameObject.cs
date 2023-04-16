using UnityEngine;

public class DissapearGameObject : MonoBehaviour
{
    private void Awake()
    {
        //gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.SetActive(false);
        Debug.Log(collision.gameObject.name);
        collision.gameObject.GetComponent<Collider>().enabled = false;
    }
}
